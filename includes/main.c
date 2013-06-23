/* drive.c
 * Designed to run on Create Command Module
 *
 * The basic architecture of this program can be re-used to easily 
 * write a wide variety of Create control programs.  All sensor values
 * are polled in the background (using the serial rx interrupt) and 
 * stored in the sensors array as long as the function 
 * delayAndUpdateSensors() is called periodically.  Users can send commands
 * directly a byte at a time using byteTx() or they can use the 
 * provided functions, such as baud() and drive().
 */



// Includes
#include <avr/interrupt.h>
#include <avr/io.h>
#include <stdlib.h>
#include "oi.h"

#define LED_FLASHES 2

// Global variables
volatile uint16_t timer_cnt = 0;
volatile uint8_t timer_on = 0;
volatile uint8_t sensors_flag = 0;
volatile uint8_t sensors_index = 0;
volatile uint8_t sensors_in[Sen6Size];
volatile uint8_t sensors[Sen6Size];
volatile int16_t distance = 0;
volatile int16_t angle = 0;

// The command currently being executed
volatile int16_t command = 0;

// The angles,distance, speed, direction etc
volatile int16_t turn_angle 		= 0;
volatile int16_t turn_direction	= 0;
volatile int16_t drive_distance 	= 0;
volatile int16_t speed		 		= 0;
volatile uint8_t turning 			= 0;
volatile uint8_t interuptEvent		= 0;

// Functions
void ByteTx(uint8_t value);
void DelayMs(uint16_t time_ms);
void DelayAndUpdateSensors(unsigned int time_ms);
void Initialise(void);
void PowerOnRobot(void);
void Baud(uint8_t baud_code);
void Drive_Wheels(int16_t velocity, int16_t radius);
void FinishedCommand();
void Drive();
void Stop();
void Commands();





// The main program
int main (void) 
{  
	// Initilise the robot to be controled by the script and ensure the robot is powered on
	Initialise();

	// Stop just as a precaution
	Stop();
  
	// Show that the program is running by flashing the LED's
	for(int i = 0; i < LED_FLASHES; i++)
	{
		LEDBothOn;
		DelayAndUpdateSensors(500);
		LEDBothOff;
		DelayAndUpdateSensors(500);
	}
	DelayAndUpdateSensors(500);

	Commands();
    
	// Drive around until a button or unsafe condition is detected and the command is not -1
    while(!(UserButtonPressed)
            && (!sensors[SenCliffL])
            && (!sensors[SenCliffFL])
            && (!sensors[SenCliffFR])
            && (!sensors[SenCliffR])
            && (!sensors[SenChAvailable]
			&& command >= 0)
        )
    {
	
		// Run the drive of the robot for current action
		Drive();
		
		// Update the sensors as the robot has driven
		DelayAndUpdateSensors(20);
		
		// Check for an interupt event
		//CheckInteruptEvent();
    }

    // Stop driving
    Stop();
}

// Serial receive interrupt to store sensor values
SIGNAL(SIG_USART_RECV)
{
  uint8_t temp;


  temp = UDR0;

  if(sensors_flag)
  {
    sensors_in[sensors_index++] = temp;
    if(sensors_index >= Sen6Size)
      sensors_flag = 0;
  }
}




// Timer 1 interrupt to time delays in ms
SIGNAL(SIG_OUTPUT_COMPARE1A)
{
  if(timer_cnt)
    timer_cnt--;
  else
    timer_on = 0;
}




// Transmit a byte over the serial port
void ByteTx(uint8_t value)
{
  while(!(UCSR0A & _BV(UDRE0))) ;
  UDR0 = value;
}




// Delay for the specified time in ms without updating sensor values
void DelayMs(uint16_t time_ms)
{
  timer_on = 1;
  timer_cnt = time_ms;
  while(timer_on) ;
}




// Delay for the specified time in ms and update sensor values
void DelayAndUpdateSensors(uint16_t time_ms)
{
  uint8_t temp;

  timer_on = 1;
  timer_cnt = time_ms;
  while(timer_on)
  {
    if(!sensors_flag)
    {
      for(temp = 0; temp < Sen6Size; temp++)
        sensors[temp] = sensors_in[temp];

      // Update running totals of distance and angle
      distance += (int)((sensors[SenDist1] << 8) | sensors[SenDist0]);
      angle += (int)((sensors[SenAng1] << 8) | sensors[SenAng0]);

      ByteTx(CmdSensors);
      ByteTx(6);
      sensors_index = 0;
      sensors_flag = 1;
    }
  }
}




// Initialise the Mind Control's ATmega168 microcontroller
void Initialise(void)
{
  cli();

  // Set I/O pins
  DDRB = 0x10;
  PORTB = 0xCF;
  DDRC = 0x00;
  PORTC = 0xFF;
  DDRD = 0xE6;
  PORTD = 0x7D;

  // Set up timer 1 to generate an interrupt every 1 ms
  TCCR1A = 0x00;
  TCCR1B = (_BV(WGM12) | _BV(CS12));
  OCR1A = 71;
  TIMSK1 = _BV(OCIE1A);

  // Set up the serial port with rx interrupt
  UBRR0 = 19;
  UCSR0B = (_BV(RXCIE0) | _BV(TXEN0) | _BV(RXEN0));
  UCSR0C = (_BV(UCSZ00) | _BV(UCSZ01));

  // Turn on interrupts
  sei();
  
  
	LEDBothOff;
	PowerOnRobot();
	ByteTx(CmdStart);
	Baud(Baud28800);
	ByteTx(CmdControl);
	ByteTx(CmdFull);
}




void PowerOnRobot(void)
{
  // If Create's power is off, turn it on
  if(!RobotIsOn)
  {
      while(!RobotIsOn)
      {
          RobotPwrToggleLow;
          DelayMs(500);  // Delay in this state
          RobotPwrToggleHigh;  // Low to high transition to toggle power
          DelayMs(100);  // Delay in this state
          RobotPwrToggleLow;
      }
      DelayMs(3500);  // Delay for startup
  }
}




// Switch the baud rate on both Create and module
void Baud(uint8_t baud_code)
{
  if(baud_code <= 11)
  {
    ByteTx(CmdBaud);
    UCSR0A |= _BV(TXC0);
    ByteTx(baud_code);
    // Wait until transmit is complete
    while(!(UCSR0A & _BV(TXC0))) ;

    cli();

    // Switch the baud rate register
    if(baud_code == Baud115200)
      UBRR0 = Ubrr115200;
    else if(baud_code == Baud57600)
      UBRR0 = Ubrr57600;
    else if(baud_code == Baud38400)
      UBRR0 = Ubrr38400;
    else if(baud_code == Baud28800)
      UBRR0 = Ubrr28800;
    else if(baud_code == Baud19200)
      UBRR0 = Ubrr19200;
    else if(baud_code == Baud14400)
      UBRR0 = Ubrr14400;
    else if(baud_code == Baud9600)
      UBRR0 = Ubrr9600;
    else if(baud_code == Baud4800)
      UBRR0 = Ubrr4800;
    else if(baud_code == Baud2400)
      UBRR0 = Ubrr2400;
    else if(baud_code == Baud1200)
      UBRR0 = Ubrr1200;
    else if(baud_code == Baud600)
      UBRR0 = Ubrr600;
    else if(baud_code == Baud300)
      UBRR0 = Ubrr300;

    sei();

    DelayMs(100);
  }
}




// Send Create drive commands in terms of velocity and radius
void Drive_Wheels(int16_t velocity, int16_t radius)
{
  ByteTx(CmdDrive);
  ByteTx((uint8_t)((velocity >> 8) & 0x00FF));
  ByteTx((uint8_t)(velocity & 0x00FF));
  ByteTx((uint8_t)((radius >> 8) & 0x00FF));
  ByteTx((uint8_t)(radius & 0x00FF));
}

void Commands()
{
	switch (command)
	{
		case 0 :
			turn_angle 		= 0;
			turn_direction	= 0;
			drive_distance 	= 100;
			speed		 	= -200;
			turning 		= 0;
			break;
		case 1 :
			turn_angle 		= 90;
			turn_direction	= RadCW;
			drive_distance 	= 0;
			speed		 	= 0;
			turning 		= 1;
			break;
		case 2 :
			turn_angle 		= 0;
			turn_direction	= 0;
			drive_distance 	= 100;
			speed		 	= -200;
			turning 		= 0;
			break;
		case 3 :
			turn_angle 		= 90;
			turn_direction	= RadCW;
			drive_distance 	= 0;
			speed		 	= 0;
			turning 		= 1;
			break;
		case 4 :
			turn_angle 		= 0;
			turn_direction	= 0;
			drive_distance 	= 100;
			speed		 	= -200;
			turning 		= 0;
			break;
		case 5 :
			turn_angle 		= 90;
			turn_direction	= RadCW;
			drive_distance 	= 0;
			speed		 	= 0;
			turning 		= 1;
			break;
		case 6 :
			turn_angle 		= 0;
			turn_direction	= 0;
			drive_distance 	= 100;
			speed		 	= -200;
			turning 		= 0;
			break;
		case 7 :
			turn_angle 		= 90;
			turn_direction	= RadCW;
			drive_distance 	= 0;
			speed		 	= 0;
			turning 		= 1;
			break;
			
		default:
			// End the robots run
			command = -1;
			break;
	}
}

// Stop the robot from driving
void Stop()
{
	ByteTx(CmdDrive);
	ByteTx((uint8_t)((0 >> 8) & 0x00FF));
	ByteTx((uint8_t)(0 & 0x00FF));
	ByteTx((uint8_t)((RadStraight >> 8) & 0x00FF));
	ByteTx((uint8_t)(RadStraight & 0x00FF));
}

// move onto the next command
void FinishedCommand()
{
	// Reset the driving variables
	turn_angle 		= 0;
	turn_direction	= 0;
	drive_distance 	= 0;
	speed		 	= 0;
	turning 		= 0;
	interuptEvent	= 0;
	
	distance = 0;
	angle = 0;
	
	// Increment to the next command
	command++;
	
	// Setup for the next command
	Commands();
}

// Manage the moving of the robot
void Drive()
{
	// If the robot is turning, manage the turn
	if(turning)
	{
		if(turn_direction)
		{
		  if(angle > turn_angle)
			FinishedCommand();
			
		  Drive_Wheels(200, RadCCW);
		}
		else
		{
		  if((-angle) > turn_angle)
			FinishedCommand();
			
		  Drive_Wheels(200, RadCW);
		}
	}
	else
	{
		// Drive Forward
		if(speed > 0)
		{
			if(distance > drive_distance)
				FinishedCommand();
				
            Drive_Wheels(speed, RadStraight);
		}
		// Drive Backwards
		else
		{
			if((-distance) > drive_distance)
				FinishedCommand();
				
            Drive_Wheels(speed, RadStraight);
		}
	}
}
