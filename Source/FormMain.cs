

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TRWinApp
{
    public partial class FormMain : Form
    {
        private StreamIO _streamIO;
        private int InitialWinXSize, InitialWinYSize;

        //synch with TeensyROM code Common_Defs.h
        const UInt16 SetColorToken     = 0x6422;
        const UInt16 LaunchFileToken   = 0x6444;
        const UInt16 PingToken         = 0x6455;
        const UInt16 PauseSIDToken     = 0x6466; //df
        const UInt16 SetSIDSongToken   = 0x6488;
        const UInt16 SIDSpeedLinToken  = 0x6499;
        const UInt16 SIDSpeedLogToken  = 0x649A;
        const UInt16 SIDVoiceMuteToken = 0x6433;
        const UInt16 C64PauseOnToken   = 0x6431; // C64 Paused
        const UInt16 C64PauseOffToken  = 0x6430; // C64 Unpaused
        const UInt16 DebugToken        = 0x6467; //dg
        const UInt16 SendFileToken     = 0x64AA;
        const UInt16 PostFileToken     = 0x64BB;
        const UInt16 CopyFileToken     = 0x64FF;
        const UInt16 GetFileToken      = 0x64B0;
        const UInt16 DeleteFileToken   = 0x64CF;
        const UInt16 AckToken          = 0x64CC;
        const UInt16 GetDirectoryToken = 0x64DD; // regular JSON format, to be deprecated
        const UInt16 GetDirNDJSONToken = 0x64DE; // NDJSON format
        const UInt16 ResetC64Token     = 0x64EE;
        const UInt16 RetryToken        = 0x9B7E;
        const UInt16 FailToken         = 0x9B7F;
        const UInt16 BadSIDToken       = 0x9B80;
        const UInt16 GoodSIDToken      = 0x9B81;

        public FormMain()
        {
            InitializeComponent();
            _streamIO = new StreamIO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlDebug.Visible = true;
            btnRefreshCOMList.PerformClick();
            rbComEthernet.PerformClick();
            serialPort1.ReadTimeout = 200;
            InitialWinXSize = this.Size.Width;
            InitialWinYSize = this.Size.Height;
            FormMain_Resize(this, EventArgs.Empty); //initial resize
        }


        /********************************  Local Control Functions *****************************************/

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.Width < InitialWinXSize) this.Width = InitialWinXSize;
            if (this.Height < InitialWinYSize) this.Height = InitialWinYSize;
            //rtbOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            rtbOutput.Width = this.ClientSize.Width - rtbOutput.Left - 15;
            rtbOutput.Height = this.ClientSize.Height - rtbOutput.Top - 15;
        }

        private void btnRefreshCOMList_Click(object sender, EventArgs e)
        {
            cmbCOMPort.Items.Clear();
            string[] thePortNames = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string item in thePortNames)
            {
                cmbCOMPort.Items.Add(item);
            }

            if (thePortNames.Length != 0)
            {
                cmbCOMPort.SelectedIndex = 0;
            }
            else
            {
                //WriteToOutput("No COM Ports Found", Color.Red);
                //cmbCOMPort.Items.Add("COM5");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "C64 Files (*.prg;*.crt)|*.prg;*.crt|PRG files (*.prg)|*.prg|CRT files (*.crt)|*.crt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            tbSource.Text = openFileDialog1.FileName;
            if (cbAutoSend.Checked) btnSendFile.PerformClick();
        }

        private void tbSource_DragDrop(object sender, DragEventArgs e)
        {
            //tbSource.Text = e.ToString();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                tbSource.Text = files[0];
                tbSource.SelectionStart = tbSource.Text.Length;
                tbSource.SelectionLength = 0;
                if (cbAutoSend.Checked) btnSendFile.PerformClick();
            }
        }

        private void tbSource_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void rbUSBDRive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUSBDrive.Checked) lblDestPath.Text = "USB Drive Path:";
            else lblDestPath.Text = "SD Card Path:";
        }

        private void rbComEthernet_CheckedChanged(object sender, EventArgs e)
        {
            pnlEthernetSetup.Enabled = rbComEthernet.Checked;
            pnlSerialSetup.Enabled = rbComSerial.Checked;
        }


        /********************************  Command Button Functions *****************************************/

        private void btnTest_Click(object sender, EventArgs e)
        {
            //byte[] command = { 0x64, 0x99, 0xf0, 0x40 };// Example 1: 0x64, 0x99, 0xf0, 0x40 = Set to -15.75% via linear equation
            //byte[] command = { 0x64, 0x9a, 0x20, 0x40 };// Example 2: 0x64, 0x9a, 0x20, 0x40 = set to +32.25 via logarithmic equation
            //byte[] command = { 0x64, 0x33, 0x05 };// Mute voice 1 & 3
            //byte[] command = { 0x64, 0x22, 0x02 , 0x0a};// Set banner to LtRed
            byte[] command = { 0x64, 0x44, 0x02, 0x2f, 0x47, 0x61, 0x6d, 0x65, 0x73, 0x2f, 0x47, 0x6f, 0x72, 0x66, 0x21, 0x00 };
            SendCommand(command, "Launch Gorf!", AckToken);

        }

        private void btnPauseSID_Click(object sender, EventArgs e)
        {
            //   App: PauseSIDToken 0x6466
            //Teensy: AckToken 0x64CC on Pass,  0x9b7f on Fail
            SendCommand(PauseSIDToken, "Pause SID", AckToken);
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            //look for "TeensyROM" instead of ack
            var expResponse = Encoding.ASCII.GetBytes("TeensyROM");
            SendCommand(PingToken, "Ping", expResponse);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //look for "Reset cmd received" instead of ack:
            var expResponse = Encoding.ASCII.GetBytes("Reset cmd received");
            SendCommand(ResetC64Token, "Reset Command", expResponse);
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            //   App: LaunchFileToken 0x6444
            //Teensy: AckToken 0x64CC
            //   App: Send CS(2), SD_nUSB(1), 
            //          DestPath/Name(up to MaxNamePathLength, null term)
            //Teensy: AckToken 0x64CC on Pass,  0x9b7f on Fail

            if (!SendCommand(LaunchFileToken, "Launch File", AckToken, false, false)) return;

            string LaunchFilePath = tbLaunchFilePath.Text;
            WriteToOutput("Launching " + strLaunchSource() + LaunchFilePath, Color.Blue);

            byte[] pathFileBytes = Encoding.ASCII.GetBytes(LaunchFilePath);
            byte[] launchPathFileName = new byte[1 + pathFileBytes.Length + 1];
            launchPathFileName[0] = LaunchSource();
            Array.Copy(pathFileBytes, 0, launchPathFileName, 1, pathFileBytes.Length);
            launchPathFileName[launchPathFileName.Length - 1] = 0; // null terminator
            SendCommand(launchPathFileName, "Path/File Name", AckToken, true, true);
        }

        private void btnSetSIDSong_Click(object sender, EventArgs e)
        {
            // Command: 
            // Set sub-song number of currently loaded SID
            //
            // Workflow: (TR POV)
            // Receive <-- SetSIDSongToken Token 0x6488 
            // Receive <-- Song number to set (1 byte, zero based, song 1 is 0) 
            // Send --> AckToken 0x64CC or FailToken 0x9B7F

            byte[] SIDSongToken = CommandTokenToByte(SetSIDSongToken);
            byte[] SetSIDSong = new byte[2 + 1];
            Array.Copy(SIDSongToken, 0, SetSIDSong, 0, 2);
            SetSIDSong[2] = (byte)(nudSongNum.Value - 1);

            //for (int byteNum = 0; byteNum < SetSIDSong.Length; byteNum++)
            //{ 
            //    WriteToOutput("Byte " + byteNum + " = " + SetSIDSong[byteNum].ToString("X2") + " '" + Encoding.UTF8.GetString(SetSIDSong, byteNum,1) + "'", Color.Purple);
            //}

            SendCommand(SetSIDSong, "Set SID Song to #" + nudSongNum.Value, AckToken);
        }

        private void cbVx_CheckedChanged(object sender, EventArgs e)
        {
            // Command: 
            // Set individual SID voice muting
            //
            // Workflow:
            // Receive <-- SIDVoiceMuteToken   0x6433
            // Receive <-- voice mute info (1 byte)
            //                bit 0=  Voice 1  on=0, mute=1
            //                bit 1=  Voice 2  on=0, mute=1
            //                bit 2=  Voice 3  on=0, mute=1 
            //             bits 7:3= Zero
            // Send --> AckToken 0x64CC or FailToken 0x9B7F

            byte[] VoiceMuteToken = CommandTokenToByte(SIDVoiceMuteToken);
            byte VoiceMuteBits = (byte)((cbV1.Checked ? 1 : 0) + (cbV2.Checked ? 2 : 0) + (cbV3.Checked ? 4 : 0));
            byte[] SetSIDVoiceMute = new byte[2 + 1];
            Array.Copy(VoiceMuteToken, 0, SetSIDVoiceMute, 0, 2);
            SetSIDVoiceMute[2] = VoiceMuteBits;

            SendCommand(SetSIDVoiceMute, "Voice Mute set: " + VoiceMuteBits, AckToken);
        }
        private void cbC64Freeze_CheckedChanged(object sender, EventArgs e)
        {
            // C64PauseOnToken C64PauseOffToken

            if (cbC64Freeze.Checked)
                SendCommand(C64PauseOnToken, "C64 Pause", AckToken);
            else
                SendCommand(C64PauseOffToken, "C64 Unpause", AckToken);
        }

        private void btnRemoteDir_Click(object sender, EventArgs e)
        {
            // Workflow: (TR POV)
            // Receive <-- List Directory Token 0x64DD/0x64DE
            // Send    --> AckToken 0x64CC
            // Receive <-- Storage Type(1), skip(2), take(2), Destination Path(MaxNameLength, null terminator)
            //        Storage Types: (RegMenuTypes)
            //           USBDrive  = 0
            //           SD        = 1
            //           Teensy    = 2
            // Send    --> AckToken 0x64CC on successful check of directory existence, 0x9b7f on Fail
            // Send    --> StartDirectoryListToken 0x5A5A or FailToken 0x9b7f
            // Send    --> Write content as json
            // Send    --> EndDirectoryListToken 0xA5A5,  0x9b7f on Fail

            byte[] pathFileBytes = Encoding.ASCII.GetBytes(tbLaunchFilePath.Text);
            byte[] pathInfo = new byte[1 + 2 + 2 + pathFileBytes.Length + 1];
            pathInfo[0] = LaunchSource(); // Storage Type
            pathInfo[1] = 0;    // skip MSB
            pathInfo[2] = 0;    // skip LSB
            pathInfo[3] = 0x7F; // take MSB
            pathInfo[4] = 0xFF; // take LSB
            Array.Copy(pathFileBytes, 0, pathInfo, 5, pathFileBytes.Length);
            pathInfo[pathInfo.Length - 1] = 0;   // null terminator
  
            if (!SendCommand(GetDirNDJSONToken, "get NDJSON Dir", AckToken, false, false)) return;
            
            if (!SendCommand(pathInfo, "Path Info", AckToken, true, false)) return;

            if (!_streamIO.FlushStreamRx(500, out string stFlushed, out string errMsg))
            {
                WriteToOutput(errMsg, Color.Red);
            }
            stFlushed = stFlushed.Substring(2, stFlushed.Length - 4); //cut off the 5a5a/a5a5, should check for them...
            WriteToOutput("Dir Path: " + strLaunchSource() + tbLaunchFilePath.Text, Color.Black);
            //WriteToOutput(stFlushed, Color.Black);
            DisplayDirNDJSON(stFlushed);

            if (!_streamIO.Close(out errMsg))
            {
                WriteToOutput(errMsg, Color.Red);
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbSource.Text))
            {
                WriteToOutput("\nInvalid Source File/Path", Color.Red);
                return;
            }

            //Read/store file, get length, calc checksum
            WriteToOutput("\nReading file: " + tbSource.Text, Color.Blue);
            BinaryReader br = new BinaryReader(File.Open(tbSource.Text, FileMode.Open));
            UInt32 len = (UInt32)br.BaseStream.Length;
            byte[] fileBuf = br.ReadBytes((Int32)len);  //read full file to array
            br.Close();
            UInt16 CheckSum = 0;
            for (UInt32 num = 0; num < len; num++) CheckSum += fileBuf[num];

            //   App: SendFileToken 0x64AA
            //Teensy: AckToken 0x64CC
            //   App: Send Length(4), CS(2), SD_nUSB(1), 
            //          DestPath/Name(up to MaxNamePathLength, null term)
            //Teensy: AckToken 0x64CC
            //   App: Send file(length)
            //Teensy: AckToken 0x64CC on Pass,  0x9b7f on Fail

            byte SD_nUSB = (byte)(rbSDCard.Checked ? 1 : 0);
            if (!tbDestPath.Text.EndsWith("/")) tbDestPath.Text += "/";
            string DestPathFile = tbDestPath.Text + Path.GetFileName(tbSource.Text);
            byte[] DestPathFileBytes = Encoding.ASCII.GetBytes(DestPathFile);
            byte[] pathInfo = new byte[4 + 2 + 1 + DestPathFileBytes.Length + 1];

            pathInfo[0] = (byte)(len >> 24); // Length MSB
            pathInfo[1] = (byte)(len >> 16);
            pathInfo[2] = (byte)(len >> 8);
            pathInfo[3] = (byte)(len);
            pathInfo[4] = (byte)(CheckSum >> 8); // Checksum MSB
            pathInfo[5] = (byte)(CheckSum);
            pathInfo[6] = SD_nUSB;
            Array.Copy(DestPathFileBytes, 0, pathInfo, 7, DestPathFileBytes.Length);
            pathInfo[pathInfo.Length - 1] = 0;   // null terminator

            if (!SendCommand(SendFileToken, "File Token", AckToken, false, false)) return;

            WriteToOutput("Transferring " + len + " bytes, CS= 0x" + CheckSum.ToString("X4"), Color.DarkBlue);
            WriteToOutput("  to TeensyROM " + (SD_nUSB == 1U ? "SD:" : "USB:") + DestPathFile, Color.DarkBlue);

            if (!SendCommand(pathInfo, "Path Info", AckToken, true, false)) return;

            WriteToOutput("Sending...", Color.Blue);

            var startTime = Environment.TickCount;
            if (!SendCommand(fileBuf, "File Data", AckToken, true, true)) return;
            WriteToOutput("  Took " + (Environment.TickCount - startTime).ToString() + "ms", Color.DarkBlue);

            WriteToOutput("Transfer Sucessful!", Color.Green);

            //set up for launch
            if (SD_nUSB == 1) rbRL_SD.Checked = true;
            else rbRL_USB.Checked = true;
            tbLaunchFilePath.Text = DestPathFile;

            if (cbAutoLaunch.Checked) btnLaunch.PerformClick();
 
        }


        /********************************  Stand Alone/Helper Functions *****************************************/

        private void WriteToOutput(string strMsg, Color color)
        {
            rtbOutput.SelectionStart = rtbOutput.TextLength; //Move caret to the end
            rtbOutput.SelectionLength = 0;
            rtbOutput.SelectionColor = color;
            rtbOutput.AppendText(strMsg + "\r");
            rtbOutput.ScrollToCaret();
            rtbOutput.Refresh();
        }

        private void DisplayDirNDJSON(string ndjson)
        {
            WriteToOutput("Size".PadLeft(10) + " Name", Color.Black);

            // Each line is a JSON object
            var lines = ndjson.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                try
                {
                    // Parse JSON object (using Newtonsoft.Json for .NET Framework)
                    var obj = Newtonsoft.Json.Linq.JObject.Parse(line);
                    string strOut = "";
                    if (obj.Property("type").Value.ToString() == "file")
                    {
                        strOut += obj.Property("size").Value.ToString().PadLeft(10);
                    }
                    else
                    {
                        strOut += "<Dir> ".PadLeft(10);
                    }
                    strOut += " " + obj.Property("name").Value.ToString();
                    
                    WriteToOutput(strOut, Color.DarkSlateBlue);
                }
                catch (Exception ) //ex
                {
                    WriteToOutput("Invalid NDJSON line: " + line, Color.Red);
                    //WriteToOutput("Msg: " + ex.Message, Color.Red);
                }
            }
        }

        private byte LaunchSource() { return (byte)(rbRL_SD.Checked ? 1 : (rbRL_TF.Checked ? 2 : 0)); }

        private string strLaunchSource() { return new[] { "USB:", "SD:", "TR:" }[LaunchSource()]; }

        private byte[] CommandTokenToByte(UInt16 Token)
        {
            return new byte[] { (byte)(Token >> 8), (byte)(Token) };
        }

        private byte[] RespTokenToByte(UInt16 Token)
        {
            return new byte[] { (byte)(Token), (byte)(Token >> 8) };
        }

        /******************************** Main Stream IO Command Function *****************************************/

        private bool SendCommand(UInt16 cmdToken, string description, UInt16 RespToken, bool skipInit = false, bool closeOnSuccess = true)
        {
            return SendCommand(cmdToken, description, RespTokenToByte(RespToken), skipInit, closeOnSuccess);
        }
        private bool SendCommand(byte[] command, string description, UInt16 RespToken, bool skipInit = false, bool closeOnSuccess = true)
        {
            return SendCommand(command, description, RespTokenToByte(RespToken), skipInit, closeOnSuccess);
        }
        private bool SendCommand(UInt16 cmdToken, string description, byte[] expResponse, bool skipInit = false, bool closeOnSuccess = true)
        {
            var command = CommandTokenToByte(cmdToken);
            return SendCommand(command, description, expResponse, skipInit, closeOnSuccess);
        }

        private bool SendCommand(byte[] command, string description, byte[] expResponse, bool skipInit = false, bool closeOnSuccess = true)
        {
            string errMsg, stFlushed;
            bool retVal = true;

            //initialize
            if (!skipInit)
            {
                if (!_streamIO.InitializeOpen(rbComEthernet.Checked, tbIPAddress.Text, cmbCOMPort.Text, out errMsg)) goto ErrorOut;
            }

            //flush rx buffer, mostly for serial
            if (!_streamIO.FlushStreamRx(20, out stFlushed, out errMsg)) goto ErrorOut;
            //WriteToOutput(stFlushed, Color.Gray);

            //write command
            if (!_streamIO.Write(command, out errMsg)) goto ErrorOut;
            WriteToOutput("Sent " + description, Color.Blue);

            //check response, if requested
            if (expResponse.Length == 0)
            {
                //flush the stream if not looking for a response...
                WriteToOutput("No Resp Check, flushing...", Color.Blue);
                if (!_streamIO.FlushStreamRx(500, out stFlushed, out errMsg)) goto ErrorOut;
                WriteToOutput(stFlushed, Color.Gray);
            }            
            else
            {
                var recBuf = new byte[expResponse.Length];
                if (!_streamIO.ReadStreamTO(recBuf, expResponse.Length, out int bytesRead, 1500, out errMsg)) goto ErrorOut;
                if (bytesRead != expResponse.Length)
                {
                    WriteToOutput("Bad Response Length: " + bytesRead.ToString() + " != " + expResponse.Length.ToString(), Color.Red);
                    retVal = false;
                    goto Close;
                }

                for (int byteNum = 0; byteNum < expResponse.Length; byteNum++)
                {
                    if (recBuf[byteNum] != expResponse[byteNum])
                    {
                        string expResp = "  Exp:";
                        string actResp = "  Act:";
                        for (int i = expResponse.Length - 1; i >= 0; i--)
                        {
                            expResp += " " + expResponse[i].ToString("X2");
                            actResp += " " + recBuf[i].ToString("X2");
                        }
                        WriteToOutput("Bad Response: ", Color.Red);
                        WriteToOutput(expResp, Color.Red);
                        WriteToOutput(actResp, Color.Red);
                        _streamIO.FlushStreamRx(500, out stFlushed, out errMsg); //flush on bad response
                        WriteToOutput(stFlushed, Color.DarkRed);
                        retVal = false;
                        goto Close;
                    }
                }
                WriteToOutput("Received Expected Response", Color.DarkGreen);
            }
            if (!closeOnSuccess) return retVal; //(true)
            goto Close; //close stream

        ErrorOut:
            WriteToOutput(errMsg, Color.Red);
            retVal = false;
        Close:
            if (cbPostFlush.Checked)
            {
                _streamIO.FlushStreamRx(500, out stFlushed, out errMsg);
                WriteToOutput(stFlushed, Color.Black);
            }
            if (!_streamIO.Close(out errMsg))
            {
                WriteToOutput(errMsg, Color.Red);
                retVal = false;
            }
            return retVal;
        }

    }
}
