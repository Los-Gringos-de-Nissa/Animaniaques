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
using Animaniaques.Classes;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace Animaniaques.Vues
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class FrenchPage : Page
    {

        Result resultFrench = new Result();

        public FrenchPage()
        {
            this.InitializeComponent();
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            checkResult();
            this.Frame.Navigate(typeof(ResultPage), resultFrench.ResultMessage());
        }

        private void checkResult()
        {

            if (reponse1.Text == "animaux" || reponse1.Text == "Animaux")
            {
                resultFrench.Score++;
            }
             if (reponse2.Text == "êtes" || reponse2.Text == "Êtes")
            {
                resultFrench.Score++;
            }
            if (reponse3.Text == "trouver" || reponse3.Text == "Trouver")
            {
                resultFrench.Score++;
            }
             if (reponse4.Text == "adjectif" || reponse4.Text == "Adjectif" || reponse4.Text == "adjectifs" || reponse4.Text == "Adjectifs")
            {
                resultFrench.Score++;
            }
             if (reponse5.Text == "peux" || reponse5.Text == "Peux" || reponse5.Text == "je peux" || reponse5.Text == "Je peux")
            {
                resultFrench.Score++;
            }
        }
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainView));
        }
    }
}
