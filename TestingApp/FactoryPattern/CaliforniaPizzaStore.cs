using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.FactoryPattern.Ingredients;

namespace TestingApp.FactoryPattern
{
	public class CaliforniaPizzaStore : PizzaStore
	{
		private Pizza _pizza = null;
		private IPizzaIngredientFactory _ingredientFactory;

		public override Pizza CreatePizza(string type)
		{
			_ingredientFactory = new CaliforniaPizzaIngredientFactory();

			if (type == "cheese")
			{
				_pizza = new CheesePizza(_ingredientFactory);
				_pizza.Name = "Californian Cheese Pizza";
			}
			else if (type == "pepperoni")
			{
				_pizza = new PepperoniPizza(_ingredientFactory);
				_pizza.Name = "Californian Cheese Pizza";
			}
			else if (type == "veggie")
			{
				_pizza = new VeggiePizza(_ingredientFactory);
				_pizza.Name = "Californian Veggie Pizza";
			}
			else
			{
				return null;
			}

			return _pizza;
		}
	}
}
