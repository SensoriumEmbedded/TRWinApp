using System.IO.Ports;

public class SerialDataStream : IDataStream
{
    private SerialPort _port;

    public SerialDataStream(string portName, int baudRate)
    {
        _port = new SerialPort(portName, baudRate);
    }

    public bool IsOpen => _port?.IsOpen ?? false;

    public void Open() => _port.Open();
    public void Close() => _port.Close();

    public void Write(byte[] data) => _port.Write(data, 0, data.Length);
    public int Read(byte[] buffer, int offset, int count)
    {
        if (_port.BytesToRead == 0) return 0;
        
        return _port.Read(buffer, offset, count);
    }
}

