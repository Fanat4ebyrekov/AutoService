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
using AutoService.EF;
using static AutoService.Classes.ClassEntities;

namespace AutoService.Lists
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            var user = context.User.Where(i => i.Login == tbLog.Text.Trim() && i.Password == tbPass.Text.Trim()).FirstOrDefault();
            if (user != null)
            {
                if (user.isAdmin)
                {
                    this.Hide();
                    ForAdmin forAdmin = new ForAdmin();
                    forAdmin.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnAcc_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser();
            newUser.ShowDialog();
            this.Close();
        }
    }
}
