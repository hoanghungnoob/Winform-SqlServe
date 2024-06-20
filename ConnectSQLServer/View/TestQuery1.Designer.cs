
namespace ConnectSQLServer.View
{
    partial class TestQuery1
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
            this.btnTruyVan = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.CloseProgram = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.Location = new System.Drawing.Point(294, 129);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(75, 23);
            this.btnTruyVan.TabIndex = 0;
            this.btnTruyVan.Text = "Truy vấn";
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trả về kết quả truy vấn";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(431, 180);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(209, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "truy vấn trả về 1 dòng dữ liệu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // CloseProgram
            // 
            this.CloseProgram.Location = new System.Drawing.Point(710, 29);
            this.CloseProgram.Name = "CloseProgram";
            this.CloseProgram.Size = new System.Drawing.Size(75, 23);
            this.CloseProgram.TabIndex = 3;
            this.CloseProgram.Text = "Close program";
            this.CloseProgram.Click += new System.EventHandler(this.btnCloseProgram);
            // 
            // TestQuery1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 331);
            this.Controls.Add(this.CloseProgram);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTruyVan);
            this.Name = "TestQuery1";
            this.Text = "TestQuery1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTruyVan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton CloseProgram;
    }
}