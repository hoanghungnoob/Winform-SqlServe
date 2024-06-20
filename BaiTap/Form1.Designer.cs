
namespace BaiTap
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbNCC = new System.Windows.Forms.ListBox();
            this.lsvDonDH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài tập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbNCC);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 464);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDonDH);
            this.groupBox2.Location = new System.Drawing.Point(502, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 464);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đơn đặt hàng theo nhà cung cấp";
            // 
            // lsbNCC
            // 
            this.lsbNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbNCC.FormattingEnabled = true;
            this.lsbNCC.Location = new System.Drawing.Point(3, 16);
            this.lsbNCC.Name = "lsbNCC";
            this.lsbNCC.Size = new System.Drawing.Size(334, 445);
            this.lsbNCC.TabIndex = 0;
            this.lsbNCC.SelectedIndexChanged += new System.EventHandler(this.lsbNCC_SelectedIndexChanged);
            // 
            // lsvDonDH
            // 
            this.lsvDonDH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvDonDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDonDH.FullRowSelect = true;
            this.lsvDonDH.GridLines = true;
            this.lsvDonDH.HideSelection = false;
            this.lsvDonDH.Location = new System.Drawing.Point(3, 16);
            this.lsvDonDH.Name = "lsvDonDH";
            this.lsvDonDH.Size = new System.Drawing.Size(334, 445);
            this.lsvDonDH.TabIndex = 0;
            this.lsvDonDH.UseCompatibleStateImageBehavior = false;
            this.lsvDonDH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số đơn hang";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày đặt hàng";
            this.columnHeader2.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbNCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvDonDH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

