using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.ObserverPattern
{
	public class ForecastDisplay : IObserver, IDisplayElement
	{
		private readonly ISubject _weatherData;

		private float currentPressure = 29.92f;
		private float lastPressure;

		public ForecastDisplay(ISubject weatherData)
		{
			this._weatherData = weatherData;
			this._weatherData.RegisterObserver(this);
		}
		public void Display()
		{
			Console.Write("Forecast: ");
			if (currentPressure > lastPressure)
			{
				Console.WriteLine("Improving weather on the way!");
			}
			else if (currentPressure == lastPressure)
			{
				Console.WriteLine("More of the same");
			}
			else if (currentPressure < lastPressure)
			{
				Console.WriteLine("Watch out for cooler, rainy weather");
			}
		}

		public void Update(float temp, float humidity, float pressure)
		{
			lastPressure = currentPressure;
			currentPressure = pressure;

			Display();
		}
	}
}
