﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DuckApp
{
	public class Squeek : IQuackBehaviour
	{
		public void Quack()
		{
			Console.WriteLine("Squeek!");
		}
	}
}
