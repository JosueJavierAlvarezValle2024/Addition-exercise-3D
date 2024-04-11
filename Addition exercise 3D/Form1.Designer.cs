namespace Addition_exercise_3D
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
            btnCalculate = new Button();
            textBox1 = new TextBox();
            txtArray1D = new TextBox();
            txtArray2D = new TextBox();
            txtArray3D = new TextBox();
            txtSumArray3D = new TextBox();
            txtSumArray2D = new TextBox();
            txtSumArray1D = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Aquamarine;
            btnCalculate.Location = new Point(278, 83);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(155, 77);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // txtArray1D
            // 
            txtArray1D.Location = new Point(184, 244);
            txtArray1D.Name = "txtArray1D";
            txtArray1D.Size = new Size(125, 27);
            txtArray1D.TabIndex = 2;
            // 
            // txtArray2D
            // 
            txtArray2D.Location = new Point(184, 308);
            txtArray2D.Name = "txtArray2D";
            txtArray2D.Size = new Size(125, 27);
            txtArray2D.TabIndex = 3;
            // 
            // txtArray3D
            // 
            txtArray3D.Location = new Point(184, 388);
            txtArray3D.Name = "txtArray3D";
            txtArray3D.Size = new Size(125, 27);
            txtArray3D.TabIndex = 4;
            // 
            // txtSumArray3D
            // 
            txtSumArray3D.Location = new Point(491, 388);
            txtSumArray3D.Name = "txtSumArray3D";
            txtSumArray3D.Size = new Size(125, 27);
            txtSumArray3D.TabIndex = 7;
            // 
            // txtSumArray2D
            // 
            txtSumArray2D.Location = new Point(491, 308);
            txtSumArray2D.Name = "txtSumArray2D";
            txtSumArray2D.Size = new Size(125, 27);
            txtSumArray2D.TabIndex = 6;
            // 
            // txtSumArray1D
            // 
            txtSumArray1D.Location = new Point(491, 244);
            txtSumArray1D.Name = "txtSumArray1D";
            txtSumArray1D.Size = new Size(125, 27);
            txtSumArray1D.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 30);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 8;
            label1.Text = "Enter a number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold);
            label2.Location = new Point(195, 171);
            label2.Name = "label2";
            label2.Size = new Size(98, 36);
            label2.TabIndex = 9;
            label2.Text = "Arrays";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold);
            label3.Location = new Point(490, 171);
            label3.Name = "label3";
            label3.Size = new Size(125, 36);
            label3.TabIndex = 10;
            label3.Text = "Addition";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(58, 247);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 11;
            label4.Text = "Array1D";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(58, 315);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 12;
            label5.Text = "Array2D";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(58, 395);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 13;
            label6.Text = "Array3D";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(734, 478);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSumArray3D);
            Controls.Add(txtSumArray2D);
            Controls.Add(txtSumArray1D);
            Controls.Add(txtArray3D);
            Controls.Add(txtArray2D);
            Controls.Add(txtArray1D);
            Controls.Add(textBox1);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox textBox1;
        private TextBox txtArray1D;
        private TextBox txtArray2D;
        private TextBox txtArray3D;
        private TextBox txtSumArray3D;
        private TextBox txtSumArray2D;
        private TextBox txtSumArray1D;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
