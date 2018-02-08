using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class SettingsPage : Page
    {
        public MainPage mainpageRef;
        public SettingsPage()
        {
            this.InitializeComponent();

            string selectedColor = (string)Application.Current.Resources["CurrentlySelectedColor"];

            // Set selected item in gridview to indicate what theme color is currently in use
            if (selectedColor != null)
            {
                if (selectedColor == "CardRed")
                {
                    ColorGrid.SelectedItem = CardRed;
                }
                if (selectedColor == "CardGreen")
                {
                    ColorGrid.SelectedItem = CardGreen;
                }
                if (selectedColor == "CardYellow")
                {
                    ColorGrid.SelectedItem = CardYellow;
                }
                if (selectedColor == "CardPurple")
                {
                    ColorGrid.SelectedItem = CardPurple;
                }
                if (selectedColor == "CardGray")
                {
                    ColorGrid.SelectedItem = CardGray;
                }
                if (selectedColor == "CardBrown")
                {
                    ColorGrid.SelectedItem = CardBrown;
                }
                if (selectedColor == "CardBlue")
                {
                    ColorGrid.SelectedItem = CardBlue;
                }
            }
        }

        public void SetMainPageReference(MainPage mp)
        {
            mainpageRef = mp;
        }
        
        private void ColorGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ColorSelectedName = ((e.ClickedItem as Grid).Parent as GridViewItem).Name;
            Application.Current.Resources["CurrentlySelectedColor"] = ColorSelectedName;

            if (ColorSelectedName == "CardRed")
            {
                Application.Current.Resources["SystemAccentColor"] = ((SolidColorBrush)CardRedColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardBrush"] = ((SolidColorBrush)CardRedColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardColor"] = CardRedColor.Fill;
                Application.Current.Resources["UserSelectedCardColorLow"] = CardRedColor_Hover.Fill;
                Application.Current.Resources["UserSelectedCardColorPressed"] = CardRedColor_Pressed.Fill;                
            }
            if (ColorSelectedName == "CardGreen")
            {
                Application.Current.Resources["SystemAccentColor"] = ((SolidColorBrush)CardGreenColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardBrush"] = ((SolidColorBrush)CardGreenColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardColor"] = CardGreenColor.Fill;
                Application.Current.Resources["UserSelectedCardColorLow"] = CardGreenColor_Hover.Fill;
                Application.Current.Resources["UserSelectedCardColorPressed"] = CardGreenColor_Pressed.Fill;
            }
            if (ColorSelectedName == "CardYellow")
            {
                Application.Current.Resources["SystemAccentColor"] = ((SolidColorBrush)CardYellowColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardBrush"] = ((SolidColorBrush)CardYellowColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardColor"] = CardYellowColor.Fill;
                Application.Current.Resources["UserSelectedCardColorLow"] = CardYellowColor_Hover.Fill;
                Application.Current.Resources["UserSelectedCardColorPressed"] = CardYellowColor_Pressed.Fill;
            }
            if (ColorSelectedName == "CardPurple")
            {
                Application.Current.Resources["SystemAccentColor"] = ((SolidColorBrush)CardPurpleColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardBrush"] = ((SolidColorBrush)CardPurpleColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardColor"] = CardPurpleColor.Fill;
                Application.Current.Resources["UserSelectedCardColorLow"] = CardPurpleColor_Hover.Fill;
                Application.Current.Resources["UserSelectedCardColorPressed"] = CardPurpleColor_Pressed.Fill;
            }
            if (ColorSelectedName == "CardBrown")
            {
                Application.Current.Resources["SystemAccentColor"] = ((SolidColorBrush)CardBrownColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardBrush"] = ((SolidColorBrush)CardBrownColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardColor"] = CardBrownColor.Fill;
                Application.Current.Resources["UserSelectedCardColorLow"] = CardBrownColor_Hover.Fill;
                Application.Current.Resources["UserSelectedCardColorPressed"] = CardBrownColor_Pressed.Fill;
            }
            if (ColorSelectedName == "CardGray")
            {
                Application.Current.Resources["SystemAccentColor"] = ((SolidColorBrush)CardGrayColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardBrush"] = ((SolidColorBrush)CardGrayColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardColor"] = CardGrayColor.Fill;
                Application.Current.Resources["UserSelectedCardColorLow"] = CardGrayColor_Hover.Fill;
                Application.Current.Resources["UserSelectedCardColorPressed"] = CardGrayColor_Pressed.Fill;
            }
            if (ColorSelectedName == "CardBlue")
            {
                Application.Current.Resources["SystemAccentColor"] = ((SolidColorBrush)CardBlueColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardBrush"] = ((SolidColorBrush)CardBlueColor.Fill).Color;
                Application.Current.Resources["UserSelectedCardColor"] = CardBlueColor.Fill;
                Application.Current.Resources["UserSelectedCardColorLow"] = CardBlueColor_Hover.Fill;
                Application.Current.Resources["UserSelectedCardColorPressed"] = CardBlueColor_Pressed.Fill;
            }

            NavigationView navView = ((this.Parent as Frame).Parent as NavigationView);
            navView.RequestedTheme = ElementTheme.Dark;
            navView.RequestedTheme = ElementTheme.Light;
        }
    }
}
