using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Topshelf;

namespace AppTimers
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);   
        
            HostFactory.Run(x =>
            {
                x.Service<Heartbeat>(s =>
                {
                    s.ConstructUsing(heartbeat => new Heartbeat());
                    s.WhenStarted(heartbeat => heartbeat.Start());
                    s.WhenStopped(heartbeat => heartbeat.Stop());
                });
                x.RunAsLocalSystem();

                x.SetServiceName("أذكار");
                /*
                                x.SetDisplayName("Agricultural Calendar");
                                x.SetDescription("Agricultural Calendar Service");
                                */
                x.SetDisplayName("برنامج أذكار");
                x.SetDescription("هذه الخدمة لي برنامج أذكار عمل تنبيهات");

            });
            Application.Run(new Form1());
        }
    }
}
