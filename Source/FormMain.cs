


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
            btnRefreshCOMList.PerformClick();
            rbComEthernet.PerformClick();
            serialPort1.ReadTimeout = 200;
        }


        /********************************  Local Control Functions *****************************************/
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

            // Workflow:
            // Receive <-- List Directory Token 0x64DD/0x64DE
            // Send --> AckToken 0x64CC
            // Receive <-- DriveType(1), Destination Path(MaxNameLength, null terminator), take(1), skip(1)
            //        DriveTypes: (RegMenuTypes)
            //           USBDrive  = 0
            //           SD        = 1
            //           Teensy    = 2
            // Send --> AckToken 0x64CC on successful check of directory existence, 0x9b7f on Fail
            // Send --> StartDirectoryListToken 0x5A5A or FailToken 0x9b7f
            // Send --> Write content as json
            // Send --> EndDirectoryListToken 0xA5A5,  0x9b7f on Fail



            // byte[] pathFileBytes = Encoding.ASCII.GetBytes(tbDestPath.Text);
            // byte[] pathInfo = new byte[1 + pathFileBytes.Length + 1 + 2 + 2];
            // pathInfo[0] = 1;  //SD
            // Array.Copy(pathFileBytes, 0, pathInfo, 1, pathFileBytes.Length);
            // pathInfo[pathInfo.Length - 5] = 0;   // null terminator
            // pathInfo[pathInfo.Length - 4] = 0;   // skip
            // pathInfo[pathInfo.Length - 3] = 2;   // 
            // pathInfo[pathInfo.Length - 2] = 2; // take
            // pathInfo[pathInfo.Length - 1] = 2; // 
            // 
            // 
            // //byte[] pathInfo = { 0x02, 0x2f, 0x47, 0x61, 0x6d, 0x65, 0x73, 0x00, 0x00, 0x00, 0x00, 0x00 }; //tr dir
            // //byte[] pathInfo = { 0x01, 0x73, 0x00, 0x00, 0x00, 0x01, 0x01 };
            // //byte[] pathInfo = { 0x01, 0x73, 0x00, 0x00, 0x00, 0x00, 0x10 }; //SD, root/term, skip none, take FFFF
            // WriteToOutput(tbDestPath.Text, Color.Purple);
            // 
            // if (!SendCommand(GetDirNDJSONToken, "get NDJSON Dir", AckToken, false, false)) return;
            // 
            // for (int byteNum = 0; byteNum < pathInfo.Length; byteNum++)
            // {
            //     WriteToOutput(byteNum + " " + pathInfo[byteNum].ToString("X2") + " \"" + (char)pathInfo[byteNum] + "\"", Color.Chocolate);
            // }
            // 
            // 
            // if (!SendCommand(pathInfo, "Path Info", AckToken, true, false)) return;
            // 
            // byte[] noneExp = { };
            // SendCommand(noneExp, "Flush Only", noneExp, true, true); //just flush and close
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

            //if (!tbDestPath.Text.EndsWith("/")) tbDestPath.Text += "/";
            string LaunchFilePath = tbLaunchFilePath.Text;
            //DestPathFile += Path.GetFileName(tbSource.Text);
            byte SD_nUSB = (byte)(rbRL_SD.Checked ? 1 : (rbRL_TF.Checked ? 2 : 0));
            string[] LaunchSource = { "USB:", "SD:", "TR:"};
            WriteToOutput("Launching " + LaunchSource[SD_nUSB] + LaunchFilePath, Color.Blue);

            byte[] pathFileBytes = Encoding.ASCII.GetBytes(LaunchFilePath);
            byte[] launchPathFileName = new byte[1 + pathFileBytes.Length + 1];
            launchPathFileName[0] = SD_nUSB;
            Array.Copy(pathFileBytes, 0, launchPathFileName, 1, pathFileBytes.Length);
            launchPathFileName[launchPathFileName.Length - 1] = 0; // null terminator
            SendCommand(launchPathFileName, "Path/File Name", AckToken, true, true);
        }

        private void btnSetSIDSong_Click(object sender, EventArgs e)
        {
            SendIntBytes(SetSIDSongToken, 2);
            SendIntBytes((UInt16)(nudSongNum.Value - 1), 1);
            if (GetAck()) WriteToOutput("Sent SID Song Num", Color.DarkGreen);
            else WriteToOutput("SID Song Num Failed!", Color.Red);
        }




        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbSource.Text))
            {
                WriteToOutput("\nInvalid Source File/Path", Color.DarkRed);
                return;
            }

            //Read/store file, get length, calc checksum
            WriteToOutput("\nReading file: " + tbSource.Text, Color.Black);
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

            SendIntBytes(SendFileToken, 2);
            if (!GetAck()) return;

            UInt32 SD_nUSB = (rbSDCard.Checked ? 1U : 0U);
            if (!tbDestPath.Text.EndsWith("/")) tbDestPath.Text += "/";
            string DestPathFile = tbDestPath.Text;
            DestPathFile += Path.GetFileName(tbSource.Text);

            WriteToOutput("Transferring " + len + " bytes, CS= 0x" + CheckSum.ToString("X4"), Color.Black);
            WriteToOutput("  to TeensyROM " + (SD_nUSB == 1U ? "SD:" : "USB:") + DestPathFile, Color.Black);

            SendIntBytes(len, 4);//Send Length
            SendIntBytes(CheckSum, 2);//Send Checksum
            SendIntBytes(SD_nUSB, 1);//Send SD or USB

            serialPort1.Write(DestPathFile + "\0");                    //Send path/name, null terminate
            if (!GetAck()) return;

            WriteToOutput("Sending...", Color.Black);
            Int32 BytesSent = 0;
            while (len > BytesSent)
            {
                Int32 BytesToSend = 16 * 1024; //block size
                if (len - BytesSent < BytesToSend) BytesToSend = (Int32)len - BytesSent;
                //serialPort1.Write(fileBuf, 0, (Int32)len); //Send file
                serialPort1.Write(fileBuf, BytesSent, BytesToSend); //Send file
                //WriteToOutput("Sent " + BytesToSend, Color.Black);
                rtbOutput.AppendText(".");
                //rtbOutput.ScrollToCaret();
                BytesSent += BytesToSend;
            }
            WriteToOutput("\n...Finished", Color.Black);

            if (!GetAck())
            {
                WriteToOutput("Transfer Failed!", Color.DarkRed);
                return;
            }
            WriteToOutput("Transfer Sucessful!", Color.Green);
            //btnConnected.PerformClick(); //auto disconnect
        }


        /********************************  Stand Alone Functions *****************************************/

        private void WriteToOutput(string strMsg, Color color)
        {
            rtbOutput.SelectionStart = rtbOutput.TextLength; //Move caret to the end
            rtbOutput.SelectionLength = 0;
            rtbOutput.SelectionColor = color;
            rtbOutput.AppendText(strMsg + "\r");
            rtbOutput.ScrollToCaret();
            rtbOutput.Refresh();
        }
        private UInt16 to16(byte[] buf)
        {
            return (UInt16)(buf[1] * 256 + buf[0]);
        }

        void SendIntBytes(UInt32 IntToSend, Int16 NumBytes)
        {
            byte[] BytesToSend = BitConverter.GetBytes(IntToSend);
            for (Int16 ByteNum = (Int16)(NumBytes - 1); ByteNum >= 0; ByteNum--)
                serialPort1.Write(BytesToSend, ByteNum, 1);
        }

        /******************************** Stream IO Control Functions *****************************************/

        bool GetAck(int iTimeoutmSec = 500)
        {
            var recBuf = new byte[2];

            if (!_streamIO.ReadStreamTO(recBuf, 2, out int bytesRead, iTimeoutmSec, out string errMsg))
            {
                WriteToOutput(errMsg, Color.Red);
                return false;
            }

            UInt16 recU16 = to16(recBuf);
            if (recU16 == AckToken)
            {
                WriteToOutput("Ack", Color.DarkGreen);
                return true;
            }
            if (recU16 == FailToken)
            {
                WriteToOutput("Command Fail Indicated", Color.DarkRed);
                return false;
            }

            WriteToOutput("Bad Ack: " + recBuf[0].ToString("X2") + ":" + recBuf[1].ToString("X2"), Color.DarkRed);
            return false;
        }

        private byte[] RespTokenToByte(UInt16 Token)
        {
            return new byte[] { (byte)(Token & 0x00FF), (byte)((Token >> 8) & 0x00FF) };
        }
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
            var command = new byte[] { (byte)((cmdToken >> 8) & 0x00FF), (byte)(cmdToken & 0x00FF) };
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
            WriteToOutput(stFlushed, Color.Gray);

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
                if (!_streamIO.ReadStreamTO(recBuf, expResponse.Length, out int bytesRead, 500, out errMsg)) goto ErrorOut;
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
