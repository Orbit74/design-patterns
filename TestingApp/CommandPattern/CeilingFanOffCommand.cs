﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.CommandPattern
{
	public class CeilingFanOffCommand : ICommand
	{
		CeilingFan _ceilingFan;
		int _previousSpeed;

		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			_ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			_previousSpeed = _ceilingFan.Speed;
			_ceilingFan.Off();
		}

		public void Undo()
		{
			switch (_previousSpeed)
			{
				case 3:
					_ceilingFan.High();
					break;
				case 2:
					_ceilingFan.Medium();
					break;
				case 1:
					_ceilingFan.Low();
					break;
				case 0:
					_ceilingFan.Off();
					break;
				default:
					break;
			}
		}
	}
}
