using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DecoratorPattern
{
	public class Mocha : CondimentDecorator
	{
		public Mocha(Beverage beverage)
			: base(beverage)
		{
			Beverage = beverage;
			beverage.Description += ", Mocha";
		}

		public override double Cost()
		{
			return Beverage.Cost() + .20;
		}
	}
}
