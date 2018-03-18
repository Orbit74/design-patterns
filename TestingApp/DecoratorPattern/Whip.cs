using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DecoratorPattern
{
	public class Whip : CondimentDecorator
	{
		public Whip(Beverage beverage)
		: base(beverage)
		{
			Beverage = beverage;
			Beverage.Description += ", Whip";
		}

		public override double Cost()
		{
			return Beverage.Cost() + .15;
		}
	}
}
