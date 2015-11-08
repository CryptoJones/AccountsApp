namespace AccountsApp
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            this.cLoginTxtBx = new System.Windows.Forms.TextBox();
            this.oPsswrdTxtBx = new System.Windows.Forms.TextBox();
            this.nLoginTxtBx = new System.Windows.Forms.TextBox();
            this.nPsswrdTxtBx = new System.Windows.Forms.TextBox();
            this.cnPsswrdTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cLoginTxtBx
            // 
            this.cLoginTxtBx.Location = new System.Drawing.Point(13, 16);
            this.cLoginTxtBx.Name = "cLoginTxtBx";
            this.cLoginTxtBx.Size = new System.Drawing.Size(100, 20);
            this.cLoginTxtBx.TabIndex = 0;
            // 
            // oPsswrdTxtBx
            // 
            this.oPsswrdTxtBx.Location = new System.Drawing.Point(12, 120);
            this.oPsswrdTxtBx.Name = "oPsswrdTxtBx";
            this.oPsswrdTxtBx.PasswordChar = '*';
            this.oPsswrdTxtBx.Size = new System.Drawing.Size(100, 20);
            this.oPsswrdTxtBx.TabIndex = 2;
            // 
            // nLoginTxtBx
            // 
            this.nLoginTxtBx.Location = new System.Drawing.Point(12, 68);
            this.nLoginTxtBx.Name = "nLoginTxtBx";
            this.nLoginTxtBx.Size = new System.Drawing.Size(100, 20);
            this.nLoginTxtBx.TabIndex = 1;
            // 
            // nPsswrdTxtBx
            // 
            this.nPsswrdTxtBx.Location = new System.Drawing.Point(13, 172);
            this.nPsswrdTxtBx.Name = "nPsswrdTxtBx";
            this.nPsswrdTxtBx.PasswordChar = '*';
            this.nPsswrdTxtBx.Size = new System.Drawing.Size(100, 20);
            this.nPsswrdTxtBx.TabIndex = 3;
            // 
            // cnPsswrdTxtBx
            // 
            this.cnPsswrdTxtBx.Location = new System.Drawing.Point(13, 224);
            this.cnPsswrdTxtBx.Name = "cnPsswrdTxtBx";
            this.cnPsswrdTxtBx.PasswordChar = '*';
            this.cnPsswrdTxtBx.Size = new System.Drawing.Size(100, 20);
            this.cnPsswrdTxtBx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Old Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirm New Password";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(128, 266);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(47, 266);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(257, 304);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnPsswrdTxtBx);
            this.Controls.Add(this.nPsswrdTxtBx);
            this.Controls.Add(this.nLoginTxtBx);
            this.Controls.Add(this.oPsswrdTxtBx);
            this.Controls.Add(this.cLoginTxtBx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cLoginTxtBx;
        private System.Windows.Forms.TextBox oPsswrdTxtBx;
        private System.Windows.Forms.TextBox nLoginTxtBx;
        private System.Windows.Forms.TextBox nPsswrdTxtBx;
        private System.Windows.Forms.TextBox cnPsswrdTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}