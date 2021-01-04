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
        Ellipse myEllipse;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Nav(object sender, RoutedEventArgs e)
        {
            result.Name = Prenom.Text;
            Application.Current.Resources["Username"] = result.Name;
            Animation_Btn();
            this.Frame.Navigate(typeof(MainView));
        }

        private void Animation_Btn()
        {
            LayoutMain.Background = new SolidColorBrush(Colors.White);
            addEllipse();
            for (int i = 0; i < 50; i++)
            {
                txb_loading.Visibility = Visibility.Visible;
                Thread.Sleep(50);
            }
        }

        public void addEllipse()
        {
            myEllipse = new Ellipse();

            Windows.UI.Color myColor = Windows.UI.Color.FromArgb(255, 0, 0, 0);
            SolidColorBrush myBrush = new SolidColorBrush();
            myBrush.Color = myColor;

            myEllipse.Stroke = myBrush;
            myEllipse.Fill = myBrush;
            myEllipse.HorizontalAlignment = HorizontalAlignment.Left;
            myEllipse.VerticalAlignment = VerticalAlignment.Center;
            myEllipse.Width = 50;
            myEllipse.Height = 100;

            LayoutMain.Children.Add(myEllipse);

            this.setAnimationToEllipse();
        }

        public void setAnimationToEllipse()
        {
            //Paramétrage de l'animation
            TranslateTransform moveTransform = new TranslateTransform();
            moveTransform.X = 0;
            moveTransform.Y = 0;
            myEllipse.RenderTransform = moveTransform;

            Duration duration = new Duration(TimeSpan.FromSeconds(2));

            DoubleAnimation myDoubleAnimationX = new DoubleAnimation();
            myDoubleAnimationX.Duration = duration;

            // Creation d’un storyBoard
            Storyboard justintimeStoryboard = new Storyboard();
            justintimeStoryboard.Duration = duration;
            justintimeStoryboard.Children.Add(myDoubleAnimationX);
            Storyboard.SetTarget(myDoubleAnimationX, moveTransform);

            Storyboard.SetTargetProperty(myDoubleAnimationX, "X");
            myDoubleAnimationX.To = 1500;

            LayoutMain.Resources.Add("justintimeStoryboard", justintimeStoryboard);

            justintimeStoryboard.Begin();
        }
    }
}
