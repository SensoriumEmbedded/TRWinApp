


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

        //synch with TeensyROM code:
        const UInt16 LaunchFileToken = 0x6444;
        const UInt16 PauseSIDToken = 0x6466;
        const UInt16 SetSIDSongToken = 0x6488;
        const UInt16 SendFileToken = 0x64AA;
        const UInt16 AckToken = 0x64CC;
        const UInt16 FailToken = 0x9B7F;

        public FormMain()
        {
            InitializeComponent();
            _streamIO = new StreamIO(/* this */);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRefreshCOMList.PerformClick();
            rbComEthernet.PerformClick();
            serialPort1.ReadTimeout = 200;
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            SendCommand(new byte[] { 0x64, 0x55 }, "Ping", false);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            //need to look for "Reset cmd received" instead of ack:
            SendCommand(new byte[] { 0x64, 0xEE }, "Reset Command", false);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SendCommand(new byte[] { 0x64, 0x44, 0x02, 0x2f, 0x47, 0x61, 0x6d, 0x65, 0x73, 0x2f, 0x47, 0x6f, 0x72, 0x66, 0x21, 0x00 }, "Launch Gorf!");  

            //byte[] TestCode = { 0x64, 0x99, 0xf0, 0x40 };// Example 1: 0x64, 0x99, 0xf0, 0x40 = Set to -15.75% via linear equation
            //byte[] TestCode = { 0x64, 0x9a, 0x20, 0x40 };// Example 2: 0x64, 0x9a, 0x20, 0x40 = set to +32.25 via logarithmic equation
            //byte[] TestCode = { 0x64, 0x33, 0x05 };// Mute voice 1 & 3
            //byte[] TestCode = { 0x64, 0x22, 0x02 , 0x0a};// Set banner to LtRed
            //serialPort1.Write(TestCode, 0, TestCode.Count());
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
            if (rbUSBDRive.Checked) lblDestPath.Text = "USB Drive Path:";
            else lblDestPath.Text = "SD Card Path:";
        }
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            //   App: LaunchFileToken 0x6444
            //Teensy: AckToken 0x64CC
            //   App: Send CS(2), SD_nUSB(1), 
            //          DestPath/Name(up to MaxNamePathLength, null term)
            //Teensy: AckToken 0x64CC on Pass,  0x9b7f on Fail

            SendIntBytes(LaunchFileToken, 2);
            if (!GetAck()) return;

            UInt32 SD_nUSB = (rbSDCard.Checked ? 1U : 0U);
            //if (!tbDestPath.Text.EndsWith("/")) tbDestPath.Text += "/";
            string DestPathFile = tbDestPath.Text;
            //DestPathFile += Path.GetFileName(tbSource.Text);

            WriteToOutput("Launching " + (SD_nUSB == 1U ? "SD:" : "USB:") + DestPathFile, Color.Black);

            SendIntBytes(SD_nUSB, 1);//Send SD or USB

            serialPort1.Write(DestPathFile + "\0");                    //Send path/name, null terminate
            if (!GetAck()) WriteToOutput("Launch Failed!", Color.Red);
        }

        private void btnPauseSID_Click(object sender, EventArgs e)
        {
            //   App: PauseSIDToken 0x6466
            //Teensy: AckToken 0x64CC on Pass,  0x9b7f on Fail
            SendCommand(new byte[] { 0x64, 0x66 }, "Pause SID");

            //SendIntBytes(PauseSIDToken, 2);
            //if (GetAck()) WriteToOutput("Sent Pause SID", Color.DarkGreen);
            //else WriteToOutput("Pause SID Failed!", Color.Red);
        }
        private void btnSetSIDSong_Click(object sender, EventArgs e)
        {
            SendIntBytes(SetSIDSongToken, 2);
            SendIntBytes((UInt16)(nudSongNum.Value - 1), 1);
            if (GetAck()) WriteToOutput("Sent SID Song Num", Color.DarkGreen);
            else WriteToOutput("SID Song Num Failed!", Color.Red);
        }
        private void rbComEthernet_CheckedChanged(object sender, EventArgs e)
        {
            pnlEthernetSetup.Enabled = rbComEthernet.Checked;
            pnlSerialSetup.Enabled = rbComSerial.Checked;
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

        private void SendCommand(byte[] command, string description, bool waitForAck = true)
        {
            string errMsg, stFlushed;

            //initialize
            if (!_streamIO.InitializeOpen(rbComEthernet.Checked, tbIPAddress.Text, cmbCOMPort.Text, out errMsg)) goto ErrorOut;

            //flush rx buffer, mostly for serial
            if (!_streamIO.FlushStreamRx(20, out stFlushed, out errMsg)) goto ErrorOut;
            WriteToOutput(stFlushed, Color.Gray);

            //write command
            if (!_streamIO.Write(command, out errMsg)) goto ErrorOut;
            WriteToOutput("Sent " + description, Color.Blue);

            //ack check, if requested
            if (waitForAck) GetAck(); //prints messages; last item, no need to check/return
            else
            {
                if (!_streamIO.FlushStreamRx(500, out stFlushed, out errMsg)) goto ErrorOut;
                WriteToOutput(stFlushed, Color.Gray);
            }

            //close
            Close:
                if (!_streamIO.Close(out errMsg))
                {
                    WriteToOutput(errMsg, Color.Red);
                }
                return;

            ErrorOut:
                WriteToOutput(errMsg, Color.Red);
                goto Close; //try to close stream
        }
    }
}
