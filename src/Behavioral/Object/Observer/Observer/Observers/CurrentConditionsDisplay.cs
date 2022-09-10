using Observer.Interfaces;

namespace Observer.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private ISubject weatherData;

        private float temperature;

        private float humidity;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;

            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
        }

        public string Display()
        {
            return $"Current conditions: {temperature}F degrees and {humidity}% humidity";
        }
    }
}
