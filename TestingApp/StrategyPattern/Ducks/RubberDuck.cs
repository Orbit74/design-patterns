using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DuckApp
{
	public class RubberDuck : Duck
	{
		public RubberDuck()
			: base (new FlyNoWay(), new Squeek())
		{

		}

		public override void Display()
		{
			Console.WriteLine("I'm a rubber duck.");
		}
	}
}
