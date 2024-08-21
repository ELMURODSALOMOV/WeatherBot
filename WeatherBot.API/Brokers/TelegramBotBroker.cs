using Telegram.Bot;
using Telegram.Bot.Types;

namespace WeatherBot.API.Brokers
{

    public partial class TelegramBotBroker : ITelegramBotBroker
    {
        private readonly string token = @"7059298578:AAEVLWMS8d3hhP67EQa_s3mdYDtExl7HLDI";
        private readonly ITelegramBotClient client;
       
        public TelegramBotBroker()
        {
            this.client = new TelegramBotClient(token);
        }
    }
}
