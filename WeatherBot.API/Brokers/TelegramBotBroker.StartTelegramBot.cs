using Telegram.Bot.Types;
using Telegram.Bot;

namespace WeatherBot.API.Brokers
{
    public partial class TelegramBotBroker
    {
        public void StartTelegramBot(
            Func<ITelegramBotClient, Update, CancellationToken, Task> handUpdate,
            Func<ITelegramBotClient, Exception, CancellationToken, Task> handleError)
        {
            this.client.StartReceiving(handUpdate, handleError);
        }
    }
}
