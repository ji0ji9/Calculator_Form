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

        private string temp = "";
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
            cancel_Click(null, null); // cancel 재사용
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
                oct_box.Text = input;

                string oBin = "";
                foreach ( char c in input)
                {
                    // 2진수로 변환 후, BIN에 누적
                    int octDigit = int.Parse(c.ToString());
                    string triOct = "";
                    while (octDigit > 0) 
                    {
                        if (octDigit - 4 >= 0) { triOct += "1"; octDigit -= 4; }
                        else { triOct += "0"; }

                        if(octDigit - 2 >= 0) { triOct += "1"; octDigit -= 2; }
                        else { triOct += "0"; }

                        if (octDigit - 1 >= 0) { triOct += "1"; octDigit -= 1; }
                        else { triOct += "0"; }
                    }
                    

                    oBin += triOct;
                }
                // to BIN
                bin_box.Text = oBin;

                oBin = new string(oBin.Reverse().ToArray()); // 연산을 위해 뒤집어줌

                // to DEC
                double dtemp = 0;
                for (int i = 0; i < oBin.Length; i++) { dtemp += Math.Pow(2, i) * int.Parse(oBin[i].ToString()); }
                dec_box.Text = dtemp.ToString();

                // to HEX
                string hhtemp = "";
                double htemp = 0;
                for (int i = 0; i < oBin.Length; i++)
                {
                    htemp += Math.Pow(2, i % 4) * int.Parse(oBin[i].ToString());
                    if ((i + 1) % 4 == 0)
                    {
                        int hex = int.Parse(htemp.ToString());
                        hhtemp += Convert.ToString(hex, 16).ToUpper(); // htemp(hex) -> 16진수
                        htemp = 0;
                        hex_box.Text = new string(hhtemp.Reverse().ToArray());
                    }
                    else hex_box.Text = new string((hhtemp + htemp).ToString().Reverse().ToArray());
                }
            }
            else if(mode == "HEX")
            {
                hex_box.Text = input;

                string hBin = "";

                // c를 이진수로 변환
                foreach (char c in input)
                {
                    int temp = Convert.ToInt32(c.ToString(), 16);
                    string sqH = "";
                    if (temp - 8 >=0) { sqH += "1"; temp -= 8; }
                    else { sqH += "0"; }

                    if (temp - 4 >= 0) { sqH += "1"; temp -= 4; }
                    else { sqH += "0"; }

                    if (temp - 2 >= 0) { sqH += "1"; temp -= 2; }
                    else { sqH += "0"; }

                    if (temp - 1 >= 0) { sqH += "1"; temp -= 1; }
                    else { sqH += "0"; }

                    hBin += sqH;
                }

                bin_box.Text = hBin;

                // to OCT
                double otemp = 0;
                string ootemp = "";
                hBin = new string(hBin.Reverse().ToArray()); // 연산을 위해 뒤집어줌
                for (int i = 0; i < hBin.Length; i++) 
                { 
                    otemp += Math.Pow(2, i % 3) * int.Parse(hBin[i].ToString()); 
                    if ((i + 1) % 3 == 0)
                    {
                        ootemp += otemp.ToString();
                        oct_box.Text = new string((otemp.ToString() + ootemp).Reverse().ToArray());
                        otemp = 0;
                    }
                    else oct_box.Text = new string((ootemp + otemp).Reverse().ToArray());
                }

                // to DEC
                double dtemp = 0;
                for (int i = 0; i < hBin.Length; i++) { dtemp += Math.Pow(2, i) * int.Parse(hBin[i].ToString()); }
                dec_box.Text = dtemp.ToString();

            }
        }
    }
}
