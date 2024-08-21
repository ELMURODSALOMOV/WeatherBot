using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace WeatherBot.API.Brokers
{
    public interface ITelegramBotBroker
    {
        void StartTelegramBot(
            Func<ITelegramBotClient, Update, CancellationToken, Task> handUpdate,
            Func<ITelegramBotClient, Exception, CancellationToken, Task> handleError
            );
    }
}
