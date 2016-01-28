using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using U04E03.Services;
using U04E03.ViewModels.Base;

namespace U04E03.ViewModels
{
	public class VMSecondPage : VMBase
	{
		private string message;
		private INavigationService navigationService;
		private Lazy<DelegateCommand<string>> goBack;

		public string Message
		{
			get
			{
				return message;
			}
			set
			{
				message = value;
				RaisePropertyChanged("Message");
			}
		}
		public VMSecondPage(INavigationService param)
		{
			navigationService = param;

			InitializeCommands();
		}
		public ICommand GoBackCommand
		{
			get { return goBack.Value; }
		}
		private void InitializeCommands()
		{
			goBack = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(GoBackCommandExecute,
													GoBackCommandCanExecute));
		}
		public void GoBackCommandExecute(string param)
		{
			navigationService.GoBack();
		}
		public bool GoBackCommandCanExecute(string param)
		{
			return true;
		}

	}
}
