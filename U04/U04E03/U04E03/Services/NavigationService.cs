using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U04E03.ViewModels;
using U04E03.Views;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace U04E03.Services
{
	public class NavigationService : INavigationService
	{
		private Frame Frame { get { return (Frame)Window.Current.Content; } }
		private Action<NavigationEventArgs> onNavigated;
		public NavigationService()
		{
		}

		public void NavigateToSecondPage(string message)
		{
			if (!this.Frame.CanGoBack)
			{
				SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
							AppViewBackButtonVisibility.Visible;
				SystemNavigationManager.GetForCurrentView().BackRequested += GoBack_event;
			}

			this.onNavigated = (e) =>
			{
				var vm = (VMSecondPage)(e.Content as SecondPage).DataContext;
				vm.Message = message;
			};

			this.Frame.Navigated += RootFrame_Navigated;
			this.Frame.Navigate(typeof(SecondPage));
		}

		private void GoBack_event(object sender, BackRequestedEventArgs e)
		{
			GoBack();
			e.Handled = true;
		}

		void RootFrame_Navigated(Object sender, NavigationEventArgs e)
		{
			this.Frame.Navigated -= RootFrame_Navigated;

			if (this.onNavigated != null)
				this.onNavigated(e);
			this.onNavigated = null;
		}
		public void GoBack()
		{
			if (this.Frame != null && this.Frame.CanGoBack)
			{
				this.Frame.GoBack();

				if (!this.Frame.CanGoBack)
				{
					SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
						AppViewBackButtonVisibility.Collapsed;
					SystemNavigationManager.GetForCurrentView().BackRequested -=
						GoBack_event;
				}
			}
		}

	}
}
