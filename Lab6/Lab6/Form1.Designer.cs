namespace Lab6
{
    partial class EncryptionForm
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
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(60, 120);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(760, 38);
            this.filePathTextBox.TabIndex = 0;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(60, 253);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(237, 38);
            this.keyTextBox.TabIndex = 1;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(54, 75);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(151, 32);
            this.fileName.TabIndex = 2;
            this.fileName.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key:";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(74, 407);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(185, 50);
            this.encrypt.TabIndex = 4;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(364, 407);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(185, 50);
            this.decrypt.TabIndex = 5;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(880, 113);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(185, 50);
            this.browse.TabIndex = 6;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 518);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.filePathTextBox);
            this.Name = "EncryptionForm";
            this.Text = "File Encrypt/Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

