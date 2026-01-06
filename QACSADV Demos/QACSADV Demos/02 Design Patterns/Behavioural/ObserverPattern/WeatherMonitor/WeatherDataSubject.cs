using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    // Concrete Subject
    public class WeatherDataSubject : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherDataSubject() => observers = new List<IObserver>();
        public void RegisterObserver(IObserver observer) => observers.Add(observer);
        public void RemoveObserver(IObserver observer) => observers.Remove(observer);
        public void NotifyObservers()
        {
            observers.ForEach(o => o.Update(temperature, humidity, pressure));
        }

        public void MeasurementsChanged() => NotifyObservers();
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
