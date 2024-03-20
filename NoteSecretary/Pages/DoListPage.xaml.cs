using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для DoListPage.xaml
    /// </summary>
    
    public partial class DoListPage : Page
    {
        public DoListPage()
        {
            InitializeComponent();
            DoListDG.ItemsSource = DB_Connection.secretaryDBEntities.DoList.ToList();
        }

        private void AddDoBtn_Click(object sender, RoutedEventArgs e)
        {
            AddDoListWindow addDoListWindow = new AddDoListWindow();
            addDoListWindow.Show();
        }

        private void DeleteDoBtn_Click(object sender, RoutedEventArgs e)
        {
            if(DoListDG.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить задачу?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var CurrentDo = DoListDG.SelectedItem as DoList;
                    if (CurrentDo != null)
                    {
                        DB_Connection.secretaryDBEntities.DoList.Remove(CurrentDo);
                        DB_Connection.secretaryDBEntities.SaveChanges();

                        DoListDG.ItemsSource = null;
                        DoListDG.ItemsSource = DB_Connection.secretaryDBEntities.DoList.ToList();

                    }

                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни одной задачи", "Ошибка");
            }
            
        }
    }
}
