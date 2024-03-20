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

namespace NoteSecretary.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddMeetingsWindow.xaml
    /// </summary>
    public partial class AddMeetingsWindow : Window
    {
        public AddMeetingsWindow()
        {
            InitializeComponent();
            ClientsComboBox.ItemsSource = DB_Connection.secretaryDBEntities.Clients.ToList();

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try

            {
                Meetings meeting = new Meetings()
                {
                    Name = DescriptionMeetingTB.Text.ToString(),
                    date = MeetingDatePicker.SelectedDate.Value.Date,
                    ClientID = (ClientsComboBox.SelectedItem as Clients).Id,
                };

                DB_Connection.secretaryDBEntities.Meetings.Add(meeting);
                DB_Connection.secretaryDBEntities.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Неправильные данные", "Ошибка");
                this.Close();
            }
        }
    }
}
