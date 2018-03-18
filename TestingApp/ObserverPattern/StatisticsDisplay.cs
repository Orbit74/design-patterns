﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.ObserverPattern
{
	public class StatisticsDisplay : IObserver, IDisplayElement
	{
		private readonly ISubject _weatherData;

		private float maxTemp = 0.0f;
		private float minTemp = 200;
		private float tempSum = 0.0f;
		private int numReadings;

		public StatisticsDisplay(ISubject weatherData)
		{
			this._weatherData = weatherData;
			this._weatherData.RegisterObserver(this);
		}
		public void Display()
		{
			Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
			+ "/" + maxTemp + "/" + minTemp);
		}

		public void Update(float temp, float humidity, float pressure)
		{
			tempSum += temp;
			numReadings++;

			if (temp > maxTemp)
			{
				maxTemp = temp;
			}

			if (temp < minTemp)
			{
				minTemp = temp;
			}

			Display();
		}
	}
}
