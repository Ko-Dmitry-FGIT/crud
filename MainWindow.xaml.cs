using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace crud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int mode = 0;
        public MainWindow()
        {
            DataContext = new ApplicationVM();
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            WindowAddRole Window1 = new WindowAddRole();
            mode = 1;
            Window1.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            WindowAddRole Window1 = new WindowAddRole();
            mode = 2;
            Window1.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            RolesVM rolevm = RolesListVM._selectedRole;
            string id_actor = (rolevm._role.Id_actor).ToString();
            string id_movie = (rolevm._role.Id_movie).ToString();
            DataProvider dp = new DataProvider();
            SqlCommand cmd = new SqlCommand(String.Format("delete from roles where id_movie = {1} and id_actor = {0}", id_actor, id_movie), dp.Connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ApplicationVM();

        }
    }
}
