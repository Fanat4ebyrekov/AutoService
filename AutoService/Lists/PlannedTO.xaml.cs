﻿using System;
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
    /// Логика взаимодействия для PlannedTO.xaml
    /// </summary>
    public partial class PlannedTO : Window
    {
        public PlannedTO()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car();

            try
            { 
                car.Brand = tbBrand.Text;
                car.Model = tbModel.Text;
                car.YearOfIssue = Convert.ToDateTime(tbYear.Text);
                car.Mileage = tbMill.Text;

                MessageBox.Show("Пользователь добавлен");
                context.Car.Add(car);
                context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так");
                return;
            }


            this.Hide();
            MainWindow main = new MainWindow();
            main.ShowDialog();
            this.Close();
        }
    }
}
