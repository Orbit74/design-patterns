using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.FactoryPattern.Ingredients;

namespace TestingApp.FactoryPattern
{
	public class ItalianPizzaStore : PizzaStore
	{
		private Pizza _pizza = null;
		private IPizzaIngredientFactory _ingredientFactory;

		public override Pizza CreatePizza(string type)
		{
			_ingredientFactory = new ItalianPizzaIngredientFactory();

			if (type == "cheese")
			{
				_pizza = new CheesePizza(_ingredientFactory);
				_pizza.Name = "Italian Cheese Pizza";
			}
			else if (type == "pepperoni")
			{
				_pizza = new PepperoniPizza(_ingredientFactory);
				_pizza.Name = "Italian Cheese Pizza";
			}
			else if (type == "veggie")
			{
				_pizza = new VeggiePizza(_ingredientFactory);
				_pizza.Name = "Italian Veggie Pizza";
			}
			else
			{
				return null;
			}

			return _pizza;
		}
	}
}
