
public interface IDataStream
{
    void Open();
    void Close();
    void Write(byte[] data);
    int Read(byte[] buffer, int offset, int count);
    bool IsOpen { get; }
}
