using System;
using System.Windows.Forms;
using System.Threading;

namespace TestJob2
{
    public delegate void HelpToSetRes (TextBox tb, double res);
    public delegate void Inform(Label info,string text);

    #region MainForm
    public partial class MainForm : Form
    {
        #region Fields
        private readonly HelpToSetRes _helper;
        private readonly Inform _info;
        private Thread _calcThead;
        #endregion

        #region Constr
        public MainForm()
        {
            InitializeComponent();

            _helper = new HelpToSetRes(SetRes);
            _info = new Inform(Info);

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
        private static void SetRes(TextBox tb, double res)
        {
            tb.Text = res.ToString();
        }
        #endregion

        #region Calc
        /// <summary>
        /// Calculate the numbers.
        /// </summary>
        private void Calc()
        {
            Invoke(_info, infoLb,"Please wait!!!Running Calc!!!");
            
            double a, b, res;

            if (!double.TryParse(this.a_txtBox.Text.ToString(), out a) 
                | !double.TryParse(this.b_txtBox.Text.ToString(), out b))
            {
                MessageBox.Show("incorrect input");
            }

            res = a + b;

            Thread.Sleep(10000);
            Invoke(_helper, this.res_txtBox,res);
            Invoke(_info, infoLb, "");
        }
        #endregion

        #region KillTheThread
        private void KillTheThread()
        {
            if (_calcThead.IsAlive)
            {
                _calcThead.Abort();
            }
        }
        #endregion

        #region EventHandler
        private void calc_btn_Click(object sender, EventArgs e)
        {

            if (_calcThead!=null)
            {
                _calcThead.Abort();
            }

            _calcThead = new Thread(Calc);
            _calcThead.Priority = ThreadPriority.Lowest;
            _calcThead.IsBackground = true;
            _calcThead.IsBackground = true;
            _calcThead.Start();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            KillTheThread();

            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            KillTheThread();
        }
        #endregion
    }
#endregion
}
//public class MyParam
//{
//    public double a;
//    public double b;

//    public MyParam(double tempA, double tempB)
//    {
//        this.a = tempA;
//        this.b = tempB;
//    }

//}