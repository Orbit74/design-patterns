﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DuckApp
{
	public class FlyRocketPowered : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I can fly like a rocket!");
		}
	}
}
