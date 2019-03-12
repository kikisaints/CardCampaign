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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Card_Campaign.Controls
{
    public sealed partial class ClassIconPicker : UserControl
    {
        public ClassIconPicker()
        {
            this.InitializeComponent();
        }

        private string currentClassIcon = "";

        public string ClassIconType
        {
            get { return currentClassIcon; }
            set
            {
                currentClassIcon = (string)value;
                SetImageIcon(currentClassIcon);
            }
        }

        public void SetImageIcon(string className)
        {
            if(className == "Barbarian")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/BarbarianIcon.png"));
            }
            else if (className == "Bard")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/BardIcon.png"));
            }
            else if (className == "Cleric")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/ClericIcon.png"));
            }
            else if (className == "Druid")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/DruidIcon.png"));
            }
            else if (className == "Fighter")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/FighterIcon.png"));
            }
            else if (className == "Monk")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/MonkIcon.png"));
            }
            else if (className == "Paladin")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/PaladinIcon.png"));
            }
            else if (className == "Ranger")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/RangerIcon.png"));
            }
            else if (className == "Rogue")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/RogueIcon.png"));
            }
            else if (className == "Sorcerer")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/SorcererIcon.png"));
            }
            else if (className == "Warlock")
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/WarlockIcon.png"));
            }
            else if (className == "Wizard" || className == "" || className == null)
            {
                ClassIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/WizardIcon.png"));
            }
        }
    }
}
