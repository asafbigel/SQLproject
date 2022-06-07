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

namespace SQLproject
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
        private void Tables_Click(object sender, RoutedEventArgs e)
        {
            View.Content = new TablesPage();
        }
        private void Querys_Click(object sender, RoutedEventArgs e)
        {
            View.Content = new QuerysPage();
        }
        private void ManagerWindow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Pages.SelectedItem == null)
                return;
            string option = ((TextBlock)Pages.SelectedItem).Text;
            switch (option)
            {
                case "Querys":
                    View.Content = new QuerysPage();
                    break;
                case "Tables":
                    View.Content = new TablesPage(); break;
                case "Exit":
                    Close();
                    break;
                default:
                    break;
            }
        }

    }
}
