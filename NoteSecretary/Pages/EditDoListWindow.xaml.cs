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
    /// Логика взаимодействия для EditDoListWindow.xaml
    /// </summary>
    public partial class EditDoListWindow : Window
    {
        public EditDoListWindow()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
