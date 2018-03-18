using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DuckApp
{
	public class MalllardDuck : Duck
	{
		public MalllardDuck()
			: base (new FlyWithWings(), new QuackNoise())
		{

		}

		public override void Display()
		{
			Console.WriteLine("I'm an actual duck.");
		}
	}
}
