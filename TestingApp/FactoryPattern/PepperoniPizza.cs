﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.FactoryPattern.Ingredients;

namespace TestingApp.FactoryPattern
{
	public class PepperoniPizza : Pizza
	{
		public readonly IPizzaIngredientFactory _pizzaIngredientFactory;

		public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
		{
			_pizzaIngredientFactory = pizzaIngredientFactory;
		}

		public override void Prepare()
		{
			Console.WriteLine($"Preparing {Name}");
			Dough = _pizzaIngredientFactory.CreateDough();
			Sauce = _pizzaIngredientFactory.CreateSauce();
			Cheese = _pizzaIngredientFactory.CreateCheese();
			Pepperoni = _pizzaIngredientFactory.CreatePepperoni();
		}
	}
}
