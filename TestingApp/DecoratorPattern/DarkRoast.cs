﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DecoratorPattern
{
	public class DarkRoast : Beverage
	{
		public DarkRoast()
		{
			Description = "Dark Roast";
		}

		public override double Cost()
		{
			return .99;
		}
	}
}
