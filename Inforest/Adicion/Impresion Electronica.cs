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
namespace Adicion
{
    public class Impresion_Electronica
    {
        private int pais;

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
                //if (sFax != "")
                //{
                //    sLinea = ("Fax: " + sFax).PadLeft - 40("Fax:" + sFax).Trim().Length / 2, ' ');
                //    Printer.Print sLinea;
                //}
                //if (tCodigoFE != "999")
                //{
                //    Printer.Print = " ";
                //    Printer.Print = "BOLETA DE VENTA ELECTRONICA";
                //    Printer.Print = " ";
                //}
                #endregion
                //**************************FIN  DE PERU
                Printer.Imprimir("");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}