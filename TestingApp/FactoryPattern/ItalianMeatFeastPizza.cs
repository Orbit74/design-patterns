using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.FactoryPattern
{
	public class ItalianMeatFeastPizza : Pizza
	{
		public ItalianMeatFeastPizza()
		{
			Name = "Italian and Cheese Pizza";
			Dough = "Thick Crust Dough";
			Sauce = "Plum Tomato Sauce";

			Toppings.Add("Mozzarella Cheese, Pepperoni, Chicken, Spicy Beef");
		}
	}
}
