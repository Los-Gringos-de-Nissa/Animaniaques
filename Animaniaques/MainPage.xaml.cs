using System;
using Windows.UI.Xaml;
using Microsoft.Toolkit.Uwp;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Animaniaques.Vues;
using Windows.UI.Xaml.Media.Animation;
using System.Drawing;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System.Threading;
using Windows.UI;
using Windows.UI.Xaml.Shapes;
using Animaniaques.Classes;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Animaniaques
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        Result result = new Result();
        private Storyboard myStoryboard;
        public MainPage()
        {
            this.InitializeComponent();
        }

        // Animation sur le bouton de lancement de l'application
        private async void Button_Nav(object sender, RoutedEventArgs e)
        {

            result.Name = Prenom.Text;
            Application.Current.Resources["Username"] = result.Name;

           await btn_main.Rotate(value: 360.0f,
                         centerX: 0.5f,
                         centerY: 0.0f,
                         duration: 5000, delay: 0).StartAsync();
            // Navigation vers la page principale de l'application avec les 3 exercices
            this.Frame.Navigate(typeof(MainView));
        }
    }
}
