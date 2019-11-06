using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Infomatica.Util;
using System.Data;
using System.Drawing.Printing;
using System.Data.OleDb;



namespace Adicion.View
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        DataTable RsImpresion;
        DataTable RsPropiedad;
        DataTable RsPropiedadCombo;
        double nSumaNeto;
        bool lcuentaCobrar;
        string xImpresionFE;
        double xTotalS;

        SqlConnection Cn;
        SqlCommand cmd;
        SqlDataReader reader;
        static String connectionString = @"Data Source=192.168.3.36;Initial Catalog=inforest9009;User ID=sa;Password=sistemas;";
        private int pais;

        public int Valor { get; private set; }

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
            //ViewVenta frm = new ViewVenta();
            //frm.ShowDialog();
            ImprimeBoletaElectronica();



        }
        private void ImprimeBoletaElectronica()
        {


            string sRazonSocial = "Infomatica SA";
            string sRazonComercial = "Infomatica Razon Comercial";
            string sDireccion = "av santa cruz n8 24";
            string sTelefono = "0125478995";
            string tSucursal = "Av los Laureles 123";
            string tSfc = "dwwds";
            bool estadoReimpresion = true;
            string sRUC = "105078911";
            string sLinea = "";
            string sFax = "224455165813";
            string sDireccion2 = "av santa cruz n8 20";
            string tCodigoFE = "999";
            ImpresionUtil Printer = new ImpresionUtil();
            try
            {
                //************************************* BOLIVIA********************
                //Printer.Print = sRazonSocial;
                //Printer.Print = sRazonComercial;

                ////tSucursal  = Calcular("select vs.tResumido as codigo from vsucursal vs inner join TCAJA tc on vs.Codigo = tc.tSucursal where tc.tCaja='" & sCaja & "'", Cn)
                //Printer.Print = "Surcusal N° " + (tSucursal == "0" ? "" : tSucursal);
                //Printer.Print = sDireccion;
                //Printer.Print = "Telefono: " + sTelefono; //DEBE IR IMPRIME CENTRO
                //Printer.Print = "SFC: "+ tSfc + "  dwwds";
                //if (estadoReimpresion == true)
                //{
                //    Printer.Print = "COMPROBANTE - COPIA";
                //    estadoReimpresion = false;
                //}
                //else
                //{
                //    Printer.Print = "COMPROBANTE - COPIA";
                //}

                //******************************** FIN DE BOLIVIA **********************

                // **************************PERU *************************************

                #region "IMPRESION PERU"

                Printer.Print = sRazonSocial;
                Printer.Print = sRazonComercial;

                switch (pais)
                {
                    case 003:
                        sLinea = ("C.U.I.T,: " + sRUC).PadLeft(40 - ("C.U.I.T.: " + sRUC).Trim().Length / 2, ' ');
                        break;
                    default:
                        sLinea = ("R.U.C.: " + sRUC).PadLeft(40 - ("R.U.C.: " + sRUC).Trim().Length / 2, ' ');
                        break;
                }
                Printer.Print = sLinea;
                Printer.Print = sDireccion2;

                if (sDireccion2.Trim() != "")
                {
                    Printer.Print = sDireccion2;
                }
                sLinea = ("Telefono: " + sTelefono).PadLeft(40 - ("Telefono: " + sTelefono).Trim().Length / 2, ' ');

                Printer.Print = sLinea;
                if (sFax != "")
                {
                    sLinea = ("Fax: " + sFax).PadLeft(40 - ("Fax: " + sFax).Trim().Length / 2, ' ');
                    Printer.Print = sLinea;
                }
                if (tCodigoFE != "999")
                {
                    Printer.Print = " ";
                    Printer.Print = "BOLETA DE VENTA ELECTRONICA";
                    Printer.Print = " ";
                }
                //Printer.Print Mid(RsImpresion!tDocumento, 1, 1) & "-" & Mid(RsImpresion!tDocumento, 2, 5) & "-" & Mid(RsImpresion!tDocumento, 7)
                string tDocumento = "F00010000058";
                ////Printer.Print = Mid(RsImpresion!tDocumento, 1, 1) +Mid(RsImpresion!tDocumento, 4, 3) + "-" + Mid(RsImpresion!tDocumento, 8, 8),40;
                //Printer.ImprimeXCentro(tDocumento.Substring(1, 1), 40);
                Printer.Print = tDocumento.Substring(1, 1) + tDocumento.Substring(4, 3) + tDocumento.Substring(8, 4);
                Printer.Print = " ";
                //Aca debe ir Impresion por Linea
                string Cliente = "alah";
                string xTipoIdentidad = "";
                bool lImpClienteCabDoc = true;
                if (lImpClienteCabDoc)
                {
                    Printer.Print = "-";
                    if (Cliente is null || Cliente.Trim().Length > 0)
                    {
                        Printer.Print = "Cliente: " + Cliente;
                    }
                }
                string rucclientefa = "999999999999";
                string direcCliente = "Los Angeles-California";
                xTipoIdentidad = "";
                //xTipoIdentidad = Calcular("select upper(tResumido) as Codigo from vTipoIdentidad inner join TCLIENTE on vTipoIdentidad.Codigo=tcliente.tTipoIdentidad" +
                // " where tcliente.tCodigoCliente= (select isnull(tCodigoCliente,'') as codigo From MDOCUMENTO where tDocumento='" + RsImpresion!tDocumento + "')", Cn);
                if (xTipoIdentidad == "0")
                {
                    xTipoIdentidad = "Iden.";
                }
                Printer.Print = xTipoIdentidad + "    : " + rucclientefa;
                Printer.Print = "Direcc.: " + direcCliente;
                //..
                bool lFEBiz = true;

                if (lFEBiz)
                {
                    string tUbigeo = "";
                    string sUbigeo = "";
                    //tUbigeo = Calcular("select top 1 isnull(tUbigeo,'') as Codigo from tcliente where tIdentidad='" + RsImpresion!Ruc + "'", Cn);
                    //sUbigeo = Calcular("select isnull(tdistrito+'-'+tprovincia+'-'+tDepartamento,'') as codigo from tubigeo where tcodigo='" + tUbigeo + "'", Cn);
                    Printer.Print = "Ubigeo : " + tUbigeo + " " + sUbigeo;
                }

                string CodigoPedido = "B006-00000006";
                string FechaRegistro = "11/06/2019 10:38:50";
                string TipoPedido = "En Local";
                string xUnidadNegocio = "Sin unidad Negocio";
                string tCaja = "002 - ADMIN";
                string tUsuario = "ADMIN";
                string Mozo = "Mayra";

                Printer.Print = "-";

                Printer.Print = "Pedido        : " + CodigoPedido;
                Printer.Print = "Fecha Emision : " + FechaRegistro;
                Printer.Print = "Tipo          : " + TipoPedido;
                Printer.Print = "Local         : " + xUnidadNegocio;
                Printer.Print = "Caja          : " + tCaja + " - " + tUsuario;
                Printer.Print = "Mesero        : " + (Mozo is null ? "" : Mozo);
                //ddd
                bool ImpDolarDelivery = true;
                string sMonedaE = "Soles";
                string sMonedaN = "";
                if (ImpDolarDelivery)
                {
                    Printer.Print = "Tipo Moneda   : " + sMonedaE;
                }
                else
                {
                    Printer.Print = "Tipo Moneda   : " + sMonedaN;
                }
                ////tipo de cambio
                //if (RsParametroTC!lVerTCImp == true ){
                //    Printer.Print "T/Cambio  : " + System.String.Format(nTC, "###,D0.00");
                //}
                ////-----------------------------------------------------------
                ///*
                string Mesa = "Salon Piso 1 - M08";
                //Printer.Print "Nro.Serie     : " & Calcular("select isnull(tSerieImpresora,'') codigo from MDOCUMENTO where tDocumento ='" & RsImpresion!tDocumento & "'", Cn)
                Printer.Print = "Mesa          : " + Mesa;
                bool lImprimeMotivoDescuentoFB = true;
                string MotivoDescuento = "";
                if (lImprimeMotivoDescuentoFB & MotivoDescuento != "")
                {
                    Printer.Print = "Descuento     : " + MotivoDescuento;
                }
                //ss
                bool lObservacionCabDoc = true;
                string tObservacion = "";
                if (lObservacionCabDoc)
                {
                    Printer.Print = "Observacion   : " + tObservacion;
                }
                Printer.Print = "";
                Printer.Print = "-";
                //ss
                bool lImpProdDesc = false;
                //bool lImpProdDesc = true;


                if (lImpProdDesc)
                {
                    Printer.Print = "Codigo      Cant. UM   P.Unit      Total";
                    Printer.Print = "Producto                          Dscto.";
                }
                else
                {
                    Printer.Print = "Producto         Cant. P.Unit      Total";
                }
                string Item = "";
                //Printer.Print "Producto         Cant. P.Unit      Total"
                //Printer.Print "Cantid. Producto                SubTotal"
                Printer.Print = "-";

                Item = "";
                //Cuerpo
                string ProductoDetallado = "";
                string xproducto = "";
                string Producto = "Margarita";
                bool ximprimeDetallado = true;
                bool prueba = true;
                while (prueba) //!RsImpresion.EOF -- RECORRER UN RECORSET
                {
                    if (ximprimeDetallado)
                    {
                        xproducto = Producto;
                    }
                    else
                    {
                        xproducto = ProductoDetallado;
                    }
                    prueba = false;
                }

                //if (Calcular("select isnull(treserva,'') as Codigo from mdocumento where tdocumento='" + RsImpresion!tDocumento + "'", Cn) != "")
                //{
                //    xproducto = xproducto + ": " + Calcular("select isnull(tobservacion,'') as codigo from dpedido where tcodigopedido='" + RsImpresion!tCodigoPedido + "' and titem='" + RsImpresion!tItem + "'", Cn);
                //}
                string tCodigoPedido = "";
                string tItem = "";
                bool lPropiedadDocumento = true;

                //hacer recorset
                if (Item != tCodigoPedido + tItem)
                {
                    //Impresion de Propiedades
                    if (lPropiedadDocumento)
                    {
                        //xRsPropiedad.Filter = "tCodigoPedido='" + tItem.Substring(1, 10) + tItem.Substring(11, 3);
                        //if (!xRsPropiedad.EOF)
                        //{
                        //    xRsPropiedad.MoveFirst;
                        //}
                    }
                    //while (!xRsPropiedad.EOF)
                    {
                        //Printer.Print "        * " & xRsPropiedad!Operador & " " & xRsPropiedad!Descripcion
                        ////ImprimeXLinea "        * " & xRsPropiedad!Operador & " " & xRsPropiedad!Descripcion, 40, 8
                        //Printer.Print "        * " + IIf(xRsPropiedad!nCantidad = 1, \", "(" + xRsPropiedad!nCantidad + ")") + xRsPropiedad!Operador + " " + xRsPropiedad!Descripcion, 31, 10;

                        //xRsPropiedad.MoveNext;
                    }
                }
                //Impresion de la Observacion
                string xObservacion = "";
                bool lObservacionDocumento = true;
                if (lObservacionDocumento & xObservacion.Trim().Length > 0)
                {
                    Printer.Print = "        - " + xObservacion.Trim();
                }
                string tOferta = "";

                if ((tOferta is null) | tOferta == "")
                {
                    //if (!(RsImpresion!lImpProdDesc) ){
                    //    CANT = Len(Trim(xproducto));
                    //    ProductoTem = xproducto;
                }
                //sss
                string ProductoTem = "";
                Double nCantidad = 1500;
                Double nPrecioOficial = 2330;
                bool nTC = true;
                if (Valor == 0)
                {
                    if (ImpDolarDelivery)
                    {
                        //sLinea = xproducto.PadRight(15, ' ').Substring(1, 15) + " " + String.Format(nCantidad.ToString(), "##0.00").PadRight(6, ' ').Substring(1, 6) + " " +
                            //String.Format(nPrecioOficial.ToString(), / nTC, "##0.00").PadRight(6, ' ').Substring(1, 6) + " " +
                            //String.Format((nCantidad * nPrecioOficial).ToString(), / nTC, "##,D0.00").PadRight(10, ' ').Substring(1, 10);

                    }
                    else
                    {
                        //    sLinea = Mid(xproducto + string(15, " "), 1, 15) + " " + Right(string(6, " ") + System.String.Format(RsImpresion!nCantidad, "##0.00"), 6) + " " + Right(string(6, " ") + System.String.Format(RsImpresion!nPrecioOficial, "##0.00"), 6) + " " + Right(string(10, " ") + System.String.Format(RsImpresion!nCantidad * RsImpresion!nPrecioOficial, "##,D0.00"), 10);
                        //}
                        //Valor = 1;
                        //CANT = Len(Mid(ProductoTem, 16));
                        //ProductoTem = ProductoTem.Substring( 1,16);
                        //Printer.Print  = sLinea;
                    }
                }






                    #endregion
                    //**************************FIN  DE PERU
                    Printer.Imprimir("");
            }
            catch (Exception ex)
            {
                throw;
            }
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
