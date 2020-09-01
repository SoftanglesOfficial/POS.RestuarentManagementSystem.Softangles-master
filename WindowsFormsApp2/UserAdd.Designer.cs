namespace WindowsFormsApp2
{
    partial class UserAdd
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
            this.UTextBoxFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UTextBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UTextBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UTextBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UCheckBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.UBtnSave = new System.Windows.Forms.Button();
            this.btnFetchReocrd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UTextBoxFullName
            // 
            this.UTextBoxFullName.Location = new System.Drawing.Point(221, 73);
            this.UTextBoxFullName.Name = "UTextBoxFullName";
            this.UTextBoxFullName.Size = new System.Drawing.Size(221, 22);
            this.UTextBoxFullName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name";
            // 
            // UTextBoxConfirmPassword
            // 
            this.UTextBoxConfirmPassword.Location = new System.Drawing.Point(221, 278);
            this.UTextBoxConfirmPassword.Name = "UTextBoxConfirmPassword";
            this.UTextBoxConfirmPassword.PasswordChar = '*';
            this.UTextBoxConfirmPassword.Size = new System.Drawing.Size(221, 22);
            this.UTextBoxConfirmPassword.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Confirm Password";
            // 
            // UTextBoxPassword
            // 
            this.UTextBoxPassword.Location = new System.Drawing.Point(221, 205);
            this.UTextBoxPassword.Name = "UTextBoxPassword";
            this.UTextBoxPassword.PasswordChar = '*';
            this.UTextBoxPassword.Size = new System.Drawing.Size(221, 22);
            this.UTextBoxPassword.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // UTextBoxUserName
            // 
            this.UTextBoxUserName.Location = new System.Drawing.Point(221, 142);
            this.UTextBoxUserName.Name = "UTextBoxUserName";
            this.UTextBoxUserName.Size = new System.Drawing.Size(221, 22);
            this.UTextBoxUserName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Name";
            // 
            // UCheckBoxIsAdmin
            // 
            this.UCheckBoxIsAdmin.AutoSize = true;
            this.UCheckBoxIsAdmin.Location = new System.Drawing.Point(225, 324);
            this.UCheckBoxIsAdmin.Name = "UCheckBoxIsAdmin";
            this.UCheckBoxIsAdmin.Size = new System.Drawing.Size(18, 17);
            this.UCheckBoxIsAdmin.TabIndex = 16;
            this.UCheckBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "IsAdmin";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(109, 372);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(151, 49);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackBtn_MouseClick);
            // 
            // UBtnSave
            // 
            this.UBtnSave.Location = new System.Drawing.Point(281, 372);
            this.UBtnSave.Name = "UBtnSave";
            this.UBtnSave.Size = new System.Drawing.Size(151, 49);
            this.UBtnSave.TabIndex = 18;
            this.UBtnSave.Text = "Save";
            this.UBtnSave.UseVisualStyleBackColor = true;
            this.UBtnSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UBtnSave_MouseClick);
            // 
            // btnFetchReocrd
            // 
            this.btnFetchReocrd.Location = new System.Drawing.Point(303, 442);
            this.btnFetchReocrd.Name = "btnFetchReocrd";
            this.btnFetchReocrd.Size = new System.Drawing.Size(129, 49);
            this.btnFetchReocrd.TabIndex = 21;
            this.btnFetchReocrd.Text = "Fetch By Email";
            this.btnFetchReocrd.UseVisualStyleBackColor = true;
            this.btnFetchReocrd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFetchReocrd_MouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 455);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 587);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnFetchReocrd);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UBtnSave);
            this.Controls.Add(this.UCheckBoxIsAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UTextBoxConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UTextBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UTextBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UTextBoxFullName);
            this.Name = "UserAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAdd";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UTextBoxFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UTextBoxConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UTextBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UTextBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UCheckBoxIsAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button UBtnSave;
        private System.Windows.Forms.Button btnFetchReocrd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}