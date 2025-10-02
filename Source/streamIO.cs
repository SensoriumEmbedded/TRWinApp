using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TRWinApp
{
    public class StreamIO
    {
        private IDataStream _stream;

        public IDataStream Stream => _stream; //temporary exposure of stream

        public bool InitializeOpen(bool useEthernet, string stIPAddress, string stCOMPort, out string errMsg)
        {
            _stream = null;

            try
            {
                if (useEthernet)
                    _stream = new TcpDataStream(stIPAddress, 80);
                else
                {
                    if (stCOMPort == "")
                    {
                        errMsg = "Select COM port";
                        return false;
                    }
                    _stream = new SerialDataStream(stCOMPort, 115200);
                }

                _stream.Open();
                errMsg = "";
                return true;
            }
            catch (Exception ex)
            {
                errMsg = "Init Error: " + ex.Message;
                return false;
            }
        }

        public bool DataAvailableTimeout(int timeoutMs)
        {
            if (_stream == null) return false;

            var startTime = Environment.TickCount;
            while (Environment.TickCount - startTime < timeoutMs && !_stream.DataAvailable())
            {
                Thread.Sleep(10); // Small delay to avoid busy loop
            }
            return _stream.DataAvailable();
        }

        public void Close()
        {
            if (_stream == null) return;

            try
            {
                _stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Close Error: " + ex.Message);
                //errMsg = "Close Error: " + ex.Message;
            }
        }

        public void FlushStream(int timeoutMs)
        {
            if (_stream == null) return;

            var buf = new byte[256];
            try
            {
                while (DataAvailableTimeout(timeoutMs))
                {
                    int bytesRead = _stream.Read(buf, 0, buf.Length);

                    var strbuf = Encoding.UTF8.GetString(buf, 0, bytesRead);
                    Console.WriteLine("Flush(" + bytesRead + "): " + strbuf);
                    //WriteToOutput("Flush(" + bytesRead + "): " + strbuf, Color.Gray);
                    //for (int byteNum = 0; byteNum < bytesRead; byteNum++)
                    //{ 
                    //    WriteToOutput("Flush: 0x" + buf[byteNum].ToString("X2") + "'" + Encoding.UTF8.GetString(buf, byteNum,1) + "'", Color.Gray);
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Error: " + ex.Message);
                //WriteToOutput("Read Error: " + ex.Message, Color.Red);
            }
        }







    }
}