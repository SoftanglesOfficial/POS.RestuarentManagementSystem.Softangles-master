namespace WindowsFormsApp2
{
    partial class ReportDashboard
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
            this.RDgettotalsalerange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BackBtnRD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
            this.buttonRefund = new System.Windows.Forms.Button();
            this.buttonSaleByItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RDgettotalsalerange
            // 
            this.RDgettotalsalerange.Location = new System.Drawing.Point(148, 94);
            this.RDgettotalsalerange.Name = "RDgettotalsalerange";
            this.RDgettotalsalerange.Size = new System.Drawing.Size(136, 55);
            this.RDgettotalsalerange.TabIndex = 0;
            this.RDgettotalsalerange.Text = "Get Total Sale (Range)";
            this.RDgettotalsalerange.UseVisualStyleBackColor = true;
            this.RDgettotalsalerange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RDgettotalsalerange_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cashier Hour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // BackBtnRD
            // 
            this.BackBtnRD.Location = new System.Drawing.Point(232, 340);
            this.BackBtnRD.Name = "BackBtnRD";
            this.BackBtnRD.Size = new System.Drawing.Size(133, 55);
            this.BackBtnRD.TabIndex = 2;
            this.BackBtnRD.Text = "Back";
            this.BackBtnRD.UseVisualStyleBackColor = true;
            this.BackBtnRD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackBtnRD_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cashier Sale";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(340, 183);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(133, 51);
            this.BtnUser.TabIndex = 4;
            this.BtnUser.Text = "Get All Users";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnUser_MouseClick);
            // 
            // buttonRefund
            // 
            this.buttonRefund.Location = new System.Drawing.Point(340, 94);
            this.buttonRefund.Name = "buttonRefund";
            this.buttonRefund.Size = new System.Drawing.Size(133, 55);
            this.buttonRefund.TabIndex = 5;
            this.buttonRefund.Text = "Get Total Refund Sale (Range)";
            this.buttonRefund.UseVisualStyleBackColor = true;
            this.buttonRefund.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRefund_MouseClick);
            // 
            // buttonSaleByItem
            // 
            this.buttonSaleByItem.Location = new System.Drawing.Point(148, 183);
            this.buttonSaleByItem.Name = "buttonSaleByItem";
            this.buttonSaleByItem.Size = new System.Drawing.Size(136, 55);
            this.buttonSaleByItem.TabIndex = 6;
            this.buttonSaleByItem.Text = "Get Total Sale By Items";
            this.buttonSaleByItem.UseVisualStyleBackColor = true;
            this.buttonSaleByItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSaleByItem_MouseClick);
            // 
            // ReportDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 418);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSaleByItem);
            this.Controls.Add(this.buttonRefund);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BackBtnRD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RDgettotalsalerange);
            this.Name = "ReportDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RDgettotalsalerange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackBtnRD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button buttonRefund;
        private System.Windows.Forms.Button buttonSaleByItem;
    }
}