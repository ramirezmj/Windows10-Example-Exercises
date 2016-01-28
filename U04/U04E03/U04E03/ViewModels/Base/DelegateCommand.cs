using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ICommand
using System.Windows.Input;

namespace U04E03.ViewModels.Base
{
	public class DelegateCommand<T> : ICommand
	{
		public Action<T> execute;
		public Func<T, bool> canExecute;
		public event EventHandler CanExecuteChanged;

		public DelegateCommand(Action<T> execute)
			: this(execute, null)
		{
		}

		public DelegateCommand(Action<T> exec, Func<T, bool> canExec)
		{
			this.execute = exec;
			this.canExecute = canExec;
		}

		public bool CanExecute(object parameter)
		{
			if (canExecute == null)
				return true;

			return canExecute((T)parameter);
		}

		public void Execute(object parameter)
		{
			if (execute != null)
			{
				execute((T)parameter);
			}
		}

		public void RaiseCanExecuteChanged(object param)
		{
			if (CanExecuteChanged != null)
				CanExecuteChanged(param, new EventArgs());
		}
	}
}
