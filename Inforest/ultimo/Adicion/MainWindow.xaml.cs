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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Mail;
using Adicion.View;
namespace Adicion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private async void BtnCorreo_Click(object sender, RoutedEventArgs e)
        //{
        //    //MailMessage _MAIL = new MailMessage();
        //    //MailAddress _Addres = new MailAddress("edelacruz@infomatica.pe");
        //    //_MAIL.To.Add("erickdlcq@gmail.com");
        //    //_MAIL.From = _Addres;
        //    //_MAIL.Subject = "Prueba de asincrono";
        //    //_MAIL.Body = "Hola asincrono";

        //    //CorreoUtil Correo = new CorreoUtil();
        //    //Correo.EnviarCorreo("erickdlcq@gmail.com", "Prueba", "Hola Mundo");

        //    //await Correo.EnviarCorreoAsync(_MAIL);
        //}

        //private void BtnImprimir_Click(object sender, RoutedEventArgs e)
        //{
        //    //ImpresionUtil Printer= new ImpresionUtil();
        //    //Printer.Print = "Hola Mundo";
        //    //Printer.Print = "----------------------------------" ;
        //    //Printer.Print = "Producto   Cantidad     Pedido    " ;
        //    //Printer.Print = "----------------------------------" ;
        //    //Printer.Imprimir("");

        //    //Teclado _Teclado = new Teclado(txtprueba,this);
        //    //_Teclado.ShowDialog();
        //}
    }
}
