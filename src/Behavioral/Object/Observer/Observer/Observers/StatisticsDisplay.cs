using Observer.Interfaces;

namespace Observer.Observers
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private ISubject weatherData;

        private float temperature;

        private float humidity;

        private float pressure;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;

            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public string Display()
        {
            return $"Temperature: {temperature}" +
                   $"\nHumidity: {humidity}" +
                   $"\nPressure: {pressure}";
        }
    }
}
