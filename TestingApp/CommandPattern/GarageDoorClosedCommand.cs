using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.CommandPattern
{
	public class GarageDoorClosedCommand : ICommand
	{
		GarageDoor _garageDoor;

		public GarageDoorClosedCommand(GarageDoor garageDoor)
		{
			_garageDoor = garageDoor;
		}

		public void Execute()
		{
			_garageDoor.Down();
		}

		public void Undo()
		{
			_garageDoor.Up();
		}
	}
}
