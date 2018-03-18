﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DecoratorPattern
{
	public class Espresso : Beverage
	{
		public Espresso()
		{
			Description = "Espresso";
		}

		public override double Cost()
		{
			return 1.99;
		}
	}
}
