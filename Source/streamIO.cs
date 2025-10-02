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

        //public IDataStream Stream => _stream; //temporary exposure of stream

        public string InitializeOpen(bool useEthernet, string stIPAddress, string stCOMPort)
        {
            _stream = null;

            try
            {
                if (useEthernet)
                    _stream = new TcpDataStream(stIPAddress, 80);
                else
                {
                    if (stCOMPort == "") return "Select COM port";
                    _stream = new SerialDataStream(stCOMPort, 115200);
                }

                _stream.Open();
                return "OK";
            }
            catch (Exception ex)
            {
                return "Init Error: " + ex.Message;
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

        public string Close()
        {
            if (_stream == null) return "NULL" + Environment.NewLine;

            try
            {
                _stream.Close();
            }
            catch (Exception ex)
            {
                return "Close Error: " + ex.Message;
            }
            return "OK";
        }

        public string FlushStream(int timeoutMs)
        {
            if (_stream == null) return "NULL" + Environment.NewLine;

            string retVal = "";
            var buf = new byte[256];
            try
            {
                while (DataAvailableTimeout(timeoutMs))
                {
                    int bytesRead = _stream.Read(buf, 0, buf.Length);

                    var strbuf = Encoding.UTF8.GetString(buf, 0, bytesRead);
                    retVal += "Flush(" + bytesRead + "): " + strbuf + Environment.NewLine;
                    //for (int byteNum = 0; byteNum < bytesRead; byteNum++)
                    //{ 
                    //    retVal += "Flush: 0x" + buf[byteNum].ToString("X2") + "'" + Encoding.UTF8.GetString(buf, byteNum,1) + "'" + Environment.NewLine;
                    //}
                }
            }
            catch (Exception ex)
            {
                retVal += "Read Error: " + ex.Message + Environment.NewLine;
            }
            return retVal;
        }

        public string ReadStreamTO(byte[] buf, int bytesToRead, out int bytesRead, int timeoutMs)
        {
            bytesRead = 0;
            try
            {
                while (DataAvailableTimeout(timeoutMs))
                {
                    bytesRead += _stream.Read(buf, bytesRead, 1); //one byte at a time
                    if (bytesRead >= bytesToRead) return "OK";
                }
                return "Read Timeout (" + bytesRead + "/" + bytesToRead + ")";
            }
            catch (Exception ex)
            {
                return "Read Error: " + ex.Message;
            }

        }

        public bool Write(byte[] data)
        {

            if (_stream == null) return false;

            try
            {
                _stream.Write(data);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



    }
}