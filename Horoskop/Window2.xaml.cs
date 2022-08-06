using System;
using System.Collections.Generic;
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
   
    public partial class Window2 : Window
    {
        Random rng = new Random();

        string[] wrozba = new string[]
        {
                "Be on the alert to recognize your prime at whatever time of your life it may occur.",
                "Your road to glory will be rocky, but fulfilling.",
                "Courage is not simply one of the virtues, but the form of every virtue at the testing point.",
                "Patience is your alley at the moment. Don’t worry!",
                "Don’t worry about money. The best things in life are free.",
                "Courage is not the absence of fear; it is the conquest of it.",
                "Courage is not the absence of fear; it is the conquest of it.",
                "The real kindness comes from within you.",
                "A ship in harbor is safe, but that’s not why ships are built.",
                "If you want the rainbow, you have to tolerate the rain. "

        };
        
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var r = rng.Next(0, wrozba.Length);
            var los = wrozba[r];
            tekst_wrozba.Text = los;
            
        }
    }
}
