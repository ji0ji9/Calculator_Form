namespace Calculator_Form
{
    partial class pro_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chg = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonEqual = new Button();
            buttonDot = new Button();
            button0 = new Button();
            buttonPM = new Button();
            buttonF = new Button();
            buttonPlus = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonE = new Button();
            buttonMinus = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonD = new Button();
            buttonMuitiple = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            buttonC = new Button();
            buttonDivide = new Button();
            buttonPercent = new Button();
            buttonRpar = new Button();
            buttonLpar = new Button();
            buttonB = new Button();
            button_back = new Button();
            buttonCancel = new Button();
            buttonRsh = new Button();
            buttonLsh = new Button();
            buttonA = new Button();
            label1 = new Label();
            result_box = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            bin_box = new TextBox();
            oct_box = new TextBox();
            dec_box = new TextBox();
            buttoBin = new Button();
            buttonOtc = new Button();
            buttonDec = new Button();
            buttonHex = new Button();
            hex_box = new TextBox();
            checkH = new CheckBox();
            checkD = new CheckBox();
            checkO = new CheckBox();
            checkB = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // chg
            // 
            chg.Location = new Point(431, 12);
            chg.Name = "chg";
            chg.Size = new Size(120, 35);
            chg.TabIndex = 0;
            chg.Text = "기본 계산기";
            chg.UseVisualStyleBackColor = true;
            chg.Click += chg_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(buttonEqual, 4, 5);
            tableLayoutPanel1.Controls.Add(buttonDot, 3, 5);
            tableLayoutPanel1.Controls.Add(button0, 2, 5);
            tableLayoutPanel1.Controls.Add(buttonPM, 1, 5);
            tableLayoutPanel1.Controls.Add(buttonF, 0, 5);
            tableLayoutPanel1.Controls.Add(buttonPlus, 4, 4);
            tableLayoutPanel1.Controls.Add(button3, 3, 4);
            tableLayoutPanel1.Controls.Add(button2, 2, 4);
            tableLayoutPanel1.Controls.Add(button1, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonE, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonMinus, 4, 3);
            tableLayoutPanel1.Controls.Add(button6, 3, 3);
            tableLayoutPanel1.Controls.Add(button5, 2, 3);
            tableLayoutPanel1.Controls.Add(button4, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonD, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonMuitiple, 4, 2);
            tableLayoutPanel1.Controls.Add(button9, 3, 2);
            tableLayoutPanel1.Controls.Add(button8, 2, 2);
            tableLayoutPanel1.Controls.Add(button7, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonC, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonDivide, 4, 1);
            tableLayoutPanel1.Controls.Add(buttonPercent, 3, 1);
            tableLayoutPanel1.Controls.Add(buttonRpar, 2, 1);
            tableLayoutPanel1.Controls.Add(buttonLpar, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonB, 0, 1);
            tableLayoutPanel1.Controls.Add(button_back, 4, 0);
            tableLayoutPanel1.Controls.Add(buttonCancel, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonRsh, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonLsh, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonA, 0, 0);
            tableLayoutPanel1.Location = new Point(18, 319);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(533, 311);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(427, 258);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(100, 45);
            buttonEqual.TabIndex = 29;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(321, 258);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(100, 45);
            buttonDot.TabIndex = 28;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(215, 258);
            button0.Name = "button0";
            button0.Size = new Size(100, 45);
            button0.TabIndex = 27;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += num_Click;
            // 
            // buttonPM
            // 
            buttonPM.Location = new Point(109, 258);
            buttonPM.Name = "buttonPM";
            buttonPM.Size = new Size(100, 45);
            buttonPM.TabIndex = 26;
            buttonPM.Text = "±";
            buttonPM.UseVisualStyleBackColor = true;
            // 
            // buttonF
            // 
            buttonF.Location = new Point(3, 258);
            buttonF.Name = "buttonF";
            buttonF.Size = new Size(100, 45);
            buttonF.TabIndex = 25;
            buttonF.Text = "F";
            buttonF.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(427, 207);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(100, 45);
            buttonPlus.TabIndex = 24;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(321, 207);
            button3.Name = "button3";
            button3.Size = new Size(100, 45);
            button3.TabIndex = 23;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += num_Click;
            // 
            // button2
            // 
            button2.Location = new Point(215, 207);
            button2.Name = "button2";
            button2.Size = new Size(100, 45);
            button2.TabIndex = 22;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += num_Click;
            // 
            // button1
            // 
            button1.Location = new Point(109, 207);
            button1.Name = "button1";
            button1.Size = new Size(100, 45);
            button1.TabIndex = 21;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += num_Click;
            // 
            // buttonE
            // 
            buttonE.Location = new Point(3, 207);
            buttonE.Name = "buttonE";
            buttonE.Size = new Size(100, 45);
            buttonE.TabIndex = 20;
            buttonE.Text = "E";
            buttonE.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(427, 156);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(100, 45);
            buttonMinus.TabIndex = 19;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(321, 156);
            button6.Name = "button6";
            button6.Size = new Size(100, 45);
            button6.TabIndex = 18;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += num_Click;
            // 
            // button5
            // 
            button5.Location = new Point(215, 156);
            button5.Name = "button5";
            button5.Size = new Size(100, 45);
            button5.TabIndex = 17;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += num_Click;
            // 
            // button4
            // 
            button4.Location = new Point(109, 156);
            button4.Name = "button4";
            button4.Size = new Size(100, 45);
            button4.TabIndex = 16;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += num_Click;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(3, 156);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(100, 45);
            buttonD.TabIndex = 15;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = true;
            // 
            // buttonMuitiple
            // 
            buttonMuitiple.Location = new Point(427, 105);
            buttonMuitiple.Name = "buttonMuitiple";
            buttonMuitiple.Size = new Size(100, 45);
            buttonMuitiple.TabIndex = 14;
            buttonMuitiple.Text = "×";
            buttonMuitiple.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(321, 105);
            button9.Name = "button9";
            button9.Size = new Size(100, 45);
            button9.TabIndex = 13;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += num_Click;
            // 
            // button8
            // 
            button8.Location = new Point(215, 105);
            button8.Name = "button8";
            button8.Size = new Size(100, 45);
            button8.TabIndex = 12;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += num_Click;
            // 
            // button7
            // 
            button7.Location = new Point(109, 105);
            button7.Name = "button7";
            button7.Size = new Size(100, 45);
            button7.TabIndex = 11;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += num_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(3, 105);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(100, 45);
            buttonC.TabIndex = 10;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(427, 54);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(100, 45);
            buttonDivide.TabIndex = 9;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = true;
            // 
            // buttonPercent
            // 
            buttonPercent.Location = new Point(321, 54);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(100, 45);
            buttonPercent.TabIndex = 8;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            // 
            // buttonRpar
            // 
            buttonRpar.Location = new Point(215, 54);
            buttonRpar.Name = "buttonRpar";
            buttonRpar.Size = new Size(100, 45);
            buttonRpar.TabIndex = 7;
            buttonRpar.Text = ")";
            buttonRpar.UseVisualStyleBackColor = true;
            // 
            // buttonLpar
            // 
            buttonLpar.Location = new Point(109, 54);
            buttonLpar.Name = "buttonLpar";
            buttonLpar.Size = new Size(100, 45);
            buttonLpar.TabIndex = 6;
            buttonLpar.Text = "(";
            buttonLpar.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(3, 54);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(100, 45);
            buttonB.TabIndex = 5;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            button_back.Location = new Point(427, 3);
            button_back.Name = "button_back";
            button_back.Size = new Size(100, 45);
            button_back.TabIndex = 4;
            button_back.Text = "🔙";
            button_back.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(321, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 45);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonRsh
            // 
            buttonRsh.Location = new Point(215, 3);
            buttonRsh.Name = "buttonRsh";
            buttonRsh.Size = new Size(100, 45);
            buttonRsh.TabIndex = 2;
            buttonRsh.Text = ">>";
            buttonRsh.UseVisualStyleBackColor = true;
            // 
            // buttonLsh
            // 
            buttonLsh.Location = new Point(109, 3);
            buttonLsh.Name = "buttonLsh";
            buttonLsh.Size = new Size(100, 45);
            buttonLsh.TabIndex = 1;
            buttonLsh.Text = "<<";
            buttonLsh.UseVisualStyleBackColor = true;
            // 
            // buttonA
            // 
            buttonA.Location = new Point(3, 3);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(100, 45);
            buttonA.TabIndex = 0;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 2;
            label1.Text = "프로그래머";
            // 
            // result_box
            // 
            result_box.Font = new Font("맑은 고딕", 15F);
            result_box.Location = new Point(18, 53);
            result_box.Name = "result_box";
            result_box.Size = new Size(533, 47);
            result_box.TabIndex = 3;
            result_box.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7617264F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.23827F));
            tableLayoutPanel2.Controls.Add(bin_box, 1, 3);
            tableLayoutPanel2.Controls.Add(oct_box, 1, 2);
            tableLayoutPanel2.Controls.Add(dec_box, 1, 1);
            tableLayoutPanel2.Controls.Add(buttoBin, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonOtc, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonDec, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonHex, 0, 0);
            tableLayoutPanel2.Controls.Add(hex_box, 1, 0);
            tableLayoutPanel2.Location = new Point(44, 131);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(507, 159);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // bin_box
            // 
            bin_box.Location = new Point(98, 120);
            bin_box.Name = "bin_box";
            bin_box.Size = new Size(406, 31);
            bin_box.TabIndex = 10;
            // 
            // oct_box
            // 
            oct_box.Location = new Point(98, 81);
            oct_box.Name = "oct_box";
            oct_box.Size = new Size(406, 31);
            oct_box.TabIndex = 9;
            // 
            // dec_box
            // 
            dec_box.Location = new Point(98, 42);
            dec_box.Name = "dec_box";
            dec_box.Size = new Size(406, 31);
            dec_box.TabIndex = 8;
            // 
            // buttoBin
            // 
            buttoBin.Location = new Point(3, 120);
            buttoBin.Name = "buttoBin";
            buttoBin.Size = new Size(89, 33);
            buttoBin.TabIndex = 6;
            buttoBin.Text = "BIN";
            buttoBin.UseVisualStyleBackColor = true;
            buttoBin.Click += mode_Click;
            // 
            // buttonOtc
            // 
            buttonOtc.Location = new Point(3, 81);
            buttonOtc.Name = "buttonOtc";
            buttonOtc.Size = new Size(89, 33);
            buttonOtc.TabIndex = 4;
            buttonOtc.Text = "OCT";
            buttonOtc.UseVisualStyleBackColor = true;
            buttonOtc.Click += mode_Click;
            // 
            // buttonDec
            // 
            buttonDec.Location = new Point(3, 42);
            buttonDec.Name = "buttonDec";
            buttonDec.Size = new Size(89, 33);
            buttonDec.TabIndex = 2;
            buttonDec.Text = "DEC";
            buttonDec.UseVisualStyleBackColor = true;
            buttonDec.Click += mode_Click;
            // 
            // buttonHex
            // 
            buttonHex.Location = new Point(3, 3);
            buttonHex.Name = "buttonHex";
            buttonHex.Size = new Size(89, 33);
            buttonHex.TabIndex = 0;
            buttonHex.Text = "HEX";
            buttonHex.UseVisualStyleBackColor = true;
            buttonHex.Click += mode_Click;
            // 
            // hex_box
            // 
            hex_box.Location = new Point(98, 3);
            hex_box.Name = "hex_box";
            hex_box.Size = new Size(406, 31);
            hex_box.TabIndex = 7;
            // 
            // checkH
            // 
            checkH.AutoCheck = false;
            checkH.AutoSize = true;
            checkH.Checked = true;
            checkH.CheckState = CheckState.Checked;
            checkH.Location = new Point(19, 140);
            checkH.Name = "checkH";
            checkH.Size = new Size(22, 21);
            checkH.TabIndex = 5;
            checkH.UseVisualStyleBackColor = true;
            // 
            // checkD
            // 
            checkD.AutoCheck = false;
            checkD.AutoSize = true;
            checkD.Location = new Point(19, 179);
            checkD.Name = "checkD";
            checkD.Size = new Size(22, 21);
            checkD.TabIndex = 6;
            checkD.UseVisualStyleBackColor = true;
            // 
            // checkO
            // 
            checkO.AutoCheck = false;
            checkO.AutoSize = true;
            checkO.Location = new Point(19, 219);
            checkO.Name = "checkO";
            checkO.Size = new Size(22, 21);
            checkO.TabIndex = 7;
            checkO.UseVisualStyleBackColor = true;
            // 
            // checkB
            // 
            checkB.AutoCheck = false;
            checkB.AutoSize = true;
            checkB.Location = new Point(19, 257);
            checkB.Name = "checkB";
            checkB.Size = new Size(22, 21);
            checkB.TabIndex = 8;
            checkB.UseVisualStyleBackColor = true;
            // 
            // pro_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 658);
            Controls.Add(checkB);
            Controls.Add(checkO);
            Controls.Add(checkD);
            Controls.Add(checkH);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(result_box);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(chg);
            Name = "pro_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pro_Form";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chg;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox result_box;
        private Button buttonA;
        private Button buttonEqual;
        private Button buttonDot;
        private Button button0;
        private Button buttonPM;
        private Button buttonF;
        private Button buttonPlus;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonE;
        private Button buttonMinus;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonD;
        private Button buttonMuitiple;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttonC;
        private Button buttonDivide;
        private Button buttonPercent;
        private Button buttonRpar;
        private Button buttonLpar;
        private Button buttonB;
        private Button button_back;
        private Button buttonCancel;
        private Button buttonRsh;
        private Button buttonLsh;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox bin_box;
        private TextBox oct_box;
        private TextBox dec_box;
        private Button buttoBin;
        private Button buttonOtc;
        private Button buttonDec;
        private Button buttonHex;
        private TextBox hex_box;
        private CheckBox checkH;
        private CheckBox checkD;
        private CheckBox checkO;
        private CheckBox checkB;
    }
}