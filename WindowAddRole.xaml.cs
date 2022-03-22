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
using System.Windows.Shapes;

namespace crud
{
    /// <summary>
    /// Interaction logic for WindowAddRole.xaml
    /// </summary>
    public partial class WindowAddRole : Window
    {
        public WindowAddRole()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.mode == 1)
            {
                string id_actor = textBox.Text;
                string id_movie = textBox1.Text;
                string role = textBox2.Text;
                button.Content = "Добавить";
                DataProvider dp = new DataProvider();
                SqlCommand cmd = new SqlCommand(String.Format("select * from roles where id_movie = {0} and id_actor = {1}", id_movie, id_actor), dp.Connection);
                var check = cmd.ExecuteScalar();
                if (check != null)
                {
                    MessageBox.Show("Уже есть в бд");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand(String.Format("insert into roles values ({0},{1},'{2}')", id_actor, id_movie, role), dp.Connection);
                    cmd1.ExecuteNonQuery();
                }
            }
            if (MainWindow.mode == 2)
            {
                RolesVM rolevm = RolesListVM._selectedRole;
                string id_actor = (rolevm._role.Id_actor).ToString();
                string id_movie = (rolevm._role.Id_movie).ToString();
                string role = rolevm.Name;
                button.Content = "Изменить";
                DataProvider dp = new DataProvider();
                SqlCommand cmd = new SqlCommand(String.Format("update roles set id_movie = {1}, id_actor = {0}, name = '{2}' where id_movie = {3} and id_actor = {4}",
                textBox.Text, textBox1.Text, textBox2.Text, id_movie, id_actor), dp.Connection);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
 
            
        }
    }
}
