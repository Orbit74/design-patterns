using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.CommandPattern
{
	public class RemoteControl
	{
		List<Action> _onCommands = new List<Action>();
		List<Action> _offCommands = new List<Action>();
		Action _undoCommand;

		public RemoteControl() { }

		public void SetCommand(Action onCommand, Action offCommand)
		{
			_onCommands.Add(onCommand);
			_offCommands.Add(offCommand);
		}

		public void OnClicked(int index)
		{
			_onCommands[index]();
			_undoCommand = _onCommands[index];
		}

		public void OffClicked(int index)
		{
			_offCommands[index]();
			_undoCommand = _offCommands[index];
		}

		public void UndoClicked()
		{
			_undoCommand();
		}

		public void Clear()
		{
			_onCommands = new List<Action>();
			_offCommands = new List<Action>();
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
