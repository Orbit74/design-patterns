using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.FactoryPattern.Ingredients;

namespace TestingApp.FactoryPattern
{
	public class ItalianPizzaIngredientFactory : IPizzaIngredientFactory
	{
		public Cheese CreateCheese()
		{
			return new MozzarellaCheese();
		}

		public Clam CreateClam()
		{
			return new FrozenClams();
		}

		public Dough CreateDough()
		{
			return new ThickCrustDough();
		}

		public Pepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}

		public Sauce CreateSauce()
		{
			return new PlumTomatoSauce();
		}

		public Veggie[] CreateVeggies()
		{
			Veggie[] veggies = new Veggie[] { new BlackOlives(), new EggPlant(), new Spinich() };
			return veggies;
		}
	}
}
