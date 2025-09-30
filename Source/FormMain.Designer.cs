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
            this.rbUSBDRive = new System.Windows.Forms.RadioButton();
            this.rbSDCard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.pnlCommButtons = new System.Windows.Forms.Panel();
            this.nudSongNum = new System.Windows.Forms.NumericUpDown();
            this.btnSetSIDSong = new System.Windows.Forms.Button();
            this.btnPauseSID = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.rbComSerial = new System.Windows.Forms.RadioButton();
            this.rbComEthernet = new System.Windows.Forms.RadioButton();
            this.pnlSerialSetup = new System.Windows.Forms.Panel();
            this.pnlEthernetSetup = new System.Windows.Forms.Panel();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCommButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSongNum)).BeginInit();
            this.pnlSerialSetup.SuspendLayout();
            this.pnlEthernetSetup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(249, 12);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(72, 28);
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
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(16, 403);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(592, 214);
            this.rtbOutput.TabIndex = 9;
            this.rtbOutput.Text = "";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(9, 8);
            this.btnPing.Margin = new System.Windows.Forms.Padding(4);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(72, 28);
            this.btnPing.TabIndex = 10;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(51, 15);
            this.cmbCOMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(89, 24);
            this.cmbCOMPort.TabIndex = 11;
            // 
            // btnRefreshCOMList
            // 
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
            this.btnClear.Location = new System.Drawing.Point(536, 369);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clr Log";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(89, 8);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 28);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDestPath
            // 
            this.lblDestPath.AutoSize = true;
            this.lblDestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestPath.Location = new System.Drawing.Point(128, 167);
            this.lblDestPath.Name = "lblDestPath";
            this.lblDestPath.Size = new System.Drawing.Size(91, 16);
            this.lblDestPath.TabIndex = 23;
            this.lblDestPath.Text = "SD Card Path:";
            // 
            // tbDestPath
            // 
            this.tbDestPath.Location = new System.Drawing.Point(140, 187);
            this.tbDestPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDestPath.Name = "tbDestPath";
            this.tbDestPath.Size = new System.Drawing.Size(468, 22);
            this.tbDestPath.TabIndex = 22;
            this.tbDestPath.Text = "/";
            // 
            // rbUSBDRive
            // 
            this.rbUSBDRive.AutoSize = true;
            this.rbUSBDRive.Location = new System.Drawing.Point(16, 196);
            this.rbUSBDRive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbUSBDRive.Name = "rbUSBDRive";
            this.rbUSBDRive.Size = new System.Drawing.Size(91, 20);
            this.rbUSBDRive.TabIndex = 21;
            this.rbUSBDRive.Text = "USB Drive";
            this.rbUSBDRive.UseVisualStyleBackColor = true;
            this.rbUSBDRive.CheckedChanged += new System.EventHandler(this.rbUSBDRive_CheckedChanged);
            // 
            // rbSDCard
            // 
            this.rbSDCard.AutoSize = true;
            this.rbSDCard.Checked = true;
            this.rbSDCard.Location = new System.Drawing.Point(16, 171);
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
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Destination:";
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(16, 109);
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
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Source:";
            // 
            // tbSource
            // 
            this.tbSource.AllowDrop = true;
            this.tbSource.Location = new System.Drawing.Point(51, 111);
            this.tbSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSource.Name = "tbSource";
            this.tbSource.ReadOnly = true;
            this.tbSource.Size = new System.Drawing.Size(557, 22);
            this.tbSource.TabIndex = 16;
            this.tbSource.Text = "<-- Selection button      -or-      Drag/Drop File Here";
            this.tbSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbSource_DragDrop);
            this.tbSource.DragOver += new System.Windows.Forms.DragEventHandler(this.tbSource_DragOver);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(9, 78);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(102, 28);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "Test (Debug)";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pnlCommButtons
            // 
            this.pnlCommButtons.Controls.Add(this.nudSongNum);
            this.pnlCommButtons.Controls.Add(this.btnSetSIDSong);
            this.pnlCommButtons.Controls.Add(this.btnPauseSID);
            this.pnlCommButtons.Controls.Add(this.btnLaunch);
            this.pnlCommButtons.Controls.Add(this.btnPing);
            this.pnlCommButtons.Controls.Add(this.btnReset);
            this.pnlCommButtons.Controls.Add(this.btnSendFile);
            this.pnlCommButtons.Controls.Add(this.btnTest);
            this.pnlCommButtons.Location = new System.Drawing.Point(16, 244);
            this.pnlCommButtons.Name = "pnlCommButtons";
            this.pnlCommButtons.Size = new System.Drawing.Size(592, 118);
            this.pnlCommButtons.TabIndex = 24;
            // 
            // nudSongNum
            // 
            this.nudSongNum.Location = new System.Drawing.Point(347, 48);
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
            this.btnSetSIDSong.Location = new System.Drawing.Point(249, 44);
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
            this.btnPauseSID.Location = new System.Drawing.Point(9, 42);
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
            this.btnLaunch.Location = new System.Drawing.Point(329, 12);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(72, 28);
            this.btnLaunch.TabIndex = 15;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // rbComSerial
            // 
            this.rbComSerial.AutoSize = true;
            this.rbComSerial.Location = new System.Drawing.Point(12, 9);
            this.rbComSerial.Name = "rbComSerial";
            this.rbComSerial.Size = new System.Drawing.Size(63, 20);
            this.rbComSerial.TabIndex = 25;
            this.rbComSerial.Text = "Serial";
            this.rbComSerial.UseVisualStyleBackColor = true;
            // 
            // rbComEthernet
            // 
            this.rbComEthernet.AutoSize = true;
            this.rbComEthernet.Location = new System.Drawing.Point(12, 35);
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
            this.pnlSerialSetup.Location = new System.Drawing.Point(108, 6);
            this.pnlSerialSetup.Name = "pnlSerialSetup";
            this.pnlSerialSetup.Size = new System.Drawing.Size(412, 41);
            this.pnlSerialSetup.TabIndex = 19;
            // 
            // pnlEthernetSetup
            // 
            this.pnlEthernetSetup.Controls.Add(this.tbIPAddress);
            this.pnlEthernetSetup.Location = new System.Drawing.Point(108, 50);
            this.pnlEthernetSetup.Name = "pnlEthernetSetup";
            this.pnlEthernetSetup.Size = new System.Drawing.Size(412, 42);
            this.pnlEthernetSetup.TabIndex = 27;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(16, 1);
            this.tbIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(124, 22);
            this.tbIPAddress.TabIndex = 23;
            this.tbIPAddress.Text = "192.168.1.222";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Interface:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Commands:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbComSerial);
            this.panel1.Controls.Add(this.rbComEthernet);
            this.panel1.Location = new System.Drawing.Point(5, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 70);
            this.panel1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Communication Log:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(624, 631);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlEthernetSetup);
            this.Controls.Add(this.pnlSerialSetup);
            this.Controls.Add(this.pnlCommButtons);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDestPath);
            this.Controls.Add(this.tbDestPath);
            this.Controls.Add(this.rbUSBDRive);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rbSDCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.tbSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "TeensyROM Transfer/Control v0.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCommButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSongNum)).EndInit();
            this.pnlSerialSetup.ResumeLayout(false);
            this.pnlEthernetSetup.ResumeLayout(false);
            this.pnlEthernetSetup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbUSBDRive;
        private System.Windows.Forms.RadioButton rbSDCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Panel pnlCommButtons;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnPauseSID;
        private System.Windows.Forms.NumericUpDown nudSongNum;
        private System.Windows.Forms.Button btnSetSIDSong;
        private System.Windows.Forms.RadioButton rbComSerial;
        private System.Windows.Forms.RadioButton rbComEthernet;
        private System.Windows.Forms.Panel pnlSerialSetup;
        private System.Windows.Forms.Panel pnlEthernetSetup;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

