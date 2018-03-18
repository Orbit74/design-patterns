using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.FactoryPattern
{
	public class NewYorkMeatFeastPizza : Pizza
	{
		public NewYorkMeatFeastPizza()
		{
			Name = "New York Sauce and Cheese Pizza";
			Dough = "Thin Crust Dough";
			Sauce = "Marinara Sauce";

			Toppings.Add("Grated Reggiano Cheese, Pepperoni, Chicken, Beef");
		}
	}
}
