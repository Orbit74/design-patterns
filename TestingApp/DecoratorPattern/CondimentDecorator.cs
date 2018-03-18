using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DecoratorPattern
{
	public abstract class CondimentDecorator : Beverage
	{
		public Beverage Beverage { get; set; }
		public CondimentDecorator(Beverage beverage)
		{
			Beverage = beverage;
		}

		public override double Cost()
		{
			throw new NotImplementedException();
		}
	}
}
