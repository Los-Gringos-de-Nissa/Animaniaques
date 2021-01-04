using Animaniaques.Classes;
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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace Animaniaques.Vues
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class GeoPage : Page
    {
        Result resultGeo = new Result();
        public GeoPage()
        {
            this.InitializeComponent();
        }
        private void send_Click(object sender, RoutedEventArgs e)
        {
            checkResult();
            this.Frame.Navigate(typeof(ResultPage), resultGeo.ResultMessage());
        }
        private void checkResult()
        {
            if (reponse1.Text == "madrid" || reponse1.Text == "Madrid")
            {
                resultGeo.Score++;
            }
            if (reponse2.Text == "canberra" || reponse2.Text == "Canberra")
            {
                resultGeo.Score++;
            }
            if (reponse3.Text == "rabat" || reponse3.Text == "Rabat")
            {
                resultGeo.Score++;
            }
            if (reponse4.Text == "washington" || reponse4.Text == "Washington")
            {
                resultGeo.Score++;
            }
            if (reponse5.Text == "paris" || reponse5.Text == "Paris")
            {
                resultGeo.Score++;
            }
        }
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainView));
        }
    }
}
