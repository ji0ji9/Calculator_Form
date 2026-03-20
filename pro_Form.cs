using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator_Form
{
    public partial class pro_Form : Form
    {
        public pro_Form()
        {
            InitializeComponent();
        }

        private string temp;
        private string mode = "HEX";

        private void chg_Click(object sender, EventArgs e)
        {
            this.Hide();
            basic_Form bForm = new basic_Form();
            bForm.Owner = this;
            bForm.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            result_box.Clear();
            hex_box.Clear();
            dec_box.Clear();
            oct_box.Clear();
            bin_box.Clear();
            temp = "";
        }

        private void mode_Click(object sender, EventArgs e) // gpt (코드 단순화)
        {
            Button btn = (Button)sender;
            result_box.Clear();
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
            if (result_box.Text == "0") temp = "0";

            temp += btn.Text;
            result_box.Text = temp;
            numChanger(temp);
        }

        private void numChanger(string input)
        {
            if (mode == "DEC")
            {
                int dec = int.Parse(input);
                hex_box.Text = Convert.ToString(dec, 16).ToUpper();
                dec_box.Text = input;
                oct_box.Text = Convert.ToString(dec, 8);
                bin_box.Text = Convert.ToString(dec, 2);
            }
            else if (mode == "BIN")
            {
                bin_box.Text = input;

                string rv = new string(input.Reverse().ToArray());  // gpt(뒤집는 연산방법)
                double dtemp = 0;   // to Dec
                double otemp = 0;
                double htemp = 0;

                // BIN to DEC
                for (int i = 0; i < rv.Length; i++) 
                { 
                    dtemp += Math.Pow(2, i) * int.Parse(rv[i].ToString());
                }
                dec_box.Text = dtemp.ToString();

                // BIN to OCT
                string ootemp = "";
                for (int i = 0; i < rv.Length; i++)
                {
                    oct_box.Clear();
                    otemp += Math.Pow(2, i % 3) * int.Parse(rv[i].ToString());
                    if ((i+1) % 3 == 0)
                    {
                        ootemp += otemp.ToString(); // 3자리 연산 후 temp에 저장
                        otemp = 0; // 3 자리수에서 초기화
                        oct_box.Text = new string(ootemp.Reverse().ToArray());
                    }
                    else
                    {
                        oct_box.Text = new string((ootemp.ToString() + otemp.ToString()).Reverse().ToArray());
                        //MessageBox.Show($"{otemp}, {ootemp}");
                    }
                }
                
                // to HEX는 OCT와 동일 연산
                string hhtemp = "";
                for (int i = 0; i < rv.Length; i++)
                {
                    hex_box.Clear();
                    htemp += Math.Pow(2, i % 4) * int.Parse(rv[i].ToString());
                    if ((i + 1) % 4 == 0)
                    {
                        hhtemp += Convert.ToString((int)htemp, 16).ToUpper(); // htemp -> 16진수
                        htemp = 0;
                        hex_box.Text = new string(hhtemp.Reverse().ToArray());
                    }
                    else
                    { 
                        hex_box.Text = new string((hhtemp.ToString() + htemp.ToString()).Reverse().ToArray());
                    }
                }

            }
            else if (mode == "OCT")
            {
                input.Split();
            }
        }
    }
}
