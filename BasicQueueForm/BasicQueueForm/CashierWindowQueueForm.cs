using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace BasicQueueForm
{
    public partial class CashierWindowQueue : Form
    {
        Timer timer;
        public CashierWindowQueue()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1 * 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass1.CashierQueue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass1.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierView.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierView.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            NowServingForm form2 = new NowServingForm();
            form2.Show();

        }

        private void CashierWindowQueue_Load(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass1.CashierQueue);
            timer.Stop();
        }
    }
}
