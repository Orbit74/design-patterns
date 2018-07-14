using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.SingletonPattern
{
	public class Singleton
	{
		public string Status { get; set; } = "Not Initilised";
		private static Singleton _singletonInstance;

		static Singleton() { }

		public static Singleton GetSingleton()
		{
			if (_singletonInstance == null)
			{
				_singletonInstance = new Singleton { Status = "Iniialised" };
			}

			return _singletonInstance;
		}
	}
}
