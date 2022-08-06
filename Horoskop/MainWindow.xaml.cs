using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Horoskop
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User user;


        public MainWindow()
        {

            InitializeComponent();
            setUser(this.user);

           


        }

        private void setUser(User user)
        {
            if (user == null)
            {
                DaneZalogowanego.Text = "Guest";
            }else
            {
                DaneZalogowanego.Text = user.imie;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("Login First :)");
                return;
            }
            
            Window3 win3 = new Window3(user);
            
            win3.Show();


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
            {
                Window4 win4 = new Window4();
                win4.Show();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
          
                Window5 win5 = new Window5();
                win5.ShowDialog();

            this.user = win5.user;
            setUser(this.user);

        }

        
    }
}
