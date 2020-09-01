namespace WindowsFormsApp2
{
    partial class DeleteDialogBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DeleteBtnYes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DeleteBtnNo = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(4, 47);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 140);
            this.panel7.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Want To Delete This Thing?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Looks Like You Want To Delete This Item?";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 57);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(21, 122);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 57);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DeleteBtnYes);
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 58);
            this.panel4.TabIndex = 0;
            // 
            // DeleteBtnYes
            // 
            this.DeleteBtnYes.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteBtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtnYes.ForeColor = System.Drawing.Color.White;
            this.DeleteBtnYes.Location = new System.Drawing.Point(0, 0);
            this.DeleteBtnYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtnYes.Name = "DeleteBtnYes";
            this.DeleteBtnYes.Size = new System.Drawing.Size(257, 58);
            this.DeleteBtnYes.TabIndex = 0;
            this.DeleteBtnYes.Text = "Yes! I want To Delete";
            this.DeleteBtnYes.UseVisualStyleBackColor = false;
            this.DeleteBtnYes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeleteBtnYes_MouseClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DeleteBtnNo);
            this.panel5.Location = new System.Drawing.Point(279, 122);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 58);
            this.panel5.TabIndex = 0;
            // 
            // DeleteBtnNo
            // 
            this.DeleteBtnNo.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteBtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtnNo.ForeColor = System.Drawing.Color.White;
            this.DeleteBtnNo.Location = new System.Drawing.Point(0, 0);
            this.DeleteBtnNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtnNo.Name = "DeleteBtnNo";
            this.DeleteBtnNo.Size = new System.Drawing.Size(215, 58);
            this.DeleteBtnNo.TabIndex = 0;
            this.DeleteBtnNo.Text = "No! I Don\'t Want To Delete";
            this.DeleteBtnNo.UseVisualStyleBackColor = false;
            this.DeleteBtnNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeleteBtnNo_MouseClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.OrangeRed;
            this.panel6.Location = new System.Drawing.Point(0, 190);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(521, 12);
            this.panel6.TabIndex = 2;
            // 
            // DeleteDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 202);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteDialogBox";
            this.Load += new System.EventHandler(this.DeleteDialogBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DeleteBtnYes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button DeleteBtnNo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}