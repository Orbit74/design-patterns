using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.ObserverPattern
{
	public class CurrentConditionsDisplay : IObserver, IDisplayElement
	{
		private readonly ISubject _weatherData;
		
		public float Temperature { get; set; }
		public float Humidity { get; set; }

		public CurrentConditionsDisplay(ISubject weatherData)
		{
			this._weatherData = weatherData;
			this._weatherData.RegisterObserver(this);
		}
		public void Display()
		{
			Console.WriteLine($"Current conditions: {Temperature}C degrees. {Humidity}% humidity");
		}

		public void Update(float temp, float humidity, float pressure)
		{
			this.Temperature = temp;
			this.Humidity = humidity;
			Display();
		}
	}
}
