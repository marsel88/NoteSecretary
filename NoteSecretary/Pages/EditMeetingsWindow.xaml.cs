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
    /// Логика взаимодействия для EditMeetingsWindow.xaml
    /// </summary>
    public partial class EditMeetingsWindow : Window
    {
        public EditMeetingsWindow()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClientsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
