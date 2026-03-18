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

        private string temp;
        private string mode;

        private void chg_Click(object sender, EventArgs e)
        {
            this.Hide();
            basic_Form bForm = new basic_Form();
            bForm.Owner = this;
            bForm.Show();
        }

        private void mode_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            mode = btn.Text;
            checkH.Checked = (mode == "HEX");
            checkD.Checked = (mode == "DEC");
            checkO.Checked = (mode == "OCT");
            checkB.Checked = (mode == "BIN");

            buttonA.Enabled = buttonB.Enabled = buttonC.Enabled = buttonD.Enabled = buttonE.Enabled = buttonF.Enabled = (mode == "HEX");
            button8.Enabled = button9.Enabled = (mode == "HEX" || mode == "DEC");
            button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = (mode != "BIN");
            button1.Enabled = button0.Enabled = true;

        }

        private void num_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            temp += btn.Text;
            result_box.Text = temp;

            numChanger(temp);
        }

        private void numChanger(string input)
        {
            if (mode == "DEC")
            {
                int dec = int.Parse(input);
                hex_box.Text = Convert.ToString(dec, 16);
                dec_box.Text = dec.ToString();
                oct_box.Text = Convert.ToString(dec, 8);
                bin_box.Text = Convert.ToString(dec, 2);
            }
            else if (mode == "HEX")
            {
                //입력값 string temp가 16진수임

            }
        }

        
    }
}
