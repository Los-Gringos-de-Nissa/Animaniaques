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
    public sealed partial class MathPage : Page
    {
        int chiffre1;
        int chiffre2;
        int result;

        private MathsOperations MO = new MathsOperations();
        public MathPage()
        {
            this.InitializeComponent();
            operation.DataContext = MO;
        }

        private void btnLaunchMath(object sender, RoutedEventArgs e)
        {
            string prenom = Prenom.Text;
            //var operationList = new List<string>();
            int i = 1;

            while (i < 6)
            {
                i++;
                //operationList.Add("Opération n°=" + i + " : " + chiffre1 + " x " + chiffre2 + " = " + result);
                if (prenom != "")
                {
                    Random rnd = new Random();
                    chiffre1 = rnd.Next(2, 9);
                    chiffre2 = rnd.Next(2, 9);
                    result = chiffre1 * chiffre2;
                    MO.AddOperation(new Maths(prenom, chiffre1, chiffre2, result));
                }
            }
        }

        /*private void btnValid(object sender, RoutedEventArgs e)
        {
            string prenom = Prenom.Text;
            MO[MathsOperations.SelectedIndex] = new Maths(prenom, chiffre1, chiffre2, result);
            string operation1 = Reponse.Text;
        }*/
    }
}
