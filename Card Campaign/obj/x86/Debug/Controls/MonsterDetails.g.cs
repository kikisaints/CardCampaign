﻿#pragma checksum "C:\Users\kisai\Documents\GitHub\CardCampaign\Card Campaign\Controls\MonsterDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB509A7D759E847816E8AA030F8DB966"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Card_Campaign.Controls
{
    partial class MonsterDetails : 
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
            case 1: // Controls\MonsterDetails.xaml line 15
                {
                    this.infoHeader = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2: // Controls\MonsterDetails.xaml line 29
                {
                    this.infoDetail = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Controls\MonsterDetails.xaml line 30
                {
                    this.content = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Controls\MonsterDetails.xaml line 23
                {
                    this.subheader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.subheader).Tapped += this.SubContentChevron_Tapped;
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.subheader).PointerEntered += this.Subheader_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.subheader).PointerExited += this.Subheader_PointerExited;
                }
                break;
            case 5: // Controls\MonsterDetails.xaml line 25
                {
                    this.subContentChevron = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.FontIcon)this.subContentChevron).Tapped += this.SubContentChevron_Tapped;
                }
                break;
            case 6: // Controls\MonsterDetails.xaml line 18
                {
                    this.header = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.header).Tapped += this.SubContentChevron_Tapped;
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.header).PointerEntered += this.Subheader_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.header).PointerExited += this.Subheader_PointerExited;
                }
                break;
            case 7: // Controls\MonsterDetails.xaml line 20
                {
                    this.contentChevron = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.FontIcon)this.contentChevron).Tapped += this.SubContentChevron_Tapped;
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

