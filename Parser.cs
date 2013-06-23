using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RobotProgrammer
{
    class Parser
    {
        const int 	MaxSpeed 		= 50,
					MinSpeed 		= 10,
					DefaultSpeed 	= 20;

		int Speed = DefaultSpeed;

		public enum ValidateError
		{
			Error,
			BrickUnavaliable,
			DriveUnavaliable,
			NoError
		}



		public string ConvertDrivetoRobot (string DriveCode)
		{
			// Check the validily of the Drive Code
			ArrayList Errors;
			if (ValidateRobotCode (DriveCode, out Errors) != ValidateError.NoError) 
			{
				return null;
			}

			// Split the drive code into lines
			string RobotCode = string.Empty;
			string Argument = string.Empty;
			int Speed = DefaultSpeed;


			ArrayList DriveCodeLines = SplitCodeIntoLines (DriveCode);

			foreach (string Line in DriveCodeLines) 
			{
				if(IsComment(Line)) RobotCode += Line;

				string CleanLine = Line.ToLower().Trim();



				if(CleanLine.StartsWith("--remotemax--"))
				{

				}
				else if(CleanLine.StartsWith("--remotespot--"))
				{

				}				
				else if(CleanLine.StartsWith("--remoteleft--"))
				{

				}
				else if(CleanLine.StartsWith("--remotedrive--"))
				{

				}
				else if(CleanLine.StartsWith("--remoteright--"))
				{

				}
				else if(CleanLine.StartsWith("--bump--"))
				{

				}
				else if(CleanLine.StartsWith("--bumpleft--"))
				{

				}
				else if(CleanLine.StartsWith("--bumpright--"))
				{

				}
				else
				{
					RobotCode += ParseDrivetoRobot(Line);
				}



			}
            return RobotCode;
		}

		string ParseDrivetoRobot (string Line)
		{
			string BrickCode = string.Empty;
			string Argument;

			if(IsComment(Line)) BrickCode += Line;

				string CleanLine = Line.ToLower().Trim();

				// Forward Drive
				if(CleanLine.StartsWith("forward") || 
				   CleanLine.StartsWith("drive") ||
				   CleanLine.StartsWith("back")
				   )
				{
					// Get the speed argument
					Argument = GetDriveArgument(Line);
					int Distance = 0;

					// check the speed argument
					if(int.TryParse(Argument, out Distance))
					{
						// If backwards then make the distance negitive
						// TODO check method of making negative
						if(CleanLine.StartsWith("back")) Distance = Distance - (Distance * 2);

						// Add the line of code
						BrickCode += "drive(" + Distance + "," + Speed + ");\r\n";
					}
				}

				// Turn
				if(CleanLine.StartsWith("left") || 
				   CleanLine.StartsWith("right")
				   )
				{
					// Get the speed argument
					Argument  = GetDriveArgument(Line);
					int Angle = 0;

					// check the speed argument
					if(int.TryParse(Argument, out Angle))
					{
						// If left direction is Couner Clock Wise else Clock Wise
						if (CleanLine.StartsWith("left"))
						{
							BrickCode += "turn(CCW," + Angle + ");\r\n";
						}
						else
						{
							BrickCode += "turn(CW," + Angle + ");\r\n";
						}
					}
				}

				// Wait until
				if(CleanLine.StartsWith("wait until"))
				{
					Argument = GetDriveArgument(Line);
					if(CheckActionArgument(Argument))
					{
						BrickCode += "waitUntil(" + Argument + ");";
					}
				}

				// wait
				if(CleanLine.StartsWith("wait"))
				{
					// Get the time argument
					Argument = GetDriveArgument(Line);
					int time = 0;

					// Check the time is valid and write the line
					if(int.TryParse(Argument, out time)) BrickCode += "wait(" + time + ");\r\n";
				}

				// Speed update
				if(CleanLine.StartsWith("speed"))
				{
					// Get the speed argument
					Argument = GetDriveArgument(Line);
					int tempSpeed = 0;

					// check the speed argument
					if(int.TryParse(Argument, out tempSpeed))
					{
						// Ensure the speed if within the valid limits
						if(tempSpeed > MaxSpeed) tempSpeed = MaxSpeed;
						if(tempSpeed < MinSpeed) tempSpeed = MinSpeed;

						// update the speed
						Speed = tempSpeed;
					}
				}

                if (CleanLine.StartsWith(""))
                {
                    BrickCode += "stop();";
                }
			return BrickCode;
		}

		public string GetDriveArgument (string Line)
		{
            // Split the drive line into its arguments
            string[] strItems = Line.Split(' ');

            // If the line has an argument return the argument, otherwise return 0
            if (strItems.Count() == 3)
            {
                return strItems[2];
            }
            else
            {
                return "0";
            }
		}


		bool CheckActionArgument (string Argument)
		{
			if (Argument == "buttonpress" || 
			    Argument == "remotemax" ||
			    Argument == "remotespot" ||
			    Argument == "remoteleft" ||
			    Argument == "remoteright" ||
			    Argument == "remotedrive") 
			{
				return true;
			} 
			else 
			{
				return false;
			}
		}
	
		public string ConvertBricktoRobot (string BrickCode)
		{
            return null;
		}

				/// <summary>
		/// Converts Robot Code to brick code.
		/// </summary>
		/// <returns>
		/// Brick code File
		/// </returns>
		/// <param name='RobotCode'>
		/// Robot code File
		/// </param>
		public string ConvertRobotToBrick (string RobotCode)
		{
			// Validate the code and do not continue if not validated
			ArrayList Errors;
			if (ValidateRobotCode (RobotCode, out Errors) != ValidateError.NoError) 
			{
				return null;
			}

			// Split the brick code into lines
			string BrickCode = string.Empty;
			ArrayList RobotCodeLines = SplitCodeIntoLines(RobotCode);

			// Loop all the code lines
			foreach(string Line in RobotCodeLines)
			{
				// TODO need to take into account loops and ifs
				BrickCode += ParseRobotToBrick(Line);
			}
            return BrickCode;
		}


		public string ConvertBrickToDrive (string BickCode)
		{
            return null;
		}


		/// <summary>
		/// Parses the brick code to robot code.
		/// </summary>
		/// <returns>
		/// Robot Code Line
		/// </returns>
		/// <param name='Brick'>
		/// Brick Code Line
		/// </param>
		string ParseBrickToRobot (string Brick)
		{
			string Operator = "";
			string Args = "";

			//TODO split operator

			switch (Operator)
			{
				case "forward" :
					return "Drive(" + Args + ",10);";
				case "backward" :
					return "Drive(" + Args + ",-10);";
				case "left" :
					return "Turn(" + Args + ",CCW;";
				case "right" :
                    return "Turn(" + Args + ",CW);";
				default :
					return "ERROR";
			}
		}

		/// <summary>
		/// Parses a line of robot code to brick code
		/// </summary>
		/// <returns>
		/// Brick Code line
		/// </returns>
		/// <param name='Robot'>
		/// Robot Code Line
		/// </param>
		string ParseRobotToBrick (string Robot)
		{
			// Ensure that the line is not a comment
			if (IsComment (Robot)) 
			{
				// return the comment untouched
				return Robot;
			} 
			else 
			{
				string 		Operation = "";
				ArrayList 	Args;

				// TODO spilt line 

				switch (Operation.ToLower())
				{
					case "drive" :
						
						break;
				}
			}
            return null;
		}

		/// <summary>
		/// Converts from Robot Code to C Code.
		/// </summary>
		/// <returns>
		/// C Code output for the included file
		/// </returns>
		public string ConvertToC()
		{
            return null;
		}

		/// <summary>
		/// Splits the code file provided into lines (items in a arraylist).
		/// </summary>
		/// <returns>
		/// The code into lines.
		/// </returns>
		/// <param name='Code'>
		/// Code file
		/// </param>
		ArrayList SplitCodeIntoLines (string Code)
		{
            ArrayList CodeLines = new ArrayList();
            CodeLines.AddRange(Code.Split('\n'));
            return CodeLines;
		}

		ArrayList SplitMultiStatmentLine (string Line)
		{
			// TODO produce split
			return null;
		}

		/// <summary>
		/// Converts from C Code to Robot Code .
		/// </summary>
		/// <returns>
		/// The from c.
		/// </returns>
		public string ConvertFromC ()
		{
            return null;
		}

		/// <summary>
		/// Determines whether the code line is a comment.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this code line is a comment; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='CodeLine'>
		/// Line of code to check
		/// </param>
		public bool IsComment (string CodeLine)
		{
			if (CodeLine.StartsWith ("//")) 
			{
				return true;
			}

			return false;
		}

		public ValidateError ValidateRobotCode (string RobotCode, out ArrayList Errors)
		{
            Errors = new ArrayList();
            return ValidateError.NoError;
		}

		public ValidateError ValidateBrickCode(string BrickCode, out ArrayList Errors)
		{
            Errors = new ArrayList();
            return ValidateError.NoError;
		}

		public ValidateError ValidateDriveCode (string DriveCode, out ArrayList Errors)
		{
            Errors = new ArrayList();
			return ValidateError.NoError;
		}
    }
}
