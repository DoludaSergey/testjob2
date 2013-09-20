using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace TestJob2
{
    #region Program
    public static class Program
    {
        static private Thread _visualThread;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //_visualThread = new Thread(DoIt);
            //_visualThread.Priority = ThreadPriority.AboveNormal;
            //_visualThread.Start();

            //Action<object> action = (object obj) => DoIt();

            //var t = Task.Factory.StartNew(action,"Initialisation");
            //t.Wait();

            Task t = new Task(DoIt);
            t.Start();
            t.Wait();
        }

        /// <summary>
        /// Call a main form
        /// </summary>
        private static void DoIt()
        {
            Application.Run(new MainForm());
        }
    }
    #endregion
}