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
    /// Логика взаимодействия для NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnGood_Click(object sender, RoutedEventArgs e)
        {
           User user = new User();

            try
            {
                user.FIO = tbFIO.Text;
                user.Phone = tbNumber.Text;
                user.Email = tbEmail.Text;
                user.Login = tbLogin.Text;
                user.Password = tbPass.Text;

                MessageBox.Show("Клиент добавлен");
                context.User.Add(user);
                context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так");
                return;
            }

            this.Hide();
            Autorization autorization = new Autorization();
            autorization.ShowDialog();
            this.Close();
        }
    }
}
