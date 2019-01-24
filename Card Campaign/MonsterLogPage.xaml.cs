using Card_Campaign.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Card_Campaign
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MonsterLogPage : Page
    {
        public ObservableCollection<MonsterTag> monsterSortOC = new ObservableCollection<MonsterTag>();
        private ObservableCollection<MonsterTag> currectSortedCollection = new ObservableCollection<MonsterTag>();
        List<string> monsterNamesList;

        MonsterTag lastSelected;
        public MonsterLogPage()
        {
            this.InitializeComponent();
            monsterNamesList = new List<string>();

            ((App)Application.Current).FillLog(ref monsterSortOC);
            FillMonsterNames();
            MonsterLogList.ItemsSource = monsterSortOC;
        }

        private void FillMonsterNames()
        {
            foreach (MonsterTag mt in monsterSortOC)
            {
                monsterNamesList.Add(mt.CreatureName);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBoxItem = e.AddedItems[0] as ComboBoxItem;
            if (comboBoxItem == null) return;

            var content = comboBoxItem.Content as string;
            if (content != null && content.Equals("Challenge Rating"))
            {
                alignmentBox.Visibility = Visibility.Collapsed;
                challengeRatingBox.Visibility = Visibility.Visible;

                challengeRatingBox.SelectedIndex = 0;

                var sortResult = monsterSortOC.OrderByDescending(a => a.FloatChallengeRating);

                MonsterLogList.ItemsSource = sortResult;
                GrabSortedChallengeRationCollection();
            }
            if (content != null && content.Equals("A - Z"))
            {
                alignmentBox.Visibility = Visibility.Collapsed;
                challengeRatingBox.Visibility = Visibility.Collapsed;

                var sortResult = monsterSortOC.OrderBy(a => a.CreatureName);
                MonsterLogList.ItemsSource = sortResult;
            }
            if (content != null && content.Equals("Alignments"))
            {
                alignmentBox.Visibility = Visibility.Visible;
                challengeRatingBox.Visibility = Visibility.Collapsed;

                alignmentBox.SelectedIndex = 0;

                var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("LG"));
    
                MonsterLogList.ItemsSource = sortResult;
                GrabSortedAlignmentCollection("LG");
            }
        }

        private void GrabSortedAlignmentCollection(string type)
        {
            currectSortedCollection.Clear();
            foreach(MonsterTag obj in MonsterLogList.Items)
            {
                string align = obj.Alignment;
                if (align == type)
                    currectSortedCollection.Add(obj);
                else
                    break;
            }

            MonsterLogList.ItemsSource = currectSortedCollection;
        }

        private void GrabSortedChallengeRationCollection(float maxRange = 30.0f, float minrange = 0.0f)
        {
            currectSortedCollection.Clear();
            for (int i = MonsterLogList.Items.Count - 1; i >= 0; i--)
            {
                MonsterTag mCR = (MonsterTag)MonsterLogList.Items[i];
                float cr = mCR.FloatChallengeRating;

                if (cr >= minrange && cr <= maxRange)
                    currectSortedCollection.Add(mCR);
            }

            MonsterLogList.ItemsSource = currectSortedCollection;
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (alignmentBox.Visibility == Visibility.Visible)
            {                
                var comboBoxItem = e.AddedItems[0] as ComboBoxItem;
                if (comboBoxItem == null) return;

                var content = comboBoxItem.Content as string;
                if (content != null && content.Equals("Lawful Good"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("LG"));
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedAlignmentCollection("LG");
                }
                if (content != null && content.Equals("Neutral Good"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("NG"));
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedAlignmentCollection("NG");
                }
                if (content != null && content.Equals("Chaotic Good"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("CG"));
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedAlignmentCollection("CG");
                }
                if (content != null && content.Equals("Lawful Neutral"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("LN"));
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedAlignmentCollection("LN");
                }
                if (content != null && content.Equals("Neutral"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("N"));
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedAlignmentCollection("N");
                }
                if (content != null && content.Equals("Chaotic Neutral"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("CN"));
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedAlignmentCollection("CN");
                }
                if (content != null && content.Equals("Lawful Evil"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("LE"));
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedAlignmentCollection("LE");
                }
                if (content != null && content.Equals("Neutral Evil"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("NE"));
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedAlignmentCollection("NE");
                }
                if (content != null && content.Equals("Chaotic Evil"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.IsOfAlignmentType("CE"));
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedAlignmentCollection("CE");
                }
            }
        }

        private void challengeRatingBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (challengeRatingBox.Visibility == Visibility.Visible)
            {
                var comboBoxItem = e.AddedItems[0] as ComboBoxItem;
                if (comboBoxItem == null) return;

                var content = comboBoxItem.Content as string;
                if (content != null && content.Equals("All"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.FloatChallengeRating);
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedChallengeRationCollection();
                }
                if (content != null && content.Equals("0 - 5"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.FloatChallengeRating);
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedChallengeRationCollection(5.0f, 0.0f);
                }
                if (content != null && content.Equals("5 - 10"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.FloatChallengeRating);
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedChallengeRationCollection(10.0f, 5.0f);
                }
                if (content != null && content.Equals("10 - 20"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.FloatChallengeRating);
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedChallengeRationCollection(20.0f, 10.0f);
                }
                if (content != null && content.Equals("20 - 30"))
                {
                    var sortResult = monsterSortOC.OrderByDescending(a => a.FloatChallengeRating);
                    MonsterLogList.ItemsSource = sortResult;
                    GrabSortedChallengeRationCollection(30.0f, 20.0f);
                }
            }
        }

        private void typeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void searchLog_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if(args.CheckCurrent() && sender.Text != null)
            {
                List<string> suggestion = new List<string>();

                foreach (string s in monsterNamesList)
                {
                    string checkList = "";
                    string letterCase = sender.Text.ToUpper();
                    string nameCheck = s.ToUpper();

                    int i = 0;
                    foreach(char c in letterCase)
                    {
                        if (i + 1 >= s.Length)
                            break;

                        if(c == nameCheck[i + 1])
                            checkList += nameCheck[i + 1];
                        i++;
                    }

                    if (letterCase == checkList)
                        suggestion.Add(s);
                }

                searchLog.ItemsSource = suggestion;
            }
        }

        private void searchLog_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            var selectedItem = args.SelectedItem.ToString();
            sender.Text = selectedItem;
        }

        private void searchLog_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                searchLog.Text = args.ChosenSuggestion.ToString();
            }
        }

        private string GetAbilityScore(int baseStat)
        {
            if (baseStat <= 1)
                return baseStat.ToString() + " \r(-5)";
            if (baseStat == 2 || baseStat == 3)
                return baseStat.ToString() + " \r(-4)";
            if (baseStat == 4 || baseStat == 5)
                return baseStat.ToString() + " \r(-3)";
            if (baseStat == 6 || baseStat == 7)
                return baseStat.ToString() + " \r(-2)";
            if (baseStat == 8 || baseStat == 9)
                return baseStat.ToString() + " \r(-1)";
            if (baseStat == 10 || baseStat == 11)
                return baseStat.ToString() + " \r(+0)";
            if (baseStat == 12 || baseStat == 13)
                return baseStat.ToString() + " \r(+1)";
            if (baseStat == 14 || baseStat == 15)
                return baseStat.ToString() + " \r(+2)";
            if (baseStat == 16 || baseStat == 17)
                return baseStat.ToString() + " \r(+3)";
            if (baseStat == 18 || baseStat == 19)
                return baseStat.ToString() + " \r(+4)";
            if (baseStat == 20 || baseStat == 21)
                return baseStat.ToString() + " \r(+5)";
            if (baseStat == 22 || baseStat == 23)
                return baseStat.ToString() + " \r(+6)";
            if (baseStat == 24 || baseStat == 25)
                return baseStat.ToString() + " \r(+7)";
            if (baseStat == 26 || baseStat == 27)
                return baseStat.ToString() + " \r(+8)";
            if (baseStat == 28 || baseStat == 29)
                return baseStat.ToString() + " \r(+9)";
            if (baseStat >= 30)
                return baseStat.ToString() + " \r(+10)";

            return baseStat.ToString();
        }

        private void MonsterLogList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MonsterTagFlyout.ShowAt(this);
            MonsterTag mTag = (MonsterTag)(sender as GridView).SelectedItem;
            int mIndex = MonsterLogList.Items.IndexOf(mTag);

            monsterCardFlyout.SizeTypeStat = ((App)Application.Current).CheckBeastSizeType(mIndex);
            monsterCardFlyout.ACStat = ((App)Application.Current).CheckBeastAC(mIndex);
            monsterCardFlyout.HPStat = ((App)Application.Current).CheckBeastHP(mIndex);
            monsterCardFlyout.SPStat = ((App)Application.Current).CheckBeastSpeed(mIndex);

            monsterCardFlyout.ACStat = monsterCardFlyout.ACStat.Replace(" (", "\r(");
            monsterCardFlyout.SPStat = monsterCardFlyout.SPStat.Replace(',', '\r');
            monsterCardFlyout.SPStat = monsterCardFlyout.SPStat.Replace(" (", "\r(");
            monsterCardFlyout.HPStat = monsterCardFlyout.HPStat.Replace(' ', '\r');

            monsterCardFlyout.StrengthStat = GetAbilityScore(((App)Application.Current).CheckBeastSTR(mIndex));
            monsterCardFlyout.ConstitutionStat = GetAbilityScore(((App)Application.Current).CheckBeastCON(mIndex));
            monsterCardFlyout.DextarityStat = GetAbilityScore(((App)Application.Current).CheckBeastDEX(mIndex));
            monsterCardFlyout.IntelligenceStat = GetAbilityScore(((App)Application.Current).CheckBeastINT(mIndex));
            monsterCardFlyout.WisdomStat = GetAbilityScore(((App)Application.Current).CheckBeastWIS(mIndex));
            monsterCardFlyout.CharismaStat = GetAbilityScore(((App)Application.Current).CheckBeastCHA(mIndex));
        }
    }
}
