using ServiceCollection.Abstract;
using ServiceCollection.Senders;
using ServiceCollection.Services;
using static System.Console;

ISender telegram = new Telegram();
ISender mail = new Mail();

var retriever = new RetrieverService();
var notifier = new NotifierService(retriever, telegram);

notifier.NotifyGoodMorning();
notifier.NotifyGoodNight();

ReadKey();