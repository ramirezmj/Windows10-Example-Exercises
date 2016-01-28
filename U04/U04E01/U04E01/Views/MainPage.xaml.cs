using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Profile;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace U04E01.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
			Window.Current.SizeChanged += Window_SizeChanged;

		}

		private void Window_SizeChanged(object sender, WindowSizeChangedEventArgs e)
		{
			DetermineVisualState();
		}

		private void DetermineVisualState()
		{
			var state = string.Empty;
			AnalyticsVersionInfo ai = AnalyticsInfo.VersionInfo;
			string systemFamily = ai.DeviceFamily;

			if (systemFamily == "Windows.Desktop")
			{
				var size = Window.Current.Bounds;
				if (size.Width <= 500)
				{
					state = "Portrait";
				}
				else {
					state = "Landscape";
				}
			}
			else if (systemFamily == "Windows.Mobile")
			{
				var applicationView = ApplicationView.GetForCurrentView();
				if (applicationView.Orientation == ApplicationViewOrientation.Landscape)
				{
					state = "Landscape";
				}
				else {
					state = "Portrait";
				}
			}
			VisualStateManager.GoToState(this, state, true);
		}
	}
}
