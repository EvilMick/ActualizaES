using System.ServiceProcess;
using System.Timers;

namespace ActualizaES
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer1 = null;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer1 = new Timer();
            this.timer1.Interval = 300000;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            Librería.WriteErrorLog("Comienzo actualización de datos");
        }
        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            LectorRSS lector = new LectorRSS();
            lector.RSS_XML();
            Librería.WriteErrorLog("Actualización completada");
        }

        protected override void OnStop()
        {
        }
    }
}
