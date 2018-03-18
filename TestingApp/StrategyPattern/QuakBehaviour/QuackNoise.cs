using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DuckApp
{
	public class QuackNoise : IQuackBehaviour
	{
		public void Quack()
		{
			Console.WriteLine("Quack!");
		}
	}
}
