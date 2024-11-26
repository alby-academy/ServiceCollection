using Microsoft.Extensions.DependencyInjection;
using ServiceCollection.Abstract;
using ServiceCollection.Senders;
using ServiceCollection.Services;
using static System.Console;

var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
services.AddSingleton<ISender, Telegram>();
services.AddSingleton<NotifierService>();
services.AddSingleton<RetrieverService>();

var provider = services.BuildServiceProvider();
var notifier = provider.GetRequiredService<NotifierService>();

notifier.NotifyGoodMorning();
notifier.NotifyGoodNight();

ReadKey();