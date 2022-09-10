using Observer.Interfaces;
using System.Collections.Generic;

namespace Observer.Subjects
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;

        private float temperature;

        private float humidity;

        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int index = observers.IndexOf(observer);

            if (index != -1)
            {
                observers.Remove(observer);
            }
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }
    }
}
