namespace WindowsFormsApp2
{
    partial class Add_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Category));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRefreshPanel = new System.Windows.Forms.Panel();
            this.btnRefreshLbl = new System.Windows.Forms.Label();
            this.btnRefreshImg = new System.Windows.Forms.PictureBox();
            this.btnpanelSave = new System.Windows.Forms.Panel();
            this.btnLblSave = new System.Windows.Forms.Label();
            this.btnSaveImg = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.BtnRefreshPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshImg)).BeginInit();
            this.btnpanelSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 65);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_minimize_window_50;
            this.pictureBox1.Location = new System.Drawing.Point(913, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.OrangeRed;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(12, 11);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(96, 48);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Back_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add/Modify Categories";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(973, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(191, 85);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(305, 30);
            this.txtCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.BtnRefreshPanel);
            this.groupBox2.Controls.Add(this.btnpanelSave);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(513, 526);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(511, 110);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // BtnRefreshPanel
            // 
            this.BtnRefreshPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnRefreshPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnRefreshPanel.Controls.Add(this.btnRefreshLbl);
            this.BtnRefreshPanel.Controls.Add(this.btnRefreshImg);
            this.BtnRefreshPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshPanel.Location = new System.Drawing.Point(247, 22);
            this.BtnRefreshPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRefreshPanel.Name = "BtnRefreshPanel";
            this.BtnRefreshPanel.Size = new System.Drawing.Size(207, 72);
            this.BtnRefreshPanel.TabIndex = 1;
            this.BtnRefreshPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRefreshPanel_MouseClick);
            // 
            // btnRefreshLbl
            // 
            this.btnRefreshLbl.AutoSize = true;
            this.btnRefreshLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLbl.Location = new System.Drawing.Point(91, 26);
            this.btnRefreshLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnRefreshLbl.Name = "btnRefreshLbl";
            this.btnRefreshLbl.Size = new System.Drawing.Size(86, 25);
            this.btnRefreshLbl.TabIndex = 1;
            this.btnRefreshLbl.Text = "Refresh";
            this.btnRefreshLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRefreshLbl_MouseClick);
            // 
            // btnRefreshImg
            // 
            this.btnRefreshImg.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshImg.Image")));
            this.btnRefreshImg.Location = new System.Drawing.Point(1, 4);
            this.btnRefreshImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshImg.Name = "btnRefreshImg";
            this.btnRefreshImg.Size = new System.Drawing.Size(91, 59);
            this.btnRefreshImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefreshImg.TabIndex = 0;
            this.btnRefreshImg.TabStop = false;
            this.btnRefreshImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRefreshImg_MouseClick);
            // 
            // btnpanelSave
            // 
            this.btnpanelSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnpanelSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnpanelSave.Controls.Add(this.btnLblSave);
            this.btnpanelSave.Controls.Add(this.btnSaveImg);
            this.btnpanelSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpanelSave.Location = new System.Drawing.Point(12, 22);
            this.btnpanelSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnpanelSave.Name = "btnpanelSave";
            this.btnpanelSave.Size = new System.Drawing.Size(227, 72);
            this.btnpanelSave.TabIndex = 2;
            this.btnpanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnpanelSave_MouseClick);
            // 
            // btnLblSave
            // 
            this.btnLblSave.AutoSize = true;
            this.btnLblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLblSave.Location = new System.Drawing.Point(117, 26);
            this.btnLblSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnLblSave.Name = "btnLblSave";
            this.btnLblSave.Size = new System.Drawing.Size(62, 25);
            this.btnLblSave.TabIndex = 1;
            this.btnLblSave.Text = "Save";
            this.btnLblSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLblSave_MouseClick);
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveImg.Image")));
            this.btnSaveImg.Location = new System.Drawing.Point(0, 4);
            this.btnSaveImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(109, 65);
            this.btnSaveImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSaveImg.TabIndex = 0;
            this.btnSaveImg.TabStop = false;
            this.btnSaveImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSaveImg_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.btnColorPicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 410);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(504, 225);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Information";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(191, 143);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(92, 30);
            this.txtColor.TabIndex = 9;
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Location = new System.Drawing.Point(35, 143);
            this.btnColorPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(144, 30);
            this.btnColorPicker.TabIndex = 7;
            this.btnColorPicker.Text = "Color Picker";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnColorPicker_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 335);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            // Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1040, 639);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Category";
            this.Load += new System.EventHandler(this.Add_Category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.BtnRefreshPanel.ResumeLayout(false);
            this.BtnRefreshPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshImg)).EndInit();
            this.btnpanelSave.ResumeLayout(false);
            this.btnpanelSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel BtnRefreshPanel;
        private System.Windows.Forms.Label btnRefreshLbl;
        private System.Windows.Forms.PictureBox btnRefreshImg;
        private System.Windows.Forms.Panel btnpanelSave;
        private System.Windows.Forms.Label btnLblSave;
        private System.Windows.Forms.PictureBox btnSaveImg;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}