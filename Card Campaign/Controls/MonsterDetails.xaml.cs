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

        public void LeftAlignDetailContent()
        {
            infoHeader.HorizontalAlignment = HorizontalAlignment.Left;
            infoDetail.HorizontalAlignment = HorizontalAlignment.Left;
            infoDetail.Margin = new Thickness(8, 0, 0, 0);
            content.TextAlignment = TextAlignment.Left;
            content.Margin = new Thickness(8, 0, 0, 0);
        }

        public DependencyProperty SubHeaderVisibilityProperty =
        DependencyProperty.RegisterAttached(
          "SubHeaderVisibility",
          typeof(Visibility),
          typeof(MonsterDetails),
          new PropertyMetadata(false)
        );

        public Visibility SubHeaderVisibility
        {
            get { return subheader.Visibility; }
            set { subheader.Visibility = (Visibility)value; }
        }

        public DependencyProperty HeaderVisibilityProperty =
        DependencyProperty.RegisterAttached(
          "HeaderVisibility",
          typeof(Visibility),
          typeof(MonsterDetails),
          new PropertyMetadata(false)
        );

        public Visibility HeaderVisibility
        {
            get { return header.Visibility; }
            set { header.Visibility = (Visibility)value; }
        }

        public DependencyProperty ContentVisibilityProperty =
        DependencyProperty.RegisterAttached(
          "ContentVisibility",
          typeof(Visibility),
          typeof(MonsterDetails),
          new PropertyMetadata(false)
        );

        public Visibility ContentVisibility
        {
            get { return content.Visibility; }
            set { content.Visibility = (Visibility)value; }
        }

        public DependencyProperty SubHeaderTextProperty =
        DependencyProperty.RegisterAttached(
          "SubHeaderText",
          typeof(string),
          typeof(MonsterDetails),
          new PropertyMetadata(false)
        );

        public string SubHeaderText
        {
            get { return subheader.Text; }
            set { subheader.Text = (string)value; }
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
