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
    public partial class NowServingForm : Form
    {
        public NowServingForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NowServingForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblServing.Text = CashierClass1.CashierQueue.Peek();
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Theres nothing in the Queue right now.", "Message");
                this.Close();
            }
        }
    }
}
