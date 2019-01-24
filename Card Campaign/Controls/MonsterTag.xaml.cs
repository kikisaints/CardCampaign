using Card_Campaign.Controls;
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
    public sealed partial class MonsterTag : UserControl
    {
        public static readonly DependencyProperty AlignmentProperty =
        DependencyProperty.RegisterAttached(
          "Alignment",
          typeof(string),
          typeof(MonsterTag),
          new PropertyMetadata(false)
        );

        public string Alignment
        {
            get { return AlignmentTextB.Text; }
            set { AlignmentTextB.Text = (string)value; }
        }

        public static readonly DependencyProperty ChallengeRatingProperty =
        DependencyProperty.RegisterAttached(
          "ChallengeRating",
          typeof(string),
          typeof(MonsterTag),
          new PropertyMetadata(false)
        );

        public string ChallengeRating
        {
            get
            {
                return ChallengeRatingTextB.Text;
            }
            set
            {
                string[] CR = value.Split("cr");
                ChallengeRatingTextB.Text = CR[1];
            }
        }

        public float FloatChallengeRating
        {
            get
            {
                string check = ChallengeRatingTextB.Text;

                switch (check)
                {
                    case "1/8":
                        return 0.125f;
                    case "1/4":
                        return 0.25f;
                    case "1/2":
                        return 0.5f;
                    default:
                        {
                            int intcheck = 0;
                            Int32.TryParse(check, out intcheck);
                            return intcheck;
                        }
                }
            }
            set { }
        }

        public bool IsOfAlignmentType(string align)
        {
            if (align == AlignmentTextB.Text)
                return true;

            return false;
        }

        public static readonly DependencyProperty CreatureNameProperty =
        DependencyProperty.RegisterAttached(
          "CreatureName",
          typeof(string),
          typeof(MonsterTag),
          new PropertyMetadata(false)
        );

        public string CreatureName
        {
            get
            {
                return MonterNameTextB.Text;
            }
            set { MonterNameTextB.Text = (string)value; }
        }

        public MonsterTag()
        {
            this.InitializeComponent();
        }
    }
}
