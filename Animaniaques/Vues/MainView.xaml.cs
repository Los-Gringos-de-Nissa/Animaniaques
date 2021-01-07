using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;
using System.Drawing;
using Microsoft.Toolkit.Uwp.UI.Animations;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace Animaniaques.Vues
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainView : Page
    {
        public MainView()
        {
            this.InitializeComponent();
        }
        // Animations sur les boutons des différents exercices
        private async void Button_Geo(object sender, RoutedEventArgs e)
        {
            await btn_geo.Rotate(value: 360.0f,
                         centerX: 0.5f,
                         centerY: 0.0f,
                         duration: 1000, delay: 0).StartAsync();
            this.Frame.Navigate(typeof(GeoPage));
        }

        private async void Button_French(object sender, RoutedEventArgs e)
        {
            await btn_french.Rotate(value: 360.0f,
                         centerX: 0.5f,
                         centerY: 0.0f,
                         duration: 1000, delay: 0).StartAsync();
            this.Frame.Navigate(typeof(FrenchPage));
        }

        private async void Button_Math(object sender, RoutedEventArgs e)
        {
            await btn_math.Rotate(value: 360.0f,
                         centerX: 0.5f,
                         centerY: 0.0f,
                         duration: 1000, delay: 0).StartAsync();
            this.Frame.Navigate(typeof(MathPage));
        }
    }
}
