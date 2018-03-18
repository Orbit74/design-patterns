using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DuckApp
{
	public class ModelDuck : Duck
	{
		public ModelDuck()
			: base (new FlyNoWay(), new QuackNoise())
		{

		}

		public override void Display()
		{
			Console.WriteLine("I'm a model duck.");
		}
	}
}
