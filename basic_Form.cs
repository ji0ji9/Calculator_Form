using System;
using System.Drawing.Imaging;

namespace Calculator_Form
{
    public partial class basic_Form : Form
    {

        private float result;
        private float f_num;
        private float b_num;
        private string operater;
        private bool equal_flag;
        private string temp;


        public basic_Form()
        {
            InitializeComponent();
            input.Text = "";
        }

        //연산 함수
        private float Calculate(float a, float b, string op)
        {
            switch (op)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "×": return a * b;
                case "÷":
                    if (b == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다");
                        Clear_Click(null, null);
                        return 0;
                    }
                    return a / b;
                default: return 0;
            }
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (equal_flag)
            {
                result_box.Clear();
                equal_flag = false;
            }

            if (temp == "0" && btn.Text != ".") temp = ""; // 0만 있는 상태에서 숫자(.은 제외)를 누르면 0을 지움

            temp += btn.Text; // 숫자 연속으로 입력 시, 쌓아줌
            input.Text = temp;

        }

        private void op_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (string.IsNullOrEmpty(temp)) return;

            if (equal_flag) // =으로 연산이 끝난 숫자 바로 뒤 op 올 때 연산 기록 지워 줌
            {
                equal_flag = false;
                result_box.Text = "";
            }

            // 만약 temp에 숫자가 있다면(사용자가 타이핑했거나 루트 결과가 있다면)
            if (!string.IsNullOrEmpty(temp))
            {
                float currentNum = float.Parse(temp);

                if (string.IsNullOrEmpty(operater))  // 기호 없을때(연산 X)
                {
                    f_num = currentNum;
                    // 루트 연산 등을 통해 이미 result_box에 기록이 있다면 temp를 또 쓰지 않음
                    if (result_box.Text == "") result_box.Text = temp;
                }
                else
                {
                    f_num = Calculate(f_num, currentNum, operater);
                    // 이미 루트 기록 등이 있다면 temp 생략, 없으면 temp 추가
                    if (!result_box.Text.EndsWith(")")) result_box.Text += temp;
                }

                temp = ""; // 다음 숫자를 위해 비움
            }

            operater = btn.Text;
            result_box.Text += operater;
            input.Text = f_num.ToString();
        }

        private void singleOp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //if (string.IsNullOrEmpty(temp)) return; // temp가 비어있는지 확인
            //float num = float.Parse(temp);          // Parse 시도, 실패하면 예외 발생 가능
            if (!float.TryParse(temp, out float num)) return; // 위의 두 줄 한 줄로

            float val = 0;
            if (btn.Text == "√") val = (float)Math.Sqrt(num);
            else if (btn.Text == "x²") val = num * num;

            result_box.Text += $"{btn.Text}({num})";
            temp = val.ToString();
            input.Text = temp.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            input.Clear();
            result_box.Clear();
            f_num = 0;
            b_num = 0;
            temp = "";
            operater = "";
            equal_flag = false;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            // temp가 빈 문자열일때
            if (!string.IsNullOrEmpty(temp))
                b_num = float.Parse(temp);

            result = Calculate(f_num, b_num, operater);

            if (temp.EndsWith(")")) result_box.Text += '=';
            else result_box.Text += temp.ToString() + '=';


            input.Text = result.ToString();

            temp = result.ToString();
            operater = "";
            equal_flag = true;
            f_num = 0;
        }

        private void change_Click(object sender, EventArgs e)
        {
            pro_Form proForm = new pro_Form();
            proForm.Owner = this;
            proForm.Show();
            this.Hide();
        }
    }
}
