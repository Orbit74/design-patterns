using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.ObserverPattern
{
	public class WeatherData : ISubject
	{
		public List<IObserver> Observers { get; set; }
		public float Temperature { get; private set; }
		public float Humidity { get; private set; }
		public float Pressure { get; private set; }

		public WeatherData()
		{
			Observers = new List<IObserver>();
		}

		public void NotifyObservers()
		{
			foreach (var item in Observers)
			{
				item.Update(Temperature, Humidity, Pressure);
			};
		}

		public void RegisterObserver(IObserver o)
		{
			Observers.Add(o);
		}

		public void RemoveObserver(IObserver o)
		{
			Observers.Remove(o);
		}

		public void SetMeasurements(float temperature, float humidity, float pressure)
		{
			this.Temperature = temperature;
			this.Humidity = humidity;
			this.Pressure = pressure;
			NotifyObservers();
		}
	}
}
