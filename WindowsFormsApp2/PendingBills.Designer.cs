namespace WindowsFormsApp2
{
    partial class PendingBills
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.PendingBillsBtnPrintBill = new System.Windows.Forms.Button();
            this.BtnSettlePayments = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnPendingBillUpdate = new System.Windows.Forms.Button();
            this.PanelSettlePayments = new System.Windows.Forms.Panel();
            this.BtnFinish = new System.Windows.Forms.Button();
            this.TextBoxBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCashReceived = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.PanelSettlePayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 362);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(197, 10);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(122, 362);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PendingBillsBtnPrintBill
            // 
            this.PendingBillsBtnPrintBill.Location = new System.Drawing.Point(74, 4);
            this.PendingBillsBtnPrintBill.Margin = new System.Windows.Forms.Padding(2);
            this.PendingBillsBtnPrintBill.Name = "PendingBillsBtnPrintBill";
            this.PendingBillsBtnPrintBill.Size = new System.Drawing.Size(120, 38);
            this.PendingBillsBtnPrintBill.TabIndex = 2;
            this.PendingBillsBtnPrintBill.Text = "Print Bill";
            this.PendingBillsBtnPrintBill.UseVisualStyleBackColor = true;
            this.PendingBillsBtnPrintBill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PendingBillsBtnPrintBill_MouseClick);
            // 
            // BtnSettlePayments
            // 
            this.BtnSettlePayments.Location = new System.Drawing.Point(74, 107);
            this.BtnSettlePayments.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSettlePayments.Name = "BtnSettlePayments";
            this.BtnSettlePayments.Size = new System.Drawing.Size(120, 38);
            this.BtnSettlePayments.TabIndex = 3;
            this.BtnSettlePayments.Text = "Settle Payments";
            this.BtnSettlePayments.UseVisualStyleBackColor = true;
            this.BtnSettlePayments.Click += new System.EventHandler(this.BtnSettlePayments_Click);
            this.BtnSettlePayments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnSettlePayments_MouseClick);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BtnPendingBillUpdate);
            this.MainPanel.Controls.Add(this.BtnSettlePayments);
            this.MainPanel.Controls.Add(this.PendingBillsBtnPrintBill);
            this.MainPanel.Location = new System.Drawing.Point(335, 11);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(245, 157);
            this.MainPanel.TabIndex = 11;
            // 
            // BtnPendingBillUpdate
            // 
            this.BtnPendingBillUpdate.Location = new System.Drawing.Point(74, 55);
            this.BtnPendingBillUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPendingBillUpdate.Name = "BtnPendingBillUpdate";
            this.BtnPendingBillUpdate.Size = new System.Drawing.Size(120, 38);
            this.BtnPendingBillUpdate.TabIndex = 4;
            this.BtnPendingBillUpdate.Text = "Update";
            this.BtnPendingBillUpdate.UseVisualStyleBackColor = true;
            this.BtnPendingBillUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnPendingBillUpdate_MouseClick);
            // 
            // PanelSettlePayments
            // 
            this.PanelSettlePayments.Controls.Add(this.BtnFinish);
            this.PanelSettlePayments.Controls.Add(this.TextBoxBalance);
            this.PanelSettlePayments.Controls.Add(this.label4);
            this.PanelSettlePayments.Controls.Add(this.TextBoxTotalAmount);
            this.PanelSettlePayments.Controls.Add(this.label6);
            this.PanelSettlePayments.Controls.Add(this.label5);
            this.PanelSettlePayments.Controls.Add(this.TextBoxCashReceived);
            this.PanelSettlePayments.Location = new System.Drawing.Point(335, 173);
            this.PanelSettlePayments.Margin = new System.Windows.Forms.Padding(2);
            this.PanelSettlePayments.Name = "PanelSettlePayments";
            this.PanelSettlePayments.Size = new System.Drawing.Size(245, 197);
            this.PanelSettlePayments.TabIndex = 11;
            // 
            // BtnFinish
            // 
            this.BtnFinish.Location = new System.Drawing.Point(0, 165);
            this.BtnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(245, 30);
            this.BtnFinish.TabIndex = 10;
            this.BtnFinish.Text = "Finish";
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnFinish_MouseClick);
            // 
            // TextBoxBalance
            // 
            this.TextBoxBalance.Location = new System.Drawing.Point(118, 114);
            this.TextBoxBalance.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxBalance.Name = "TextBoxBalance";
            this.TextBoxBalance.ReadOnly = true;
            this.TextBoxBalance.Size = new System.Drawing.Size(76, 20);
            this.TextBoxBalance.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Amount";
            // 
            // TextBoxTotalAmount
            // 
            this.TextBoxTotalAmount.Location = new System.Drawing.Point(118, 37);
            this.TextBoxTotalAmount.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxTotalAmount.Name = "TextBoxTotalAmount";
            this.TextBoxTotalAmount.ReadOnly = true;
            this.TextBoxTotalAmount.Size = new System.Drawing.Size(76, 20);
            this.TextBoxTotalAmount.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cash Received";
            // 
            // TextBoxCashReceived
            // 
            this.TextBoxCashReceived.Location = new System.Drawing.Point(118, 76);
            this.TextBoxCashReceived.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCashReceived.Name = "TextBoxCashReceived";
            this.TextBoxCashReceived.Size = new System.Drawing.Size(76, 20);
            this.TextBoxCashReceived.TabIndex = 7;
            this.TextBoxCashReceived.TextChanged += new System.EventHandler(this.TextBoxCashReceived_TextChanged);
            this.TextBoxCashReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCashReceived_KeyPress);
            // 
            // PendingBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 392);
            this.Controls.Add(this.PanelSettlePayments);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PendingBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PendingBills";
            this.Load += new System.EventHandler(this.PendingBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.PanelSettlePayments.ResumeLayout(false);
            this.PanelSettlePayments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button PendingBillsBtnPrintBill;
        private System.Windows.Forms.Button BtnSettlePayments;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelSettlePayments;
        private System.Windows.Forms.Button BtnFinish;
        private System.Windows.Forms.TextBox TextBoxBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCashReceived;
        private System.Windows.Forms.Button BtnPendingBillUpdate;
    }
}