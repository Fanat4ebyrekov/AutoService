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
using AutoService.Lists;

namespace AutoService
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pendant_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SuspensionDiagnostic suspensionDiagnostic = new SuspensionDiagnostic();
            suspensionDiagnostic.ShowDialog();
            this.Close();
        }

        private void btnEngine_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            EngineDiagnostics engineDiagnostics = new EngineDiagnostics();
            engineDiagnostics.ShowDialog();
            this.Close();
        }

        private void btnSuspSet_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ConvergCollapse convergCollapse= new ConvergCollapse();
            convergCollapse.ShowDialog();
            this.Close();
        }

        private void btnTO_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PlannedTO plannedTO = new PlannedTO();
            plannedTO.ShowDialog();
            this.Close();
        }

        private void btnTire_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            TireService tireService = new TireService();
            tireService.ShowDialog();
            this.Close();
        }
    }
}
