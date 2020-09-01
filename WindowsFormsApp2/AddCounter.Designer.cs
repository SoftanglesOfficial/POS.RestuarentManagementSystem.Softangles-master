namespace WindowsFormsApp2
{
    partial class AddCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCounter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVCounter = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnsave = new System.Windows.Forms.Panel();
            this.btnSavelbl = new System.Windows.Forms.Label();
            this.btnSaveimg = new System.Windows.Forms.PictureBox();
            this.btnefresh = new System.Windows.Forms.Panel();
            this.btnRefreshlbl = new System.Windows.Forms.Label();
            this.btnRefreshimg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCounter)).BeginInit();
            this.btnsave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveimg)).BeginInit();
            this.btnefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshimg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 57);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_minimize_window_50;
            this.pictureBox1.Location = new System.Drawing.Point(573, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.OrangeRed;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(15, 5);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(96, 48);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Back_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(637, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add/Modify Section";
            // 
            // txtSection
            // 
            this.txtSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.Location = new System.Drawing.Point(265, 17);
            this.txtSection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(361, 26);
            this.txtSection.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Section Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSection);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-3, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 64);
            this.panel2.TabIndex = 4;
            // 
            // DGVCounter
            // 
            this.DGVCounter.AllowUserToAddRows = false;
            this.DGVCounter.AllowUserToDeleteRows = false;
            this.DGVCounter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.DGVCounter.Location = new System.Drawing.Point(0, 204);
            this.DGVCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVCounter.Name = "DGVCounter";
            this.DGVCounter.ReadOnly = true;
            this.DGVCounter.RowHeadersWidth = 51;
            this.DGVCounter.Size = new System.Drawing.Size(696, 149);
            this.DGVCounter.TabIndex = 5;
            this.DGVCounter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCounter_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 38;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 55;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnsave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnsave.Controls.Add(this.btnSavelbl);
            this.btnsave.Controls.Add(this.btnSaveimg);
            this.btnsave.Location = new System.Drawing.Point(145, 129);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(229, 67);
            this.btnsave.TabIndex = 28;
            this.btnsave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnsave_MouseClick);
            // 
            // btnSavelbl
            // 
            this.btnSavelbl.AutoSize = true;
            this.btnSavelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavelbl.Location = new System.Drawing.Point(116, 25);
            this.btnSavelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSavelbl.Name = "btnSavelbl";
            this.btnSavelbl.Size = new System.Drawing.Size(62, 25);
            this.btnSavelbl.TabIndex = 1;
            this.btnSavelbl.Text = "Save";
            this.btnSavelbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSavelbl_MouseClick);
            // 
            // btnSaveimg
            // 
            this.btnSaveimg.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveimg.Image")));
            this.btnSaveimg.Location = new System.Drawing.Point(1, 4);
            this.btnSaveimg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveimg.Name = "btnSaveimg";
            this.btnSaveimg.Size = new System.Drawing.Size(109, 65);
            this.btnSaveimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSaveimg.TabIndex = 0;
            this.btnSaveimg.TabStop = false;
            this.btnSaveimg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSaveimg_MouseClick);
            // 
            // btnefresh
            // 
            this.btnefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnefresh.Controls.Add(this.btnRefreshlbl);
            this.btnefresh.Controls.Add(this.btnRefreshimg);
            this.btnefresh.Location = new System.Drawing.Point(432, 129);
            this.btnefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnefresh.Name = "btnefresh";
            this.btnefresh.Size = new System.Drawing.Size(219, 67);
            this.btnefresh.TabIndex = 27;
            this.btnefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnefresh_MouseClick);
            // 
            // btnRefreshlbl
            // 
            this.btnRefreshlbl.AutoSize = true;
            this.btnRefreshlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshlbl.Location = new System.Drawing.Point(91, 26);
            this.btnRefreshlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnRefreshlbl.Name = "btnRefreshlbl";
            this.btnRefreshlbl.Size = new System.Drawing.Size(86, 25);
            this.btnRefreshlbl.TabIndex = 1;
            this.btnRefreshlbl.Text = "Refresh";
            this.btnRefreshlbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRefreshlbl_MouseClick);
            // 
            // btnRefreshimg
            // 
            this.btnRefreshimg.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshimg.Image")));
            this.btnRefreshimg.Location = new System.Drawing.Point(1, 4);
            this.btnRefreshimg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshimg.Name = "btnRefreshimg";
            this.btnRefreshimg.Size = new System.Drawing.Size(91, 59);
            this.btnRefreshimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefreshimg.TabIndex = 0;
            this.btnRefreshimg.TabStop = false;
            this.btnRefreshimg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRefreshimg_MouseClick);
            // 
            // AddCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 353);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnefresh);
            this.Controls.Add(this.DGVCounter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCounter";
            this.Load += new System.EventHandler(this.AddCounter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCounter)).EndInit();
            this.btnsave.ResumeLayout(false);
            this.btnsave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveimg)).EndInit();
            this.btnefresh.ResumeLayout(false);
            this.btnefresh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVCounter;
        private System.Windows.Forms.Panel btnsave;
        private System.Windows.Forms.Label btnSavelbl;
        private System.Windows.Forms.PictureBox btnSaveimg;
        private System.Windows.Forms.Panel btnefresh;
        private System.Windows.Forms.Label btnRefreshlbl;
        private System.Windows.Forms.PictureBox btnRefreshimg;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}