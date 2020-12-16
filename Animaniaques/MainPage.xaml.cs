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
using Animaniaques.Vues;
using Windows.UI.Xaml.Media.Animation;
using System.Drawing;
using System.Threading;
using Windows.UI;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Animaniaques
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Nav(object sender, RoutedEventArgs e)
        {
            Animation_Btn();
            this.Frame.Navigate(typeof(MainView));
        }

        private void Animation_Btn()
        {
            LayoutMain.Background = new SolidColorBrush(Colors.White);
            for (int i = 0; i < 50; i++)
            {
                txb_loading.Visibility = Visibility.Visible;
                Thread.Sleep(50);
            }
        }
    }
}
