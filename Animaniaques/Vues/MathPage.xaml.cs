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
                    int chiffre1 = rnd.Next(2, 9);
                    int chiffre2 = rnd.Next(2, 9);
                    MO.AddOperation(new Maths(prenom, chiffre1, chiffre2));
                }
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

                // if user has the good answer, add 1 point to result
                if (result1 * result2 == res)
                {
                    resultMaths.Score++;
                    int index = operation.SelectedIndex;
                    MO.RemoveAt(index);
                }
                // if user has the wrong answer, add 0 point to result
                else if (result1 * result2 != res)
                {
                    int index = operation.SelectedIndex;
                    MO.RemoveAt(index);
                }
            } 
            // manage the error cases here when the user enter a wrong typo e.g test
            else
            {
                
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
