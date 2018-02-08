using System;
using System.Collections.Generic;
using System.Drawing;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Card_Campaign
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static readonly DependencyProperty FrameReference =
            DependencyProperty.Register("FrameRef",
                typeof(Frame),
                typeof(MainPage),
                null);

        public Frame FrameRef
        {
            get { return (Frame)GetValue(FrameReference); }
            set { SetValue(FrameReference, value); }
        }

        public MainPage()
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

            NavView.RequestedTheme = ElementTheme.Dark;
            NavView.RequestedTheme = ElementTheme.Light;
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                SettingsPage settingsPage = new SettingsPage();
                settingsPage.SetMainPageReference(this);
                ContentFrame.Navigate(settingsPage.GetType());
            }
            else
            {
                switch (args.InvokedItem)
                {
                    case "Home":
                        ContentFrame.Navigate(typeof(HomePage));
                        break;
                }
            }
        }

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(HomePage));

            foreach (NavigationViewItemBase item in NavView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "home")
                {
                    NavView.SelectedItem = item;
                    break;
                }
            }

        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                SettingsPage settingsPage = new SettingsPage();
                settingsPage.SetMainPageReference(this);
                ContentFrame.Navigate(settingsPage.GetType());
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag)
                {
                    case "home":
                        ContentFrame.Navigate(typeof(HomePage));
                        break;
                    case "enemylog":
                        ContentFrame.Navigate(typeof(MonsterLogPage));
                        break;
                    case "spelllog":
                        ContentFrame.Navigate(typeof(SpellLogPage));
                        break;
                }
            }
        }
    }
}
