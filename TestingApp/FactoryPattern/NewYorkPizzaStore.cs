using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.FactoryPattern
{
	public class NewYorkPizzaStore : PizzaStore
	{
		public override Pizza CreatePizza(string type)
		{
			if (type == "cheese")
			{
				return new NewYorkCheesePizza();
			}
			else if (type == "pepperoni")
			{
				return new NewYorkPepperoniPizza();
			}
			else if (type == "meat feast")
			{
				return new NewYorkMeatFeastPizza();
			}
			else
			{
				return null;
			}
		}
	}
}
