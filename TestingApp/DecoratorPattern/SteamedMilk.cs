using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DecoratorPattern
{
	public class SteamedMilk : CondimentDecorator
	{

		public SteamedMilk(Beverage beverage)
			: base(beverage)
		{
			Beverage = beverage;
			Beverage.Description += ", Steamed Milk";
		}

		public override double Cost()
		{
			return Beverage.Cost() + .15;
		}
	}
}
