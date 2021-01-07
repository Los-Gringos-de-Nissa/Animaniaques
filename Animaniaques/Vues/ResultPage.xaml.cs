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
using System.Net.Mail;
using System.Net;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace Animaniaques.Vues
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class ResultPage : Page
    {
        public ResultPage()
        {
            this.InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
        
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string && !string.IsNullOrWhiteSpace((string)e.Parameter))
            {
                String username = (String) Application.Current.Resources["Username"];
                result.Text = $"{e.Parameter}";
                name.Text = username;
            }
            base.OnNavigatedTo(e);
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainView));
        }

        private void btnMail_Click(object sender, RoutedEventArgs e)
        {
            string server = "smtp.gmail.com";
            string to = userMail.Text;
            string from = "lesanimaniaques@gmail.com";
            MailMessage message = new MailMessage(from, to);
            message.IsBodyHtml = true;
            message.Subject = "Résultats animaniaques";
            message.Body = result.Text;

            SmtpClient client = new SmtpClient();
            client.Host = server;
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            NetworkCredential netCre = new NetworkCredential("lesanimaniaques@gmail.com", "losgringosdenissa");
            client.Credentials = netCre;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }
    }
}
