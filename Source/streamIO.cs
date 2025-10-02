using System;
using System.Windows.Forms;

namespace TRWinApp
{
    public class StreamIO
    {
        private IDataStream _stream;
        //private readonly FormMain _form;

        public StreamIO(/*FormMain form*/)
        {
            //_form = form;
        }

        public IDataStream Stream => _stream; //temporary exposure of stream

        public bool InitializeStream(RadioButton rbComEthernet, TextBox tbIPAddress, ComboBox cmbCOMPort, out string errMsg)
        {
            _stream = null;

            try
            {
                if (rbComEthernet.Checked)
                    _stream = new TcpDataStream(tbIPAddress.Text, 80);
                else
                {
                    if (cmbCOMPort.Text == "")
                    {
                        errMsg = "Select COM port";
                        return false;
                    }
                    _stream = new SerialDataStream(cmbCOMPort.Text, 115200);
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

    }
}