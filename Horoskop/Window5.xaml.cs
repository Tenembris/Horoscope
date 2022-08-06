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
    /// <summary>
    /// Logika interakcji dla klasy Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public User user;

        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = DB.DeserializeList<User>(File.Open("dane", FileMode.Open));
          
            foreach (var user in list)
            {
                if (user.imie == textboximie.Text && user.haslo == PasswordboxHaslo.Password)
                {
                    this.user = user;
                    this.Close(); 
                    return;
                }

            }


        }
    }
}
