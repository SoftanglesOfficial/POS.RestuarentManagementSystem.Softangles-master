namespace WindowsFormsApp2
{
    partial class User
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
            this.UBtnUpdate = new System.Windows.Forms.Button();
            this.UBtnAddNewUser = new System.Windows.Forms.Button();
            this.UBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UBtnUpdate
            // 
            this.UBtnUpdate.Location = new System.Drawing.Point(192, 233);
            this.UBtnUpdate.Name = "UBtnUpdate";
            this.UBtnUpdate.Size = new System.Drawing.Size(151, 49);
            this.UBtnUpdate.TabIndex = 2;
            this.UBtnUpdate.Text = "Update";
            this.UBtnUpdate.UseVisualStyleBackColor = true;
            this.UBtnUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UBtnUpdate_MouseClick);
            // 
            // UBtnAddNewUser
            // 
            this.UBtnAddNewUser.Location = new System.Drawing.Point(192, 102);
            this.UBtnAddNewUser.Name = "UBtnAddNewUser";
            this.UBtnAddNewUser.Size = new System.Drawing.Size(151, 49);
            this.UBtnAddNewUser.TabIndex = 1;
            this.UBtnAddNewUser.Text = "ADD  NEW USER";
            this.UBtnAddNewUser.UseCompatibleTextRendering = true;
            this.UBtnAddNewUser.UseVisualStyleBackColor = true;
            this.UBtnAddNewUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UBtnAddNewUser_MouseClick);
            // 
            // UBackBtn
            // 
            this.UBackBtn.Location = new System.Drawing.Point(192, 357);
            this.UBackBtn.Name = "UBackBtn";
            this.UBackBtn.Size = new System.Drawing.Size(151, 49);
            this.UBackBtn.TabIndex = 3;
            this.UBackBtn.Text = "Back ";
            this.UBackBtn.UseVisualStyleBackColor = true;
            this.UBackBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UBackBtn_MouseClick);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 587);
            this.ControlBox = false;
            this.Controls.Add(this.UBackBtn);
            this.Controls.Add(this.UBtnAddNewUser);
            this.Controls.Add(this.UBtnUpdate);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button UBtnUpdate;
        private System.Windows.Forms.Button UBtnAddNewUser;
        private System.Windows.Forms.Button UBackBtn;
    }
}