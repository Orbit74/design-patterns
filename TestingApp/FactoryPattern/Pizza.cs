using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.FactoryPattern.Ingredients;

namespace TestingApp.FactoryPattern
{
	public abstract class Pizza
	{
		public Dough Dough { get; set; }
		public Sauce Sauce { get; set; }
		public Cheese Cheese { get; set; }
		public Pepperoni Pepperoni { get; set; }
		public Veggie[] Veggies { get; set; }

		public string Name { get; set; }
		public List<string> Toppings { get; set; } = new List<string>();

		public abstract void Prepare();

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
