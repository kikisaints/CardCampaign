using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Card_Campaign
{
    public sealed partial class NewCampaignCardBlank : UserControl
    {
        bool _isRedSideUp;
        bool _isAnimating;

        public static readonly DependencyProperty PlayerNameProperty =
            DependencyProperty.Register("PlayerName",
                typeof(string),
                typeof(PlayerTag),
                null);
        
        public string PlayerName
        {
            get { return (string)GetValue(PlayerNameProperty); }
            set { SetValue(PlayerNameProperty, value); }
        }

        public NewCampaignCardBlank()
        {
            this.InitializeComponent();

            _isRedSideUp = true;
            _isAnimating = false;

            playerTagList.Items.Add(new PlayerTag() { PlayerName = "Queeth Bickdigger 5"});
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            playerTagList.Items.Remove((e.OriginalSource as Button).DataContext);
        }

        private void PlusSign_Click(object sender, RoutedEventArgs e)
        {
            //PlusSign.Visibility = Visibility.Collapsed;
            //CreateCampaignInfo.Visibility = Visibility.Visible;

            if (_isRedSideUp)
            {
                CreateCampaignInfo.Visibility = Visibility.Visible;
                Front.Visibility = Visibility.Visible;
                Animate();
            }
        }

        private void closebutton_Click(object sender, RoutedEventArgs e)
        {
            //PlusSign.Visibility = Visibility.Visible;
            //CreateCampaignInfo.Visibility = Visibility.Collapsed;
            if (!_isRedSideUp)
            {
                CreateCampaignInfo.Visibility = Visibility.Visible;
                Front.Visibility = Visibility.Visible;

                playerTagList.Items.Clear();
                CampaignNameBox.Text = "";
                bannerImageBox.Text = "Banner Image";

                Animate();
            }
        }

        private void RootGrid_Loaded(object sender, RoutedEventArgs e)
        {
            InitComposition();
        }

        private void Animate()
        {
            if (!_isAnimating)
            {
                var frontVisual = ElementCompositionPreview.GetElementVisual(Front);
                var backVisual = ElementCompositionPreview.GetElementVisual(CreateCampaignInfo);

                float frontStart = _isRedSideUp ? 0.0f : 180.0f;
                float frontEnd = _isRedSideUp ? 180.0f : 0.0f;

                float backStart = _isRedSideUp ? 180.0f : 360.0f;
                float backEnd = _isRedSideUp ? 360.0f : 180.0f;

                var compositor = frontVisual.Compositor;
                var batch = compositor.CreateScopedBatch(CompositionBatchTypes.Animation);
                var frontAnimation = compositor.CreateScalarKeyFrameAnimation();

                frontAnimation.InsertKeyFrame(0.0f, frontStart);
                frontAnimation.InsertKeyFrame(1.0f, frontEnd);

                frontAnimation.Duration = TimeSpan.FromMilliseconds(600);
                frontAnimation.IterationCount = 1;

                frontVisual.StartAnimation("RotationAngleInDegrees", frontAnimation);

                var backAnimation = compositor.CreateScalarKeyFrameAnimation();

                backAnimation.InsertKeyFrame(0.0f, backStart);
                backAnimation.InsertKeyFrame(1.0f, backEnd);

                backAnimation.Duration = TimeSpan.FromMilliseconds(600);
                backAnimation.IterationCount = 1;

                backVisual.StartAnimation("RotationAngleInDegrees", backAnimation);

                batch.Completed += (o, i) =>
                {
                    _isRedSideUp = !_isRedSideUp;
                    _isAnimating = false;

                    if (_isRedSideUp)
                    {
                        CreateCampaignInfo.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Front.Visibility = Visibility.Collapsed;
                    }
                };

                batch.End();
                _isAnimating = true;
            }
        }

        private void InitComposition()
        {
            //
            // Set up our perspective trasnform on the parent
            //
            var parent = ElementCompositionPreview.GetElementVisual(RootGrid);

            float depth = 500.0f;

            //The depth * 5 makes the flip look more orthographic
            var projectionMatrix = new Matrix4x4(1, 0, 0, 0,
                                                 0, 1, 0, 0,
                                                 0, 0, 1, -1 * (1 / (depth * 5)),
                                                 0, 0, 0, 1);

            var perspectiveMatrix = Matrix4x4.CreateTranslation(0, -100.0f, 0) *
                                    projectionMatrix *
                                    Matrix4x4.CreateTranslation(0, 100.0f, 0);

            parent.TransformMatrix = perspectiveMatrix;


            //
            // Make sure the two card faces start in the right position
            // and have the proper CenterPoint and RotationAxis.
            //
            float halfWidth = (float)(Front.ActualWidth / 2.0);
            float halfHeight = (float)(Front.ActualHeight / 2.0);

            var frontVisual = ElementCompositionPreview.GetElementVisual(Front);
            frontVisual.RotationAxis = new Vector3(0, 1, 0);
            frontVisual.CenterPoint = new Vector3(halfWidth, halfHeight, 0f);
            frontVisual.BackfaceVisibility = CompositionBackfaceVisibility.Hidden;
            frontVisual.RotationAngleInDegrees = 0.0f;

            var backVisual = ElementCompositionPreview.GetElementVisual(CreateCampaignInfo);
            backVisual.RotationAxis = new Vector3(0, 1, 0);
            backVisual.CenterPoint = new Vector3(halfWidth, halfHeight, 0f);
            backVisual.BackfaceVisibility = CompositionBackfaceVisibility.Hidden;
            backVisual.RotationAngleInDegrees = 180.0f;
        }
    }
}
