﻿#pragma checksum "C:\Users\kisai\Documents\GitHub\CardCampaign\Card Campaign\CampaignCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "83578A004532EA6E52C7F2027A44B9BC"
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
    partial class CampaignCard : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ToolTipService_ToolTip(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                global::Windows.UI.Xaml.Controls.ToolTipService.SetToolTip(obj, value);
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CampaignCard_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICampaignCard_Bindings
        {
            private global::Card_Campaign.CampaignCard dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj2;

            public CampaignCard_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // CampaignCard.xaml line 723
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    default:
                        break;
                }
            }

            // ICampaignCard_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Card_Campaign.CampaignCard)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Card_Campaign.CampaignCard obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_titleText(obj.titleText, phase);
                    }
                }
            }
            private void Update_titleText(global::Windows.UI.Xaml.Controls.TextBlock obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_titleText_Text(obj.Text, phase);
                    }
                }
            }
            private void Update_titleText_Text(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // CampaignCard.xaml line 723
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToolTipService_ToolTip(this.obj2, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // CampaignCard.xaml line 723
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)this.RootGrid).PointerEntered += this.RootGrid_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Grid)this.RootGrid).PointerExited += this.RootGrid_PointerExited;
                }
                break;
            case 3: // CampaignCard.xaml line 736
                {
                    this.parallaxContainer = (global::Windows.UI.Xaml.Controls.ParallaxView)(target);
                }
                break;
            case 4: // CampaignCard.xaml line 763
                {
                    this.TitleGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // CampaignCard.xaml line 769
                {
                    this.InfoButtons = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6: // CampaignCard.xaml line 816
                {
                    this.HoverButtons = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7: // CampaignCard.xaml line 817
                {
                    this.favButton = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.favButton).Checked += this.AppBarToggleButton_Checked;
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.favButton).Unchecked += this.AppBarToggleButton_Unchecked;
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.favButton).PointerEntered += this.favButton_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.favButton).PointerExited += this.favButton_PointerExited;
                }
                break;
            case 8: // CampaignCard.xaml line 808
                {
                    this.EditGrid = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9: // CampaignCard.xaml line 764
                {
                    this.titleText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // CampaignCard.xaml line 737
                {
                    global::Windows.UI.Xaml.Shapes.Rectangle element10 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                    ((global::Windows.UI.Xaml.Shapes.Rectangle)element10).RightTapped += this.RootGrid_RightTapped;
                }
                break;
            case 11: // CampaignCard.xaml line 745
                {
                    this.CardImage = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
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
            switch(connectionId)
            {
            case 1: // CampaignCard.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    CampaignCard_obj1_Bindings bindings = new CampaignCard_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

