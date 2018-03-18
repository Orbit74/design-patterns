using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.FactoryPattern
{
	public abstract class Pizza
	{
		public string Name { get; set; }
		public string Dough { get; set; }
		public string Sauce { get; set; }
		public List<string> Toppings { get; set; } = new List<string>();

		public void Prepare()
		{
			Console.WriteLine($"Preparing {Name}...");
			Console.WriteLine($"Tossing {Dough}...");
			Console.WriteLine($"Adding {Sauce}...");
			Console.WriteLine($"Adding toppings:");
			foreach (var topping in Toppings)
			{
				Console.WriteLine($" {topping}");
			}
		}

		public void Bake()
		{
			Console.WriteLine("Baking for 25 mins at 350f");
		}

		public void Cut()
		{
			Console.WriteLine("Cutting Pizza into slices");
		}

		public void Box()
		{
			Console.WriteLine("Boxing Pizza");
		}

	}
}
