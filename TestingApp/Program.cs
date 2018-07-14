using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.DecoratorPattern;
using TestingApp.DuckApp;
using TestingApp.FactoryPattern;
using TestingApp.ObserverPattern;
using TestingApp.SingletonPattern;

namespace TestingApp
{
	class Program
	{
		public delegate int Calculate(int x, int y);

		static void Main(string[] args)
		{
			//var sum = Enumerable
			//.Range(1, 10)
			//.Where(n => n % 2 == 0)
			//.Sum();

			//Console.WriteLine(sum);

			//int[] numbers = new int[] { 5, 3, 6, 7, 32, 3 };

			//var number = numbers.FirstOrDefault(x => x == 50);
			//Console.WriteLine(number.ToString());

			//Console.ReadLine();

			//Strategy Pattern
			//Duck mallardDuck = new MalllardDuck();
			//mallardDuck.Display();
			//mallardDuck.PerformFly();
			//mallardDuck.PerformQuack();
			//mallardDuck.FlyBehaviour = new FlyNoWay();
			//mallardDuck.PerformFly();
			//mallardDuck.Display();
			//mallardDuck = new ModelDuck();
			//mallardDuck.Display();
			//mallardDuck.FlyBehaviour = new FlyRocketPowered();
			//mallardDuck.PerformFly();

			//Observer Pattern
			WeatherData wd = new WeatherData();

			//CurrentConditionsDisplay ccDsiplay = new CurrentConditionsDisplay(wd);
			//ForecastDisplay fcDisplay = new ForecastDisplay(wd);
			//StatisticsDisplay sDisplay = new StatisticsDisplay(wd);
			//HeatIndexDisplay hiDisplay = new HeatIndexDisplay(wd);

			//wd.SetMeasurements(30, 65, 30.4f);
			//wd.SetMeasurements(95, 55, 31.5f);
			//wd.SetMeasurements(90, 45, 29.2f);

			//wd.NotifyObservers();

			//Decorator Pattern
			//Beverage beverage = new Espresso();
			//Console.WriteLine(beverage.Description += " £" + beverage.Cost());

			//Beverage beverage2 = new DarkRoast();
			//Console.WriteLine(beverage2.Description += " £" + beverage2.Cost());
			//beverage2 = new Soy(beverage2);
			//Console.WriteLine(beverage2.Description += " £" + beverage2.Cost());
			//beverage2 = new Whip(beverage2);
			//Console.WriteLine(beverage2.Description += " £" + beverage2.Cost());

			//Factory Pattern
			//ItalianPizzaStore italianPizzaStore = new ItalianPizzaStore();
			//NewYorkPizzaStore newYorkPizzaStore = new NewYorkPizzaStore();
			//CaliforniaPizzaStore californiaPizzaStore = new CaliforniaPizzaStore();

			//Pizza italianPizza = italianPizzaStore.OrderPizza("veggie");
			//Console.WriteLine($"Andy ordered a {italianPizza.Name}");

			//Pizza newYorkPizza = newYorkPizzaStore.OrderPizza("clam");
			//Console.WriteLine($"Dawn ordered a {newYorkPizza.Name}");

			//Pizza californian = californiaPizzaStore.OrderPizza("cheese");
			//Console.WriteLine($"James ordered a {californian.Name}");

			//Singleton Pattern
			var singleton = Singleton.GetSingleton();
			Console.WriteLine($"The status of the singleton is {singleton.Status}");


			Console.ReadLine();

		}
	}
}
