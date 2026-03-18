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
            label1 = new Label();
            textBox1 = new TextBox();
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
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(18, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(533, 311);
            tableLayoutPanel1.TabIndex = 1;
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
            // textBox1
            // 
            textBox1.Location = new Point(18, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(533, 31);
            textBox1.TabIndex = 3;
            // 
            // pro_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(chg);
            Name = "pro_Form";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "pro_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chg;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
    }
}