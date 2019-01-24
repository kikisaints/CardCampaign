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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Card_Campaign.Controls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MonsterDetails : Page
    {
        public MonsterDetails()
        {
            this.InitializeComponent();
        }

        public DependencyProperty HeaderTextProperty =
        DependencyProperty.RegisterAttached(
          "HeaderText",
          typeof(string),
          typeof(MonsterDetails),
          new PropertyMetadata(false)
        );

        public string HeaderText
        {
            get { return header.Text; }
            set { header.Text = (string)value; }
        }

        public DependencyProperty ContentTextProperty =
        DependencyProperty.RegisterAttached(
          "ContentText",
          typeof(string),
          typeof(MonsterDetails),
          new PropertyMetadata(false)
        );

        public string ContentText
        {
            get { return content.Text; }
            set { content.Text = (string)value; }
        }
    }
}
