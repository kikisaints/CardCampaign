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
    public sealed partial class MonsterCard : UserControl
    {
        public MonsterCard()
        {
            this.InitializeComponent();
            //DetailsList = new List<MonsterDetails>();
        }


        public void AddMonsterDetailsToList(List<MonsterDetails> list)
        {
            detailInfoList.ItemsSource = list;
        }

        public List<MonsterDetails> DetailsList
        {
            get { return detailInfoList.ItemsSource as List<MonsterDetails>; }
            set { detailInfoList.ItemsSource = (List<MonsterDetails>)value; }
        }

        public string MonsterName
        {
            get { return MonterNameTextB.Text; }
            set { MonterNameTextB.Text = (string)value; }
        }

        public string StrengthStat
        {
            get { return strStat.Text; }
            set { strStat.Text = (string)value; }
        }

        public string ConstitutionStat
        {
            get { return conStat.Text; }
            set { conStat.Text = (string)value; }
        }

        public string DextarityStat
        {
            get { return dexStat.Text; }
            set { dexStat.Text = (string)value; }
        }

        public string IntelligenceStat
        {
            get { return intStat.Text; }
            set { intStat.Text = (string)value; }
        }

        public string WisdomStat
        {
            get { return wisStat.Text; }
            set { wisStat.Text = (string)value; }
        }

        public string CharismaStat
        {
            get { return chaStat.Text; }
            set { chaStat.Text = (string)value; }
        }

        public string SizeTypeStat
        {
            get { return sizeTypeString.Text; }
            set { sizeTypeString.Text = (string)value; }
        }

        public string EXPStat
        {
            get { return XPString.Text; }
            set { XPString.Text = (string)value; }
        }

        public string ACStat
        {
            get { return ac.ContentText; }
            set { ac.ContentText = (string)value; }
        }

        public string HPStat
        {
            get { return hp.ContentText; }
            set { hp.ContentText = (string)value; }
        }

        public string SPStat
        {
            get { return sp.ContentText; }
            set { sp.ContentText = (string)value; }
        }

        public string Alignment
        {
            get { return AlignmentTextB.Text; }
            set { AlignmentTextB.Text = (string)value; }
        }
    }
}
