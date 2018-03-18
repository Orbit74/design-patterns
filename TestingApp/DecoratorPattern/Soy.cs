using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DecoratorPattern
{
	public class Soy : CondimentDecorator
	{
		
		public Soy(Beverage beverage)
			: base(beverage)
		{
			Beverage = beverage;
			Beverage.Description += ", Soy";
		}

		public override double Cost()
		{
			return Beverage.Cost() + .15;
		}
	}
}
