namespace Lab5
{
    partial class SettingsDialog
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
            this.integer = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.inputInteger = new System.Windows.Forms.TextBox();
            this.inputCount = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integer
            // 
            this.integer.AutoSize = true;
            this.integer.Location = new System.Drawing.Point(151, 112);
            this.integer.Name = "integer";
            this.integer.Size = new System.Drawing.Size(543, 32);
            this.integer.TabIndex = 0;
            this.integer.Text = "Enter a starting integer (0-1,000,000,000):";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(1019, 109);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(265, 32);
            this.count.TabIndex = 1;
            this.count.Text = "Enter count (1-100):";
            // 
            // inputInteger
            // 
            this.inputInteger.Location = new System.Drawing.Point(709, 112);
            this.inputInteger.Name = "inputInteger";
            this.inputInteger.Size = new System.Drawing.Size(223, 38);
            this.inputInteger.TabIndex = 2;
            // 
            // inputCount
            // 
            this.inputCount.Location = new System.Drawing.Point(1302, 106);
            this.inputCount.Name = "inputCount";
            this.inputCount.Size = new System.Drawing.Size(147, 38);
            this.inputCount.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(618, 325);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(165, 51);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(1005, 325);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(181, 51);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(464, 227);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(835, 46);
            this.error.TabIndex = 6;
            this.error.Text = "Please enter a positive integer within range.";
            this.error.Visible = false;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1755, 548);
            this.ControlBox = false;
            this.Controls.Add(this.error);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.inputCount);
            this.Controls.Add(this.inputInteger);
            this.Controls.Add(this.count);
            this.Controls.Add(this.integer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integer;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox inputInteger;
        private System.Windows.Forms.TextBox inputCount;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label error;
    }
}