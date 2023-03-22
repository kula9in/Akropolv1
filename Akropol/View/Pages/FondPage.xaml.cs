using Akropol.Model;
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

namespace Akropol.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для FondPage.xaml
    /// </summary>
    public partial class FondPage : Page
    {
        public FondPage()
        {
            InitializeComponent();
            FondList.ItemsSource = AppData.Connect.akropolKaluginEntities.Fond.ToList();

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

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(TxtFloor.Text))
                mes += "Введите колчиество этажей\n";
            if (string.IsNullOrWhiteSpace(DatePickerYearBuild.Text))
                mes += "Выберите дату постройки\n";
            if (string.IsNullOrWhiteSpace(TxtRooms.Text))
                mes += "Выберите количество комнат\n";
            if (string.IsNullOrWhiteSpace(BathCmb.Text))
                mes += "Выберите количество санузлов\n";
            if (string.IsNullOrWhiteSpace(CondCmb.Text))
                mes += " Выберите наличие кондиционера\n";
            if (string.IsNullOrWhiteSpace(TxtMarket.Text))
                mes += "Введите рыночную стоимость\n";
            if (string.IsNullOrWhiteSpace(TxtCadastr.Text))
                mes += "Введите кадастровую стоимость\n";
            

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Model.Fond fond = new Model.Fond()
            {
                floor = TxtFloor.Text,
                year_build = DatePickerYearBuild.SelectedDate,
                quntyti_rooms = TxtRooms.Text,
                Bathroom = BathCmb.SelectedItem as Model.Bathroom,
                Location = LocCmb.SelectedItem as Model.Location,         
                Aircondit = CondCmb.SelectedItem as Model.Aircondit,
                price_cadastr = TxtCadastr.Text,
                price_market = TxtMarket.Text
            };

            AppData.Connect.akropolKaluginEntities.Fond.Add(fond);
            AppData.Connect.akropolKaluginEntities.SaveChanges();
            MessageBox.Show("Добавлено");
            TxtFloor.Text = "";
            DatePickerYearBuild.Text = "";
            CondCmb.Text = "";
            TxtRooms.Text = "";
            BathCmb.Text = "";
            CondCmb.Text = "";
            TxtCadastr.Text = "";
            TxtMarket.Text = "";
            FondList.ItemsSource = AppData.Connect.akropolKaluginEntities.Fond.ToList();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(TxtId.Text);
            var uRow = AppData.Connect.akropolKaluginEntities.Fond.Where(w => w.id == num).FirstOrDefault();

            AppData.Connect.akropolKaluginEntities.SaveChanges();
            FondList.ItemsSource = AppData.Connect.akropolKaluginEntities.Fond.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(TxtId.Text);
            var dRow = AppData.Connect.akropolKaluginEntities.Fond.Where(w => w.id == num).FirstOrDefault();
            AppData.Connect.akropolKaluginEntities.Fond.Remove(dRow);
            AppData.Connect.akropolKaluginEntities.SaveChanges();
            FondList.ItemsSource = AppData.Connect.akropolKaluginEntities.Fond.ToList();
        }
    }
}
