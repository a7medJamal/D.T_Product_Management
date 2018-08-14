namespace D.T_Product_Management.PL
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
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.btn_Login = new MonoFlat.MonoFlat_Button();
            this.btn_Cancel = new MonoFlat.MonoFlat_Button();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_PWD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.btn_Login);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btn_Cancel);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_User);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_PWD);
            this.monoFlat_ThemeContainer1.Controls.Add(this.label2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.label1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = false;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(735, 230);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "تسجيل الدخول";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Login.Image = null;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(412, 182);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(130, 37);
            this.btn_Login.TabIndex = 13;
            this.btn_Login.Text = "دخول";
            this.btn_Login.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Cancel.Image = null;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.Location = new System.Drawing.Point(260, 182);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(130, 37);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(260, 76);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(205, 27);
            this.txt_User.TabIndex = 9;
            // 
            // txt_PWD
            // 
            this.txt_PWD.Location = new System.Drawing.Point(260, 129);
            this.txt_PWD.Name = "txt_PWD";
            this.txt_PWD.PasswordChar = '*';
            this.txt_PWD.Size = new System.Drawing.Size(205, 27);
            this.txt_PWD.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(575, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "كلمه المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(575, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم المستخدم";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 230);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_PWD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MonoFlat.MonoFlat_Button btn_Cancel;
        private MonoFlat.MonoFlat_Button btn_Login;
    }
}