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
        private Result resultMaths = new Result(0);
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
                   // int result = (chiffre1 * chiffre2);
                    MO.AddOperation(new Maths(prenom, chiffre1, chiffre2));
                }
            }
        }

        /*private void btnValid(object sender, RoutedEventArgs e)
        {
            var resInput = response.Text;
            int res = Int32.Parse(resInput);
            string a = operation.SelectedItem.ToString();
            string b = string.Empty;
            int val;

            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                    b += a[i];
            }

            string chiffre1 = b[0].ToString();
            int result1 = Int32.Parse(chiffre1);
            var chiffre2 = b[1].ToString();
            int result2 = Int32.Parse(chiffre2);

            if(result1 * result2 == res)
            {
                resultMaths.AddPoint();
            }
            int index = operation.SelectedIndex;
        }

        private void Reponse_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        
        private void operation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void checkResult()
        {
            var resInput = response.Text;
                     
        }
    }
}
