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
    /// Логика взаимодействия для SecWindow.xaml
    /// </summary>
    public partial class SecWindow : Window
    {
        public SecWindow()
        {
            InitializeComponent();
            Frame123.Navigate(new SecFondPage());

            BathCmb.SelectedValue = "id";
            BathCmb.DisplayMemberPath = "vid";
            BathCmb.ItemsSource = AppData.Connect.akropolKaluginEntities.Bathroom.ToList();

            LocCmb.SelectedValue = "id";
            LocCmb.DisplayMemberPath = "location1";
            LocCmb.ItemsSource = AppData.Connect.akropolKaluginEntities.Location.ToList();

            CondCmb.SelectedItem = "id";
            CondCmb.DisplayMemberPath = "aircondit1";
            CondCmb.ItemsSource = AppData.Connect.akropolKaluginEntities.Aircondit.ToList();
        }


        private void BackBtn1_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();
            Close();
        }

        private void FilterBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(CondCmb.Text))
                mes += "Выберите наличие кондиционера\n";
            if (string.IsNullOrWhiteSpace(LocCmb.Text))
                mes += "Выберите куда будут выходить окна\n";
            if (string.IsNullOrWhiteSpace(BathCmb.Text))
                mes += "Выберите какого плана будет санузел\n";
            if (mes != "")

            {
                MessageBox.Show(mes);
                mes = " ";
                return;
            }

            var a = CondCmb.SelectedItem;
            var z = LocCmb.SelectedItem;
            var r = BathCmb.SelectedItem;

            var Fltr = AppData.Connect.akropolKaluginEntities.Fond.Where(x => x.CondCmb )
        }
    }
}
