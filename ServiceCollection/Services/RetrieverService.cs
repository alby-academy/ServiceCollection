namespace ServiceCollection.Services;

public class RetrieverService
{
    public IEnumerable<string> Get()
    {
        yield return "Marta";
        yield return "Luca";
        yield return "Giovanni";
        yield return "Francesca";
    }
}