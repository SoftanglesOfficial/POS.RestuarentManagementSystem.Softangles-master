namespace WindowsFormsApp2
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.label1 = new System.Windows.Forms.Label();
            this.StrtEndPanel = new System.Windows.Forms.Panel();
            this.StrtEndLbl = new System.Windows.Forms.Label();
            this.StrtEndImg = new System.Windows.Forms.PictureBox();
            this.PosImg = new System.Windows.Forms.PictureBox();
            this.PosPanel = new System.Windows.Forms.Panel();
            this.PosLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CashierLogoutLbl = new System.Windows.Forms.Label();
            this.CashierLogoutPanel = new System.Windows.Forms.Panel();
            this.StrtEndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StrtEndImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosImg)).BeginInit();
            this.PosPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CashierLogoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier Dashboard";
            // 
            // StrtEndPanel
            // 
            this.StrtEndPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StrtEndPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrtEndPanel.Controls.Add(this.StrtEndLbl);
            this.StrtEndPanel.Controls.Add(this.StrtEndImg);
            this.StrtEndPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StrtEndPanel.Location = new System.Drawing.Point(200, 81);
            this.StrtEndPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StrtEndPanel.Name = "StrtEndPanel";
            this.StrtEndPanel.Size = new System.Drawing.Size(185, 76);
            this.StrtEndPanel.TabIndex = 13;
            this.StrtEndPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StrtEndPanel_MouseClick);
            // 
            // StrtEndLbl
            // 
            this.StrtEndLbl.AutoSize = true;
            this.StrtEndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrtEndLbl.Location = new System.Drawing.Point(4, 47);
            this.StrtEndLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StrtEndLbl.Name = "StrtEndLbl";
            this.StrtEndLbl.Size = new System.Drawing.Size(160, 25);
            this.StrtEndLbl.TabIndex = 1;
            this.StrtEndLbl.Text = "Start/End Work";
            this.StrtEndLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StrtEndLbl_MouseClick);
            // 
            // StrtEndImg
            // 
            this.StrtEndImg.Image = ((System.Drawing.Image)(resources.GetObject("StrtEndImg.Image")));
            this.StrtEndImg.Location = new System.Drawing.Point(49, 2);
            this.StrtEndImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StrtEndImg.Name = "StrtEndImg";
            this.StrtEndImg.Size = new System.Drawing.Size(72, 41);
            this.StrtEndImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StrtEndImg.TabIndex = 0;
            this.StrtEndImg.TabStop = false;
            this.StrtEndImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StrtEndImg_MouseClick);
            // 
            // PosImg
            // 
            this.PosImg.Image = ((System.Drawing.Image)(resources.GetObject("PosImg.Image")));
            this.PosImg.Location = new System.Drawing.Point(49, 2);
            this.PosImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PosImg.Name = "PosImg";
            this.PosImg.Size = new System.Drawing.Size(84, 48);
            this.PosImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosImg.TabIndex = 0;
            this.PosImg.TabStop = false;
            this.PosImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PosImg_MouseClick);
            // 
            // PosPanel
            // 
            this.PosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PosPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PosPanel.Controls.Add(this.PosLbl);
            this.PosPanel.Controls.Add(this.PosImg);
            this.PosPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PosPanel.Location = new System.Drawing.Point(519, 81);
            this.PosPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PosPanel.Name = "PosPanel";
            this.PosPanel.Size = new System.Drawing.Size(185, 76);
            this.PosPanel.TabIndex = 17;
            this.PosPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PosPanel_MouseClick);
            // 
            // PosLbl
            // 
            this.PosLbl.AutoSize = true;
            this.PosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosLbl.Location = new System.Drawing.Point(15, 48);
            this.PosLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PosLbl.Name = "PosLbl";
            this.PosLbl.Size = new System.Drawing.Size(135, 25);
            this.PosLbl.TabIndex = 1;
            this.PosLbl.Text = "Point of Sale";
            this.PosLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PosLbl_MouseClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.OrangeRed;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(-1, 185);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1085, 18);
            this.panel7.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(472, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "A Software By Softangles";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1013, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 54);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_minimize_window_50;
            this.pictureBox1.Location = new System.Drawing.Point(947, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // CashierLogoutLbl
            // 
            this.CashierLogoutLbl.AutoSize = true;
            this.CashierLogoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierLogoutLbl.Location = new System.Drawing.Point(47, 28);
            this.CashierLogoutLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CashierLogoutLbl.Name = "CashierLogoutLbl";
            this.CashierLogoutLbl.Size = new System.Drawing.Size(78, 25);
            this.CashierLogoutLbl.TabIndex = 1;
            this.CashierLogoutLbl.Text = "Logout";
            this.CashierLogoutLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CashierLogoutLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CashierLogoutLbl_MouseClick);
            // 
            // CashierLogoutPanel
            // 
            this.CashierLogoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CashierLogoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CashierLogoutPanel.Controls.Add(this.CashierLogoutLbl);
            this.CashierLogoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashierLogoutPanel.Location = new System.Drawing.Point(827, 81);
            this.CashierLogoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CashierLogoutPanel.Name = "CashierLogoutPanel";
            this.CashierLogoutPanel.Size = new System.Drawing.Size(173, 76);
            this.CashierLogoutPanel.TabIndex = 18;
            this.CashierLogoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CashierLogoutPanel_MouseClick);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 203);
            this.Controls.Add(this.CashierLogoutPanel);
            this.Controls.Add(this.StrtEndPanel);
            this.Controls.Add(this.PosPanel);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.StrtEndPanel.ResumeLayout(false);
            this.StrtEndPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StrtEndImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosImg)).EndInit();
            this.PosPanel.ResumeLayout(false);
            this.PosPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CashierLogoutPanel.ResumeLayout(false);
            this.CashierLogoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel StrtEndPanel;
        private System.Windows.Forms.Label StrtEndLbl;
        private System.Windows.Forms.PictureBox StrtEndImg;
        private System.Windows.Forms.PictureBox PosImg;
        private System.Windows.Forms.Panel PosPanel;
        private System.Windows.Forms.Label PosLbl;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CashierLogoutLbl;
        private System.Windows.Forms.Panel CashierLogoutPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}