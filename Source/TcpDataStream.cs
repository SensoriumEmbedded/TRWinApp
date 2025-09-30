
using System.Net.Sockets;

public class TcpDataStream : IDataStream
{
    private TcpClient _client;
    private NetworkStream _stream;
    private string _host;
    private int _port;
    
    public TcpDataStream(string host, int port)
    {
        _host = host;
        _port = port;
    }

    public bool IsOpen => _client?.Connected ?? false;

    public void Open()
    {
        _client = new TcpClient();
        _client.Connect(_host, _port);
        _stream = _client.GetStream();
    }

    public void Close()
    {
        _stream?.Close();
        _client?.Close();
    }

    public void Write(byte[] data) => _stream.Write(data, 0, data.Length);
    public bool DataAvailable() => _stream.DataAvailable;
    public int Read(byte[] buffer, int offset, int count) => _stream.Read(buffer, offset, count);
}
