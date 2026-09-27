using System.Windows;

namespace AutoMeca
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMaintenance_Click(Object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Feature Maintenance en cours de création", "AutoMeca", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnStock_Click(Object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Feature Stock en cours de création", "AutoMeca", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnMachine_Click(Object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Feature Machine en cours de création", "AutoMeca", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnFournisseurs_Click(Object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Feature Fournisseurs en cours de création", "AutoMeca", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}