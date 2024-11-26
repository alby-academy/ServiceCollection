using ServiceCollection.Abstract;
using static System.Console;

namespace ServiceCollection.Senders;

public class Mail : ISender
{
    public void Send(string to, string message) => WriteLine("Send mail to {0}: {1}", to, message);
}