﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DecoratorPattern
{
	public class Decaf : Beverage
	{
		public Decaf()
		{
			Description = "Decaf";
		}

		public override double Cost()
		{
			return 1.05;
		}
	}
}
