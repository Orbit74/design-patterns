﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.FactoryPattern
{
	public class ItalianCheesePizza : Pizza
	{
		public ItalianCheesePizza()
		{
			Name = "Italian and Cheese Pizza";
			Dough = "Thick Crust Dough";
			Sauce = "Plum Tomato Sauce";

			Toppings.Add("Mozzarella Cheese");
		}
	}
}
