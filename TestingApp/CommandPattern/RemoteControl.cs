using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.CommandPattern
{
	public class RemoteControl
	{
		List<ICommand> _onCommands = new List<ICommand>();
		List<ICommand> _offCommands = new List<ICommand>();

		public RemoteControl() {	}

		public void SetCommand(ICommand onCommand, ICommand offCommand)
		{
			_onCommands.Add(onCommand);
			_offCommands.Add(offCommand);
		}

		public void OnClicked(int index)
		{
			_onCommands[index].Execute();
		}

		public void OffClicked(int index)
		{
			_offCommands[index].Execute();
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine(" ---------------Remote Control ------------- \r\n");

			for (int i = 0; i < _onCommands.Count; i++)
			{
				sb.AppendLine($"[Slot {i.ToString()}] {_onCommands[i].GetType().Name} - {_offCommands[i].GetType().Name}");
			}

			return sb.ToString();
		}
	}
}
