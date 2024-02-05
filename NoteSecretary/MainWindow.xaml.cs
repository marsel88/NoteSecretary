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

namespace NoteSecretary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InfoPages.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));
        }

        private void MainMenuBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClientsPageBtn_Click(object sender, RoutedEventArgs e)
        {
            InfoPages.Navigate(new Uri("Pages/ClientsPage.xaml", UriKind.Relative));
        }

        private void MeetingsPageBtn_Click(object sender, RoutedEventArgs e)
        {
            InfoPages.Navigate(new Uri("Pages/MeetingsPage.xaml", UriKind.Relative));
        }

        private void DoListPageBtn_Click(object sender, RoutedEventArgs e)
        {
            InfoPages.Navigate(new Uri("Pages/DoListPage.xaml", UriKind.Relative));
        }
    }
}
