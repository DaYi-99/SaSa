using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaSa.Forms.Supplier
{
    public partial class FormPurchase : Form
    {
        public FormPurchase()
        {
            InitializeComponent();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
