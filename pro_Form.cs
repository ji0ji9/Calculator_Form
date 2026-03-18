using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Form
{
    public partial class pro_Form : Form
    {
        public pro_Form()
        {
            InitializeComponent();
        }

        private void chg_Click(object sender, EventArgs e)
        {
            this.Hide();
            basic_Form bForm = new basic_Form();
            bForm.Owner = this;
            bForm.Show();
        }
    }
}
