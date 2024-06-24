
namespace RibbonUIMaterial
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.editFormUserControl1 = new DevExpress.XtraGrid.Views.Grid.EditFormUserControl();
            this.editFormUserControl2 = new DevExpress.XtraGrid.Views.Grid.EditFormUserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editFormUserControl2.SetBoundPropertyName(this.label1, "");
            this.editFormUserControl1.SetBoundPropertyName(this.label1, "");
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editFormUserControl2.SetBoundPropertyName(this.label2, "");
            this.editFormUserControl1.SetBoundPropertyName(this.label2, "");
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // username
            // 
            this.editFormUserControl2.SetBoundPropertyName(this.username, "");
            this.editFormUserControl1.SetBoundPropertyName(this.username, "");
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(372, 240);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(155, 26);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.editFormUserControl2.SetBoundPropertyName(this.password, "");
            this.editFormUserControl1.SetBoundPropertyName(this.password, "");
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(372, 288);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(155, 26);
            this.password.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.editFormUserControl2.SetBoundPropertyName(this.simpleButton1, "");
            this.editFormUserControl1.SetBoundPropertyName(this.simpleButton1, "");
            this.simpleButton1.Location = new System.Drawing.Point(350, 373);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(99, 40);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Login";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editFormUserControl2.SetBoundPropertyName(this.label3, "");
            this.editFormUserControl1.SetBoundPropertyName(this.label3, "");
            this.label3.Location = new System.Drawing.Point(288, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "You don\'t have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editFormUserControl2.SetBoundPropertyName(this.linkLabel1, "");
            this.editFormUserControl1.SetBoundPropertyName(this.linkLabel1, "");
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.linkLabel1.Location = new System.Drawing.Point(436, 344);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register now";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // editFormUserControl1
            // 
            this.editFormUserControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editFormUserControl1.Appearance.Options.UseBackColor = true;
            this.editFormUserControl2.SetBoundPropertyName(this.editFormUserControl1, "");
            this.editFormUserControl1.Location = new System.Drawing.Point(241, 61);
            this.editFormUserControl1.Name = "editFormUserControl1";
            this.editFormUserControl1.Size = new System.Drawing.Size(314, 395);
            this.editFormUserControl1.TabIndex = 5;
            // 
            // editFormUserControl2
            // 
            this.editFormUserControl1.SetBoundPropertyName(this.editFormUserControl2, "");
            this.editFormUserControl2.Location = new System.Drawing.Point(266, 76);
            this.editFormUserControl2.Name = "editFormUserControl2";
            this.editFormUserControl2.Size = new System.Drawing.Size(261, 141);
            this.editFormUserControl2.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.editFormUserControl2.SetBoundPropertyName(this, "");
            this.editFormUserControl1.SetBoundPropertyName(this, "");
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.editFormUserControl2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editFormUserControl1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.Grid.EditFormUserControl editFormUserControl2;
        private DevExpress.XtraGrid.Views.Grid.EditFormUserControl editFormUserControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}