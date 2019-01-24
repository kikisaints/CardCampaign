using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Card_Campaign
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoadingPage : Page
    {
        int beastsLoaded = 0;
        public LoadingPage()
        {
            this.InitializeComponent();

            CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;

            ApplicationViewTitleBar titleBar = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Windows.UI.Colors.Transparent;
            titleBar.ButtonForegroundColor = Windows.UI.Colors.DarkGray;
            titleBar.ButtonHoverBackgroundColor = Windows.UI.Colors.Transparent;
            titleBar.ButtonHoverForegroundColor = Windows.UI.Colors.Black;
            titleBar.ButtonPressedForegroundColor = Windows.UI.Colors.Black;
            titleBar.ButtonPressedBackgroundColor = Windows.UI.Colors.Transparent;
            titleBar.ForegroundColor = Windows.UI.Colors.DarkGray;

            Window.Current.SetTitleBar(OverrideTitleBar);
        }

        //MUST BE private async void Page_Loaded(object sender, RoutedEventArgs e)
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // !!!!! when loading, enable this comment !!!!!
            await System.Threading.Tasks.Task.Run(() => ((App)Application.Current).CreateBestiary(this));

            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MainPage));
        }

        public static async Task CallOnUiThreadAsync(CoreDispatcher dispatcher, DispatchedHandler handler) =>
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, handler);

        public async void UpdateLoadingText(string name)
        {
            await CallOnUiThreadAsync(this.Dispatcher, () =>
            {
                // Update the UI to reflect the current monsters loaded.
                if(name != null)
                    monsterName.Text = name;
                loadinginfo.Text = (++beastsLoaded).ToString() + " / 761";
            });
        }
    }
}
