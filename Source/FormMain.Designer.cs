namespace TRWinApp
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnSendFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.btnRefreshCOMList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDestPath = new System.Windows.Forms.Label();
            this.tbDestPath = new System.Windows.Forms.TextBox();
            this.rbUSBDrive = new System.Windows.Forms.RadioButton();
            this.rbSDCard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.nudSongNum = new System.Windows.Forms.NumericUpDown();
            this.btnSetSIDSong = new System.Windows.Forms.Button();
            this.btnPauseSID = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.rbComSerial = new System.Windows.Forms.RadioButton();
            this.rbComEthernet = new System.Windows.Forms.RadioButton();
            this.pnlSerialSetup = new System.Windows.Forms.Panel();
            this.pnlEthernetSetup = new System.Windows.Forms.Panel();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPostFlush = new System.Windows.Forms.CheckBox();
            this.pnlDebug = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoteDir = new System.Windows.Forms.Button();
            this.rbRL_TF = new System.Windows.Forms.RadioButton();
            this.rbRL_SD = new System.Windows.Forms.RadioButton();
            this.rbRL_USB = new System.Windows.Forms.RadioButton();
            this.tbLaunchFilePath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSongNum)).BeginInit();
            this.pnlSerialSetup.SuspendLayout();
            this.pnlEthernetSetup.SuspendLayout();
            this.pnlDebug.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendFile
            // 
            this.btnSendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFile.Location = new System.Drawing.Point(245, 74);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(90, 28);
            this.btnSendFile.TabIndex = 8;
            this.btnSendFile.Text = "Send File";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(16, 328);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(653, 292);
            this.rtbOutput.TabIndex = 9;
            this.rtbOutput.Text = "";
            // 
            // btnPing
            // 
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.Location = new System.Drawing.Point(9, 26);
            this.btnPing.Margin = new System.Windows.Forms.Padding(4);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(90, 28);
            this.btnPing.TabIndex = 10;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(51, 15);
            this.cmbCOMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(89, 24);
            this.cmbCOMPort.TabIndex = 11;
            // 
            // btnRefreshCOMList
            // 
            this.btnRefreshCOMList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCOMList.Location = new System.Drawing.Point(16, 15);
            this.btnRefreshCOMList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshCOMList.Name = "btnRefreshCOMList";
            this.btnRefreshCOMList.Size = new System.Drawing.Size(29, 25);
            this.btnRefreshCOMList.TabIndex = 12;
            this.btnRefreshCOMList.Text = "...";
            this.btnRefreshCOMList.UseVisualStyleBackColor = true;
            this.btnRefreshCOMList.Click += new System.EventHandler(this.btnRefreshCOMList_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(579, 294);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clr Log";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(9, 62);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 28);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDestPath
            // 
            this.lblDestPath.AutoSize = true;
            this.lblDestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestPath.Location = new System.Drawing.Point(135, 95);
            this.lblDestPath.Name = "lblDestPath";
            this.lblDestPath.Size = new System.Drawing.Size(91, 16);
            this.lblDestPath.TabIndex = 23;
            this.lblDestPath.Text = "SD Card Path:";
            // 
            // tbDestPath
            // 
            this.tbDestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestPath.Location = new System.Drawing.Point(147, 115);
            this.tbDestPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDestPath.Name = "tbDestPath";
            this.tbDestPath.Size = new System.Drawing.Size(220, 22);
            this.tbDestPath.TabIndex = 22;
            this.tbDestPath.Text = "/";
            // 
            // rbUSBDrive
            // 
            this.rbUSBDrive.AutoSize = true;
            this.rbUSBDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUSBDrive.Location = new System.Drawing.Point(23, 125);
            this.rbUSBDrive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbUSBDrive.Name = "rbUSBDrive";
            this.rbUSBDrive.Size = new System.Drawing.Size(91, 20);
            this.rbUSBDrive.TabIndex = 21;
            this.rbUSBDrive.Text = "USB Drive";
            this.rbUSBDrive.UseVisualStyleBackColor = true;
            this.rbUSBDrive.CheckedChanged += new System.EventHandler(this.rbUSBDRive_CheckedChanged);
            // 
            // rbSDCard
            // 
            this.rbSDCard.AutoSize = true;
            this.rbSDCard.Checked = true;
            this.rbSDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSDCard.Location = new System.Drawing.Point(23, 99);
            this.rbSDCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSDCard.Name = "rbSDCard";
            this.rbSDCard.Size = new System.Drawing.Size(79, 20);
            this.rbSDCard.TabIndex = 20;
            this.rbSDCard.TabStop = true;
            this.rbSDCard.Text = "SD Card";
            this.rbSDCard.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "TR Destination:";
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSource.Location = new System.Drawing.Point(23, 37);
            this.btnSelectSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(29, 27);
            this.btnSelectSource.TabIndex = 18;
            this.btnSelectSource.Text = "...";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Local Source:";
            // 
            // tbSource
            // 
            this.tbSource.AllowDrop = true;
            this.tbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSource.Location = new System.Drawing.Point(58, 39);
            this.tbSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSource.Name = "tbSource";
            this.tbSource.ReadOnly = true;
            this.tbSource.Size = new System.Drawing.Size(309, 22);
            this.tbSource.TabIndex = 16;
            this.tbSource.Text = "<-- Selection button      -or-      Drag/Drop File Here";
            this.tbSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbSource_DragDrop);
            this.tbSource.DragOver += new System.Windows.Forms.DragEventHandler(this.tbSource_DragOver);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(8, 0);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(90, 28);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "Test/Debug";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // nudSongNum
            // 
            this.nudSongNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSongNum.Location = new System.Drawing.Point(180, 114);
            this.nudSongNum.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudSongNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSongNum.Name = "nudSongNum";
            this.nudSongNum.Size = new System.Drawing.Size(54, 22);
            this.nudSongNum.TabIndex = 18;
            this.nudSongNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSetSIDSong
            // 
            this.btnSetSIDSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSIDSong.Location = new System.Drawing.Point(144, 80);
            this.btnSetSIDSong.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetSIDSong.Name = "btnSetSIDSong";
            this.btnSetSIDSong.Size = new System.Drawing.Size(90, 28);
            this.btnSetSIDSong.TabIndex = 17;
            this.btnSetSIDSong.Text = "Set Song";
            this.btnSetSIDSong.UseVisualStyleBackColor = true;
            this.btnSetSIDSong.Click += new System.EventHandler(this.btnSetSIDSong_Click);
            // 
            // btnPauseSID
            // 
            this.btnPauseSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseSID.Location = new System.Drawing.Point(144, 26);
            this.btnPauseSID.Margin = new System.Windows.Forms.Padding(4);
            this.btnPauseSID.Name = "btnPauseSID";
            this.btnPauseSID.Size = new System.Drawing.Size(90, 28);
            this.btnPauseSID.TabIndex = 16;
            this.btnPauseSID.Text = "Pause SID";
            this.btnPauseSID.UseVisualStyleBackColor = true;
            this.btnPauseSID.Click += new System.EventHandler(this.btnPauseSID_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(147, 54);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(90, 28);
            this.btnLaunch.TabIndex = 15;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // rbComSerial
            // 
            this.rbComSerial.AutoSize = true;
            this.rbComSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComSerial.Location = new System.Drawing.Point(6, 21);
            this.rbComSerial.Name = "rbComSerial";
            this.rbComSerial.Size = new System.Drawing.Size(63, 20);
            this.rbComSerial.TabIndex = 25;
            this.rbComSerial.Text = "Serial";
            this.rbComSerial.UseVisualStyleBackColor = true;
            // 
            // rbComEthernet
            // 
            this.rbComEthernet.AutoSize = true;
            this.rbComEthernet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComEthernet.Location = new System.Drawing.Point(6, 47);
            this.rbComEthernet.Name = "rbComEthernet";
            this.rbComEthernet.Size = new System.Drawing.Size(77, 20);
            this.rbComEthernet.TabIndex = 26;
            this.rbComEthernet.Text = "Ethernet";
            this.rbComEthernet.UseVisualStyleBackColor = true;
            this.rbComEthernet.CheckedChanged += new System.EventHandler(this.rbComEthernet_CheckedChanged);
            // 
            // pnlSerialSetup
            // 
            this.pnlSerialSetup.Controls.Add(this.btnRefreshCOMList);
            this.pnlSerialSetup.Controls.Add(this.cmbCOMPort);
            this.pnlSerialSetup.Location = new System.Drawing.Point(97, 9);
            this.pnlSerialSetup.Name = "pnlSerialSetup";
            this.pnlSerialSetup.Size = new System.Drawing.Size(150, 41);
            this.pnlSerialSetup.TabIndex = 19;
            // 
            // pnlEthernetSetup
            // 
            this.pnlEthernetSetup.Controls.Add(this.tbIPAddress);
            this.pnlEthernetSetup.Location = new System.Drawing.Point(97, 53);
            this.pnlEthernetSetup.Name = "pnlEthernetSetup";
            this.pnlEthernetSetup.Size = new System.Drawing.Size(150, 37);
            this.pnlEthernetSetup.TabIndex = 27;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIPAddress.Location = new System.Drawing.Point(16, 1);
            this.tbIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(124, 22);
            this.tbIPAddress.TabIndex = 23;
            this.tbIPAddress.Text = "192.168.1.222";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Communication Log:";
            // 
            // cbPostFlush
            // 
            this.cbPostFlush.AutoSize = true;
            this.cbPostFlush.Location = new System.Drawing.Point(117, 5);
            this.cbPostFlush.Name = "cbPostFlush";
            this.cbPostFlush.Size = new System.Drawing.Size(142, 20);
            this.cbPostFlush.TabIndex = 32;
            this.cbPostFlush.Text = "Flush Before Close";
            this.cbPostFlush.UseVisualStyleBackColor = true;
            // 
            // pnlDebug
            // 
            this.pnlDebug.Controls.Add(this.btnTest);
            this.pnlDebug.Controls.Add(this.cbPostFlush);
            this.pnlDebug.Location = new System.Drawing.Point(303, 286);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(258, 40);
            this.pnlDebug.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSource);
            this.groupBox1.Controls.Add(this.btnSelectSource);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbSDCard);
            this.groupBox1.Controls.Add(this.rbUSBDrive);
            this.groupBox1.Controls.Add(this.tbDestPath);
            this.groupBox1.Controls.Add(this.btnSendFile);
            this.groupBox1.Controls.Add(this.lblDestPath);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(271, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 150);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Transfer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbComSerial);
            this.groupBox2.Controls.Add(this.rbComEthernet);
            this.groupBox2.Controls.Add(this.pnlSerialSetup);
            this.groupBox2.Controls.Add(this.pnlEthernetSetup);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 96);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interface";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoteDir);
            this.groupBox3.Controls.Add(this.rbRL_TF);
            this.groupBox3.Controls.Add(this.rbRL_SD);
            this.groupBox3.Controls.Add(this.rbRL_USB);
            this.groupBox3.Controls.Add(this.btnLaunch);
            this.groupBox3.Controls.Add(this.tbLaunchFilePath);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(271, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 106);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remote Launch";
            // 
            // btnRemoteDir
            // 
            this.btnRemoteDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoteDir.Location = new System.Drawing.Point(245, 54);
            this.btnRemoteDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoteDir.Name = "btnRemoteDir";
            this.btnRemoteDir.Size = new System.Drawing.Size(90, 28);
            this.btnRemoteDir.TabIndex = 24;
            this.btnRemoteDir.Text = "Read Dir";
            this.btnRemoteDir.UseVisualStyleBackColor = true;
            this.btnRemoteDir.Click += new System.EventHandler(this.btnRemoteDir_Click);
            // 
            // rbRL_TF
            // 
            this.rbRL_TF.AutoSize = true;
            this.rbRL_TF.Checked = true;
            this.rbRL_TF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRL_TF.Location = new System.Drawing.Point(22, 70);
            this.rbRL_TF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRL_TF.Name = "rbRL_TF";
            this.rbRL_TF.Size = new System.Drawing.Size(110, 20);
            this.rbRL_TF.TabIndex = 24;
            this.rbRL_TF.TabStop = true;
            this.rbRL_TF.Text = "Teensy Flash";
            this.rbRL_TF.UseVisualStyleBackColor = true;
            // 
            // rbRL_SD
            // 
            this.rbRL_SD.AutoSize = true;
            this.rbRL_SD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRL_SD.Location = new System.Drawing.Point(22, 23);
            this.rbRL_SD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRL_SD.Name = "rbRL_SD";
            this.rbRL_SD.Size = new System.Drawing.Size(79, 20);
            this.rbRL_SD.TabIndex = 20;
            this.rbRL_SD.Text = "SD Card";
            this.rbRL_SD.UseVisualStyleBackColor = true;
            // 
            // rbRL_USB
            // 
            this.rbRL_USB.AutoSize = true;
            this.rbRL_USB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRL_USB.Location = new System.Drawing.Point(22, 46);
            this.rbRL_USB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRL_USB.Name = "rbRL_USB";
            this.rbRL_USB.Size = new System.Drawing.Size(91, 20);
            this.rbRL_USB.TabIndex = 21;
            this.rbRL_USB.Text = "USB Drive";
            this.rbRL_USB.UseVisualStyleBackColor = true;
            // 
            // tbLaunchFilePath
            // 
            this.tbLaunchFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLaunchFilePath.Location = new System.Drawing.Point(147, 26);
            this.tbLaunchFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLaunchFilePath.Name = "tbLaunchFilePath";
            this.tbLaunchFilePath.Size = new System.Drawing.Size(220, 22);
            this.tbLaunchFilePath.TabIndex = 22;
            this.tbLaunchFilePath.Text = "/Games/Gorf!";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudSongNum);
            this.groupBox4.Controls.Add(this.btnPing);
            this.groupBox4.Controls.Add(this.btnSetSIDSong);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnPauseSID);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 166);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other Commands";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(685, 631);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlDebug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "TeensyROM Transfer/Control v0.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSongNum)).EndInit();
            this.pnlSerialSetup.ResumeLayout(false);
            this.pnlEthernetSetup.ResumeLayout(false);
            this.pnlEthernetSetup.PerformLayout();
            this.pnlDebug.ResumeLayout(false);
            this.pnlDebug.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.ComboBox cmbCOMPort;
        private System.Windows.Forms.Button btnRefreshCOMList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblDestPath;
        private System.Windows.Forms.TextBox tbDestPath;
        private System.Windows.Forms.RadioButton rbUSBDrive;
        private System.Windows.Forms.RadioButton rbSDCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnPauseSID;
        private System.Windows.Forms.NumericUpDown nudSongNum;
        private System.Windows.Forms.Button btnSetSIDSong;
        private System.Windows.Forms.RadioButton rbComSerial;
        private System.Windows.Forms.RadioButton rbComEthernet;
        private System.Windows.Forms.Panel pnlSerialSetup;
        private System.Windows.Forms.Panel pnlEthernetSetup;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbPostFlush;
        private System.Windows.Forms.Panel pnlDebug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbRL_TF;
        private System.Windows.Forms.RadioButton rbRL_SD;
        private System.Windows.Forms.RadioButton rbRL_USB;
        private System.Windows.Forms.TextBox tbLaunchFilePath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemoteDir;
    }
}

