using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.FactoryPattern.Ingredients;

namespace TestingApp.FactoryPattern
{
	public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory
	{
		public Cheese CreateCheese()
		{
			return new ReggianoCheese();
		}

		public Clam CreateClam()
		{
			return new FreshClams();
		}

		public Dough CreateDough()
		{
			return new ThinCrustDough();
		}

		public Pepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}

		public Sauce CreateSauce()
		{
			return new MarinaraSauce();
		}

		public Veggie[] CreateVeggies()
		{
			Veggie[] veggies = new Veggie[] { new Onion(), new Garlic(), new RedPepper(), new Mushroom() };
			return veggies;
		}
	}
}
