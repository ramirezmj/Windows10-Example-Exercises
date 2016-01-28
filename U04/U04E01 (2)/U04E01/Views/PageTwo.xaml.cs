using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace U04E01.Views
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class PageTwo : Page
	{
		public PageTwo()
		{
			this.InitializeComponent();
			SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
				AppViewBackButtonVisibility.Visible;
			SystemNavigationManager.GetForCurrentView().BackRequested += backButton_pressed;

		}

		private void backButton_pressed(object sender, BackRequestedEventArgs e)
		{
			if (Frame.CanGoBack)
			{
				SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
					AppViewBackButtonVisibility.Collapsed;
				Frame.GoBack();
				e.Handled = true;
			}
		}
	}
}
