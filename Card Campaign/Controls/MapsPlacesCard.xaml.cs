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

namespace Card_Campaign.Controls
{
    public sealed partial class MapsPlacesCard : UserControl
    {
        private int difficulty = 1;

        public MapsPlacesCard()
        {
            this.InitializeComponent();
        }

        public string MapName
        {
            get { return mapName.Text; }
            set { mapName.Text = (string)value; }
        }

        public string NumberOfPlotPoints
        {
            get { return numPlotPoints.Text; }
            set { numPlotPoints.Text = (string)value; }
        }

        public string NumberOfEncounters
        {
            get { return numEncounters.Text; }
            set { numEncounters.Text = (string)value; }
        }

        public string NumberOfRepeatEncounters
        {
            get { return numREncounters.Text; }
            set { numREncounters.Text = (string)value; }
        }

        public int DiffcultyRating
        {
            get
            {
                return difficulty;
            }
            set
            {
                difficulty = (int)value;

                if(difficulty <= StarList.Children.Count)
                {
                    switch(difficulty)
                    {
                        case 1:
                            SetOneStar();
                            break;
                        case 2:
                            SetTwoStar();
                            break;
                        case 3:
                            SetThreeStar();
                            break;
                        case 4:
                            SetFourStar();
                            break;
                        default:
                            SetFiveStar();
                            break;
                    }
                }
            }
        }

        private void SetOneStar()
        {
            star1.Visibility = Visibility.Visible;
            star2.Visibility = Visibility.Collapsed;
            star3.Visibility = Visibility.Collapsed;
            star4.Visibility = Visibility.Collapsed;
            star5.Visibility = Visibility.Collapsed;

            ToolTip toolTip = new ToolTip();
            toolTip.Content = "Easy";
            ToolTipService.SetToolTip(StarList, toolTip);
        }

        private void SetTwoStar()
        {
            star1.Visibility = Visibility.Visible;
            star2.Visibility = Visibility.Visible;
            star3.Visibility = Visibility.Collapsed;
            star4.Visibility = Visibility.Collapsed;
            star5.Visibility = Visibility.Collapsed;

            ToolTip toolTip = new ToolTip();
            toolTip.Content = "Normal";
            ToolTipService.SetToolTip(StarList, toolTip);
        }

        private void SetThreeStar()
        {
            star1.Visibility = Visibility.Visible;
            star2.Visibility = Visibility.Visible;
            star3.Visibility = Visibility.Visible;
            star4.Visibility = Visibility.Collapsed;
            star5.Visibility = Visibility.Collapsed;

            ToolTip toolTip = new ToolTip();
            toolTip.Content = "Hard";
            ToolTipService.SetToolTip(StarList, toolTip);
        }

        private void SetFourStar()
        {
            star1.Visibility = Visibility.Visible;
            star2.Visibility = Visibility.Visible;
            star3.Visibility = Visibility.Visible;
            star4.Visibility = Visibility.Visible;
            star5.Visibility = Visibility.Collapsed;

            ToolTip toolTip = new ToolTip();
            toolTip.Content = "Very Hard";
            ToolTipService.SetToolTip(StarList, toolTip);
        }

        private void SetFiveStar()
        {
            star1.Visibility = Visibility.Visible;
            star2.Visibility = Visibility.Visible;
            star3.Visibility = Visibility.Visible;
            star4.Visibility = Visibility.Visible;
            star5.Visibility = Visibility.Visible;

            ToolTip toolTip = new ToolTip();
            toolTip.Content = "Insane";
            ToolTipService.SetToolTip(StarList, toolTip);
        }
    }
}
