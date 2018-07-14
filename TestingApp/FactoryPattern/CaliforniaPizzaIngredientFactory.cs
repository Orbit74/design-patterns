using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.FactoryPattern.Ingredients;

namespace TestingApp.FactoryPattern
{
	public class CaliforniaPizzaIngredientFactory : IPizzaIngredientFactory
	{
		public Cheese CreateCheese()
		{
			return new MozzarellaCheese();
		}

		public Clam CreateClam()
		{
			return new FreshClams();
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
			return new MarinaraSauce();
		}

		public Veggie[] CreateVeggies()
		{
			Veggie[] veggies = new Veggie[] { new EggPlant(), new Spinich() };
			return veggies;
		}
	}
}
