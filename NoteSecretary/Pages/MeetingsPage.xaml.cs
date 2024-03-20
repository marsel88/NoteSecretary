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

namespace NoteSecretary.Pages
{
    /// <summary>
    /// Логика взаимодействия для MeetingsPage.xaml
    /// </summary>
    public partial class MeetingsPage : Page
    {
        public MeetingsPage()
        {
            InitializeComponent();
            MeetingsDG.ItemsSource = DB_Connection.secretaryDBEntities.Meetings.ToList();
        }

        private void AddMeetingBtn_Click(object sender, RoutedEventArgs e)
        {
            AddMeetingsWindow addMeetingsWindow = new AddMeetingsWindow(this);
            addMeetingsWindow.Show();
        }

        public void RefreshDataGrid()
        {
            MeetingsDG.ItemsSource = null;
            MeetingsDG.ItemsSource = DB_Connection.secretaryDBEntities.Meetings.ToList();
        }

        private void DeleteMeetingBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MeetingsDG.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить встречу?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var CurrentMeeting = MeetingsDG.SelectedItem as Meetings;
                    if (CurrentMeeting != null)
                    {
                        DB_Connection.secretaryDBEntities.Meetings.Remove(CurrentMeeting);
                        DB_Connection.secretaryDBEntities.SaveChanges();

                        MeetingsDG.ItemsSource = null;
                        MeetingsDG.ItemsSource = DB_Connection.secretaryDBEntities.Meetings.ToList();

                    }

                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни одной встречи", "Ошибка");
            }
            
        }

        private void EditMeetingBtn_Click(object sender, RoutedEventArgs e)
        {
            EditMeetingsWindow editMeetingsWindow = new EditMeetingsWindow();
            editMeetingsWindow.Show();
        }
    }
    }