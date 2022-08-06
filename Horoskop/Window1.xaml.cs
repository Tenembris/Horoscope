using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Horoskop
{
  
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
           
        }

        private void OnSelected(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Baran.txt");

            var bnp = new BitmapImage();
            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/Baran.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
            


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
         
            
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Byk.txt");



            var bnp = new BitmapImage();
            
            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/Byk.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Bliznieta.txt");

            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/Bliznieta.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Rak.txt");
            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/Rak.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Lew.txt");

            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/lew.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Panna.txt");

            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/panna.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Waga.txt");

            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/Waga.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Skorpion.txt");

            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/Skorpion.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Strzelec.txt");

            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/Strzelec.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Koziorozec.txt");

            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/koziorozec.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Wodnik.txt");

            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/Wodnik.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Ryby.txt");

            var bnp = new BitmapImage();

            bnp.BeginInit();
            bnp.UriSource = new Uri(@"znaki/Ryby.png", UriKind.Relative);
            bnp.CacheOption = BitmapCacheOption.OnLoad;
            bnp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bnp.EndInit();

            picHolder.Source = bnp;
        }

        private void TextBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            Wish2.Text = File.ReadAllText(@"C:\Users\mateu\source\repos\Horoskop\Horoskop\bin\Debug\netcoreapp3.1\tekst\Byk.txt");
        }
    }
}
