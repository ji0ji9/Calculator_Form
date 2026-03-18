namespace Calculator_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            input = new TextBox();
            Clear = new Button();
            button_1 = new Button();
            button_2 = new Button();
            button_3 = new Button();
            button_6 = new Button();
            button_5 = new Button();
            button_4 = new Button();
            button_9 = new Button();
            button_8 = new Button();
            button_7 = new Button();
            equal = new Button();
            add = new Button();
            minus = new Button();
            multiple = new Button();
            divide = new Button();
            button_0 = new Button();
            result_box = new TextBox();
            dot = new Button();
            root = new Button();
            square = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(126, 25);
            Title.TabIndex = 0;
            Title.Text = "윈도우 계산기";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // input
            // 
            input.Font = new Font("맑은 고딕", 18F);
            input.Location = new Point(18, 77);
            input.Name = "input";
            input.Size = new Size(310, 55);
            input.TabIndex = 2;
            // 
            // Clear
            // 
            Clear.Location = new Point(185, 138);
            Clear.Name = "Clear";
            Clear.Size = new Size(69, 54);
            Clear.TabIndex = 2;
            Clear.Text = "clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // button_1
            // 
            button_1.Location = new Point(21, 330);
            button_1.Name = "button_1";
            button_1.Size = new Size(69, 54);
            button_1.TabIndex = 3;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += number_Click;
            // 
            // button_2
            // 
            button_2.Location = new Point(102, 330);
            button_2.Name = "button_2";
            button_2.Size = new Size(69, 54);
            button_2.TabIndex = 4;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += number_Click;
            // 
            // button_3
            // 
            button_3.Location = new Point(185, 330);
            button_3.Name = "button_3";
            button_3.Size = new Size(69, 54);
            button_3.TabIndex = 5;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += number_Click;
            // 
            // button_6
            // 
            button_6.Location = new Point(185, 265);
            button_6.Name = "button_6";
            button_6.Size = new Size(69, 54);
            button_6.TabIndex = 8;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += number_Click;
            // 
            // button_5
            // 
            button_5.Location = new Point(102, 265);
            button_5.Name = "button_5";
            button_5.Size = new Size(69, 54);
            button_5.TabIndex = 7;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += number_Click;
            // 
            // button_4
            // 
            button_4.Location = new Point(21, 265);
            button_4.Name = "button_4";
            button_4.Size = new Size(69, 54);
            button_4.TabIndex = 6;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += number_Click;
            // 
            // button_9
            // 
            button_9.Location = new Point(185, 200);
            button_9.Name = "button_9";
            button_9.Size = new Size(69, 54);
            button_9.TabIndex = 11;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += number_Click;
            // 
            // button_8
            // 
            button_8.Location = new Point(102, 200);
            button_8.Name = "button_8";
            button_8.Size = new Size(69, 54);
            button_8.TabIndex = 10;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += number_Click;
            // 
            // button_7
            // 
            button_7.Location = new Point(21, 200);
            button_7.Name = "button_7";
            button_7.Size = new Size(69, 54);
            button_7.TabIndex = 9;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += number_Click;
            // 
            // equal
            // 
            equal.Location = new Point(265, 393);
            equal.Name = "equal";
            equal.Size = new Size(61, 54);
            equal.TabIndex = 12;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // add
            // 
            add.Location = new Point(265, 330);
            add.Name = "add";
            add.Size = new Size(61, 54);
            add.TabIndex = 13;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += op_Click;
            // 
            // minus
            // 
            minus.Location = new Point(265, 263);
            minus.Name = "minus";
            minus.Size = new Size(61, 54);
            minus.TabIndex = 14;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += op_Click;
            // 
            // multiple
            // 
            multiple.Location = new Point(265, 200);
            multiple.Name = "multiple";
            multiple.Size = new Size(61, 54);
            multiple.TabIndex = 15;
            multiple.Text = "×";
            multiple.UseVisualStyleBackColor = true;
            multiple.Click += op_Click;
            // 
            // divide
            // 
            divide.Location = new Point(265, 138);
            divide.Name = "divide";
            divide.Size = new Size(61, 54);
            divide.TabIndex = 16;
            divide.Text = "÷";
            divide.UseVisualStyleBackColor = true;
            divide.Click += op_Click;
            // 
            // button_0
            // 
            button_0.Location = new Point(102, 393);
            button_0.Name = "button_0";
            button_0.Size = new Size(69, 54);
            button_0.TabIndex = 17;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += number_Click;
            // 
            // result_box
            // 
            result_box.Location = new Point(18, 40);
            result_box.Name = "result_box";
            result_box.Size = new Size(310, 31);
            result_box.TabIndex = 18;
            // 
            // dot
            // 
            dot.Location = new Point(185, 393);
            dot.Name = "dot";
            dot.Size = new Size(69, 54);
            dot.TabIndex = 19;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += number_Click;
            // 
            // root
            // 
            root.Location = new Point(102, 140);
            root.Name = "root";
            root.Size = new Size(69, 54);
            root.TabIndex = 20;
            root.Text = "√";
            root.UseVisualStyleBackColor = true;
            root.Click += SingleOp_Click;
            // 
            // square
            // 
            square.Location = new Point(21, 140);
            square.Name = "square";
            square.Size = new Size(69, 54);
            square.TabIndex = 21;
            square.Text = "x²";
            square.UseVisualStyleBackColor = true;
            square.Click += SingleOp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 518);
            Controls.Add(square);
            Controls.Add(root);
            Controls.Add(dot);
            Controls.Add(result_box);
            Controls.Add(button_0);
            Controls.Add(divide);
            Controls.Add(multiple);
            Controls.Add(minus);
            Controls.Add(add);
            Controls.Add(equal);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(Clear);
            Controls.Add(input);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox input;
        private Button Clear;
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_9;
        private Button button_8;
        private Button button_7;
        private Button equal;
        private Button add;
        private Button minus;
        private Button multiple;
        private Button divide;
        private TextBox result_box;
        private Button dot;
        private Button root;
        private Button square;
    }
}
