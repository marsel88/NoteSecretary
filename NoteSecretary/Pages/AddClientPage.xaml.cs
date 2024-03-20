using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

namespace NoteSecretary.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Window

    {

        public AddClientPage()
        {

            InitializeComponent();
        }


        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Clients client = new Clients()
                {
                    Name = NameTB.Text.ToString(),
                    PhoneNumber = PhoneNumberTB.Text.ToString(),
                    Birthday = BirthdayDatePicker.SelectedDate.Value.Date,
                    Description = DescriptionTB.Text.ToString()
                };

                DB_Connection.secretaryDBEntities.Clients.Add(client);
                DB_Connection.secretaryDBEntities.SaveChanges();
                this.Close();
                
            }
            catch
            {
                MessageBox.Show("Неправильные данные", "Ошибка");
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
