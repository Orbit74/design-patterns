using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.FactoryPattern.Ingredients
{
	public interface IPizzaIngredientFactory
	{
		Dough CreateDough();
		Sauce CreateSauce();
		Cheese CreateCheese();
		Pepperoni CreatePepperoni();
		Veggie[] CreateVeggies();
		Clam CreateClam();
	}
}
