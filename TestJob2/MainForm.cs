using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace TestJob2
{
    public delegate void HelpToSetRes (TextBox tb, string res);
    public delegate void Inform(Label info,string text);

    #region MainForm
    public partial class MainForm : Form
    {
        #region Fields
        private readonly HelpToSetRes _helper;
        private readonly Inform _info;
        //private Thread _calcThead;
        private Task _calcTask;
        //private Action<object> action;
        private CancellationTokenSource _ts;
        private CancellationToken _ct;
        private bool _formClosing;

        #endregion

        #region Constr
        public MainForm()
        {
            InitializeComponent();

            _helper = new HelpToSetRes(SetRes);
            _info = new Inform(Info);
            _formClosing = false;

            //action = (object obj) => Calc();
        }
        #endregion

        #region Info
        /// <summary>
        /// Output _info on a form.
        /// </summary>
        /// <param name="infoLab">The lable for output info</param>
        /// <param name="text">Text for output</param>
        private static void Info(Label infoLab,string text)
        {
            infoLab.Text = text;
        }
        #endregion

        #region SetRes
        /// <summary>
        /// Set result on a form.
        /// </summary>
        /// <param name="tb">TextBox for output result</param>
        /// <param name="res">Output value resalt</param>
        private static void SetRes(TextBox tb, string res)
        {
            tb.Text = res;
        }
        #endregion

        #region Calc
        /// <summary>
        /// Calculate the numbers.
        /// </summary>
        private void Calc()
        {
            Thread.Sleep(1000);
            double a, b, res=0;

            Invoke(_helper, this.res_txtBox, "");

            if (!double.TryParse(this.a_txtBox.Text.ToString(), out a) 
                | !double.TryParse(this.b_txtBox.Text.ToString(), out b))
            {
                MessageBox.Show("Incorrect input");
            }

            for (int i = 0; i < 10;i++ )
            {
                res = a + b;
                Invoke(_info, infoLb, string.Format("Please wait!!! Running Calc!!! {0}", i));
                Thread.Sleep(1000);

                if(_ct.IsCancellationRequested)
                {
                    if (!_formClosing)
                    {
                        Invoke(_info, infoLb, "Task canceled!!! And restarted!!!");
                    }
                    //Thread.Sleep(1000);
                    return;
                }
            }

            Invoke(_helper, this.res_txtBox,res.ToString());
            Invoke(_info, infoLb, "");
        }
        #endregion

        #region KillTheThread
        private void KillTheThread()
        {
            //if (_calcThead.IsAlive)
            //{
            //    _calcThead.Abort();
            //}

            if(_calcTask.Status==TaskStatus.Running)
            {
                _formClosing = true;
                _ts.Cancel();
                Thread.Sleep(2000);
            }
        }
        #endregion

        #region EventHandler
        private void calc_btn_Click(object sender, EventArgs e)
        {
            //if (_calcThead!=null)
            //{
            //    _calcThead.Abort();
            //}

            //_calcThead = new Thread(Calc);
            //_calcThead.Priority = ThreadPriority.Lowest;
            //_calcThead.IsBackground = true;
            //_calcThead.IsBackground = true;
            //_calcThead.Start();

            if(_calcTask!=null && _calcTask.Status==TaskStatus.Running)
            {
                _ts.Cancel();
                Thread.Sleep(2000);
            }

            //_calcTask = new Task(action, "calc");
            //_calcTask.Start();
            //_calcTask = Task.Factory.StartNew(Calc);

            _ts = new CancellationTokenSource();
            _ct = _ts.Token;

            _calcTask = Task.Factory.StartNew(Calc, _ct);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (_calcTask.Status == TaskStatus.Running)
            {
                KillTheThread();
            }

            Thread.Sleep(1000);
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_calcTask.Status == TaskStatus.Running)
            {
                KillTheThread();
            }
        }
        #endregion
    }
#endregion
}