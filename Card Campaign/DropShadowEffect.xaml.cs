using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class DropShadowEffect : UserControl
    {
        public DropShadowEffect()
        {
            this.InitializeComponent();

            var compositor = ElementCompositionPreview.GetElementVisual(rootgrid).Compositor;
            var spriteVisual = compositor.CreateSpriteVisual();
            spriteVisual.Size = new Vector2(400, 300);

            var dropShadow = compositor.CreateDropShadow();
            dropShadow.Offset = new Vector3(15, 15, 0);
            dropShadow.Color = new Windows.UI.Color() { A = 20, R = 0, G = 0, B = 0 };
            spriteVisual.Shadow = dropShadow;

            ElementCompositionPreview.SetElementChildVisual(rootgrid, spriteVisual);
        }
    }
}
