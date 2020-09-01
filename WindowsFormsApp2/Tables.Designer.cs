namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbxTableStatus = new System.Windows.Forms.CheckBox();
            this.txttableCapacity = new System.Windows.Forms.TextBox();
            this.txttableNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGVtable = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnrefresh = new System.Windows.Forms.Panel();
            this.btnrefreshlbl = new System.Windows.Forms.Label();
            this.ptRefreshImg = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Panel();
            this.btnSavelbl = new System.Windows.Forms.Label();
            this.btnSaveimg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtable)).BeginInit();
            this.panel4.SuspendLayout();
            this.btnrefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptRefreshImg)).BeginInit();
            this.btnSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveimg)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1007, 54);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_minimize_window_50;
            this.pictureBox1.Location = new System.Drawing.Point(881, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
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
            this.Back.Location = new System.Drawing.Point(21, 2);
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
            this.pictureBox3.Location = new System.Drawing.Point(941, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create/Modify Tables";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.chbxTableStatus);
            this.panel2.Controls.Add(this.txttableCapacity);
            this.panel2.Controls.Add(this.txttableNumber);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 423);
            this.panel2.TabIndex = 1;
            // 
            // chbxTableStatus
            // 
            this.chbxTableStatus.AutoSize = true;
            this.chbxTableStatus.Location = new System.Drawing.Point(55, 236);
            this.chbxTableStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbxTableStatus.Name = "chbxTableStatus";
            this.chbxTableStatus.Size = new System.Drawing.Size(94, 21);
            this.chbxTableStatus.TabIndex = 2;
            this.chbxTableStatus.Text = "Is Active ?";
            this.chbxTableStatus.UseVisualStyleBackColor = true;
            // 
            // txttableCapacity
            // 
            this.txttableCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttableCapacity.Location = new System.Drawing.Point(55, 174);
            this.txttableCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttableCapacity.Name = "txttableCapacity";
            this.txttableCapacity.Size = new System.Drawing.Size(312, 30);
            this.txttableCapacity.TabIndex = 1;
            this.txttableCapacity.TextChanged += new System.EventHandler(this.txttableCapacity_TextChanged);
            this.txttableCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttableCapacity_KeyPress);
            // 
            // txttableNumber
            // 
            this.txttableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttableNumber.Location = new System.Drawing.Point(55, 107);
            this.txttableNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttableNumber.Name = "txttableNumber";
            this.txttableNumber.Size = new System.Drawing.Size(312, 30);
            this.txttableNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Table Capacity ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table Number";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGVtable);
            this.panel3.Location = new System.Drawing.Point(427, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 423);
            this.panel3.TabIndex = 2;
            // 
            // DGVtable
            // 
            this.DGVtable.AllowUserToAddRows = false;
            this.DGVtable.AllowUserToDeleteRows = false;
            this.DGVtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.DGVtable.Location = new System.Drawing.Point(4, 4);
            this.DGVtable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVtable.Name = "DGVtable";
            this.DGVtable.ReadOnly = true;
            this.DGVtable.RowHeadersWidth = 51;
            this.DGVtable.Size = new System.Drawing.Size(569, 416);
            this.DGVtable.TabIndex = 0;
            this.DGVtable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVtable_CellMouseClick);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Controls.Add(this.btnrefresh);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Location = new System.Drawing.Point(1, 486);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1003, 86);
            this.panel4.TabIndex = 2;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnrefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnrefresh.Controls.Add(this.btnrefreshlbl);
            this.btnrefresh.Controls.Add(this.ptRefreshImg);
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresh.Location = new System.Drawing.Point(227, 4);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(194, 80);
            this.btnrefresh.TabIndex = 0;
            this.btnrefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnrefresh_MouseClick);
            // 
            // btnrefreshlbl
            // 
            this.btnrefreshlbl.AutoSize = true;
            this.btnrefreshlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefreshlbl.Location = new System.Drawing.Point(91, 26);
            this.btnrefreshlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnrefreshlbl.Name = "btnrefreshlbl";
            this.btnrefreshlbl.Size = new System.Drawing.Size(86, 25);
            this.btnrefreshlbl.TabIndex = 1;
            this.btnrefreshlbl.Text = "Refresh";
            this.btnrefreshlbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnrefreshlbl_MouseClick);
            // 
            // ptRefreshImg
            // 
            this.ptRefreshImg.Image = ((System.Drawing.Image)(resources.GetObject("ptRefreshImg.Image")));
            this.ptRefreshImg.Location = new System.Drawing.Point(1, 4);
            this.ptRefreshImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptRefreshImg.Name = "ptRefreshImg";
            this.ptRefreshImg.Size = new System.Drawing.Size(91, 66);
            this.ptRefreshImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptRefreshImg.TabIndex = 0;
            this.ptRefreshImg.TabStop = false;
            this.ptRefreshImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptRefreshImg_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSave.Controls.Add(this.btnSavelbl);
            this.btnSave.Controls.Add(this.btnSaveimg);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(4, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 80);
            this.btnSave.TabIndex = 0;
            this.btnSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseClick);
            // 
            // btnSavelbl
            // 
            this.btnSavelbl.AutoSize = true;
            this.btnSavelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavelbl.Location = new System.Drawing.Point(120, 26);
            this.btnSavelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSavelbl.Name = "btnSavelbl";
            this.btnSavelbl.Size = new System.Drawing.Size(51, 25);
            this.btnSavelbl.TabIndex = 1;
            this.btnSavelbl.Text = "Add";
            this.btnSavelbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSavelbl_MouseClick);
            // 
            // btnSaveimg
            // 
            this.btnSaveimg.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveimg.Image")));
            this.btnSaveimg.Location = new System.Drawing.Point(0, 4);
            this.btnSaveimg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveimg.Name = "btnSaveimg";
            this.btnSaveimg.Size = new System.Drawing.Size(109, 73);
            this.btnSaveimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSaveimg.TabIndex = 0;
            this.btnSaveimg.TabStop = false;
            this.btnSaveimg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSaveimg_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1004, 576);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVtable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.btnrefresh.ResumeLayout(false);
            this.btnrefresh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptRefreshImg)).EndInit();
            this.btnSave.ResumeLayout(false);
            this.btnSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttableCapacity;
        private System.Windows.Forms.TextBox txttableNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVtable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel btnrefresh;
        private System.Windows.Forms.Label btnrefreshlbl;
        private System.Windows.Forms.PictureBox ptRefreshImg;
        private System.Windows.Forms.Panel btnSave;
        private System.Windows.Forms.Label btnSavelbl;
        private System.Windows.Forms.PictureBox btnSaveimg;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chbxTableStatus;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

