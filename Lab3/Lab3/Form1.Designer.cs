namespace Lab3
{
    partial class Form1
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
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(462, 516);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(142, 46);
            this.sub.TabIndex = 0;
            this.sub.Text = "Sub";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(275, 516);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(142, 46);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button2_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(275, 600);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(142, 46);
            this.mul.TabIndex = 2;
            this.mul.Text = "Mul";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.button3_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(462, 600);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(142, 46);
            this.div.TabIndex = 3;
            this.div.Text = "Div";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.button4_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(255, 350);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(306, 31);
            this.resultBox.TabIndex = 4;
            this.resultBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(255, 282);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(306, 31);
            this.input.TabIndex = 5;
            this.input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result:";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(583, 342);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(142, 46);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(535, 120);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 711);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sub);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label3;
    }
}

