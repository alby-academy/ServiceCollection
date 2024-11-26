namespace ServiceCollection.Abstract;

public interface ISender
{
    void Send(string to, string message);
}