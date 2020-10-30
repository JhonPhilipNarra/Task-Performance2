using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueueForm
{
    public partial class Queueform : Form
    {
       

        public Queueform()
        {
            InitializeComponent();

        }

        private CashierClass1 cashier = new CashierClass1();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass1.getNumberInQueue = lblQueue.Text;
            CashierClass1.CashierQueue.Enqueue(CashierClass1.getNumberInQueue);

            

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CashierWindowQueue form2 = new CashierWindowQueue();
            form2.Show();
        }
    }
}
