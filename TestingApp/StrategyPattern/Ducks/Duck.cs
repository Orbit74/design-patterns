using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.DuckApp
{
	public abstract class Duck
	{
		public IFlyBehaviour FlyBehaviour { get; set; }
		public IQuackBehaviour QuackBehaviour { get; set; }

		public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
		{
			this.FlyBehaviour = flyBehaviour;
			this.QuackBehaviour = quackBehaviour;
		}

		public abstract void Display();

		public void PerformFly()
		{
			FlyBehaviour.Fly();
		}

		public void PerformQuack()
		{
			QuackBehaviour.Quack();
		}

		public void Swim()
		{
			Console.WriteLine("All ducks can swim, even decoys");
		}
	}
}
