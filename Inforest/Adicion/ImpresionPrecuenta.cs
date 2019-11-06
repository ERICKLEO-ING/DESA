using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adicion
{
    public class ImpresionPrecuenta
    {
        //        using System;
        //using System.Collections.Generic;
        //using System.Linq;
        //using System.Text;
        //using System.Threading.Tasks;
        //using System.Windows;
        //using System.Windows.Controls;
        //using System.Windows.Data;
        //using System.Windows.Documents;
        //using System.Windows.Input;
        //using System.Windows.Media;
        //using System.Windows.Media.Imaging;
        //using System.Windows.Shapes;
        //using Adicion.View;
        //using System.Data.SqlClient;
        //using Infomatica.Util;
        //using System.Data;
        //using System.Drawing.Printing;
        //using System.Globalization;

        //namespace Adicion.View
        //    {
        //        /// <summary>
        //        /// Lógica de interacción para Login.xaml
        //        /// </summary>
        //        public partial class Login : Window
        //        {
        //            SqlConnection con;
        //            SqlCommand cmd;
        //            SqlDataReader reader;
        //            static String connectionString = @"Data Source=192.168.3.36;Initial Catalog=inforest9009;User ID=sa;Password=sistemas;";


        //            public Login()
        //            {
        //                InitializeComponent();
        //            }


        //            private void CmdSalir_Click(object sender, RoutedEventArgs e)
        //            {
        //                this.Close();
        //            }

        //            private void TxtPassword_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //            {
        //                //Teclado FRM = new Teclado(txtPassword, this);
        //                //FRM.ShowDialog();
        //            }

        //            private void Button_Click(object sender, RoutedEventArgs e)
        //            {
        //                //ViewVenta frm = new ViewVenta();
        //                //frm.ShowDialog();
        //                ImpresionUtil Printer = new ImpresionUtil();
        //                Printer.Print = "Pedido         : 19000000001 ";
        //                Printer.Print = "Fecha Emision  :";
        //                Printer.Print = "Tipo           : Local";
        //                Printer.Print = "Local          : SIN UNIDAD NEGOCIO";
        //                Printer.Print = "Caja           : 002 - ADMIN";
        //                Printer.Print = "Mesero         : ADMIN";
        //                Printer.Print = "Tipo Moneda    : Soles";
        //                Printer.Print = "Mesa           : Salon 1 Piso 1 - M08";
        //                Printer.Print = "--------------------------------------------";
        //                Printer.Print = "Producto           Cant. P.Unit        Total";
        //                Printer.Print = "--------------------------------------------";

        //                Printer.Imprimir("");

        //                Infomatica.Util.ImpresionUtil d = new ImpresionUtil();

        //            }

        //            private void Window_Loaded(object sender, RoutedEventArgs e)
        //            {

        //                //string pass = txtPassword.Password;
        //                //cmd = new SqlCommand();
        //                //con.Open();
        //                //cmd.Connection = con;
        //                //cmd.CommandText = "SELECT * FROM tusuario where pwd='" + txtPassword.Password + "'";
        //                //reader = cmd.ExecuteReader();
        //                //if (reader.Read())
        //                //{
        //                //    MessageBox.Show("Login sucess Welcome to Homepage ");
        //                //}
        //                //else
        //                //{
        //                //    MessageBox.Show("Invalid Login please check username and password");
        //                //}
        //                //con.Close();
        //            }
        //            private void imprimeprecuenta()
        //            {

        //                ImpresionUtil Printer = new ImpresionUtil();
        //                try
        //                {
        //                    string Item;
        //                    string xObservacion;
        //                    string sLinea;
        //                    double zSubTotal;
        //                    double zImpuesto1;
        //                    double zImpuesto2;
        //                    double zImpuesto3;
        //                    double zTotal;
        //                    double zDescuento;
        //                    double zRecargo;
        //                    string txt;
        //                    DataTable xRsPropiedad;
        //                    DataTable xRsPropiedadCombo;
        //                    DataTable rsImpresion;
        //                    double zGTotal;
        //                    // ---CESAR IMP
        //                    double imp1;
        //                    double imp2;
        //                    double impxT;
        //                    double impx1;
        //                    double impx2;
        //                    double impG;
        //                    double xDescuento;
        //                    double xRecargo;
        //                    double xSubTotal;
        //                    double xDiferencia;
        //                    double xAumento;
        //                    string sCaja;

        //                    int Y;
        //                    Y = 0;
        //                    //Y = Calcular(("select case when lCanalCentralPedidos=1 then 1 else 0 end codigo from  vTipoPedido where Codigo=\'" + RsImpresion), (tTipoPedido + "\'"), con);
        //                    string xClienteImp;
        //                    string xTelefonoImp;
        //                    string xDireccionImp;

        //                    //NO FUNCIONA CALCULAR.
        //                    //xClienteImp = Calcular(("select isnull(tclientedelivery,\'\') codigo from mpedido where tcodigopedido=\'" + RsImpresion), (codigo + "\'"), con);
        //                    //xTelefonoImp = Calcular(("select isnull(ttelefono,\'\') codigo from tdelivery where tcodigodelivery=\'"
        //                    //                + (xClienteImp + "\'")), con);
        //                    //xDireccionImp = Calcular(("select isnull(tDireccion,\'\') codigo from tdelivery where tcodigodelivery=\'"
        //                    //                + (xClienteImp + "\'")), con);

        //                    //imp1 = calcular("select ISNULL(Impuesto1,0) as Codigo from TPARAMETRO", con);
        //                    //imp2 = calcular("select ISNULL(Impuesto2,0) as Codigo from TPARAMETRO", con);
        //                    //impxT = (1
        //                    //            + ((imp1 / 100)
        //                    //            + (imp2 / 100)));
        //                    //impx1 = (1
        //                    //            + (imp1 / 100));
        //                    //impx2 = (1
        //                    //            + (imp2 / 100));
        //                    //lPrecioNetoPrecuenta = calcular(("select ISNULL(lPrecioNetoPrecuenta,0) as Codigo from TCAJA where tCaja = \'"
        //                    //                + (sCaja + "\' ")), con);
        //                    //// -------------------------

        //                    // MARZO 2011
        //                    string xSql;
        //                    if (lAlmacen)
        //                    {
        //                        Recordset RsOp;
        //                        OpenRecordset("select Codigo, Descripcion from vOperador where lStockMenos=1", Cn);
        //                        if ((RsOp.RecordCount > 0))
        //                        {
        //                            xSql = ("select tCodigoPropiedad as Codigo, TPROPIEDAD.tDetallado as Descripcion, tProducto, TOPERADOR.tOperad" +
        //                            "or as tOperador, TOPERADOR.tDetallado as Operador, nPrecio, tEnlace, " + ("nInsumo, nGasto, nManoObra " + ("FROM dbo.TPROPIEDAD LEFT OUTER JOIN dbo.TOPERADOR ON dbo.TPROPIEDAD.tOperador = dbo.TOPERADOR.tOperad" +
        //                            "or " + ("Where TPROPIEDAD.lActivo = 1 And IsNull(TOPERADOR.lStockMenos, 0) <> 1 union " + ("select \'9999\' as Codigo, tDetallado as Descripcion, tCodigoPlato as tProducto, \'" + RsOp)))));
        //                            (codigo + ("\' as tOperador, \'" + RsOp));
        //                            (Descripcion + ("\' as Operador, 0, "
        //                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tCodigoProducto as tEnlace, nCantidad * nPrecio as nInsumo, 0, 0 " + ("FROM "
        //                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA INNER JOIN "
        //                                        + (sAlmacenMDB + (".dbo.MRECETAVENTA ON "
        //                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tLocal = "
        //                                        + (sAlmacenMDB + (".dbo.MRECETAVENTA.tLocal AND "
        //                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tRecetaVenta = "
        //                                        + (sAlmacenMDB + (".dbo.MRECETAVENTA.tRecetaVenta INNER JOIN "
        //                                        + (sAlmacenMDB + (".dbo.TPRODUCTO ON "
        //                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tCodigoProducto = "
        //                                        + (sAlmacenMDB + (".dbo.TPRODUCTO.tCodigoProducto " + ("Where lNoDescargo = 1 and "
        //                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tLocal=\'"
        //                                        + (sLocal + "\'")))))))))))))))))))))))))));
        //                        }
        //                        else
        //                        {
        //                            xSql = ("select tCodigoPropiedad as Codigo, TPROPIEDAD.tDetallado as Descripcion, tProducto, TPROPIEDAD.tOpera" +
        //                            "dor, nPrecio, tEnlace, " + ("nInsumo, nGasto, nManoObra, tOperador.tDetallado AS Operador " + ("FROM dbo.TPROPIEDAD LEFT OUTER JOIN dbo.TOPERADOR ON dbo.TPROPIEDAD.tOperador = dbo.TOPERADOR.tOperad" +
        //                            "or " + "Where TPROPIEDAD.lActivo = 1 And IsNull(TOPERADOR.lStockMenos, 0) <> 1")));
        //                        }



        //                        string sRazonSocial = "infomatica";
        //                        string sRazonComercial = "infomatica razon comercial";
        //                        string sDireccion = "direccion 1";
        //                        string sDireccion2 = "direccion 2";



        //                        // 'Cabecera
        //                        Printer.Print = sRazonSocial;
        //                        Printer.Print = sRazonComercial;


        //                        //case pais
        //                        //    Case "001" 'Bolivia
        //                        //        sLinea = String((40 - Len(Trim("N.I.T.: " + sRUC))) / 2, " ") & "N.I.T.: " + sRUC
        //                        //    Case Else 'Peru, Ecuador
        //                        //        sLinea = String((40 - Len(Trim("R.U.C.: " + sRUC))) / 2, " ") & "R.U.C.: " + sRUC
        //                        //End Select


        //                        //Printer.Print sLinea
        //                        Printer.Print = sDireccion;
        //                        if (sDireccion2 != "")
        //                        {
        //                            Printer.Print = sDireccion2;
        //                        }

        //                        Printer.Imprimir("");
        //                    }
        //                }
        //                catch (Exception)
        //                {

        //                    throw;
        //                }
        //            }
        //            private void Button_Click_1(object sender, RoutedEventArgs e)
        //            {
        //                imprimeprecuenta();
        //            }
        //        }
        //    }
    }
}
