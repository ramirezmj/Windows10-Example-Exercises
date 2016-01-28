using System;
using System.Windows.Input;
using U04E03.Services;
using U04E03.ViewModels.Base;

namespace U04E03.ViewModels
{
	public class VMMain : VMBase
	{
		private string message;
		private INavigationService navigationService;
		private Lazy<DelegateCommand<string>> navigateToSecondPageCommand;

		public string Message
		{
			get { return message; }
			set
			{
				message = value;
				RaisePropertyChanged("Message");
				navigateToSecondPageCommand.Value.RaiseCanExecuteChanged(this);
			}
		}

		public VMMain(INavigationService navServ)
		{
			navigationService = navServ;
			InitializeCommands();
			Message = "Aloja";
		}

		public ICommand NavigateToSecondPageCommand
		{
			get { return navigateToSecondPageCommand.Value; }
		}
		private void InitializeCommands()
		{
			navigateToSecondPageCommand = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(NavigateToSecondPageCommandExecute,
													NavigateToSecondPageCommandCanExecute));
		}
		public void NavigateToSecondPageCommandExecute(string param)
		{
			navigationService.NavigateToSecondPage(param);
		}
		public bool NavigateToSecondPageCommandCanExecute(string param)
		{
			return !string.IsNullOrEmpty(param);
		}
	}
}
