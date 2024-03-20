using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
namespace NoteSecretary.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {

        public ClientsPage()
        {
            InitializeComponent();
            ClientsDG.ItemsSource = DB_Connection.secretaryDBEntities.Clients.ToList();



        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            AddClientPage addClientPage = new AddClientPage();
            addClientPage.Show();
        }



        private void DeleteClientBtn_Click(object sender, RoutedEventArgs e)
        {
            if(ClientsDG.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить клиента?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var CurrentClient = ClientsDG.SelectedItem as Clients;
                    if (CurrentClient != null)
                    {
                        var meetings = DB_Connection.secretaryDBEntities.Meetings.Where(m => m.ClientID == CurrentClient.Id).ToList();
                        DB_Connection.secretaryDBEntities.Clients.Remove(CurrentClient);
                        DB_Connection.secretaryDBEntities.Meetings.RemoveRange(meetings);
                        DB_Connection.secretaryDBEntities.SaveChanges();

                        ClientsDG.ItemsSource = null;
                        ClientsDG.ItemsSource = DB_Connection.secretaryDBEntities.Clients.ToList();

                    }

                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни одного клиента", "Ошибка");
            }
          
        }
        private void EditClientBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
