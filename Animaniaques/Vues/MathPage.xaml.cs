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

        private MathsOperations MO = new MathsOperations();
        Result resultMaths = new Result();

        public MathPage()
        {
            this.InitializeComponent();
            operation.DataContext = MO;
        }

        private void btnLaunchMath(object sender, RoutedEventArgs e)
        {
            int i = 1;
            // Au lancement de l'exercice, 5 opérations de multiplication sont générées aléatoirement
            while (i < 6)
            {
                    i++;
                    Random rnd = new Random();
                    int chiffre1 = rnd.Next(2, 9);
                    int chiffre2 = rnd.Next(2, 9);
                    MO.AddOperation(new Maths(chiffre1, chiffre2));
            }
        }

        private void btnValid(object sender, RoutedEventArgs e)
        {

            if (MO.Count >= 0) { 
            var resInput = response.Text;
            int res = Int32.Parse(resInput);
            string a = operation.SelectedItem.ToString();
            string b = string.Empty;


                for (int i = 0; i < a.Length; i++)
                {
                    if (Char.IsDigit(a[i]))
                        b += a[i];
                }

                string chiffre1 = b[0].ToString();
                int result1 = Int32.Parse(chiffre1);
                var chiffre2 = b[1].ToString();
                int result2 = Int32.Parse(chiffre2);

                // si l'utilisateur a la bonne réponse on ajoute 1 point au Score
                if (result1 * result2 == res)
                {
                    resultMaths.Score++;
                    int index = operation.SelectedIndex;
                    MO.RemoveAt(index);
                }
                // si l'utilisateur n'a pas la bonne réponse on n'ajoute pas de point au Score
                else if (result1 * result2 != res)
                {
                    int index = operation.SelectedIndex;
                    MO.RemoveAt(index);
                }
            } 

            if (MO.Count == 0)
                {
                this.Frame.Navigate(typeof(ResultPage), resultMaths.ResultMessage());
            }

            response.Text = "";
            }    

        private void Reponse_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        
        private void operation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainView));
        }
    }
}
