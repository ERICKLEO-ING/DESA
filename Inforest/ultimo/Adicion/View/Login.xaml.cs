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
using Adicion.View;
using System.Data.SqlClient;



namespace Adicion.View
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        static String connectionString = @"Data Source=192.168.3.36;Initial Catalog=inforest9009;User ID=sa;Password=sistemas;";

        public Login()
        {
            InitializeComponent();
        }
        

        private void CmdSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxtPassword_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Teclado FRM = new Teclado(txtPassword, this);
            FRM.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewVenta frm = new ViewVenta();
            frm.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //string pass = txtPassword.Password;
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = "SELECT * FROM tusuario where pwd='" + txtPassword.Password + "'";
            //reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    MessageBox.Show("Login sucess Welcome to Homepage ");
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Login please check username and password");
            //}
            //con.Close();
        }   

    } 
}
