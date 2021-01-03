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

namespace Kantin_Amikom
{
	/// <summary>
	/// Interaction logic for Daftar.xaml
	/// </summary>
	public partial class Daftar : Window
	{
		public Daftar()
		{
			InitializeComponent();
		}
		public void Button_Click(object sender, RoutedEventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source=DESKTOP-TB88EJL;Initial Catalog=Kantin_Amikom;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("Insert into tblogin values(@Username, @Password)", con);
			cmd.Parameters.AddWithValue("@Username", uname.Text);
			cmd.Parameters.AddWithValue("@Password", pass.Text);
			con.Open();
			cmd.ExecuteNonQuery();
			MessageBox.Show("Akun berhasil dibuat"); 
			con.Close();
			
		}

		public void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MainWindow kembali = new MainWindow();
			kembali.Show();
		}
	}
}
