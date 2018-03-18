using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.ObserverPattern
{
	public interface IObserver
	{
		void Update(float temp, float humidity, float pressure);
	}
}
