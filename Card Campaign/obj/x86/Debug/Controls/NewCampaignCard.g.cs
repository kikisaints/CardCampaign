﻿#pragma checksum "C:\Users\kisai\Documents\GitHub\CardCampaign\Card Campaign\Controls\NewCampaignCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F1219FEBE54F0C697AA902A9A56D1B3B"
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
    partial class NewCampaignCardBlank : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
            case 1: // Controls\NewCampaignCard.xaml line 242
                {
                    this.TravelFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 2: // Controls\NewCampaignCard.xaml line 230
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.removeButton_Click;
                }
                break;
            case 3: // Controls\NewCampaignCard.xaml line 258
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)this.RootGrid).Loaded += this.RootGrid_Loaded;
                }
                break;
            case 4: // Controls\NewCampaignCard.xaml line 259
                {
                    this.Front = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // Controls\NewCampaignCard.xaml line 263
                {
                    this.CreateCampaignInfo = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // Controls\NewCampaignCard.xaml line 302
                {
                    this.createdbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // Controls\NewCampaignCard.xaml line 287
                {
                    this.playerList = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8: // Controls\NewCampaignCard.xaml line 294
                {
                    this.bannerImageBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Controls\NewCampaignCard.xaml line 295
                {
                    this.uploadButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 10: // Controls\NewCampaignCard.xaml line 288
                {
                    this.playerTagList = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 11: // Controls\NewCampaignCard.xaml line 282
                {
                    this.addPlayers = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 12: // Controls\NewCampaignCard.xaml line 273
                {
                    this.CampaignNameBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // Controls\NewCampaignCard.xaml line 274
                {
                    this.closebutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.closebutton).Click += this.closebutton_Click;
                }
                break;
            case 14: // Controls\NewCampaignCard.xaml line 260
                {
                    this.PlusSign = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PlusSign).Click += this.PlusSign_Click;
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

