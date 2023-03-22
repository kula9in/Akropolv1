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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            var enter = AppData.Connect.akropolKaluginEntities.Manager.Where(i => i.Login == TxtBLog.Text && i.Password == PassB.Password && i.Id_role == 2).FirstOrDefault();
            var enter1 = AppData.Connect.akropolKaluginEntities.Manager.Where(i => i.Login == TxtBLog.Text && i.Password == PassB.Password && i.Id_role == 1).FirstOrDefault();
            if (enter == null && enter1 == null)
            {
                MessageBox.Show("Проверьте логин и пароль");
            }
            else if (enter1 == null)
            {
                SecWindow sec = new SecWindow();
                sec.Show();
                Close();
            }
            else if (enter == null)
            {
                OnovaWindow onovaWindow = new OnovaWindow();
                Close();
                onovaWindow.Show();
                MessageBox.Show("Успешный вход");
            }
            
        }
    }   
}
