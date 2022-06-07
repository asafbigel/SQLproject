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

namespace SQLproject
{
    /// <summary>
    /// Interaction logic for TablesWindows.xaml
    /// </summary>
    public partial class TablesWindows : Window
    {
        public TablesWindows(string v)
        {
            InitializeComponent();
            switch (v)
            {
                case "querys":
                    Tables.Visibility = Visibility.Hidden;
                    break;
                case "tables":
                    Querys.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }
        }
        private void Tables_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   
            if (Tables.SelectedItem == null)
                return;
            string option = ((TextBlock)Tables.SelectedItem).Text;
            switch (option)
            {
                case "Table1":
                    View.Content = new TablesPage();
                    break;
                case "Table2":
                    View.Content = new TablesPage(); break;
                case "Table3":
                    View.Content = new TablesPage(); break;
                case "Table4":
                    View.Content = new TablesPage(); break;
                case "Exit":
                    Close();
                    break;
                default:
                    break;
            }
        }
        private void Querys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Querys.SelectedItem == null)
                return;
            string option = ((TextBlock)Querys.SelectedItem).Text;
            switch (option)
            {
                case "Query1":
                    View.Content = new TablesPage(); break;
                case "Query2":
                    View.Content = new TablesPage(); break;
                case "Query3":
                    View.Content = new TablesPage(); break;
                case "Query4":
                    View.Content = new TablesPage(); break;
                case "Exit":
                    Close(); break;
                default:
                    break;
            }
        }

    }
}
