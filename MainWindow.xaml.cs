using System;
using System.Collections.Generic;
using System.Data;
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

namespace Kantin_Amikom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TB88EJL;Initial Catalog=Kantin_Amikom;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from tblogin where Username= '" + username.Text + "' and Password ='" + password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah", "Perhatian!", MessageBoxButton.OK);
            }

        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Daftar daftar = new Daftar();
            daftar.Show();
            
        }
    }
}
