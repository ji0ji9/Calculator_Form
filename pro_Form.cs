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
            mode_Click(buttonDec, EventArgs.Empty);
        }

        private string temp;
        private string mode;
        private string operater;
        private string temp_b;
        int result = 0;
        string sh;
        bool equal_flag = false;

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
            temp_box.Clear();
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

            if (string.IsNullOrEmpty(operater)) result_box.Text = temp;
            else
            {
                temp_box.Text = temp_b + operater + temp;
                result_box.Text = temp;
                int n = 10;
                if (mode == "DEC") n = 10;
                else if (mode == "OCT") n = 8;
                else if (mode == "HEX") n = 16;
                else if (mode == "BIN") n = 2;

                if (operater == "+")
                {
                    result = Convert.ToInt32(temp_b, n) + Convert.ToInt32(temp, n);
                }
                else if (operater == "-")
                {
                    result = int.Parse(temp_b) - int.Parse(temp);
                }
                else if (operater == "÷")
                {
                    result = int.Parse(temp_b) / int.Parse(temp);
                }
                else if (operater == "×")
                {
                    result = int.Parse(temp_b) * int.Parse(temp);
                }
            }

            numChanger(temp);
        }

        private void numChanger(string input)
        {
            if (mode == "DEC")
            {
                int dec = int.Parse(input);
                hex_box.Text = Convert.ToString(dec, 16).ToUpper();
                dec_box.Text = input;
                string oct = Convert.ToString(dec, 8);
                oct = long.Parse(oct).ToString($"D{((oct.Length - 1) / 3 + 1) * 3}");
                oct_box.Text = oct;
                string bin = Convert.ToString(dec, 2);
                bin = long.Parse(bin).ToString($"D{((bin.Length - 1) / 4 + 1) * 4}");
                bin_box.Text = bin;
            }
            else if (mode == "BIN")
            {
                if (equal_flag)
                {
                    bin_box.Text = Convert.ToString(result, 2);
                    result_box.Text = Convert.ToString(result, 2);
                    equal_flag = false;
                }
                else bin_box.Text = input;

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
                    if ((i + 1) % 3 == 0)
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
                Convert.ToString(int.Parse(input), 8);
                oct_box.Text = input;

                string oBin = "";
                foreach (char c in input)
                {
                    // 2진수로 변환 후, BIN에 누적
                    int octDigit = int.Parse(c.ToString());
                    string triOct = "";
                    while (octDigit > 0)
                    {
                        if (octDigit - 4 >= 0) { triOct += "1"; octDigit -= 4; }
                        else { triOct += "0"; }

                        if (octDigit - 2 >= 0) { triOct += "1"; octDigit -= 2; }
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
            else if (mode == "HEX")
            {
                hex_box.Text = input;

                string hBin = "";

                // c를 이진수로 변환
                foreach (char c in input)
                {
                    int temp = Convert.ToInt32(c.ToString(), 16);
                    string sqH = "";
                    if (temp - 8 >= 0) { sqH += "1"; temp -= 8; }
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

        private void shift_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sh = btn.Text;
            if (sh == ">>") result_box.Text = temp + " Rsh ";
            else temp_box.Text = temp + " Lsh ";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            equal_flag = true;

            temp_box.Text += " =";
            int sh_result = 0;
            if (sh != "")
            {
                string[] splitSim = { "Rsh", "Lsh" };
                string[] split_num = temp_box.Text.Split(splitSim, 2, StringSplitOptions.RemoveEmptyEntries);
                if (sh == ">>")
                {
                    sh_result = int.Parse(split_num[0]) >> int.Parse(split_num[1]);
                }
                else if (sh == "<<")
                {
                    sh_result = int.Parse(split_num[0]) << int.Parse(split_num[1]);
                }
                result_box.Text = sh_result.ToString();
            }

            if (!string.IsNullOrEmpty(operater))
            {
                result_box.Text = result.ToString();
                operater = "";
                numChanger(result.ToString());
            }
            temp = "";
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operater = btn.Text;
            temp_box.Text = temp + operater;
            temp_b = temp;
            temp = "";
        }
    }
}
