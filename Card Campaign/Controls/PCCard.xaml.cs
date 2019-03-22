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
    public sealed partial class PCCard : UserControl
    {
        public PCCard()
        {
            this.InitializeComponent();
        }

        public string CharacterName
        {
            get { return charName.Text; }
            set
            {
                charName.Text = (string)value;
            }
        }

        public string PlayerName
        {
            get { return charPlayerName.Text; }
            set
            {
                charPlayerName.Text = (string)value;
            }
        }

        public string CharacterRace
        {
            get { return charRace.Text; }
            set
            {
                charRace.Text = (string)value;
            }
        }

        public string CharacterLevel
        {
            get { return charLevel.Text; }
            set
            {
                charLevel.Text = (string)value;
            }
        }

        public string CharacterAlignment
        {
            get { return charAlignment.Text; }
            set
            {
                charAlignment.Text = (string)value;
            }
        }

        public string Class
        {
            get { return classIcon.ClassIconType; }
            set
            {
                classIcon.ClassIconType = (string)value;
                charClass.Text = (string)value;
            }
        }
    }
}
