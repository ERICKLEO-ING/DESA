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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlUtil sql = new SqlUtil();
            SqlConnection cn = new SqlConnection("server=sa ; password=sistemas ; database=base1 ; integrated security = true");
            cn.Open();
            MessageBox.Show("Se abrio conexion con el Sql Server Satisfactoriamente");
            cn.Close();
            MessageBox.Show("Se cerró la conexión.");




            //variables no definidas //
            //sUsuario = sVar1;
            //Nomb = sVar; 1
            Boolean wSalir;
            wSalir = false;
            Boolean wAgregaCombo;
            wAgregaCombo = false;
            Boolean wAgrega;
            wAgrega = false;
            Boolean wDetalle;
            wDetalle = true;
            string sComanda = "";
            string sMozoD = "";
            string sTurno = "MOZO";
            string sMozo = string.Empty;
            string lsql;
            string sCaja = string.Empty;
            string sMensaje;
            string vbCritical;
            string sAlmacenMDB = string.Empty;
            string descripcion;
            string codigo;
            string sLocal = string.Empty;
            Boolean lAlmacen = false;

            //txt NO USADO
            //txtMozo.Caption = sVar1;

            //frm no definida
            // frmCargoMozo.Caption = (" Caja : " + sCaja);
            //muestra = this.Caption;
            //if (MESA247)
            //{
            //    ActivaMesa247(true);
            //}
            //else
            //{
            //    ActivaMesa247(false);
            //}


            ////Comentario

            //CmdCabecera(10).Enabled = False
            //CmdCabecera(6).Caption = sBoton1;
            //CmdCabecera(7).Caption = sBoton2;
            //CmdCabecera(8).Caption = sBoton3;
            //CmdCabecera(14).Caption = sBoton4;
            //CmdCabecera(16).Caption = sBoton5;
            //CmdCabecera(6).Enabled = ((sBoton1 != "") ? true : false);
            //CmdCabecera(7).Enabled = ((sBoton2 != "") ? true : false);
            //CmdCabecera(8).Enabled = ((sBoton3 != "") ? true : false);
            //CmdCabecera(14).Enabled = ((sBoton4 != "") ? true : false);
            //CmdCabecera(16).Enabled = ((sBoton5 != "") ? true : false);

            //if (lBloqueaPrecuenta)
            //{
            //    cmdOpcion(4).Enabled = false;
            //}
            //else
            //{
            //    cmdOpcion(4).Enabled = true;
            //}

            Boolean lEnvioAutomatico = true;
            Boolean lsomelier = true;


            // Cabecera

            if (lsomelier)
            {
                lsql = ("SELECT * from vPedidoCabecera " + "where tEstadoPedido = \'01\' and tTurno = \'MOZO\' order by Codigo");
            }
            else
            {
                lsql = ("SELECT * from vPedidoCabecera " + ("where tEstadoPedido = \'01\' and tTurno = \'MOZO\' and tMozo=\'" + (sMozo + "\' order by Codigo")));
            }


            //RsCabecera

            if (lEnvioAutomatico)
            {
                lsql = ("SELECT * from vPedidoCabecera " + ("where tEstadoPedido = \'01\' and tCaja = \'" + (sCaja + "\' and FecProg is not null and isnull(nMinutosAntesEnvio,0) <> 0 order by Codigo")));
                //OpenRecordset(lsql, sql);
                //Timer.Enabled = True
                //Timer.Interval = 1000
            }


            //Origenes de Venta
            //this.fraorigenVentas.Visible = false;
            ////Origen de ventas
            //lsql = "select * from vOrigenVenta where Activo = 1 and visible = 1 Order by Boton";
            //lsql = "select * from vTipoPedido where Codigo = \'02\'";
            //RscanalOrigenVentas.OpenRecordset(lsql, cn);
            //AsignaBotonOrigenVentas;
            //19; 
            //,RsOrigenVentas; 
            //,this.cmdOrigen();
            ////-----------------------------------------------------
            ////----------------------------------


            //Detalle

            if (lsomelier)
            {
                lsql = "select * from vPedidoDetalle where tEstadoItem ='N' and tCodigoPedido in (select tCodigoPedido from MPEDIDO where tEstadoPedido='01' and tTurno = 'MOZO') ORDER BY tCodigoPedido, tItem";
            }
            else
            {
                lsql = "select * from vPedidoDetalle where tEstadoItem ='N' and tCodigoPedido in (select tCodigoPedido from MPEDIDO where tEstadoPedido='01' and tTurno = 'MOZO' and tMozo='" + sMozo + "') ORDER BY tCodigoPedido, tItem";
            }
            RsDetalle = sql.ConsultaSQL(lsql, "");

            lsql = "select * from vGrupo where lActivo = 1 order by nBoton";
            RsGrupo = sql.ConsultaSQL(lsql, "");

            //Continuacion del procedimiento del RsGrupo
            if ((RsGrupo.Rows.Count == 0))
            {
                MessageBox.Show("Error: Se necesita al menos un Grupo creado", "Alerta", MessageBoxButton.OK);


            }

            if ((lsql == "select * from vSubGrupo where lActivo = 1 Order by nBoton"))
            {

                RsSubgrupo = sql.ConsultaSQL(lsql, "");
                {
                    MessageBox.Show("Error: Se necesita al menos un SubGrupo creado");

                }

                OpenRecordset("[usp_Inforest_ObtieneProductos]", sql);
                // Set RsProducto = Lib.OpenRecordset(Isql, Cn)
                if ((RsProducto.Rows.Count == 0))
                {
                    MessageBox.Show("Error: Se necesita al menos un producto creado");
                    //vbCritical;
                    //sMensaje;
                    RsProducto = sql.ConsultaSQL(lsql, "Error: Se necesita al menos un producto creado");
                }

                if ((lsql == "select * from vMotorizado where lActivo = 1 Order by nBoton"))
                {
                    OpenRecordset(lsql, sql);
                    // Operador Correccion
                    ListarOperadoresConFiltro(sProducto);
                    // Propiedades
                    string xSql;
                    if (lAlmacen == true)
                    {
                        Recordset RsOp;
                        OpenRecordset("select Codigo, Descripcion from vOperador where lStockMenos=1", sql);
                        if ((RsOp.RecordCount > 0))
                        {
                            xSql = ("select tCodigoPropiedad as Codigo, TPROPIEDAD.tDetallado as Descripcion, tProducto, TOPERADOR.tOperad" + "or as tOperador, TOPERADOR.tDetallado as Operador, nPrecio, tEnlace, " + ("nInsumo, nGasto, nManoObra, ISNULL(tpropiedad.lsolicitacantidad,0) lsolicitacantidad  " + ("FROM dbo.TPROPIEDAD LEFT OUTER JOIN dbo.TOPERADOR ON dbo.TPROPIEDAD.tOperador = dbo.TOPERADOR.tOperad" +
                            "or " + ("Where TPROPIEDAD.lActivo = 1 And IsNull(TOPERADOR.lStockMenos, 0) <> 1 union " + ("select \'9999\' as Codigo, tDetallado as Descripcion, tCodigoPlato as tProducto, \'" + RsOp)))));
                            (codigo + ("\' as tOperador, \'" + RsOp));
                            (descripcion + ("\' as Operador, 0, "
                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tCodigoProducto as tEnlace, nCantidad * nPrecio as nInsumo, 0, 0,0 " + ("FROM ")
                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA INNER JOIN ")
                                        + (sAlmacenMDB + (".dbo.MRECETAVENTA ON ")
                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tLocal = ")
                                        + (sAlmacenMDB + (".dbo.MRECETAVENTA.tLocal AND ")
                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tRecetaVenta = ")
                                        + (sAlmacenMDB + (".dbo.MRECETAVENTA.tRecetaVenta INNER JOIN ")
                                        + (sAlmacenMDB + (".dbo.TPRODUCTO ON ")
                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tCodigoProducto = ")
                                        + (sAlmacenMDB + (".dbo.TPRODUCTO.tCodigoProducto " + ("Where lNoDescargo = 1 and ")
                                        + (sAlmacenMDB + (".dbo.DRECETAVENTA.tLocal=\'")
                                        + (sLocal + "\'")))))))))))))))))))))))))));
                        }
                        else
                        {
                            xSql = ("select tCodigoPropiedad as Codigo, TPROPIEDAD.tDetallado as Descripcion, tProducto, TPROPIEDAD.tOpera" +
                            "dor, nPrecio, tEnlace, " + ("nInsumo, nGasto, nManoObra, tOperador.tDetallado AS Operador, ISNULL(tpropiedad.lsolicitacantidad,0) " +
                            "lsolicitacantidad  " + ("FROM dbo.TPROPIEDAD LEFT OUTER JOIN dbo.TOPERADOR ON dbo.TPROPIEDAD.tOperador = dbo.TOPERADOR.tOperad" +
                            "or " + "Where TPROPIEDAD.lActivo = 1 And IsNull(TOPERADOR.lStockMenos, 0) <> 1")));
                        }

                    }
                    else
                    {
                        xSql = ("select tCodigoPropiedad as Codigo, TPROPIEDAD.tDetallado as Descripcion, tProducto, TPROPIEDAD.tOpera" +
                        "dor, nPrecio, tEnlace, " + ("nInsumo, nGasto, nManoObra, toperador.tDetallado AS Operador, ISNULL(tpropiedad.lsolicitacantidad,0) " +
                        "lsolicitacantidad  " + ("FROM dbo.TPROPIEDAD LEFT OUTER JOIN dbo.TOPERADOR ON dbo.TPROPIEDAD.tOperador = dbo.TOPERADOR.tOperad" +
                        "or " + "Where TPROPIEDAD.lActivo = 1 And IsNull(TOPERADOR.lStockMenos, 0) <> 1")));
                    }

                    OpenRecordset(("usp_Inforest_ObtienePropiedad \'"
                                    + (((lAlmacen == true) ? 1 : 0) + ("\',\'"
                                    + (sAlmacenMDB + ("\',\'"
                                    + (sLocal + "\'")))))), sql);
                    // Producto Propiedad
                    lsql = ("SELECT dbo.TPRODUCTOPROPIEDAD.tCodigoPedido, dbo.TPRODUCTOPROPIEDAD.tItem, dbo.TPRODUCTOPROPIEDAD.tCo" +
                    "digoPropiedad, dbo.TPRODUCTOPROPIEDAD.tProducto, t1.Descripcion AS Descripcion, Operador,isnull(tpro" +
                    "ductopropiedad.ncantidad,1) ncantidad " + (" FROM    dbo.TOPERADOR INNER JOIN dbo.TPRODUCTOPROPIEDAD INNER JOIN ("
                                + (xSql + (@")T1 ON dbo.TPRODUCTOPROPIEDAD.tCodigoPropiedad = T1.Codigo AND dbo.TPRODUCTOPROPIEDAD.tProducto = T1.tProducto AND dbo.TPRODUCTOPROPIEDAD.tEnlace = T1.tEnlace ON dbo.TOPERADOR.tOperador = T1.tOperador COLLATE Modern_Spanish_CI_AS LEFT OUTER JOIN dbo.TPROPIEDAD ON dbo.TOPERADOR.tOperador = dbo.TPROPIEDAD.tOperador AND dbo.TPRODUCTOPROPIEDAD.tCodigoPropiedad = dbo.TPROPIEDAD.tCodigoPropiedad AND dbo.TPRODUCTOPROPIEDAD.tProducto = dbo.TPROPIEDAD.tProducto " + " where tCodigoPedido in (select tCodigoPedido from MPEDIDO where tEstadoPedido=\'01\' and tTurno = \'MOZ" +
                                "O\' ) order by toperador.nboton "))));
                    OpenRecordset(lsql, sql);
                    // Combo Propiedad
                    lsql = ("SELECT dbo.TCOMBOPROPIEDAD.tCodigoPedido, dbo.TCOMBOPROPIEDAD.tItem, dbo.TCOMBOPROPIEDAD.tItemCombo, " +
                    "T1.Descripcion, T1.Operador, isnull(tcombopropiedad.ncantidad,1) ncantidad  " + (" FROM         dbo.TOPERADOR INNER JOIN dbo.TPROPIEDAD ON dbo.TOPERADOR.tOperador = dbo.TPROPIEDAD.tOp" +
                    "erador RIGHT OUTER JOIN dbo.TCOMBOPROPIEDAD INNER JOIN  ("
                                + (xSql + (@") T1 ON  dbo.TCOMBOPROPIEDAD.tCodigoPropiedad = T1.Codigo AND dbo.TCOMBOPROPIEDAD.tProducto = T1.tProducto AND                       dbo.TCOMBOPROPIEDAD.tEnlace = T1.tEnlace ON dbo.TOPERADOR.tOperador = T1.tOperador COLLATE Modern_Spanish_CI_AS AND dbo.TPROPIEDAD.tCodigoPropiedad = dbo.TCOMBOPROPIEDAD.tCodigoPropiedad AND dbo.TPROPIEDAD.tProducto = dbo.TCOMBOPROPIEDAD.tProducto  " + " where tCodigoPedido in (select tCodigoPedido from MPEDIDO where tEstadoPedido=\'01\' and tTurno = \'MOZ" +
                                "O\') order by toperador.nboton"))));
                    OpenRecordset(lsql, sql);
                    // Combos
                    // Isql = "SELECT dbo.TCOMBO.tCombo, dbo.TCOMBO.tCodigoProducto AS Codigo, dbo.TPRODUCTO.tResumido AS Descripcion " & _
                    ("FROM dbo.TCOMBO INNER JOIN dbo.TPRODUCTO ON dbo.TCOMBO.tCodigoProducto = dbo.TPRODUCTO.tCodigoProduct" +
                    "o " + "where lActivo=1");
                    OpenRecordset("usp_Inforest_ObtieneCombos", Cn);
                    // Motivo de Eliminacion
                    Isql = "select * from vMotivoEliminacion where lActivo = 1 order by Codigo";
                    OpenRecordset(Isql, Cn);
                    AsignaComando;
                    38;
                    RsMotivoEliminacion;
                    cmdEliminacion();
                    // Areas
                    OpenRecordset(("select * from vAreaImpresora where tCaja =\'"
                                    + (sCaja + "\'")), Cn);
                    // Canales de Venta
                    OpenRecordset("select * from vTipoPedido", Cn);
                    if (!(RsCanalesVenta.RecordCount > 0))
                    {
                        MsgBox;
                        "Debe tener configurado al menos un Canal de Venta";
                        (vbCritical + vbOKOnly);
                        sMensaje;
                        Unload;
                        this;
                    }

                    // Combo
                    Isql = ("SELECT * from vPedidoCombo " + ("WHERE tEstadoPedido=\'01\' " + "ORDER BY tCodigoPedido, tItemCombo"));
                    OpenRecordset(Isql, Cn);
                    // Configuraci�n de Grillas
                    ConfGrilla(3, grdCabecera, "Pax", 2, "nAdulto", 430, 0, 0, "", "Mesa", 2, "Mesa", 1000, 0, 0, "", "Observacion", 2, "tObservacion", 1200, 0, 0, "");
                    ConfGrilla(10, grdDetalle, "Or", 2, "nOrden", 300, 1, 0, "#0", "-", 2, "lCorte", 250, 0, 4, "", "Producto", 2, "Producto", 1820, 0, 0, "", "Precio", 2, "nPrecioVenta", 700, 1, 0, "###,###,##0.00", "Cant.", 2, "nCantidad", 590, 1, 0, "###0.00", "SubTotal", 2, "nVenta", 790, 1, 0, "###,###,##0.00", "F", 2, "tFacturado", 250, 0, 0, "", "E", 2, "lImprime", 250, 0, 4, "", "P", 2, "lPropiedad", 250, 0, 4, "", "O", 2, "lObservacion", 250, 0, 4, "");
                    ConfGrilla(7, grdCombo, "-", 2, "lCorte", 250, 0, 4, "", "Producto", 2, "Producto", 1950, 0, 0, "", "Cant.", 2, "nCantidad", 650, 1, 0, "#,##0.00", "E", 2, "lImprime", 250, 0, 4, "", "P", 2, "lPropiedad", 250, 0, 4, "", "O", 2, "lObservacion", 250, 0, 4, "", "Ord", 2, "nOrden", 400, 1, 0, "#0");
                    grdCabecera.DataSource = RsCabecera;
                    grdDetalle.DataSource = RsDetalle;
                    grdCombo.DataSource = RsCombo;
                    // Asignar Grupo
                    AsignaBoton;
                    5;
                    RsGrupo;
                    cmdGrupo();
                    RsGrupo.MoveFirst;
                    RsGrupo.Find;
                    ("Codigo=\'"
                                + (sGrupoDefault + "\'"));
                    if (RsGrupo.EOF)
                    {

                        RsGrupo = sql.ConsultaSQL(lsql, "");
                        {
                            MessageBox.Show("Error: Se necesita al menos un SubGrupo creado");

                        }

                    }

                    //    {
                    //        (!RsGrupo.EOF
                    //                    & RsGrupo);
                    //        (nBoton > 0);
                    //        cmdGrupo(RsGrupo, nBoton).backColor = vbBlue;
                    //    }
                    //else
                    //    {
                    //        RsGrupo.MoveFirst;
                    //        RsGrupo.Find;
                    //        ("nBoton=\'" + (Calcular("select min(nBoton) as Codigo FROM vGrupo where nBoton>0 and lActivo=1", Cn) + "\'"));
                    //        cmdGrupo(RsGrupo, nBoton).backColor = vbBlue;
                    //    }

                    //    xGrupo = RsGrupo;
                    //    codigo;
                    //    RsSubgrupo.Filter = ("tGrupo = \'"
                    //                + (xGrupo + "\'"));
                    //    AsignaBoton;
                    //    7;
                    //    RsSubgrupo;
                    //    cmdSubGrupo();
                    //    RsSubgrupo.MoveFirst;
                    //    RsSubgrupo.Find;
                    //    ("nBoton=\'" + (Calcular(("select min(nBoton) as Codigo FROM vSubGrupo where nBoton>0 and tGrupo = \'" + (xGrupo + "\' and lActivo=1")), Cn) + "\'"));

                    //    if ((RsSubgrupo.EOF || RsSubgrupo))
                    //    {
                    //        nBoton = 0;
                    //        MsgBox;
                    //        "Error: Se necesita configurar un SubGrupo con Boton";
                    //        vbCritical;
                    //        sMensaje;
                    //    }

                    //    if ((cmdSubGrupo(RsSubgrupo, nBoton).backColor == vbRed))
                    //    {
                    //        xSubGrupo = RsSubgrupo;
                    //        codigo;
                    //        RsProducto.Filter = ("tSubGrupo = \'"
                    //                    + (xSubGrupo + "\'"));
                    //        sTipoPedido = sTipoPedidoPD;
                    //        AsignaBotonProducto;
                    //        20;
                    //        RsProducto;
                    //        cmdProducto();
                    //        sTipoPedido;
                    //        sUnidadNegocio;
                    //        AsignaBoton;
                    //        19;
                    //        RsMotorizado;
                    //        cmdMotorizado();


                    //        Asigna Operador
                    //        AsignaBoton;
                    //        13;
                    //        RsOperador;
                    //        cmdOperador();
                    //        if ((RsOperador.RecordCount > 0))
                    //        {
                    //            RsOperador.MoveFirst;
                    //            if ((!IsNull(RsOperador, nBoton)
                    //                        && RsOperador))
                    //            {
                    //                (nBoton > 0);
                    //                cmdOperador_Click(RsOperador, nBoton);
                    //            }

                    //        }

                    //        fraCabecera.Visible = false;
                    //        fraPlato.Visible = false;
                    //        fraPropiedad.Visible = false;
                    //        fraEliminacion.Visible = false;
                    //        ActivaFrame;
                    //        fraPlato;
                    //        wDetalle = true;
                    //        wAgrega = false;
                    //        wAgregaCombo = false;
                    //        lPropiedad = false;
                    //        if ((RsCabecera.RecordCount == 0))
                    //        {
                    //            sPedido = "";
                    //            LimpiaCabecera;
                    //        }
                    //        else
                    //        {
                    //            RsCabecera.MoveFirst;
                    //            sPedido = RsCabecera;
                    //            codigo;
                    //            ActivaFrame;
                    //            fraPlato;
                    //        }


                    //        nuevoo
                    //        if (!lInfhotel)
                    //        {
                    //            fraPuntoVenta.Visible = false;
                    //            txtPuntoVenta.Visible = false;
                    //        }
                    //        else
                    //        {


                    //            Punto de Venta
                    //           lsql = ("Select tPuntoVenta as Codigo, tDescripcion as Descripcion, nUltimoComanda, tmoneda" + (" From tPuntoVenta " + (" where tHotel=\'"
                    //                       + (sHotel + "\' AND lActivo=1 and lInforest=1"))));
                    //            OpenRecordset(lsql, CnInfhotel);
                    //            if ((rsPuntoVenta.RecordCount == 0))
                    //            {

                    //                RsPuntoVenta = sql.ConsultaSQL(lsql, "");
                    //                {
                    //                    MessageBox.Show("Error: Se necesita al menos un SubGrupo creado");

                    //                }

                    //            }

                    //    ((int)(i));
                    //    for (i = 10; (i <= 19); i++)
                    //    {
                    //        cmdMotorizado(i).Visible = false;
                    //    }

                    //    txtFechaProg.Visible = false;
                    //    txtPuntoVenta.Visible = true;
                    //    Label1(25).Caption = "Pto. Venta :";
                    //    cmdBuscar(4).Top = 1050;
                    //    fraMotorizado.Top = 3105;
                    //    fraMotorizado.Height = 1865;
                    //    AsignaBoton;
                    //    9;
                    //    RsMotorizado;
                    //    cmdMotorizado();
                    //    AsignaComando;
                    //    9;
                    //    rsPuntoVenta;
                    //    cmdPunto();
                    //}


                    ////cover pedido 
                    //If lcover Then
                    //        cmdCabecera(21).Visible = true;
                    //ActivaMesa247(true);
                    //lblmoneda.Caption = sMonN;
                    //lblFecha.Caption = Format(FechaServidor(), "dddd, dd MMMM yyyy");
                    //Screen.MousePointer = vbDefault;
                }
            }
        }
    }
}




