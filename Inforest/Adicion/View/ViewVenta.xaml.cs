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
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using Infomatica.Util;

namespace Adicion.View
{
    // <summary>
    // Lógica de interacción para ViewVenta.xaml
    // </summary>
    public partial class ViewVenta : Window
    {
        DataTable RsCabecera = new DataTable();
        DataTable RsDetalle = new DataTable();
        DataTable RsCombo = new DataTable();
        DataTable RsImpresion = new DataTable();
        DataTable RsProducto = new DataTable();
        DataTable RsMotorizado = new DataTable();
        DataTable RsArea = new DataTable();
        DataTable RsPropiedad = new DataTable();
        DataTable RsT3 = new DataTable();
        DataTable RsOferta = new DataTable();
        DataTable RsMotivoEliminacion = new DataTable();
        DataTable RsProductoPropiedad = new DataTable();
        DataTable RsComboPropiedad = new DataTable();
        DataTable RsOperador = new DataTable();
        DataTable RProductoCombo = new DataTable();
        DataTable RsCanalesVenta = new DataTable();
        DataTable RsPuntoVenta = new DataTable();
        DataTable RsGrupo = new DataTable();
        DataTable RsPedido = new DataTable(); //-- MESA247
        int contadormesa; //-- refresar
        DataTable RsSubgrupo = new DataTable();



        //Variables Generales

        Boolean wDetalle;
        Boolean wAgrega;

        //entregarA
        Boolean wCombo;
        Boolean wAgregaCombo;
        int nCombo;
        double nCCombo;

        //VARIABLE COLOR MESA 247
        //int mesacolor

        //origen de ventas 
        DataTable RscanalOrigenVentas = new DataTable();
        string vOrigenVentas;
        DataTable RsOrigenVentas = new DataTable();
        Boolean lOrigenventas;

        //Variable Cabecera
        string sTipoPedido;
        string sTipoAtencion;
        string sMotorizado;
        string sCortesa;
        string sFechaProg;
        long nCorrela;
        double xMontoMaximo;
        //int ntTiempo
        string sDetalleConsumo;
        public Boolean lIncluido;
        string sUsuarioAutoriza;
        Boolean wCabecera;

        string sPuntoVenta;

        //Variables Detalles 
        double nPVenta;
        double nPBase;
        double nImpuesto1;
        double nImpuesto2;
        double nImpuesto3;
        double nRecargo;
        double nDescuento;
        double nOficial;
        double nCantidad;
        string sitem;
        string xItem;
        string sProducto;
        string sProductoCombo;
        string sCombo;
        string sGrupo;
        string xGrupo;
        string sSubGrupo;
        string xSubGrupo;
        string sTD;
        double xSuma;
        double xLinea;
        double xConsumo;
        Boolean lPrecuenta;
        string sMozoD;
        Boolean wSalir;


        double xDescuento;
        double sDescuento;
        double Acumulado;
        string sCodigoDescuento;
        string sDescripcionDescuento;
        Boolean wCalcula;
        string tAutorizaDescuento;
        int nOrden;
        int nOperdadorPropiedad;

        //===================== tope
        Boolean lRatio;
        Boolean ltope;
        double nTope;
        Boolean procedeDescuento;
        string codigoanteriordescuento;
        double montoanteriorDescuento;

        //insumo critico23
        string muestra;

        //Canales de Venta
        Boolean lActivaMozo;
        Boolean lActivaMotorizado;
        Boolean lObligaMesa;
        Boolean lObligaMotorizado;
        Boolean lObligaMozo;
        Boolean lObligaFechaEntrega;
        Boolean lObligaClienteFrecuente;
        Boolean lCanalDelivery;
        Boolean lCanalCentralPedidos;

        //MODIFICAR DESCUENTO
        string sAutoriza;

        //auditoria
        string tNombreMozo;

        //invitado2013
        DataTable RsTemporal = new DataTable();
        //invitado2013




        public ViewVenta()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}




