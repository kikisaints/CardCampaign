using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class CampaignMainPage : Page
    {
        public CampaignMainPage()
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
            titleBar.ButtonInactiveBackgroundColor = Windows.UI.Colors.Transparent;
            titleBar.ForegroundColor = Windows.UI.Colors.DarkGray;

            Window.Current.SetTitleBar(OverrideTitleBar);
        }
    }
}
