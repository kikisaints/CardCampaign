﻿#pragma checksum "C:\Users\kisai\Documents\GitHub\CardCampaign\Card Campaign\MonsterLogPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "69243F968D800EE14AD8E067490BFB30"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Card_Campaign
{
    partial class MonsterLogPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MonsterLogPage.xaml line 16
                {
                    this.MonsterTagFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.MonsterTagFlyout).Closing += this.MonsterTagFlyout_Closing;
                }
                break;
            case 2: // MonsterLogPage.xaml line 26
                {
                    this.monsterCardFlyout = (global::Card_Campaign.Controls.MonsterCard)(target);
                }
                break;
            case 3: // MonsterLogPage.xaml line 111
                {
                    this.MonsterLogList = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.MonsterLogList).SelectionChanged += this.MonsterLogList_SelectionChanged;
                }
                break;
            case 4: // MonsterLogPage.xaml line 43
                {
                    this.searchLog = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.searchLog).TextChanged += this.searchLog_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.searchLog).SuggestionChosen += this.searchLog_SuggestionChosen;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.searchLog).QuerySubmitted += this.searchLog_QuerySubmitted;
                }
                break;
            case 5: // MonsterLogPage.xaml line 52
                {
                    this.SortBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.SortBox).SelectionChanged += this.ComboBox_SelectionChanged;
                }
                break;
            case 6: // MonsterLogPage.xaml line 63
                {
                    this.alignmentBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.alignmentBox).SelectionChanged += this.ComboBox_SelectionChanged_1;
                }
                break;
            case 7: // MonsterLogPage.xaml line 75
                {
                    this.challengeRatingBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.challengeRatingBox).SelectionChanged += this.challengeRatingBox_SelectionChanged;
                }
                break;
            case 8: // MonsterLogPage.xaml line 83
                {
                    this.typeBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.typeBox).SelectionChanged += this.typeBox_SelectionChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

