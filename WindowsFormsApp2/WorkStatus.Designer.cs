namespace WindowsFormsApp2
{
    partial class WorkStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkStatus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StrtPanel = new System.Windows.Forms.Panel();
            this.StrtLbl = new System.Windows.Forms.Label();
            this.StrtLblImg = new System.Windows.Forms.PictureBox();
            this.EndWorkPanel = new System.Windows.Forms.Panel();
            this.EndWorkLbl = new System.Windows.Forms.Label();
            this.EndWorkImg = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StrtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StrtLblImg)).BeginInit();
            this.EndWorkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndWorkImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 44);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.icons8_minimize_window_50;
            this.pictureBox2.Location = new System.Drawing.Point(500, -5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.OrangeRed;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(19, 5);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(99, 34);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Back_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(557, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 44);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start/End Work";
            // 
            // StrtPanel
            // 
            this.StrtPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StrtPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrtPanel.Controls.Add(this.StrtLbl);
            this.StrtPanel.Controls.Add(this.StrtLblImg);
            this.StrtPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StrtPanel.Location = new System.Drawing.Point(15, 48);
            this.StrtPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StrtPanel.Name = "StrtPanel";
            this.StrtPanel.Size = new System.Drawing.Size(266, 98);
            this.StrtPanel.TabIndex = 1;
            this.StrtPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StrtPanel_MouseClick);
            // 
            // StrtLbl
            // 
            this.StrtLbl.AutoSize = true;
            this.StrtLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StrtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrtLbl.Location = new System.Drawing.Point(136, 37);
            this.StrtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StrtLbl.Name = "StrtLbl";
            this.StrtLbl.Size = new System.Drawing.Size(115, 25);
            this.StrtLbl.TabIndex = 1;
            this.StrtLbl.Text = "Start Work";
            this.StrtLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StrtLbl_MouseClick);
            // 
            // StrtLblImg
            // 
            this.StrtLblImg.Image = ((System.Drawing.Image)(resources.GetObject("StrtLblImg.Image")));
            this.StrtLblImg.Location = new System.Drawing.Point(3, 4);
            this.StrtLblImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StrtLblImg.Name = "StrtLblImg";
            this.StrtLblImg.Size = new System.Drawing.Size(133, 91);
            this.StrtLblImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StrtLblImg.TabIndex = 0;
            this.StrtLblImg.TabStop = false;
            this.StrtLblImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StrtLblImg_MouseClick);
            // 
            // EndWorkPanel
            // 
            this.EndWorkPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.EndWorkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndWorkPanel.Controls.Add(this.EndWorkLbl);
            this.EndWorkPanel.Controls.Add(this.EndWorkImg);
            this.EndWorkPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndWorkPanel.Location = new System.Drawing.Point(331, 48);
            this.EndWorkPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndWorkPanel.Name = "EndWorkPanel";
            this.EndWorkPanel.Size = new System.Drawing.Size(266, 98);
            this.EndWorkPanel.TabIndex = 1;
            this.EndWorkPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EndWorkPanel_MouseClick);
            // 
            // EndWorkLbl
            // 
            this.EndWorkLbl.AutoSize = true;
            this.EndWorkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndWorkLbl.Location = new System.Drawing.Point(143, 37);
            this.EndWorkLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndWorkLbl.Name = "EndWorkLbl";
            this.EndWorkLbl.Size = new System.Drawing.Size(107, 25);
            this.EndWorkLbl.TabIndex = 1;
            this.EndWorkLbl.Text = "End Work";
            this.EndWorkLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EndWorkLbl_MouseClick);
            // 
            // EndWorkImg
            // 
            this.EndWorkImg.Image = ((System.Drawing.Image)(resources.GetObject("EndWorkImg.Image")));
            this.EndWorkImg.Location = new System.Drawing.Point(4, 2);
            this.EndWorkImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndWorkImg.Name = "EndWorkImg";
            this.EndWorkImg.Size = new System.Drawing.Size(133, 91);
            this.EndWorkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndWorkImg.TabIndex = 1;
            this.EndWorkImg.TabStop = false;
            this.EndWorkImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EndWorkImg_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(615, 263);
            this.dataGridView1.TabIndex = 2;
            // 
            // WorkStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EndWorkPanel);
            this.Controls.Add(this.StrtPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WorkStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkStatus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StrtPanel.ResumeLayout(false);
            this.StrtPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StrtLblImg)).EndInit();
            this.EndWorkPanel.ResumeLayout(false);
            this.EndWorkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndWorkImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel StrtPanel;
        private System.Windows.Forms.Label StrtLbl;
        private System.Windows.Forms.PictureBox StrtLblImg;
        private System.Windows.Forms.Panel EndWorkPanel;
        private System.Windows.Forms.Label EndWorkLbl;
        private System.Windows.Forms.PictureBox EndWorkImg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}