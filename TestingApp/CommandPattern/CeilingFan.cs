using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.CommandPattern
{
	public class CeilingFan
	{
		public const int HIGH = 3;
		public const int MEDIUM = 2;
		public const int LOW = 1;
		public const int OFF = 0;

		string _location;
		public int Speed { get; set; }

		public CeilingFan(string location)
		{
			_location = location;
			Speed = OFF;
		}

		public void High()
		{
			Speed = HIGH;
			Console.WriteLine("Ceiling fan speed is high");
		}

		public void Medium()
		{
			Speed = MEDIUM;
			Console.WriteLine("Ceiling fan speed is medium");
		}

		public void Low()
		{
			Speed = LOW;
			Console.WriteLine("Ceiling fan speed is low");
		}

		public void Off()
		{
			Speed = OFF;
			Console.WriteLine("Ceiling fan is off");
		}
	}
}
