namespace RobotProgrammer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabConMain = new System.Windows.Forms.TabControl();
            this.tabDrive = new System.Windows.Forms.TabPage();
            this.cmdDriveDelete = new System.Windows.Forms.Button();
            this.cmdViewDriveSource = new System.Windows.Forms.Button();
            this.cmdSpeed = new System.Windows.Forms.Button();
            this.lblDriveMode = new System.Windows.Forms.Label();
            this.lblDriveDescription = new System.Windows.Forms.Label();
            this.cboDriveMode = new System.Windows.Forms.ComboBox();
            this.lstDrive = new System.Windows.Forms.ListBox();
            this.cmdWait = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdLeft = new System.Windows.Forms.Button();
            this.cmdRight = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdForward = new System.Windows.Forms.Button();
            this.tabDriveCode = new System.Windows.Forms.TabPage();
            this.rtbDriveCode = new System.Windows.Forms.RichTextBox();
            this.cmdViewDriveDesigner = new System.Windows.Forms.Button();
            this.tabBuilder = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRobot = new System.Windows.Forms.TabPage();
            this.cmdViewRobotDesigner = new System.Windows.Forms.Button();
            this.rtbRobotCode = new System.Windows.Forms.RichTextBox();
            this.tabCCode = new System.Windows.Forms.TabPage();
            this.cmdLockC = new System.Windows.Forms.Button();
            this.rtbCCode = new System.Windows.Forms.RichTextBox();
            this.cmdCCommands = new System.Windows.Forms.Button();
            this.cmdCMain = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driveCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDriveModeSimple = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDriveModeAdvanced = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDriveModeDefaultsTurn = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabConMain.SuspendLayout();
            this.tabDrive.SuspendLayout();
            this.tabDriveCode.SuspendLayout();
            this.tabBuilder.SuspendLayout();
            this.tabRobot.SuspendLayout();
            this.tabCCode.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConMain
            // 
            this.tabConMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConMain.Controls.Add(this.tabDrive);
            this.tabConMain.Controls.Add(this.tabDriveCode);
            this.tabConMain.Controls.Add(this.tabBuilder);
            this.tabConMain.Controls.Add(this.tabRobot);
            this.tabConMain.Controls.Add(this.tabCCode);
            this.tabConMain.Location = new System.Drawing.Point(16, 33);
            this.tabConMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabConMain.Name = "tabConMain";
            this.tabConMain.SelectedIndex = 0;
            this.tabConMain.Size = new System.Drawing.Size(907, 566);
            this.tabConMain.TabIndex = 0;
            this.tabConMain.SelectedIndexChanged += new System.EventHandler(this.tabConMain_SelectedIndexChanged);
            // 
            // tabDrive
            // 
            this.tabDrive.Controls.Add(this.cmdDriveDelete);
            this.tabDrive.Controls.Add(this.cmdViewDriveSource);
            this.tabDrive.Controls.Add(this.cmdSpeed);
            this.tabDrive.Controls.Add(this.lblDriveMode);
            this.tabDrive.Controls.Add(this.lblDriveDescription);
            this.tabDrive.Controls.Add(this.cboDriveMode);
            this.tabDrive.Controls.Add(this.lstDrive);
            this.tabDrive.Controls.Add(this.cmdWait);
            this.tabDrive.Controls.Add(this.cmdStop);
            this.tabDrive.Controls.Add(this.cmdLeft);
            this.tabDrive.Controls.Add(this.cmdRight);
            this.tabDrive.Controls.Add(this.cmdBack);
            this.tabDrive.Controls.Add(this.cmdForward);
            this.tabDrive.Location = new System.Drawing.Point(4, 25);
            this.tabDrive.Margin = new System.Windows.Forms.Padding(4);
            this.tabDrive.Name = "tabDrive";
            this.tabDrive.Padding = new System.Windows.Forms.Padding(4);
            this.tabDrive.Size = new System.Drawing.Size(899, 537);
            this.tabDrive.TabIndex = 0;
            this.tabDrive.Text = "Drive";
            this.tabDrive.UseVisualStyleBackColor = true;
            // 
            // cmdDriveDelete
            // 
            this.cmdDriveDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDriveDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDriveDelete.BackgroundImage")));
            this.cmdDriveDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDriveDelete.Location = new System.Drawing.Point(821, 342);
            this.cmdDriveDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDriveDelete.Name = "cmdDriveDelete";
            this.cmdDriveDelete.Size = new System.Drawing.Size(67, 62);
            this.cmdDriveDelete.TabIndex = 13;
            this.cmdDriveDelete.UseVisualStyleBackColor = true;
            this.cmdDriveDelete.Click += new System.EventHandler(this.cmdDriveDelete_Click);
            // 
            // cmdViewDriveSource
            // 
            this.cmdViewDriveSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdViewDriveSource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdViewDriveSource.BackgroundImage")));
            this.cmdViewDriveSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdViewDriveSource.Location = new System.Drawing.Point(821, 465);
            this.cmdViewDriveSource.Margin = new System.Windows.Forms.Padding(4);
            this.cmdViewDriveSource.Name = "cmdViewDriveSource";
            this.cmdViewDriveSource.Size = new System.Drawing.Size(67, 62);
            this.cmdViewDriveSource.TabIndex = 12;
            this.cmdViewDriveSource.UseVisualStyleBackColor = true;
            this.cmdViewDriveSource.Click += new System.EventHandler(this.cmdViewDriveSource_Click);
            // 
            // cmdSpeed
            // 
            this.cmdSpeed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdSpeed.BackgroundImage")));
            this.cmdSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSpeed.Location = new System.Drawing.Point(13, 430);
            this.cmdSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSpeed.Name = "cmdSpeed";
            this.cmdSpeed.Size = new System.Drawing.Size(100, 92);
            this.cmdSpeed.TabIndex = 11;
            this.cmdSpeed.UseVisualStyleBackColor = true;
            this.cmdSpeed.Click += new System.EventHandler(this.cmdSpeed_Click);
            // 
            // lblDriveMode
            // 
            this.lblDriveMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDriveMode.AutoSize = true;
            this.lblDriveMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveMode.Location = new System.Drawing.Point(347, 6);
            this.lblDriveMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveMode.Name = "lblDriveMode";
            this.lblDriveMode.Size = new System.Drawing.Size(78, 31);
            this.lblDriveMode.TabIndex = 10;
            this.lblDriveMode.Text = "Drive";
            // 
            // lblDriveDescription
            // 
            this.lblDriveDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDriveDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveDescription.Location = new System.Drawing.Point(339, 460);
            this.lblDriveDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveDescription.Name = "lblDriveDescription";
            this.lblDriveDescription.Size = new System.Drawing.Size(475, 62);
            this.lblDriveDescription.TabIndex = 9;
            this.lblDriveDescription.Text = "lblDriveDescription";
            // 
            // cboDriveMode
            // 
            this.cboDriveMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDriveMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDriveMode.FormattingEnabled = true;
            this.cboDriveMode.Items.AddRange(new object[] {
            "Drive",
            "Bump",
            "Bump Left",
            "Bump Right",
            "Remote - Max",
            "Remote - Spot",
            "Remote - Left",
            "Remote - Right",
            "Remote - Drive"});
            this.cboDriveMode.Location = new System.Drawing.Point(344, 407);
            this.cboDriveMode.Margin = new System.Windows.Forms.Padding(4);
            this.cboDriveMode.Name = "cboDriveMode";
            this.cboDriveMode.Size = new System.Drawing.Size(280, 37);
            this.cboDriveMode.TabIndex = 8;
            this.cboDriveMode.SelectedIndexChanged += new System.EventHandler(this.cboDriveMode_SelectedIndexChanged);
            // 
            // lstDrive
            // 
            this.lstDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDrive.FormattingEnabled = true;
            this.lstDrive.ItemHeight = 29;
            this.lstDrive.Location = new System.Drawing.Point(344, 41);
            this.lstDrive.Margin = new System.Windows.Forms.Padding(4);
            this.lstDrive.Name = "lstDrive";
            this.lstDrive.Size = new System.Drawing.Size(468, 352);
            this.lstDrive.TabIndex = 7;
            this.lstDrive.DoubleClick += new System.EventHandler(this.lstDrive_DoubleClick);
            // 
            // cmdWait
            // 
            this.cmdWait.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdWait.BackgroundImage")));
            this.cmdWait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdWait.Location = new System.Drawing.Point(13, 330);
            this.cmdWait.Margin = new System.Windows.Forms.Padding(4);
            this.cmdWait.Name = "cmdWait";
            this.cmdWait.Size = new System.Drawing.Size(100, 92);
            this.cmdWait.TabIndex = 6;
            this.cmdWait.UseVisualStyleBackColor = true;
            this.cmdWait.Click += new System.EventHandler(this.cmdWait_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdStop.BackgroundImage")));
            this.cmdStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdStop.Location = new System.Drawing.Point(121, 107);
            this.cmdStop.Margin = new System.Windows.Forms.Padding(4);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(100, 92);
            this.cmdStop.TabIndex = 5;
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdLeft
            // 
            this.cmdLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdLeft.BackgroundImage")));
            this.cmdLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdLeft.Location = new System.Drawing.Point(13, 107);
            this.cmdLeft.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLeft.Name = "cmdLeft";
            this.cmdLeft.Size = new System.Drawing.Size(100, 92);
            this.cmdLeft.TabIndex = 4;
            this.cmdLeft.UseVisualStyleBackColor = true;
            this.cmdLeft.Click += new System.EventHandler(this.cmdLeft_Click);
            // 
            // cmdRight
            // 
            this.cmdRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRight.BackgroundImage")));
            this.cmdRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRight.Location = new System.Drawing.Point(229, 107);
            this.cmdRight.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRight.Name = "cmdRight";
            this.cmdRight.Size = new System.Drawing.Size(100, 92);
            this.cmdRight.TabIndex = 3;
            this.cmdRight.UseVisualStyleBackColor = true;
            this.cmdRight.Click += new System.EventHandler(this.cmdRight_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBack.BackgroundImage")));
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.Location = new System.Drawing.Point(121, 207);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(100, 92);
            this.cmdBack.TabIndex = 1;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdForward
            // 
            this.cmdForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdForward.BackgroundImage")));
            this.cmdForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdForward.Location = new System.Drawing.Point(121, 7);
            this.cmdForward.Margin = new System.Windows.Forms.Padding(4);
            this.cmdForward.Name = "cmdForward";
            this.cmdForward.Size = new System.Drawing.Size(100, 92);
            this.cmdForward.TabIndex = 0;
            this.cmdForward.UseVisualStyleBackColor = true;
            this.cmdForward.Click += new System.EventHandler(this.cmdForward_Click);
            // 
            // tabDriveCode
            // 
            this.tabDriveCode.Controls.Add(this.rtbDriveCode);
            this.tabDriveCode.Controls.Add(this.cmdViewDriveDesigner);
            this.tabDriveCode.Location = new System.Drawing.Point(4, 25);
            this.tabDriveCode.Margin = new System.Windows.Forms.Padding(4);
            this.tabDriveCode.Name = "tabDriveCode";
            this.tabDriveCode.Padding = new System.Windows.Forms.Padding(4);
            this.tabDriveCode.Size = new System.Drawing.Size(899, 537);
            this.tabDriveCode.TabIndex = 1;
            this.tabDriveCode.Text = "Drive Code";
            this.tabDriveCode.UseVisualStyleBackColor = true;
            // 
            // rtbDriveCode
            // 
            this.rtbDriveCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDriveCode.Location = new System.Drawing.Point(8, 7);
            this.rtbDriveCode.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDriveCode.Name = "rtbDriveCode";
            this.rtbDriveCode.Size = new System.Drawing.Size(804, 518);
            this.rtbDriveCode.TabIndex = 14;
            this.rtbDriveCode.Text = "";
            // 
            // cmdViewDriveDesigner
            // 
            this.cmdViewDriveDesigner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdViewDriveDesigner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdViewDriveDesigner.BackgroundImage")));
            this.cmdViewDriveDesigner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdViewDriveDesigner.Location = new System.Drawing.Point(821, 465);
            this.cmdViewDriveDesigner.Margin = new System.Windows.Forms.Padding(4);
            this.cmdViewDriveDesigner.Name = "cmdViewDriveDesigner";
            this.cmdViewDriveDesigner.Size = new System.Drawing.Size(67, 62);
            this.cmdViewDriveDesigner.TabIndex = 13;
            this.cmdViewDriveDesigner.UseVisualStyleBackColor = true;
            this.cmdViewDriveDesigner.Click += new System.EventHandler(this.cmdDriveDesigner_Click);
            // 
            // tabBuilder
            // 
            this.tabBuilder.Controls.Add(this.label1);
            this.tabBuilder.Location = new System.Drawing.Point(4, 25);
            this.tabBuilder.Margin = new System.Windows.Forms.Padding(4);
            this.tabBuilder.Name = "tabBuilder";
            this.tabBuilder.Padding = new System.Windows.Forms.Padding(4);
            this.tabBuilder.Size = new System.Drawing.Size(899, 537);
            this.tabBuilder.TabIndex = 2;
            this.tabBuilder.Text = "Builder";
            this.tabBuilder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "This page will allow you to design a program";
            // 
            // tabRobot
            // 
            this.tabRobot.Controls.Add(this.cmdViewRobotDesigner);
            this.tabRobot.Controls.Add(this.rtbRobotCode);
            this.tabRobot.Location = new System.Drawing.Point(4, 25);
            this.tabRobot.Margin = new System.Windows.Forms.Padding(4);
            this.tabRobot.Name = "tabRobot";
            this.tabRobot.Padding = new System.Windows.Forms.Padding(4);
            this.tabRobot.Size = new System.Drawing.Size(899, 537);
            this.tabRobot.TabIndex = 3;
            this.tabRobot.Text = "Robot Code";
            this.tabRobot.UseVisualStyleBackColor = true;
            // 
            // cmdViewRobotDesigner
            // 
            this.cmdViewRobotDesigner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdViewRobotDesigner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdViewRobotDesigner.BackgroundImage")));
            this.cmdViewRobotDesigner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdViewRobotDesigner.Location = new System.Drawing.Point(821, 465);
            this.cmdViewRobotDesigner.Margin = new System.Windows.Forms.Padding(4);
            this.cmdViewRobotDesigner.Name = "cmdViewRobotDesigner";
            this.cmdViewRobotDesigner.Size = new System.Drawing.Size(67, 62);
            this.cmdViewRobotDesigner.TabIndex = 14;
            this.cmdViewRobotDesigner.UseVisualStyleBackColor = true;
            // 
            // rtbRobotCode
            // 
            this.rtbRobotCode.Location = new System.Drawing.Point(8, 7);
            this.rtbRobotCode.Margin = new System.Windows.Forms.Padding(4);
            this.rtbRobotCode.Name = "rtbRobotCode";
            this.rtbRobotCode.Size = new System.Drawing.Size(804, 518);
            this.rtbRobotCode.TabIndex = 0;
            this.rtbRobotCode.Text = "";
            // 
            // tabCCode
            // 
            this.tabCCode.Controls.Add(this.cmdLockC);
            this.tabCCode.Controls.Add(this.rtbCCode);
            this.tabCCode.Controls.Add(this.cmdCCommands);
            this.tabCCode.Controls.Add(this.cmdCMain);
            this.tabCCode.Location = new System.Drawing.Point(4, 25);
            this.tabCCode.Margin = new System.Windows.Forms.Padding(4);
            this.tabCCode.Name = "tabCCode";
            this.tabCCode.Padding = new System.Windows.Forms.Padding(4);
            this.tabCCode.Size = new System.Drawing.Size(899, 537);
            this.tabCCode.TabIndex = 4;
            this.tabCCode.Text = "C Code";
            this.tabCCode.UseVisualStyleBackColor = true;
            // 
            // cmdLockC
            // 
            this.cmdLockC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLockC.Location = new System.Drawing.Point(833, 501);
            this.cmdLockC.Name = "cmdLockC";
            this.cmdLockC.Size = new System.Drawing.Size(59, 29);
            this.cmdLockC.TabIndex = 3;
            this.cmdLockC.Text = "button1";
            this.cmdLockC.UseVisualStyleBackColor = true;
            this.cmdLockC.Click += new System.EventHandler(this.cmdLockC_Click);
            // 
            // rtbCCode
            // 
            this.rtbCCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCCode.Location = new System.Drawing.Point(8, 7);
            this.rtbCCode.Name = "rtbCCode";
            this.rtbCCode.Size = new System.Drawing.Size(884, 488);
            this.rtbCCode.TabIndex = 2;
            this.rtbCCode.Text = "";
            // 
            // cmdCCommands
            // 
            this.cmdCCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCCommands.Location = new System.Drawing.Point(116, 502);
            this.cmdCCommands.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCCommands.Name = "cmdCCommands";
            this.cmdCCommands.Size = new System.Drawing.Size(100, 28);
            this.cmdCCommands.TabIndex = 1;
            this.cmdCCommands.Text = "commands.c";
            this.cmdCCommands.UseVisualStyleBackColor = true;
            this.cmdCCommands.Click += new System.EventHandler(this.cmdCCommands_Click);
            // 
            // cmdCMain
            // 
            this.cmdCMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCMain.Location = new System.Drawing.Point(8, 502);
            this.cmdCMain.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCMain.Name = "cmdCMain";
            this.cmdCMain.Size = new System.Drawing.Size(100, 28);
            this.cmdCMain.TabIndex = 0;
            this.cmdCMain.Text = "main.c";
            this.cmdCMain.UseVisualStyleBackColor = true;
            this.cmdCMain.Click += new System.EventHandler(this.cmdCMain_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(939, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(939, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.printToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveCodeToolStripMenuItem,
            this.robotCodeToolStripMenuItem,
            this.cCodeToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // driveCodeToolStripMenuItem
            // 
            this.driveCodeToolStripMenuItem.Name = "driveCodeToolStripMenuItem";
            this.driveCodeToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.driveCodeToolStripMenuItem.Text = "Drive Code";
            // 
            // robotCodeToolStripMenuItem
            // 
            this.robotCodeToolStripMenuItem.Name = "robotCodeToolStripMenuItem";
            this.robotCodeToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.robotCodeToolStripMenuItem.Text = "Robot Code";
            // 
            // cCodeToolStripMenuItem
            // 
            this.cCodeToolStripMenuItem.Name = "cCodeToolStripMenuItem";
            this.cCodeToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.cCodeToolStripMenuItem.Text = "C Code";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(216, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveToolStripMenuItem});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // driveToolStripMenuItem
            // 
            this.driveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.driveToolStripMenuItem.Name = "driveToolStripMenuItem";
            this.driveToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.driveToolStripMenuItem.Text = "Drive";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDriveModeSimple,
            this.mnuDriveModeAdvanced});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // mnuDriveModeSimple
            // 
            this.mnuDriveModeSimple.Name = "mnuDriveModeSimple";
            this.mnuDriveModeSimple.Size = new System.Drawing.Size(144, 24);
            this.mnuDriveModeSimple.Text = "Simple";
            this.mnuDriveModeSimple.Click += new System.EventHandler(this.mnuDriveModeSimple_Click);
            // 
            // mnuDriveModeAdvanced
            // 
            this.mnuDriveModeAdvanced.Checked = true;
            this.mnuDriveModeAdvanced.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuDriveModeAdvanced.Name = "mnuDriveModeAdvanced";
            this.mnuDriveModeAdvanced.Size = new System.Drawing.Size(144, 24);
            this.mnuDriveModeAdvanced.Text = "Advanced";
            this.mnuDriveModeAdvanced.Click += new System.EventHandler(this.mnuDriveModeAdvanced_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDriveModeDefaultsTurn,
            this.speedToolStripMenuItem});
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.defaultToolStripMenuItem.Text = "Simple Mode Defaults";
            // 
            // mnuDriveModeDefaultsTurn
            // 
            this.mnuDriveModeDefaultsTurn.Name = "mnuDriveModeDefaultsTurn";
            this.mnuDriveModeDefaultsTurn.Size = new System.Drawing.Size(137, 24);
            this.mnuDriveModeDefaultsTurn.Text = "Turn - 45";
            this.mnuDriveModeDefaultsTurn.Click += new System.EventHandler(this.mnuDriveModeDefaultsTurn_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save Program";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Open Program";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 630);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabConMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(954, 666);
            this.Name = "frmMain";
            this.Text = "iRobot Programmer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabConMain.ResumeLayout(false);
            this.tabDrive.ResumeLayout(false);
            this.tabDrive.PerformLayout();
            this.tabDriveCode.ResumeLayout(false);
            this.tabBuilder.ResumeLayout(false);
            this.tabBuilder.PerformLayout();
            this.tabRobot.ResumeLayout(false);
            this.tabCCode.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabConMain;
        private System.Windows.Forms.TabPage tabDrive;
        private System.Windows.Forms.TabPage tabDriveCode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button cmdForward;
        private System.Windows.Forms.ListBox lstDrive;
        private System.Windows.Forms.Button cmdWait;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdLeft;
        private System.Windows.Forms.Button cmdRight;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Label lblDriveDescription;
        private System.Windows.Forms.ComboBox cboDriveMode;
        private System.Windows.Forms.Label lblDriveMode;
        private System.Windows.Forms.Button cmdSpeed;
        private System.Windows.Forms.Button cmdViewDriveSource;
        private System.Windows.Forms.RichTextBox rtbDriveCode;
        private System.Windows.Forms.Button cmdViewDriveDesigner;
        private System.Windows.Forms.Button cmdDriveDelete;
        private System.Windows.Forms.TabPage tabBuilder;
        private System.Windows.Forms.TabPage tabRobot;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDriveModeSimple;
        private System.Windows.Forms.ToolStripMenuItem mnuDriveModeAdvanced;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDriveModeDefaultsTurn;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driveCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robotCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdViewRobotDesigner;
        private System.Windows.Forms.RichTextBox rtbRobotCode;
        private System.Windows.Forms.TabPage tabCCode;
        private System.Windows.Forms.Button cmdCCommands;
        private System.Windows.Forms.Button cmdCMain;
        private System.Windows.Forms.RichTextBox rtbCCode;
        private System.Windows.Forms.Button cmdLockC;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

