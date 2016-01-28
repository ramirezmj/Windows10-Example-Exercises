using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U04E03.Services;

namespace U04E03.ViewModels.Base
{
	public class VMLocator
	{
		private Lazy<VMMain> mainViewModel;
		private Lazy<VMSecondPage> secondPageViewModel;
		private INavigationService navigationService;

		public VMLocator()
		{
			navigationService = new NavigationService();
			mainViewModel = new Lazy<VMMain>(() => new VMMain(navigationService));
			secondPageViewModel = new Lazy<VMSecondPage>(() => new VMSecondPage(navigationService));
		}

		public VMMain MainViewModel
		{
			get
			{
				return mainViewModel.Value;
			}
		}

		public VMSecondPage SecondPageViewModel
		{
			get
			{
				return secondPageViewModel.Value;
			}
		}
	}
}
