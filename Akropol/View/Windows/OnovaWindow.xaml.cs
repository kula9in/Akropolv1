using Akropol.Model;
using Akropol.View.Pages;
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
using System.Windows.Shapes;

namespace Akropol.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для OnovaWindow.xaml
    /// </summary>
    public partial class OnovaWindow : Window
    {
        public OnovaWindow()
        {
            InitializeComponent();
            Frame11.Navigate(new FondPage());
        }

        private void FondBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame11.Content = new Akropol.View.Pages.FondPage();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Close();
        }
 
    }
}
