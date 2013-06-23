using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace RobotProgrammer
{
    public partial class frmMain : Form
    {
        public int intKeypadReturn = 0;
        public bool bolKeypadReturn = false;
        public string strFilename = string.Empty;


        enum ProgramStatus
        {
            DriveDesigner,
            DriveCode,
            RobotDesigner,
            RobotCode,
            CCode
        }

        ProgramStatus enumProgramStatus = ProgramStatus.DriveDesigner;

        /// <summary>
        /// Drive Mode is in advanced mode
        /// </summary>
        bool bolDriveModeAdvanced = true;

        int intDriveSimpleTurnDefault = 45;

        enum enumDriveMode
        {
            NotInDrive,
            Drive,
            Bump,
            BumpLeft,
            BumpRight,
            RemoteMax,
            RemoteSpot,
            RemoteLeft,
            RemoteDrive,
            RemoteRight
        }

        enumDriveMode DriveMode = enumDriveMode.Drive;

        string strRobotDesigner = null;

        public frmMain()
        {
            InitializeComponent();
        }

        #region Drive Commands
        static string DriveDescription = "The normal mode for the robot.\nThe action that will be taken if nothing else happens.";
        static string BumpDescription = "What happens when the robot hits a object straight on.";
        static string BumpLeftDescription = "What happens when the robot hits a object to its left.";
        static string BumpRightDescription = "What happens when the robot hits a object to its right.";
        static string RemoteMaxDescription = "What happens when the Max button on the remote is pressed";
        static string RemoteSpotDescription = "What happens when the Spot button on the remote is pressed";
        static string RemoteLeftDescription = "What happens when the left button on the remote is pressed";
        static string RemoteDriveDescription = "What happens when the drive button on the remote is pressed";
        static string RemoteRightDescription = "What happens when the right button on the remote is pressed";

        object[] lstDriveStorage = new object[9];
        

        private void cmdForward_Click(object sender, EventArgs e)
        {
            ProcessDriveCommand("Forward");
        }

        private void cmdLeft_Click(object sender, EventArgs e)
        {
            ProcessDriveCommand("Left");
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            ProcessDriveCommand("Stop");
        }

        private void cmdRight_Click(object sender, EventArgs e)
        {
            ProcessDriveCommand("Right");
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            ProcessDriveCommand("Back");
        }

        private void cmdWait_Click(object sender, EventArgs e)
        {
            ProcessDriveCommand("Wait");
        }

        private void cmdSpeed_Click(object sender, EventArgs e)
        {
            ProcessDriveCommand("Speed");
        }

        private void ProcessDriveCommand(string Command)
        {
            // Lock the form to prevent multiple calls
            LockForm(true);

            Keypad frmKeypad;

            // Show the keypad if applicable
            switch (Command)
            {
                case "Forward":
                case "Back":
                    frmKeypad = new Keypad("Length", this);
                    frmKeypad.Show();
                    break;
                case "Left" :
                case "Right" :
                    if (bolDriveModeAdvanced)
                    {
                        frmKeypad = new Keypad("Degrees", this);
                        frmKeypad.Show();
                    }
                    else
                    {
                        bolKeypadReturn = true;
                        intKeypadReturn = intDriveSimpleTurnDefault;
                    }
                    break;
                case "Speed" :
                    frmKeypad = new Keypad("cm/s", this, 10,50);
                    frmKeypad.Show();
                    break;
                case "Wait":
                    frmKeypad = new Keypad("Secs", this,0,10);
                    frmKeypad.Show();
                    break;
                default :
                    bolKeypadReturn = true;
                    intKeypadReturn = -2;
                    break;
            }

            // Wait until the keypad has returned
            while (!bolKeypadReturn)
            {
                // Waste time
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }


            // Add the command
            if (intKeypadReturn == -2)
            {
                AddDriveCommand(Command);
            }
            else if (intKeypadReturn > 0)
            {
                AddDriveCommand(Command + " - " + intKeypadReturn.ToString());
            }

            // Reset the Keypad return
            bolKeypadReturn = false;
            intKeypadReturn = 0;

            // Unlock the form
            LockForm(false);
        }

        private void AddDriveCommand(string Command)
        {
            // If there is an item selected, put the new item after that
            if (lstDrive.SelectedIndex >= 0) 
            {
                lstDrive.Items.Insert(lstDrive.SelectedIndex + 1, Command);
                ++lstDrive.SelectedIndex;
            } 
            // No item selected, put the item at the end of the list
            else
            {
                lstDrive.Items.Add(Command);
            }

            lstDrive.SelectedIndex = lstDrive.Items.Count - 1;

        }

        /// <summary>
        /// Save the current drive commands
        /// </summary>
        private void SaveDriveListBox()
        {
            object[] SaveList = new object[lstDrive.Items.Count];
            lstDrive.Items.CopyTo(SaveList, 0);
            lstDriveStorage[(int)DriveMode] = SaveList;

        }

        /// <summary>
        /// Load the drive commands from the temp storage
        /// </summary>
        private void LoadDriveListBox()
        {
            // Clear the old items
            lstDrive.Items.Clear();
            // Ensure that the storage is not null
            if ((object[])lstDriveStorage[(int)DriveMode] != null)
            {
                // load the storage
                lstDrive.Items.AddRange((object[])lstDriveStorage[(int)DriveMode]);
            }
        }

        #endregion

        private void LockForm(bool Lock)
        {
            Lock = !Lock;
            
            cmdBack.Enabled = Lock;
            cmdForward.Enabled = Lock;
            cmdLeft.Enabled = Lock;
            cmdRight.Enabled = Lock;
            cmdStop.Enabled = Lock;
            cmdWait.Enabled = Lock;
        }

        private void cboDriveMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save the code for the old mode
            SaveDriveListBox();

            // Select the new mode
            switch (cboDriveMode.SelectedItem.ToString())
            {
                case "Drive" :
                    lblDriveDescription.Text = DriveDescription;
                    DriveMode = enumDriveMode.Drive;
                    break;
                case "Bump":
                    lblDriveDescription.Text = BumpDescription;
                    DriveMode = enumDriveMode.Bump;
                    break;
                case "Bump Left":
                    lblDriveDescription.Text = BumpLeftDescription;
                    DriveMode = enumDriveMode.BumpLeft;
                    break;
                case "Bump Right":
                    lblDriveDescription.Text = BumpRightDescription;
                    DriveMode = enumDriveMode.BumpRight;
                    break;
                case "Remote - Max":
                    lblDriveDescription.Text = RemoteMaxDescription;
                    DriveMode = enumDriveMode.BumpRight;
                    break;                    
                case "Remote - Spot":
                    lblDriveDescription.Text = RemoteSpotDescription;
                    DriveMode = enumDriveMode.BumpRight;
                    break;
                case "Remote - Right":
                    lblDriveDescription.Text = RemoteRightDescription;
                    DriveMode = enumDriveMode.BumpRight;
                    break;
                case "Remote - Drive":
                    lblDriveDescription.Text = RemoteDriveDescription;
                    DriveMode = enumDriveMode.BumpRight;
                    break;
                case "Remote - Left":
                    lblDriveDescription.Text = RemoteLeftDescription;
                    DriveMode = enumDriveMode.BumpRight;
                    break;
                default :
                    LogError("Error - Case not found for '" + cboDriveMode.SelectedItem.ToString() + "'\nDefaulting to drive mode.");
                    lblDriveDescription.Text = DriveDescription;
                    DriveMode = enumDriveMode.Drive;
                    cboDriveMode.SelectedIndex = 0;
                    break;
            }

            // Update the title and the mode
            lblDriveMode.Text = cboDriveMode.SelectedItem.ToString();
            DriveMode = (enumDriveMode)cboDriveMode.SelectedIndex;

            // Load the code for the new mode
            LoadDriveListBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Run the standard setup
            cboDriveMode.SelectedIndex = 0;
        }



        private void LogError(string Error)
        {
            MessageBox.Show(Error, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmdViewDriveSource_Click(object sender, EventArgs e)
        {
            tabConMain.SelectedIndex = 1;
        }

        private void tabConMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure that the program can cope with the selected item
            if ((int)enumProgramStatus > tabConMain.SelectedIndex)
            {
                int intAttemptedIndex = tabConMain.SelectedIndex;

                // Select the lowest tab avaliable
                tabConMain.SelectedIndex = (int)enumProgramStatus;

                MessageBox.Show("You have written some code that cannot be parsed to " + ((ProgramStatus)intAttemptedIndex).ToString() + 
                    "\nThis means that you cannot use " + ((ProgramStatus)intAttemptedIndex).ToString(), "Parsing Error");   
            }

            // Drive Code
            switch (tabConMain.SelectedIndex)
            {
                case 1:
                    SaveDriveListBox();
                    GenerateDriveCode();
                    break;
                case 2:

                    break;
                case 3:
                    // Check for Robot Designer
                    if (strRobotDesigner != null)
                    {
                        GenerateRobotCodeFromDesigner();
                    }
                    else if (rtbDriveCode.Text != string.Empty)
                    {
                        // Drive code exists
                        GenerateRobotCodeFromDriveCode();
                    }
                    else if (((object[])lstDriveStorage[0]) != null)
                    {
                        // No drive code has been produced
                        GenerateDriveCode();
                        GenerateRobotCodeFromDriveCode();
                    }
                    break;
                case 4:
                    
                    break;
            }
        }

        /// <summary>
        /// Generate the Drive code from the Drive Command storage and put it into the Drive Code Box
        /// </summary>
        private void GenerateDriveCode()
        {
            // Clear the old Code
            rtbDriveCode.Text = string.Empty;

            // Ensure all the objects have a value
            for (int i = 1; i < 9; i++)
            {
                if (lstDriveStorage[i] == null) lstDriveStorage[i] = new object[0];
            }

            // Add the bump code
            rtbDriveCode.Text += "--bump-- ";
            foreach (object Line in (object[])lstDriveStorage[1])
            {
                rtbDriveCode.Text += Line.ToString() + ", ";
            }
            rtbDriveCode.Text += "\n";
            rtbDriveCode.Text += "--BumpLeft-- ";
            foreach (object Line in (object[])lstDriveStorage[2])
            {
                rtbDriveCode.Text += Line.ToString() + ", ";
            }
            rtbDriveCode.Text += "\n";
            rtbDriveCode.Text += "--BumpRight-- ";
            foreach (object Line in (object[])lstDriveStorage[3])
            {
                rtbDriveCode.Text += Line.ToString() + ", ";
            }
            rtbDriveCode.Text += "\n";
            rtbDriveCode.Text += "--RemoteMax-- ";
            foreach (object Line in (object[])lstDriveStorage[4])
            {
                rtbDriveCode.Text += Line.ToString() + ", ";
            }
            rtbDriveCode.Text += "\n";
            rtbDriveCode.Text += "--RemoteSpot-- ";
            foreach (object Line in (object[])lstDriveStorage[5])
            {
                rtbDriveCode.Text += Line.ToString() + ", ";
            }
            rtbDriveCode.Text += "\n";
            rtbDriveCode.Text += "--RemoteLeft-- ";
            foreach (object Line in (object[])lstDriveStorage[6])
            {
                rtbDriveCode.Text += Line.ToString() + ", ";
            }
            rtbDriveCode.Text += "\n";
            rtbDriveCode.Text += "--RemoteRight-- ";
            foreach (object Line in (object[])lstDriveStorage[7])
            {
                rtbDriveCode.Text += Line.ToString() + ", ";
            }
            rtbDriveCode.Text += "\n";
            rtbDriveCode.Text += "--RemoteDrive-- ";
            foreach (object Line in (object[])lstDriveStorage[8])
            {
                rtbDriveCode.Text += Line.ToString() + ", ";
            }
            rtbDriveCode.Text += "\n";
            // Write the Drive Commands
            foreach (object Line in (object[])lstDriveStorage[0])
            {
                rtbDriveCode.Text += Line.ToString() + "\n";
            }

            Parser parse = new Parser();
            ArrayList Errors = new ArrayList();
            Parser.ValidateError Error =parse.ValidateDriveCode(rtbDriveCode.Text, out Errors);
            if (Error != Parser.ValidateError.NoError)
            {
                LogError("There has been an error in the code");
            }
           
        }

        /// <summary>
        /// Take the Drive commands and put them into the drive storage
        /// </summary>
        private void GenerateDriveCommands()
        {

        }

        private void cmdDriveDelete_Click(object sender, EventArgs e)
        {
            // Remove the selected item
            if (lstDrive.SelectedIndex >= 0)
            {
                lstDrive.Items.RemoveAt(lstDrive.SelectedIndex);
            }
        }

        private void cmdDriveDesigner_Click(object sender, EventArgs e)
        {
            // Select the Drive Designer
            tabConMain.SelectedIndex = 0;
        }


        #region Menu
        private void mnuDriveModeSimple_Click(object sender, EventArgs e)
        {
            bolDriveModeAdvanced = false;

            mnuDriveModeAdvanced.Checked = false;
            mnuDriveModeSimple.Checked = true;
        }

        private void mnuDriveModeAdvanced_Click(object sender, EventArgs e)
        {
            bolDriveModeAdvanced = true;

            mnuDriveModeAdvanced.Checked = true;
            mnuDriveModeSimple.Checked = false;
        }

        private void mnuDriveModeDefaultsTurn_Click(object sender, EventArgs e)
        {
            // Lock the form to prevent multiple calls
            LockForm(true);

            Keypad frmKeypad;

            // Show the keypad
            frmKeypad = new Keypad("Degrees", this);
            frmKeypad.Show();

            // Wait until the keypad has returned
            while (!bolKeypadReturn)
            {
                // Waste time
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }

            // Add the command
            if (intKeypadReturn > 0)
            {
                intDriveSimpleTurnDefault = intKeypadReturn;
                mnuDriveModeDefaultsTurn.Text = "Turn - " + intDriveSimpleTurnDefault.ToString();
            }

            // Reset the Keypad return
            bolKeypadReturn = false;
            intKeypadReturn = 0;

            // Unlock the form
            LockForm(false);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strFilename != string.Empty)
            {
                Save SaveFile = new Save();
                SaveFile.SaveProgram();
            }
            else
            {
                // No file, run save as
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check for Save
            //TODO Check for Save on Load

            // Open the file selection dialog
            openFileDialog.ShowDialog();

            // Ensure the file exists
            if (openFileDialog.CheckFileExists)
            {
                // Open the file
                Open OpenFile = new Open();
                if (OpenFile.OpenProgram(openFileDialog.FileName))
                {
                    // If the load has been sucessful set the openfile to the opened file.
                    strFilename = openFileDialog.FileName;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            //TODO, finish dealing with the save as
        }
        #endregion

        private void GenerateRobotCodeFromDesigner()
        {
            Parser parse = new Parser();
            rtbRobotCode.Text = parse.ConvertBricktoRobot(strRobotDesigner);
        }

        private void GenerateRobotCodeFromDriveCode()
        {
            Parser parse = new Parser();
            rtbRobotCode.Text = parse.ConvertDrivetoRobot(rtbDriveCode.Text);
        }

        private void GenerateCfromRobotCode()
        {

        }

        private void cmdCMain_Click(object sender, EventArgs e)
        {
            rtbCCode.Text = "Main Code";
        }

        private void cmdCCommands_Click(object sender, EventArgs e)
        {
            rtbCCode.Text = "C Commands";
        }

        private void cmdLockC_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to unlock the C Code?\nThis will stop you from being able to modify the program using any other method", "Unlock C Code", MessageBoxButtons.YesNo);

            if (response == System.Windows.Forms.DialogResult.Yes)
            {
                cmdLockC.Visible = false;

                rtbCCode.Enabled = true;


                tabConMain.Controls.Remove(tabDrive);
                tabConMain.Controls.Remove(tabDriveCode);
                tabConMain.Controls.Remove(tabRobot);
                tabConMain.Controls.Remove(tabBuilder);
            }
        }

      

        private void lstDrive_DoubleClick(object sender, EventArgs e)
        {
            LockForm(true);

            string Command = lstDrive.SelectedItem.ToString();
            Parser parse = new Parser();

            string Argument = parse.GetDriveArgument(Command);
            Keypad key = new Keypad("TBC", int.Parse(Argument), this);

            key.Show();

            // Wait until the keypad has returned
            while (!bolKeypadReturn)
            {
                // Waste time
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }


            // Reset the Keypad return
            bolKeypadReturn = false;
            intKeypadReturn = 0;

            // Unlock the form
            LockForm(false);
        }
    }
}
