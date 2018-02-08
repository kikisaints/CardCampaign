using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Card_Campaign
{
    public sealed partial class NewCampaignCard : UserControl
    {
        public static readonly DependencyProperty PlayerNameProperty =
            DependencyProperty.Register("PlayerName",
                typeof(string),
                typeof(PlayerTag),
                null);
        
        public string PlayerName
        {
            get { return (string)GetValue(PlayerNameProperty); }
            set { SetValue(PlayerNameProperty, value); }
        }

        public NewCampaignCard()
        {
            this.InitializeComponent();

            //playerTagList.Items.Add(new PlayerTag() { PlayerName = "Queeth Bickdigger 5"});
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            playerTagList.Items.Remove((e.OriginalSource as Button).DataContext);
        }

        private void PlusSign_Click(object sender, RoutedEventArgs e)
        {
            PlusSign.Visibility = Visibility.Collapsed;
            CreateCampaignInfo.Visibility = Visibility.Visible;
        }

        private void closebutton_Click(object sender, RoutedEventArgs e)
        {
            PlusSign.Visibility = Visibility.Visible;
            CreateCampaignInfo.Visibility = Visibility.Collapsed;
        }
    }
}
