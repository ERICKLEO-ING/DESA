using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Infomatica.Restaurante.Model
{
    public class VG
    {
        //public IDbConnection CnInforest { get; set; }
        //public IDbConnection CnAlmacen { get; set; }


        //Desclaraciones Temporales
        public string sMensaje { get; set; } = "Mensaje Inforest";

        //        //Declaración de Biblioteca del Windows
        //        public void Sleep Lib "kernel32" (long dwMilliseconds) {
        //public long DeleteFile Lib "kernel32" "DeleteFileA" (string lpFileName) {
        //public long GetPrivateProfileString Lib "kernel32" "GetPrivateProfileStringA" (string lpApplicationName, Any lpKeyName, string lpDefault, string lpReturnedString, long nSize, string lpFileName) {
        //public long WritePrivateProfileString Lib "kernel32" "WritePrivateProfileStringA" (string lpApplicationName, Any lpKeyName, Any lpString, string lpFileName) {

        //public object OpenFile% Lib "kernel32" (object lpFileName$, OFSTRUCT lpReOpenBuff, object wStyle%) {
        //public long SHFileOperation Lib "shell32.dll" "SHFileOperationA" (SHFILEOPSTRUCT lpFileOp) {

        //Declaración de Variables de Conneccion
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Inforest\Data\inforest.mdb;Persist Security Info=False


        //Type OFSTRUCT; //136 bytes in length
        //        string* 1 cBytes;
        //    string* 1 fFixedDisk;
        //    int nErrCode;
        //        string* 4 Reserved;
        //    string* 128 szPathName;
        //End Type;

        //        Type SHFILEOPSTRUCT;
        //        long hwnd;
        //        long wFunc;
        //        string pFrom;
        //        string pTo;
        //        long fFlags;
        //        bool fAnyOperationsAborted;
        //        long hNameMappings;
        //        string lpszProgressTitle;
        //        End Type;

        //public enum eFO
        //{
        //    FO_COPY = 0x2L,
        //    FOF_NOCONFIRMATION = 0x10L,
        //    FOF_NOCONFIRMMKDIR = 0x200L
        //};

        public string tenlacebusqueda { get; set; }
        public string tenlacebusquedaVenta { get; set; } //-- BUSQUEDA DE DATOS EN FORMULARIO VENTA , CAJA RAPIDA Y ADICION
        //public Libreria16.Applications Lib { get; set; }
        public static SqlConnection CnInforest { get; set; }
        public IDbConnection CnAlmacen { get; set; }
        public IDbConnection CnDBF { get; set; }
        public IDbConnection CnInfhotel { get; set; }
        public string sUserName { get; set; }
        public string sUserPassword { get; set; }
        public string sLocal { get; set; }
        //consulta integrada
        public IDataAdapter rsListaServidores { get; set; }

        //Declaracion de Variables Publicas
        //Parametros Generales
        public string sCliente { get; set; }
        public string sRazonSocial { get; set; }
        public string sRazonComercial { get; set; }
        public string sDireccion { get; set; }
        public string sDireccion2 { get; set; }
        public string sMail { get; set; }
        public string sWeb { get; set; }
        public string sTelefono { get; set; }
        public string sFax { get; set; }
        public string sRUC { get; set; }
        public string sMonN { get; set; }
        public string sMonedaN { get; set; }
        public string sMonE { get; set; }
        public string sMonE2 { get; set; }
        public string sMonE3 { get; set; }

        public string sMonedaE { get; set; }
        public string sMonedaE2 { get; set; }
        public string sMonedaE3 { get; set; }
        public double nDELIVERY { get; set; }
        public double nLlevar { get; set; }
        public double nCanal4 { get; set; }
        public double nCanal5 { get; set; }
        public string sImpuesto1 { get; set; }
        public string sImpuesto2 { get; set; }
        public string sImpuesto3 { get; set; }
        public double nPorcentaje1 { get; set; }
        public double nPorcentaje2 { get; set; }
        public double nPorcentaje3 { get; set; }
        public string sPie { get; set; }
        public string sPiePreCuenta { get; set; }
        public string sPAdmin { get; set; }
        public string sElimina { get; set; }
        public int nTiempo { get; set; }
        public int nFItem { get; set; }
        public int nCabecera { get; set; }
        public int nDetalle { get; set; }
        public int nFItemGuia { get; set; }
        public int nCabeceraGuia { get; set; }
        public int nDetalleGuia { get; set; }
        public int nChkTiempo { get; set; }
        public string sComanda { get; set; }
        public bool sResumen { get; set; }
        public string sEmpresa { get; set; }
        public string sUltimo { get; set; }
        public string sBoton1 { get; set; }
        public string sBoton2 { get; set; }
        public string sBoton3 { get; set; }
        public string sBoton4 { get; set; }
        public string sBoton5 { get; set; }
        public int nLongitud { get; set; }
        public bool lLongitud { get; set; }
        public bool lPrinter { get; set; }
        public bool lRapido { get; set; }
        public bool lInfhotel { get; set; }
        public string sClub { get; set; }
        public double nPunto { get; set; }
        public int nDecimal { get; set; }
        public int nDias { get; set; }
        public int nDiasDelivery { get; set; }
        public int nPuerto { get; set; }
        //Public nPuerto As Integer

        public string nBalanzaComando { get; set; }
        public int nBalanzaPuerto { get; set; }
        public long nBalanzaBS { get; set; }
        public long nBalanzaBD { get; set; }
        public string nBalanzaParidad { get; set; }
        public long nBalanzaBP { get; set; }
        public string nBalanzaCF { get; set; }
        public int lBalTiempo { get; set; }
        public bool lBal { get; set; }

        public string tMensaje1 { get; set; }
        public string tMensaje2 { get; set; }
        public bool lEquivalencia { get; set; }
        public bool lSomelier { get; set; }
        public bool lComboGeneral { get; set; }
        public int nTiempoDelivery { get; set; }
        public bool lObligaPax { get; set; }
        public DateTime fImpresionDiaContable { get; set; }
        public bool lImpresionDiaContable { get; set; }
        public string tContribuyenteEspecial { get; set; }
        public string fContribuyenteEspecial { get; set; }

        //Variables de Impresora
        public string sSerieCaja { get; set; }
        public string sFont { get; set; }
        public string sFont1 { get; set; }
        public string sFont2 { get; set; }
        public string sPuertoIF { get; set; }
        public string sBitSegIF { get; set; }

        //Variables Caja
        public string sPreCuenta { get; set; }
        public bool wComanda { get; set; }
        public bool vComanda { get; set; }
        public bool lEliminaC { get; set; }
        public bool lElimina { get; set; }
        public bool lPasswordC { get; set; }
        public bool lPassword { get; set; }
        public string sGrupoDefault { get; set; }
        public bool lConsumo1 { get; set; }
        public bool lConsumo2 { get; set; }
        public bool lConsumo3 { get; set; }
        public bool lPrecuentaImpresora { get; set; }
        public bool lAdicion { get; set; }
        public bool lCierre { get; set; }
        public bool lPrecuentaAgrupada { get; set; }
        public bool lDocumentoAgrupado { get; set; }
        public string sTipoPedido { get; set; }
        public string sTipoPedidoPD { get; set; }
        public bool lObligaCierre { get; set; }
        public bool lFiltroTipoPedido { get; set; }
        public bool lCancelacion { get; set; }
        public bool lObligaPrinter { get; set; }
        public bool lDirecto { get; set; }
        public bool lObligaPrecuenta { get; set; }
        public bool lComboPrecuenta { get; set; }
        public bool lComboDocumento { get; set; }
        public bool lCambioMesa { get; set; }
        public bool lVisaNet { get; set; }
        public bool lImpuestoPrecuenta { get; set; }
        public bool lOrden { get; set; }
        public bool lValorCortesia { get; set; }
        public bool lObservacion { get; set; }
        public bool lCajaRapida { get; set; }
        public bool lPropiedadDocumento { get; set; }
        public bool lPropiedadPrecuenta { get; set; }
        public bool lPrecioNetoPrecuenta { get; set; }
        public int nLimitePrecuenta { get; set; }
        public int nLimiteReimpresion { get; set; }
        public bool lPasswordTransferencia { get; set; }
        public int nLongitudBarra { get; set; }
        public bool lCapturaPeso { get; set; }
        public bool lPasswordImportarPedido { get; set; }
        public string sUnidadNegocio { get; set; }
        public bool lMultiCajero { get; set; }
        public bool lMCPV { get; set; }
        public bool lFechaEntregaDelivery { get; set; }
        public bool lCCVOX { get; set; }
        public bool lObservacionPrecuenta { get; set; }
        public bool lObservacionDocumento { get; set; }
        public bool lObservacionCabDoc { get; set; }
        public bool lPagoRapidoPV { get; set; }
        public string tTextoConsumo { get; set; }
        public bool lImpreEquivaPrecuenta { get; set; }
        public bool lDocumEquivaPrecuenta { get; set; }
        public bool lDisgrega { get; set; }
        public bool lSiab { get; set; }
        public IDbConnection CnSiab { get; set; }
        public string sSYBASE { get; set; }




        ///'''''''''''''''''''
        //Parametros de Ingreso
        public string sRuta { get; set; }
        public string sMDB { get; set; }
        public string sAlmacenMDB { get; set; }
        public string sAlmacenRuta { get; set; }
        public string sDBF { get; set; }
        public bool lAlmacen { get; set; }
        public string sModulo { get; set; }
        public string sRutaCD { get; set; }
        public string sMDBCD { get; set; }

        public string sRutaWAP { get; set; }
        public string sMDBWAP { get; set; }

        //--- SAP
        public bool lSAP { get; set; }
        public string sServidorSAp { get; set; }
        public string sBdSAP { get; set; }
        public string sCodSap { get; set; }
        public bool VSApForBusqueda { get; set; }
        //----visor----
        public bool lvisor { get; set; }

        //Variables Infhotel
        public string sHotel { get; set; }
        public string sReserva { get; set; }
        public string sHabitacion { get; set; }
        public string sPasajero { get; set; }
        public string sFichaPasajero { get; set; }
        public string sCajaInfhotel { get; set; }
        public string xUsuario { get; set; }
        public string sPropina { get; set; }
        public string sMonPropina { get; set; }
        public string sTipoComanda { get; set; }
        public string sPuntoVentaInfhotel { get; set; }

        //Variables Genericas
        public string sTurno { get; set; }
        //CESAR TURNO
        public string sTurnoModificacion { get; set; }

        public string sCaja { get; set; }
        public string sSalon { get; set; }
        public string sUsuario { get; set; }
        public string sPassword { get; set; }
        public string sPedido { get; set; }
        public string sDocumento { get; set; }
        public string sMesa { get; set; }
        public bool wCambioMesa { get; set; }
        public double nTC { get; set; }
        public double nTC2 { get; set; }
        public double nTC3 { get; set; }
        public string sGrupoUsuario { get; set; }
        public string sMozo { get; set; }
        //origen de ventas
        public string sOrigenVenta { get; set; }

        public bool lBotonTrans { get; set; }
        public double nCargo { get; set; }
        public string NFactura { get; set; }
        public string sTienda { get; set; }
        public string sTemporal { get; set; }
        public int xCantidad { get; set; }

        //Variables CD
        public string sUserNameCD { get; set; }
        public string sUserPasswordCD { get; set; }
        public bool CD { get; set; }


        public bool WEBAP { get; set; }
        public bool MESA247 { get; set; }
        public bool EAN13 { get; set; }

        //Variables de Programacion
        public string Isql { get; set; }
        public string sCodigo { get; set; }
        public string sDescrip { get; set; }
        //public Variant nPos { get; set; }
        public double nFactor { get; set; }
        public bool lFactor { get; set; }

        public string sTemp { get; set; }
        public string sTipo { get; set; }
        public string xTipo { get; set; }
        public bool wEnter { get; set; }
        public bool wMesa { get; set; }
        public bool wInicio { get; set; }
        public bool Sw { get; set; }
        public string sVar1 { get; set; }
        public string sVar2 { get; set; }
        public string sVar3 { get; set; }
        public double nVar1 { get; set; }
        public string sFormulario { get; set; }
        public int CorrelativoC { get; set; }

        //Declaracion de Nota de Credito
        public bool lactivaFechaNC { get; set; }
        public bool lParcialNC { get; set; }
        public bool lNCElimina { get; set; }
        public bool lNCAnula { get; set; }
        //Declaracion de Variables de Color
        public enum UbicaPuntero
        {
            Primero = 1,
            Ultimo = 2,
            previo = 3,
            siguiente = 4,
            pgup = 5,
            pgdn = 6
        }

        public enum TAmbiente
        {
            Prueba = 1,
            Produccion = 2
        }

        public enum TTipoEmision
        {
            Normal = 1,
            IndisponibilidadSys = 2
        }

        //public const vbLista { get; set; }
        //public const vbOcupada = 0x80C0FF { get; set; }
        //public const vbReservada = 0x8000L { get; set; }
        //public const vbSucia = 0xC0C0L { get; set; }
        //public const vbBloqueada = 0xC0L { get; set; }
        //public const vbFServicio = 0xC0C0C0 { get; set; }
        //public const vbPrecuentaImp = 0x80FF & { get; set; }
        //public const vbOriginal = 0x4080L { get; set; }

        //version educativa
        public bool lVersionEducativa { get; set; }
        //HARDkey
        public bool lHARDkey { get; set; }
        public string clave1 { get; set; }
        public string clave2 { get; set; }
        //------------------------------

        //ADMINISTRACION CENTRALIZADA
        public string sServidorCentral { get; set; }
        public string bdInforestCentral { get; set; }
        public bool lCentral { get; set; }
        public bool lMenuTablas { get; set; }

        //====================== un exe multilocal

        public string localConectado { get; set; }
        public bool multiLocal { get; set; }
        public bool ultimoConectado { get; set; }
        public IDbConnection cnDefault { get; set; }
        //====================
        public IDbConnection cnAlmacenDefault { get; set; }
        //====================

        public string moduloUso { get; set; }


        //ALMACEN REMOTO
        public string sRutaAlmacenRemoto { get; set; }
        public string sMDBAlmacenRemoto { get; set; }
        public IDbConnection CnAlmacenRemoto { get; set; }
        public bool lAlmacenRemoto { get; set; }
        public string verificaAlmacenRemoto { get; set; }

        //KDS
        public bool lKDS { get; set; }
        public string sOrderInfo { get; set; }
        public string sBump { get; set; }

        //descripcion alternativa

        public bool lDescripcionAlternativa { get; set; }

        //para mesas
        public string sTempMesa { get; set; }

        //TVS
        //Public lCompatibilidadTVS As Boolean


        //EXTRANJERO- BOLIVIA
        public string pais { get; set; }
        public string textoComprobanteBolivia { get; set; }
        //cgMiranda-------------------------
        public bool estadoReimpresion { get; set; }
        //fin cgmiranda---------------------
        // controler
        public string tcodigoUsuarioA { get; set; }


        //pagoRapido
        public bool lPagoRapido { get; set; }


        //MODIFICACIONES NORKYS lg 03/2012
        public bool lPasswordPorCobrar { get; set; }
        public bool lmodificatipoPedido { get; set; }

        //registroventasunat
        public double nTCO { get; set; }

        //diacontable
        public bool lDiaContable { get; set; } //true=automatico false=manual
        public string tHoraCierreDiaContable { get; set; }
        public bool lIniciaPorDiaContable { get; set; }
        public bool lDiaContableAperturado { get; set; }

        //club
        public bool lClub { get; set; }

        //control de licencias
        public string tVersionEducativaLicencia { get; set; }


        //tarifa
        public string tTarifaActualMotorizado { get; set; }

        //AUDITORIA
        public string tModuloSeg { get; set; }
        public long nCorrelativoAcceso { get; set; }
        public IDbConnection CnSeg { get; set; }
        public string sPasa { get; set; }
        public bool lAuditoria { get; set; }

        //impresion
        public bool lReimpresion { get; set; }

        //0084-2013 CESAR Para el Pago Rapido
        public string lModuloPago { get; set; }


        //Invitado
        public string sCodigoInvitado { get; set; }


        //PARIENTE
        public string sCodigoParienteSeleccionado { get; set; }
        public string sCodigoClienteFrecuente { get; set; }


        //busquedaSocio
        public bool lCargaDesdePedido { get; set; }
        public bool lTabBuscar { get; set; }

        //CESAR PAGO RAPIDO
        public double nTotalPR { get; set; }


        //lg tipocanalreporte
        public string sTipoCanalReporte { get; set; }
        public string sTipoCanalNombreReporte { get; set; }

        //consulta descargo al cierre
        public bool lActivaConsultaDescargo { get; set; }

        //bloqueaprecuenta
        public bool lBloqueaPrecuenta { get; set; }

        //CESAR ROTULADO
        public bool lRotulado { get; set; }


        //lg
        public bool lMultiAreaSubGrupo { get; set; }
        public bool lMultiAreaCaja { get; set; }


        //HUELLA
        public bool wEnterHuella { get; set; }
        public bool wenterHuellaSup { get; set; }
        public bool lVieneHuella { get; set; }
        public string pTipo { get; set; }
        public bool lHuella { get; set; }
        public bool lUsuarioHuella { get; set; }


        //FORMATO VARIABLE
        public int nCabeceraV { get; set; }
        public int nItemV { get; set; }
        public int nPieV { get; set; }

        //envio de correo
        public string sUsuarioMail { get; set; }
        public string sClaveMail { get; set; }
        public string Smtp_Prorroga { get; set; }
        public string UsuarioEnvio_Prorroga { get; set; }
        public string PasswordEnvio_Prorroga { get; set; }
        public string Asunto_Prorroga { get; set; }
        public string Cuerpo_Prorroga { get; set; }

        //Validacion RUC
        public bool xlTipoDocumento { get; set; }

        //Requerimientos
        public string sRequerimiento { get; set; }

        //ImpresionImagenPrecuenta
        public bool lImprimeImagCabPrecuenta { get; set; }
        public bool lImprimeImagPiePrecuenta { get; set; }

        //MostrarVencimiento
        public string sVencimientoLicencia { get; set; }
        public string sCantidadLicenciaModulo { get; set; }

        //ImpresionImagenDocumento
        public bool lImprimeImagCabDocumento { get; set; }
        public bool lImprimeImagPieDocumento { get; set; }
        int lTamanio { get; set; }
        //ADODB.Recordset rsQr = new ADODB.Recordset() { get; set; }
        string comilla { get; set; }

        //despachopedido
        public bool lAccesoDespachoPedido { get; set; }
        public long nLongitudAlmacen { get; set; }



        //FACTURACION ELECTRONICA
        public bool lFacturacionE { get; set; }
        public string tCodigoFE { get; set; }
        public bool lAmbienteProduccion { get; set; }
        public string tPieDocumento1 { get; set; }

        public string sRutaFE { get; set; }
        public string sMDBFE { get; set; }
        public IDbConnection CnFE { get; set; }
        public string IsqlFact { get; set; }
        public int xi { get; set; }

        // erick DLC
        public bool lQRFE { get; set; }
        public string RutaImgFE { get; set; }



        public string ClaveAcceso { get; set; }


        //huellas
        public bool lHuellaDigitalPersona { get; set; }
        public bool lHuellaSecugen { get; set; }
        //        public long GetDC Lib "user32" (long hwnd) {
        //public long TextOut Lib "gdi32" "TextOutA" (long hdc, long X, long Y, string lpString, long nCount) {
        //public long ReleaseDC Lib "user32" (long hwnd, long hdc) {




        //AGENTE RETENCION
        public string tTextoAgenteRetencion { get; set; }

        //imprime dni
        public string xTipoIdentidad { get; set; }

        //guarda LOG CAJA RAPIDA
        public bool lLogCajaRapida { get; set; }
        //por pastipan
        public bool lBuscaPedidoNumero { get; set; }

        //codigobarrarecibo
        public bool lCodigoReciboIngreso { get; set; }

        //autorizacion
        public string tUsuarioAutoriza { get; set; }

        public bool lConsumo4 { get; set; }
        public bool lPrecuentaNoValorizada { get; set; }

        //PAGO MASIVO
        public string tTipoPagoMasivo { get; set; }
        public string tTipoTarjetaMasivo { get; set; }
        public string tOtroTipoCancelacionMasivo { get; set; }
        public string tDocumentoPagoMasivo { get; set; }
        public string tBancoPagoMasivo { get; set; }

        public bool lImpresionCodigoBarras { get; set; }


        public bool lEnvioAutomatico { get; set; }
        public int lMinutoEnvioAntes { get; set; }
        public bool lEnvioProduccionUsuario { get; set; }
        public bool lEnvioProduccionCaja { get; set; }

        //ENLACE ELECTRONICO OFISIS
        public bool lFEOfisis { get; set; }
        public bool lFEOventas { get; set; }

        public string sTelefonoReserva { get; set; }


        //BUSCAR
        public bool lBuscarPedidoVisualizarGrilla { get; set; }
        public bool lBuscarPedidoFiltrarMesa { get; set; }

        // glosa de impresion transferencia gratuita
        public string lGlosaTrans { get; set; }

        public bool lPagoAntesImpresion { get; set; }

        public bool lPagocortesiaAI { get; set; }
        // Cover - ecuador
        public bool lcover { get; set; }
        public double sMontoMinCover { get; set; }
        public string sCodItemCover { get; set; }


        //-- ofisis notas de credito
        public bool lNcOfisis { get; set; }

        public int AvisoLicencia { get; set; }

        public bool lFEpape { get; set; }
        public string IPpape { get; set; }
        public string PUERTOpape { get; set; }
        public string PUERTOLOCALpape { get; set; }

        public bool lDesPagoCheque { get; set; }
        public bool lDesPagoOtra { get; set; }

        public bool lKardexFechaIngreso { get; set; }

        // FACTURACION PAPERLEES
        //public clsTrama clsTramaFE { get; set; }
        public string PapeMatricial { get; set; }
        public string PapeTermico { get; set; }

        //ENLACE ELECTRONICO SPRING
        public bool lFESpring { get; set; }

        //ENLACE ELECTRONICO CARBAJAL
        public bool lFECarbajal { get; set; }

        public bool lDesactivaNCFP { get; set; }

        public string Estado { get; set; }

        public bool lFEBiz { get; set; }

        public bool lImprimeMotivoDescuentoFB { get; set; }

        public bool lActivaAnticipo { get; set; }

        public bool lFeGoodHope { get; set; }

        public bool lImpPropina { get; set; }

        public bool lImpComandaf2 { get; set; }

        public bool lFEubl21 { get; set; }

        public bool lPassOtrosPagos { get; set; }

        public bool lBloqInafecto { get; set; }

        public bool lFEEcuador { get; set; }

        public bool lFEGesa { get; set; }

        public double DiasContingenciaDocumentos { get; set; }

        public bool lImpClienteCabDoc { get; set; }

        public bool lBuscarPedidoBarraMesero { get; set; }

        public string sLey1 { get; set; }
        public string sValorLey1 { get; set; }

        public string RutaConsultaRuc { get; set; }
    }
}
