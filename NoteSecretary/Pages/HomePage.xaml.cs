using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication;
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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {

            InitializeComponent();
            DateTime now = DateTime.Now;
            TodayDateTimeTB.Text = now.ToString("g");
            DB_Connection.secretaryDBEntities.User.ToList();
            NameTB.Text = DB_Connection.secretaryDBEntities.User.First().Name;
            
        }
    }
}
