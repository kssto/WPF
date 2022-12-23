using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



    
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                ;
                var http_c = new HttpClient();
                var json = await http_c.GetStringAsync("https://api.github.com/users");
                var x = JsonConvert.DeserializeObject<List<model>>(json);
                foreach (model m in x)
                {
                    btn1.IsEnabled = false;
                    txt1.Text = m.login + "‘|’" + m.id + "‘|’" + m.node_id;
                }
            }
            catch (Exception )
            {

            }
            //using (HttpClient clien = new HttpClient())
            //{
            //    var res = await clien.GetAsync("https://api.github.com/users");

            //    res.EnsureSuccessStatusCode();
            //    if (res.IsSuccessStatusCode)
            //    {
            //      btn1.IsEnabled= false;
            //      txt1.Text = await res.Content.ReadAsStringAsync();
            //    }
            //    else
            //    {

            //    }
            //}

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
