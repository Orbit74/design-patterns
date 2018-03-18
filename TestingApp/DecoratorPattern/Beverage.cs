using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DecoratorPattern
{
	public abstract class Beverage
	{
		public virtual string Description { get; set; } = "Unknown Description";

		public abstract double Cost();
	}
}
