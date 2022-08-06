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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
using System.IO;

namespace Horoskop
{
    /// <summary>
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3(User user)
        {
            InitializeComponent();
            var znak = "";

            var DataUr = user.data;
            
            DateTime AriesP = new DateTime(DataUr.Year, 3, 21);
            DateTime AriesK = new DateTime(DataUr.Year, 4, 19);

            DateTime TaurusP = new DateTime(DataUr.Year, 4, 20);
            DateTime TaurusK = new DateTime(DataUr.Year, 5, 22);

            DateTime GeminiP = new DateTime(DataUr.Year, 5, 23);
            DateTime GeminiK = new DateTime(DataUr.Year, 6, 21);

            DateTime CancerP = new DateTime(DataUr.Year, 6, 22);
            DateTime CancerK = new DateTime(DataUr.Year, 7, 22);

            DateTime LeoP = new DateTime(DataUr.Year, 7, 23);
            DateTime LeoK = new DateTime(DataUr.Year, 8, 23);

            DateTime VirgoP = new DateTime(DataUr.Year, 8, 24);
            DateTime VirgoK = new DateTime(DataUr.Year, 9, 22);

            DateTime LibraP = new DateTime(DataUr.Year, 9, 23);
            DateTime LibraK = new DateTime(DataUr.Year, 10, 22);

            DateTime ScorpioP = new DateTime(DataUr.Year, 10, 22);
            DateTime ScorpioK = new DateTime(DataUr.Year, 11, 21);

            DateTime SagittariusP = new DateTime(DataUr.Year, 11, 21);
            DateTime SagittariusK = new DateTime(DataUr.Year, 12, 21);

            DateTime CapricornP = new DateTime(DataUr.Year, 12, 22);
            DateTime CapricornK = new DateTime(DataUr.Year, 1, 19);

            DateTime AquariusP = new DateTime(DataUr.Year, 1, 20);
            DateTime AquariusK = new DateTime(DataUr.Year, 2, 18);

            DateTime PiscesP = new DateTime(DataUr.Year, 2, 19);
            DateTime PiscesK = new DateTime(DataUr.Year, 3, 19);

            if (DateTime.Compare(DataUr, AriesP) >= 0 && DateTime.Compare(DataUr, AriesK) <= 0) 
            {
                znak = "Aries";
            }else if (DateTime.Compare(DataUr, TaurusP) >= 0 && DateTime.Compare(DataUr, TaurusK) <= 0)
            {
                znak = "Taurus";
            }else if (DateTime.Compare(DataUr, GeminiP) >= 0 && DateTime.Compare(DataUr, GeminiK) <= 0) {

                znak = "Gemini";
            }
            else if (DateTime.Compare(DataUr, CancerP) >= 0 && DateTime.Compare(DataUr, CancerK) <= 0)
            {

                znak = "Cancer";
            }
            else if (DateTime.Compare(DataUr, LeoP) >= 0 && DateTime.Compare(DataUr, LeoK) <= 0)
            {

                znak = "Leo";
            }
            else if (DateTime.Compare(DataUr, VirgoP) >= 0 && DateTime.Compare(DataUr, VirgoK) <= 0)
            {

                znak = "Virgo";
            }
            else if (DateTime.Compare(DataUr, LibraP) >= 0 && DateTime.Compare(DataUr, LibraK) <= 0)
            {

                znak = "Libra";
            }
            else if (DateTime.Compare(DataUr, ScorpioP) >= 0 && DateTime.Compare(DataUr, ScorpioK) <= 0)
            {

                znak = "Scorpio";
            }
            else if (DateTime.Compare(DataUr, SagittariusP) >= 0 && DateTime.Compare(DataUr, SagittariusK) <= 0)
            {

                znak = "Sagittarius";
            }
            else if (DateTime.Compare(DataUr, CapricornP) >= 0 && DateTime.Compare(DataUr, CapricornK) <= 0)
            {
                znak = "Sagittarius";
            }
            else if (DateTime.Compare(DataUr, AquariusP) >= 0 && DateTime.Compare(DataUr, AquariusK) <= 0)
            {
                znak = "Aquarius";
            }
            else if (DateTime.Compare(DataUr, PiscesP) >= 0 && DateTime.Compare(DataUr, PiscesK) <= 0)
            {
                znak = "Pisces";
            }

            HttpWebRequest req = WebRequest.Create($"https://sameer-kumar-aztro-v1.p.rapidapi.com/?sign={znak}&day=today") as HttpWebRequest;
            req.Method = "POST";
            req.Headers.Add("X-RapidAPI-Host", "sameer-kumar-aztro-v1.p.rapidapi.com");
            req.Headers.Add("X-RapidAPI-Key", "71b3691d60msh9e8d090586406a6p1bd400jsn3e802e87de68");
            var res =  req.GetResponse();

            using (var reader = new StreamReader(res.GetResponseStream()))
            {
                string result = reader.ReadToEnd();
                Res? wrozba = JsonSerializer.Deserialize<Res>(result);
                wrozba_text_block.Text = wrozba.description;
            }



        
        }
        class Res
        {
            public string? color { get; set; }
            public string? compatibility { get; set; }
            public string? current_date { get; set; }
            public string? date_range { get; set; }
            public string? description { get; set; }
            public string? lucky_number { get; set; }
            public string? lucky_time { get; set; }
            public string? mood { get; set; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
