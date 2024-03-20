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
    /// Логика взаимодействия для AddDoListWindow.xaml
    /// </summary>
    public partial class AddDoListWindow : Window
    {
        public AddDoListWindow()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DoList doList = new DoList()
                {
                    Name = NameTB.Text.ToString(),
                    Description = DescriptionTB.Text.ToString()
                };

                DB_Connection.secretaryDBEntities.DoList.Add(doList);
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
