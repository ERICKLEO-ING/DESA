

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
    using System.Threading;
    using System.Threading.Tasks;
    using System.Timers;
    using InfoService.Rappi.Controller;
    public partial class Service1 : ServiceBase
    {
        //private Timer _timer;
        RappiPedidos RP = new RappiPedidos();
        public Service1()
        {
            InitializeComponent();
        }

        private void SetupProcessingTimer()
        {
            //_timer = new Timer();
            //_timer.AutoReset = true;
            //double interval = 1;// Settings.Default.Interval;
            //_timer.Interval = interval * 6000;
            //_timer.Enabled = true;
            //_timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
           var s=  RP.ConsultarToken();
            // begin your service work
            //MakeSomething();
        }

        protected override void OnStart(string[] args)
        {

            var s = RP.ConsultarToken();
            RP.BuscarOrdenes(s);
            Thread.Sleep(5000);
            //SetupProcessingTimer();
        }

        protected override void OnStop()
        {
        }
    }
}
