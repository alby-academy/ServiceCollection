using ServiceCollection.Abstract;
using static System.Console;

namespace ServiceCollection.Senders;

public class Telegram : ISender
{
    public void Send(string to, string message) => WriteLine("Send telegram to {0}: {1}", to, message);
}