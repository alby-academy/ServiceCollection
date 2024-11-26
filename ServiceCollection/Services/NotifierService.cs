using ServiceCollection.Abstract;

namespace ServiceCollection.Services;

public class NotifierService(RetrieverService retriever, ISender sender)
{
    public void NotifyGoodMorning()
    {
        var users = retriever.Get();
        foreach (var user in users) sender.Send(user, "Good morning!");
    }
    
    public void NotifyGoodNight()
    {
        var users = retriever.Get();
        foreach (var user in users) sender.Send(user, "Good night!");
    }
}