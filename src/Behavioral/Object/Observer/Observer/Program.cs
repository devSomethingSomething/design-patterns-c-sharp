using Observer.Interfaces;
using Observer.Observers;
using Observer.Subjects;
using System;

namespace Observer
{
    public class Program
    {
        private static void Main()
        {
            // A subject to listen to
            var weatherData = new WeatherData();

            // Create observers and register them with the subject
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            // Initial check, no updates
            Console.WriteLine(currentConditionsDisplay.Display());

            // Second check, one update
            weatherData.SetMeasurements(50.0f, 40.0f, 30.0f);
            Console.WriteLine(currentConditionsDisplay.Display());

            // Remove listener
            weatherData.RemoveObserver(currentConditionsDisplay);

            // Final check, second update
            weatherData.SetMeasurements(0.0f, 0.0f, 0.0f);
            Console.WriteLine(currentConditionsDisplay.Display());

            Console.ReadKey(true);
        }
    }
}
