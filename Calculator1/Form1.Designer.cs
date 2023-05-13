namespace Calculator1
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            btnEgal = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnC = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(272, 66);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(32, 286);
            button1.Name = "button1";
            button1.Size = new Size(78, 66);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(131, 286);
            button2.Name = "button2";
            button2.Size = new Size(78, 66);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(226, 286);
            button3.Name = "button3";
            button3.Size = new Size(78, 66);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(32, 201);
            button4.Name = "button4";
            button4.Size = new Size(78, 66);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(131, 201);
            button5.Name = "button5";
            button5.Size = new Size(78, 66);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(226, 201);
            button6.Name = "button6";
            button6.Size = new Size(78, 66);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(32, 118);
            button7.Name = "button7";
            button7.Size = new Size(78, 66);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(131, 118);
            button8.Name = "button8";
            button8.Size = new Size(78, 66);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(226, 118);
            button9.Name = "button9";
            button9.Size = new Size(78, 66);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(32, 371);
            button10.Name = "button10";
            button10.Size = new Size(78, 66);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // btnEgal
            // 
            btnEgal.Location = new Point(226, 371);
            btnEgal.Name = "btnEgal";
            btnEgal.Size = new Size(78, 66);
            btnEgal.TabIndex = 11;
            btnEgal.Text = "=";
            btnEgal.UseVisualStyleBackColor = true;
            btnEgal.Click += btnEgal_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(310, 371);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(78, 66);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += BtnPlus_Click_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(310, 286);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(78, 66);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(310, 201);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(78, 66);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(310, 118);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(78, 66);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "%";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(192, 192, 255);
            btnC.Location = new Point(310, 35);
            btnC.Name = "btnC";
            btnC.Size = new Size(78, 66);
            btnC.TabIndex = 16;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // button17
            // 
            button17.Location = new Point(131, 371);
            button17.Name = "button17";
            button17.Size = new Size(78, 66);
            button17.TabIndex = 17;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(414, 465);
            Controls.Add(button17);
            Controls.Add(btnC);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnEgal);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btnEgal;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnC;
        private Button button17;
    }
}