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
            this.cbAutoSend = new System.Windows.Forms.CheckBox();
            this.cbAutoLaunch = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTRFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPathSource = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRemoteDir = new System.Windows.Forms.Button();
            this.rbRL_TF = new System.Windows.Forms.RadioButton();
            this.rbRL_SD = new System.Windows.Forms.RadioButton();
            this.rbRL_USB = new System.Windows.Forms.RadioButton();
            this.tbTRPath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbColorTarget = new System.Windows.Forms.ComboBox();
            this.cbC64Freeze = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbV3 = new System.Windows.Forms.CheckBox();
            this.cbV2 = new System.Windows.Forms.CheckBox();
            this.cbV1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDefaultSpeed = new System.Windows.Forms.Button();
            this.lblPlaybackSpeed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackbarSIDSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudSongNum)).BeginInit();
            this.pnlSerialSetup.SuspendLayout();
            this.pnlEthernetSetup.SuspendLayout();
            this.pnlDebug.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarSIDSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendFile
            // 
            this.btnSendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFile.Location = new System.Drawing.Point(98, 81);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(100, 28);
            this.btnSendFile.TabIndex = 8;
            this.btnSendFile.Text = "Send to TR";
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
            this.rtbOutput.Location = new System.Drawing.Point(12, 422);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(657, 241);
            this.rtbOutput.TabIndex = 9;
            this.rtbOutput.Text = "";
            // 
            // btnPing
            // 
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.Location = new System.Drawing.Point(20, 22);
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
            this.cmbCOMPort.Location = new System.Drawing.Point(51, 2);
            this.cmbCOMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(89, 24);
            this.cmbCOMPort.TabIndex = 11;
            // 
            // btnRefreshCOMList
            // 
            this.btnRefreshCOMList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCOMList.Location = new System.Drawing.Point(16, 2);
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
            this.btnClear.Location = new System.Drawing.Point(578, 388);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Log";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(118, 22);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 28);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset/Menu";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Source Path/Filename:";
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
            this.tbSource.Text = "<-- Selection button   -or-   Drag/Drop File Here";
            this.tbSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbSource_DragDrop);
            this.tbSource.DragOver += new System.Windows.Forms.DragEventHandler(this.tbSource_DragOver);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(4, 3);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(102, 28);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "Test/Debug";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // nudSongNum
            // 
            this.nudSongNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSongNum.Location = new System.Drawing.Point(117, 62);
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
            this.btnSetSIDSong.Location = new System.Drawing.Point(20, 58);
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
            this.btnPauseSID.Location = new System.Drawing.Point(20, 22);
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
            this.btnLaunch.Location = new System.Drawing.Point(108, 101);
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
            this.rbComSerial.Location = new System.Drawing.Point(20, 27);
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
            this.rbComEthernet.Location = new System.Drawing.Point(20, 53);
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
            this.pnlSerialSetup.Location = new System.Drawing.Point(91, 22);
            this.pnlSerialSetup.Name = "pnlSerialSetup";
            this.pnlSerialSetup.Size = new System.Drawing.Size(150, 43);
            this.pnlSerialSetup.TabIndex = 19;
            // 
            // pnlEthernetSetup
            // 
            this.pnlEthernetSetup.Controls.Add(this.tbIPAddress);
            this.pnlEthernetSetup.Location = new System.Drawing.Point(91, 52);
            this.pnlEthernetSetup.Name = "pnlEthernetSetup";
            this.pnlEthernetSetup.Size = new System.Drawing.Size(150, 26);
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
            this.label5.Location = new System.Drawing.Point(12, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Communication Log:";
            // 
            // cbPostFlush
            // 
            this.cbPostFlush.AutoSize = true;
            this.cbPostFlush.Location = new System.Drawing.Point(3, 38);
            this.cbPostFlush.Name = "cbPostFlush";
            this.cbPostFlush.Size = new System.Drawing.Size(142, 20);
            this.cbPostFlush.TabIndex = 32;
            this.cbPostFlush.Text = "Flush Before Close";
            this.cbPostFlush.UseVisualStyleBackColor = true;
            // 
            // pnlDebug
            // 
            this.pnlDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDebug.Controls.Add(this.btnTest);
            this.pnlDebug.Controls.Add(this.cbPostFlush);
            this.pnlDebug.Location = new System.Drawing.Point(509, 312);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(160, 64);
            this.pnlDebug.TabIndex = 33;
            this.pnlDebug.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAutoSend);
            this.groupBox1.Controls.Add(this.cbAutoLaunch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSource);
            this.groupBox1.Controls.Add(this.btnSelectSource);
            this.groupBox1.Controls.Add(this.btnSendFile);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(281, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 128);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local File System";
            // 
            // cbAutoSend
            // 
            this.cbAutoSend.AutoSize = true;
            this.cbAutoSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoSend.Location = new System.Drawing.Point(205, 72);
            this.cbAutoSend.Name = "cbAutoSend";
            this.cbAutoSend.Size = new System.Drawing.Size(150, 20);
            this.cbAutoSend.TabIndex = 39;
            this.cbAutoSend.Text = "Auto Send on Select";
            this.cbAutoSend.UseVisualStyleBackColor = true;
            // 
            // cbAutoLaunch
            // 
            this.cbAutoLaunch.AutoSize = true;
            this.cbAutoLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoLaunch.Location = new System.Drawing.Point(205, 98);
            this.cbAutoLaunch.Name = "cbAutoLaunch";
            this.cbAutoLaunch.Size = new System.Drawing.Size(155, 20);
            this.cbAutoLaunch.TabIndex = 38;
            this.cbAutoLaunch.Text = "Auto Launch on Send";
            this.cbAutoLaunch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbComSerial);
            this.groupBox2.Controls.Add(this.rbComEthernet);
            this.groupBox2.Controls.Add(this.pnlEthernetSetup);
            this.groupBox2.Controls.Add(this.pnlSerialSetup);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 92);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interface";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbTRFilename);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblPathSource);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnRemoteDir);
            this.groupBox3.Controls.Add(this.rbRL_TF);
            this.groupBox3.Controls.Add(this.rbRL_SD);
            this.groupBox3.Controls.Add(this.rbRL_USB);
            this.groupBox3.Controls.Add(this.btnLaunch);
            this.groupBox3.Controls.Add(this.tbTRPath);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(281, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 142);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TeensyROM File System";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Filename:";
            // 
            // tbTRFilename
            // 
            this.tbTRFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTRFilename.Location = new System.Drawing.Point(108, 73);
            this.tbTRFilename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTRFilename.Name = "tbTRFilename";
            this.tbTRFilename.Size = new System.Drawing.Size(188, 22);
            this.tbTRFilename.TabIndex = 50;
            this.tbTRFilename.Text = "Gorf!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Path:";
            // 
            // lblPathSource
            // 
            this.lblPathSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathSource.Location = new System.Drawing.Point(28, 50);
            this.lblPathSource.Name = "lblPathSource";
            this.lblPathSource.Size = new System.Drawing.Size(80, 19);
            this.lblPathSource.TabIndex = 48;
            this.lblPathSource.Text = "USB:";
            this.lblPathSource.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(206, 101);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 28);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRemoteDir
            // 
            this.btnRemoteDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoteDir.Location = new System.Drawing.Point(333, 70);
            this.btnRemoteDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoteDir.Name = "btnRemoteDir";
            this.btnRemoteDir.Size = new System.Drawing.Size(34, 28);
            this.btnRemoteDir.TabIndex = 24;
            this.btnRemoteDir.Text = "Dir";
            this.btnRemoteDir.UseVisualStyleBackColor = true;
            this.btnRemoteDir.Click += new System.EventHandler(this.btnRemoteDir_Click);
            // 
            // rbRL_TF
            // 
            this.rbRL_TF.AutoSize = true;
            this.rbRL_TF.Checked = true;
            this.rbRL_TF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRL_TF.Location = new System.Drawing.Point(245, 20);
            this.rbRL_TF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRL_TF.Name = "rbRL_TF";
            this.rbRL_TF.Size = new System.Drawing.Size(110, 20);
            this.rbRL_TF.TabIndex = 24;
            this.rbRL_TF.TabStop = true;
            this.rbRL_TF.Text = "Teensy Flash";
            this.rbRL_TF.UseVisualStyleBackColor = true;
            this.rbRL_TF.Click += new System.EventHandler(this.rbRL_X_Click);
            // 
            // rbRL_SD
            // 
            this.rbRL_SD.AutoSize = true;
            this.rbRL_SD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRL_SD.Location = new System.Drawing.Point(23, 23);
            this.rbRL_SD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRL_SD.Name = "rbRL_SD";
            this.rbRL_SD.Size = new System.Drawing.Size(79, 20);
            this.rbRL_SD.TabIndex = 20;
            this.rbRL_SD.Text = "SD Card";
            this.rbRL_SD.UseVisualStyleBackColor = true;
            this.rbRL_SD.Click += new System.EventHandler(this.rbRL_X_Click);
            // 
            // rbRL_USB
            // 
            this.rbRL_USB.AutoSize = true;
            this.rbRL_USB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRL_USB.Location = new System.Drawing.Point(135, 23);
            this.rbRL_USB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRL_USB.Name = "rbRL_USB";
            this.rbRL_USB.Size = new System.Drawing.Size(91, 20);
            this.rbRL_USB.TabIndex = 21;
            this.rbRL_USB.Text = "USB Drive";
            this.rbRL_USB.UseVisualStyleBackColor = true;
            this.rbRL_USB.Click += new System.EventHandler(this.rbRL_X_Click);
            // 
            // tbTRPath
            // 
            this.tbTRPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTRPath.Location = new System.Drawing.Point(108, 47);
            this.tbTRPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTRPath.Name = "tbTRPath";
            this.tbTRPath.Size = new System.Drawing.Size(259, 22);
            this.tbTRPath.TabIndex = 22;
            this.tbTRPath.Text = "/Games/";
            this.tbTRPath.LostFocus += new System.EventHandler(this.tbTRPath_LostFocus);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnSetColor);
            this.groupBox4.Controls.Add(this.cmbColor);
            this.groupBox4.Controls.Add(this.cmbColorTarget);
            this.groupBox4.Controls.Add(this.cbC64Freeze);
            this.groupBox4.Controls.Add(this.btnPing);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 178);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "System Control";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "(Reset to upd display)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Colors: ";
            // 
            // btnSetColor
            // 
            this.btnSetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetColor.Location = new System.Drawing.Point(186, 134);
            this.btnSetColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(56, 24);
            this.btnSetColor.TabIndex = 45;
            this.btnSetColor.Text = "Set";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Black  ",
            "White  ",
            "Red   ",
            "Cyan  ",
            "Purple ",
            "Green  ",
            "Blue  ",
            "Yellow ",
            "Orange ",
            "Brown  ",
            "Light Red ",
            "Dark Grey",
            "Med Grey",
            "Light Green",
            "Light Blue ",
            "Light Grey "});
            this.cmbColor.Location = new System.Drawing.Point(20, 135);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(159, 24);
            this.cmbColor.TabIndex = 44;
            // 
            // cmbColorTarget
            // 
            this.cmbColorTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorTarget.FormattingEnabled = true;
            this.cmbColorTarget.Items.AddRange(new object[] {
            "Screen Background",
            "Screen Border",
            "Top of screen banner color",
            "Time Display & Waiting msg",
            "Input key option indication",
            "General text/descriptions",
            "File names & other text"});
            this.cmbColorTarget.Location = new System.Drawing.Point(20, 105);
            this.cmbColorTarget.Name = "cmbColorTarget";
            this.cmbColorTarget.Size = new System.Drawing.Size(222, 24);
            this.cmbColorTarget.TabIndex = 39;
            // 
            // cbC64Freeze
            // 
            this.cbC64Freeze.AutoSize = true;
            this.cbC64Freeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbC64Freeze.Location = new System.Drawing.Point(20, 57);
            this.cbC64Freeze.Name = "cbC64Freeze";
            this.cbC64Freeze.Size = new System.Drawing.Size(97, 20);
            this.cbC64Freeze.TabIndex = 43;
            this.cbC64Freeze.Text = "C64 Freeze";
            this.cbC64Freeze.UseVisualStyleBackColor = true;
            this.cbC64Freeze.CheckedChanged += new System.EventHandler(this.cbC64Freeze_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Mute:";
            // 
            // cbV3
            // 
            this.cbV3.AutoSize = true;
            this.cbV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbV3.Location = new System.Drawing.Point(202, 68);
            this.cbV3.Name = "cbV3";
            this.cbV3.Size = new System.Drawing.Size(43, 20);
            this.cbV3.TabIndex = 41;
            this.cbV3.Text = "v3";
            this.cbV3.UseVisualStyleBackColor = true;
            this.cbV3.CheckedChanged += new System.EventHandler(this.cbVx_CheckedChanged);
            // 
            // cbV2
            // 
            this.cbV2.AutoSize = true;
            this.cbV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbV2.Location = new System.Drawing.Point(202, 42);
            this.cbV2.Name = "cbV2";
            this.cbV2.Size = new System.Drawing.Size(43, 20);
            this.cbV2.TabIndex = 40;
            this.cbV2.Text = "v2";
            this.cbV2.UseVisualStyleBackColor = true;
            this.cbV2.CheckedChanged += new System.EventHandler(this.cbVx_CheckedChanged);
            // 
            // cbV1
            // 
            this.cbV1.AutoSize = true;
            this.cbV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbV1.Location = new System.Drawing.Point(202, 16);
            this.cbV1.Name = "cbV1";
            this.cbV1.Size = new System.Drawing.Size(43, 20);
            this.cbV1.TabIndex = 39;
            this.cbV1.Text = "v1";
            this.cbV1.UseVisualStyleBackColor = true;
            this.cbV1.CheckedChanged += new System.EventHandler(this.cbVx_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDefaultSpeed);
            this.groupBox5.Controls.Add(this.lblPlaybackSpeed);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnPauseSID);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cbV1);
            this.groupBox5.Controls.Add(this.nudSongNum);
            this.groupBox5.Controls.Add(this.cbV2);
            this.groupBox5.Controls.Add(this.cbV3);
            this.groupBox5.Controls.Add(this.btnSetSIDSong);
            this.groupBox5.Controls.Add(this.trackbarSIDSpeed);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(15, 293);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(474, 94);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SID Playback";
            // 
            // btnDefaultSpeed
            // 
            this.btnDefaultSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultSpeed.Location = new System.Drawing.Point(374, 55);
            this.btnDefaultSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnDefaultSpeed.Name = "btnDefaultSpeed";
            this.btnDefaultSpeed.Size = new System.Drawing.Size(90, 28);
            this.btnDefaultSpeed.TabIndex = 47;
            this.btnDefaultSpeed.Text = "Default";
            this.btnDefaultSpeed.UseVisualStyleBackColor = true;
            this.btnDefaultSpeed.Click += new System.EventHandler(this.btnDefaultSpeed_Click);
            // 
            // lblPlaybackSpeed
            // 
            this.lblPlaybackSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaybackSpeed.Location = new System.Drawing.Point(269, 58);
            this.lblPlaybackSpeed.Name = "lblPlaybackSpeed";
            this.lblPlaybackSpeed.Size = new System.Drawing.Size(80, 16);
            this.lblPlaybackSpeed.TabIndex = 43;
            this.lblPlaybackSpeed.Text = "100";
            this.lblPlaybackSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Playback Speed:";
            // 
            // trackbarSIDSpeed
            // 
            this.trackbarSIDSpeed.Location = new System.Drawing.Point(262, 29);
            this.trackbarSIDSpeed.Maximum = 127;
            this.trackbarSIDSpeed.Minimum = -68;
            this.trackbarSIDSpeed.Name = "trackbarSIDSpeed";
            this.trackbarSIDSpeed.Size = new System.Drawing.Size(199, 56);
            this.trackbarSIDSpeed.TabIndex = 39;
            this.trackbarSIDSpeed.TickFrequency = 10;
            this.trackbarSIDSpeed.ValueChanged += new System.EventHandler(this.trackbarSIDSpeed_ValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(681, 674);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlDebug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbOutput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "TeensyROM Transfer/Control v0.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
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
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarSIDSpeed)).EndInit();
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
        private System.Windows.Forms.TextBox tbTRPath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemoteDir;
        private System.Windows.Forms.CheckBox cbAutoLaunch;
        private System.Windows.Forms.CheckBox cbAutoSend;
        private System.Windows.Forms.CheckBox cbV3;
        private System.Windows.Forms.CheckBox cbV2;
        private System.Windows.Forms.CheckBox cbV1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbC64Freeze;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbColorTarget;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPathSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTRFilename;
        private System.Windows.Forms.TrackBar trackbarSIDSpeed;
        private System.Windows.Forms.Label lblPlaybackSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDefaultSpeed;
        private System.Windows.Forms.Label label9;
    }
}

