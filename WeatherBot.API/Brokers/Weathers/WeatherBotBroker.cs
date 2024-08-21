using Newtonsoft.Json;
using WeatherBot.API.Models.Weathers;

namespace WeatherBot.API.Brokers.Weathers
{
    public class WeatherBotBroker : IWeatherBotBroker
    {
        public async Task<Root> GetWeatherInfo(double latitude, double longitude)
        {
            var client = new HttpClient();
            var responce = await client.GetStringAsync(
                string.Format($"https://api.openweathermap.org/data/2.5/forecast?lat={latitude}&lon={longitude}&appid=dfd8c9c6e8d8edce4acf890275d8ac76"));

            return JsonConvert.DeserializeObject<Root>(responce);
        }
    }
}