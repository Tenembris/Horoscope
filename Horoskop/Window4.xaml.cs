using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
    /// Logika interakcji dla klasy Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = new User()
            {
                imie = textboximie.Text,
                haslo = PasswordBoxHaslo.Password,
                email = textboxemail.Text,
                data = (DateTime)datapicker1.SelectedDate
            };

            DB.WriteToBinaryFile<User>("dane", user, true);

            this.Close();
        }

        
    }
}
