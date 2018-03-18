using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.FactoryPattern
{
	public class ItalianPizzaStore : PizzaStore
	{
		public override Pizza CreatePizza(string type)
		{
			if (type == "cheese")
			{
				return new ItalianCheesePizza();
			}
			else if (type == "pepperoni")
			{
				return new ItalianPepperoniPizza();
			}
			else if (type == "meat feast")
			{
				return new ItalianMeatFeastPizza();
			}
			else
			{
				return null;
			}
		}
	}
}
