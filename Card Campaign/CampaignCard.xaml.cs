using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Card_Campaign
{
    public sealed partial class CampaignCard : UserControl
    {
        private object lastHovered;
        private bool checkedState = false;
        public GridView ParallaxGridViewRef
        {
            set
            {
                if (value != null)
                {
                    parallaxContainer.Source = value;
                }
            }
        }
        public CampaignCard()
        {
            this.InitializeComponent();

            lastHovered = favButton.Icon;
        }

        private void RootGrid_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            HoverButtons.Visibility = Visibility.Visible;
        }

        private void RootGrid_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            HoverButtons.Visibility = Visibility.Collapsed;
        }
        private void AppBarToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            favButton.Icon = new SymbolIcon(Symbol.SolidStar);
            checkedState = true;
            lastHovered = favButton.Icon;
        }

        private void AppBarToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            favButton.Icon = new SymbolIcon(Symbol.OutlineStar);
            checkedState = false;
            lastHovered = favButton.Icon;
        }

        private void favButton_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (checkedState)
            {
                favButton.Icon = new SymbolIcon(Symbol.UnFavorite);
            }
        }

        private void favButton_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            favButton.Icon = (IconElement)lastHovered;
        }

        private void RootGrid_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        async void ShowCampaignWindow_Click(object sender, RoutedEventArgs e)
        {
            //BootGMBinderSite();

            CoreApplicationView newCoreView = CoreApplication.CreateNewView();

            ApplicationView newAppView = null;
            int mainViewId = ApplicationView.GetApplicationViewIdForWindow(
              CoreApplication.MainView.CoreWindow);

            await newCoreView.Dispatcher.RunAsync(
              CoreDispatcherPriority.Normal,
              () =>
              {
                  newAppView = ApplicationView.GetForCurrentView();
                  Window.Current.Content = new CampaignMainPage();
                  Window.Current.Activate();
              });

            await ApplicationViewSwitcher.TryShowAsStandaloneAsync(
              newAppView.Id,
              ViewSizePreference.UseHalf,
              mainViewId,
              ViewSizePreference.UseHalf);
        }

        async void BootGMBinderSite()
        {
            CoreApplicationView newCoreView = CoreApplication.CreateNewView();

            ApplicationView newAppView = null;
            int mainViewId = ApplicationView.GetApplicationViewIdForWindow(
              CoreApplication.MainView.CoreWindow);

            await newCoreView.Dispatcher.RunAsync(
              CoreDispatcherPriority.Normal,
              () =>
              {
                  newAppView = ApplicationView.GetForCurrentView();
                  Window.Current.Content = new GMBinder_WebviewPage();
                  Window.Current.Activate();
              });

            await ApplicationViewSwitcher.TryShowAsStandaloneAsync(
              newAppView.Id,
              ViewSizePreference.UseHalf,
              mainViewId,
              ViewSizePreference.UseHalf);
        }
    }
}
