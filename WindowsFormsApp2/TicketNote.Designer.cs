namespace WindowsFormsApp2
{
    partial class TicketNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketNote));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TicketNoteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OkayPanel = new System.Windows.Forms.Panel();
            this.OkayLbl = new System.Windows.Forms.Label();
            this.OkayImg = new System.Windows.Forms.PictureBox();
            this.ClearPanel = new System.Windows.Forms.Panel();
            this.ClearLbl = new System.Windows.Forms.Label();
            this.ClearImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.OkayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkayImg)).BeginInit();
            this.ClearPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 55);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add Ticket Note";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(521, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            // 
            // TicketNoteRichTextBox
            // 
            this.TicketNoteRichTextBox.Location = new System.Drawing.Point(0, 55);
            this.TicketNoteRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TicketNoteRichTextBox.Name = "TicketNoteRichTextBox";
            this.TicketNoteRichTextBox.Size = new System.Drawing.Size(415, 313);
            this.TicketNoteRichTextBox.TabIndex = 1;
            this.TicketNoteRichTextBox.Text = "";
            // 
            // OkayPanel
            // 
            this.OkayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OkayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OkayPanel.Controls.Add(this.OkayLbl);
            this.OkayPanel.Controls.Add(this.OkayImg);
            this.OkayPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkayPanel.Location = new System.Drawing.Point(424, 63);
            this.OkayPanel.Margin = new System.Windows.Forms.Padding(4);
            this.OkayPanel.Name = "OkayPanel";
            this.OkayPanel.Size = new System.Drawing.Size(139, 44);
            this.OkayPanel.TabIndex = 2;
            this.OkayPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OkayPanel_MouseClick);
            // 
            // OkayLbl
            // 
            this.OkayLbl.AutoSize = true;
            this.OkayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkayLbl.Location = new System.Drawing.Point(57, 7);
            this.OkayLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OkayLbl.Name = "OkayLbl";
            this.OkayLbl.Size = new System.Drawing.Size(63, 25);
            this.OkayLbl.TabIndex = 1;
            this.OkayLbl.Text = "Okay";
            this.OkayLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OkayLbl_MouseClick);
            // 
            // OkayImg
            // 
            this.OkayImg.Image = ((System.Drawing.Image)(resources.GetObject("OkayImg.Image")));
            this.OkayImg.Location = new System.Drawing.Point(0, -1);
            this.OkayImg.Margin = new System.Windows.Forms.Padding(4);
            this.OkayImg.Name = "OkayImg";
            this.OkayImg.Size = new System.Drawing.Size(49, 44);
            this.OkayImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OkayImg.TabIndex = 0;
            this.OkayImg.TabStop = false;
            this.OkayImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OkayImg_MouseClick);
            // 
            // ClearPanel
            // 
            this.ClearPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClearPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClearPanel.Controls.Add(this.ClearLbl);
            this.ClearPanel.Controls.Add(this.ClearImg);
            this.ClearPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearPanel.Location = new System.Drawing.Point(424, 140);
            this.ClearPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ClearPanel.Name = "ClearPanel";
            this.ClearPanel.Size = new System.Drawing.Size(139, 44);
            this.ClearPanel.TabIndex = 2;
            this.ClearPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearPanel_MouseClick);
            // 
            // ClearLbl
            // 
            this.ClearLbl.AutoSize = true;
            this.ClearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLbl.Location = new System.Drawing.Point(57, 7);
            this.ClearLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClearLbl.Name = "ClearLbl";
            this.ClearLbl.Size = new System.Drawing.Size(64, 25);
            this.ClearLbl.TabIndex = 1;
            this.ClearLbl.Text = "Clear";
            this.ClearLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearLbl_MouseClick);
            // 
            // ClearImg
            // 
            this.ClearImg.Image = ((System.Drawing.Image)(resources.GetObject("ClearImg.Image")));
            this.ClearImg.Location = new System.Drawing.Point(0, -1);
            this.ClearImg.Margin = new System.Windows.Forms.Padding(4);
            this.ClearImg.Name = "ClearImg";
            this.ClearImg.Size = new System.Drawing.Size(49, 44);
            this.ClearImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearImg.TabIndex = 0;
            this.ClearImg.TabStop = false;
            this.ClearImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearImg_MouseClick);
            // 
            // TicketNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 370);
            this.Controls.Add(this.ClearPanel);
            this.Controls.Add(this.OkayPanel);
            this.Controls.Add(this.TicketNoteRichTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketNote";
            this.Load += new System.EventHandler(this.TicketNote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.OkayPanel.ResumeLayout(false);
            this.OkayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkayImg)).EndInit();
            this.ClearPanel.ResumeLayout(false);
            this.ClearPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TicketNoteRichTextBox;
        private System.Windows.Forms.Panel OkayPanel;
        private System.Windows.Forms.Label OkayLbl;
        private System.Windows.Forms.PictureBox OkayImg;
        private System.Windows.Forms.Panel ClearPanel;
        private System.Windows.Forms.Label ClearLbl;
        private System.Windows.Forms.PictureBox ClearImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}