

namespace InfoService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Linq;
    using System.ServiceProcess;
    using System.Text;
    using InfoService.Rappi.Controller;
    using InfoService.Infomatica.Model;
    using System.Configuration;

    public partial class Service1 : ServiceBase
    {
        RappiPedidos RP = new RappiPedidos();
        public Service1()
        {
            InitializeComponent();
        }
        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            //var s = RP.ConsultarToken();
            //RP.BuscarOrdenes(s);
            // TODO: Insert monitoring activities here.   
            //EventLog.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                VariableGeneral.lRappi = ConfigurationManager.AppSettings["ActivaRappi"].ToString() == "1" ? true : false;
                VariableGeneral.lUber = ConfigurationManager.AppSettings["ActivaUberEat"].ToString() == "1" ? true : false;

                VariableGeneral.TokenRappi = ConfigurationManager.AppSettings["TokenRappi"].ToString();

                VariableGeneral.LoginRappi = ConfigurationManager.AppSettings["LoginRappi"].ToString();
                VariableGeneral.OrdersRappi = ConfigurationManager.AppSettings["OrdersRappi"].ToString();
                VariableGeneral.TakeRappi = ConfigurationManager.AppSettings["TakeRappi"].ToString();
                VariableGeneral.RejectRappi = ConfigurationManager.AppSettings["RejectRappi"].ToString();
                VariableGeneral.MenuRappi = ConfigurationManager.AppSettings["MenuRappi"].ToString();


                if (VariableGeneral.lRappi)
                {
                    var s = RP.ConsultarToken();
                    RP.BuscarOrdenes(s);
                    //System.Timers.Timer timer = new System.Timers.Timer();
                    //timer.Interval = 30000; // 60 seconds   
                    //timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
                    //timer.Start();
                }

            }
            catch (Exception ex)
            {

               
            }


            //var s = RP.ConsultarToken();
            //RP.BuscarOrdenes(s);
            //Thread.Sleep(5000);

        }


        protected override void OnStop()
        {
        }
    }
}
