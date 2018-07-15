using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.CommandPattern
{
	public class GarageDoorOpenCommand : ICommand
	{
		GarageDoor _garageDoor;

		public GarageDoorOpenCommand(GarageDoor garageDoor)
		{
			_garageDoor = garageDoor;
		}

		public void Execute()
		{
			_garageDoor.Up();
		}

		public void Undo()
		{
			_garageDoor.Down();
		}
	}
}
