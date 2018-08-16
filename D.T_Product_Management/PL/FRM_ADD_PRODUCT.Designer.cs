namespace D.T_Product_Management.PL
{
    partial class FRM_ADD_PRODUCT
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
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMD_CATEGERORIES = new CS_ClassLibraryTester.SLCComboBox();
            this.btn_Cancel = new MonoFlat.MonoFlat_Button();
            this.btn_ADD = new MonoFlat.MonoFlat_Button();
            this.btn_SelectPic = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label6 = new MonoFlat.MonoFlat_Label();
            this.PICBOX = new System.Windows.Forms.PictureBox();
            this.monoFlat_Label5 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label4 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.txt_Description = new MonoFlat.MonoFlat_TextBox();
            this.txt_QUT = new MonoFlat.MonoFlat_TextBox();
            this.txt_PRICE = new MonoFlat.MonoFlat_TextBox();
            this.txt_ID = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.groupBox2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.groupBox1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(1486, 798);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.monoFlat_ThemeContainer1.TabIndex = 2;
            this.monoFlat_ThemeContainer1.Text = "اضافه المنتجات";
            this.monoFlat_ThemeContainer1.Click += new System.EventHandler(this.monoFlat_ThemeContainer1_Click);
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(1374, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 14;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(37, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1419, 433);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عرض البيانات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1375, 389);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupBox1.Controls.Add(this.CMD_CATEGERORIES);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_ADD);
            this.groupBox1.Controls.Add(this.btn_SelectPic);
            this.groupBox1.Controls.Add(this.monoFlat_Label6);
            this.groupBox1.Controls.Add(this.PICBOX);
            this.groupBox1.Controls.Add(this.monoFlat_Label5);
            this.groupBox1.Controls.Add(this.monoFlat_Label4);
            this.groupBox1.Controls.Add(this.monoFlat_Label3);
            this.groupBox1.Controls.Add(this.monoFlat_Label2);
            this.groupBox1.Controls.Add(this.monoFlat_Label1);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.txt_QUT);
            this.groupBox1.Controls.Add(this.txt_PRICE);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1461, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتجات";
            // 
            // CMD_CATEGERORIES
            // 
            this.CMD_CATEGERORIES.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMD_CATEGERORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMD_CATEGERORIES.FormattingEnabled = true;
            this.CMD_CATEGERORIES.Location = new System.Drawing.Point(1262, 57);
            this.CMD_CATEGERORIES.Name = "CMD_CATEGERORIES";
            this.CMD_CATEGERORIES.Size = new System.Drawing.Size(182, 28);
            this.CMD_CATEGERORIES.TabIndex = 6;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Cancel.Image = null;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.Location = new System.Drawing.Point(514, 185);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(146, 41);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click_1);
            // 
            // btn_ADD
            // 
            this.btn_ADD.BackColor = System.Drawing.Color.Transparent;
            this.btn_ADD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ADD.Image = null;
            this.btn_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ADD.Location = new System.Drawing.Point(791, 185);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(146, 41);
            this.btn_ADD.TabIndex = 5;
            this.btn_ADD.Text = "اضافه";
            this.btn_ADD.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_SelectPic
            // 
            this.btn_SelectPic.BackColor = System.Drawing.Color.Transparent;
            this.btn_SelectPic.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_SelectPic.Image = null;
            this.btn_SelectPic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SelectPic.Location = new System.Drawing.Point(46, 193);
            this.btn_SelectPic.Name = "btn_SelectPic";
            this.btn_SelectPic.Size = new System.Drawing.Size(245, 33);
            this.btn_SelectPic.TabIndex = 4;
            this.btn_SelectPic.Text = "اختيار الصوره";
            this.btn_SelectPic.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_SelectPic.Click += new System.EventHandler(this.btn_SelectPic_Click_1);
            // 
            // monoFlat_Label6
            // 
            this.monoFlat_Label6.AutoSize = true;
            this.monoFlat_Label6.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label6.Location = new System.Drawing.Point(113, 22);
            this.monoFlat_Label6.Name = "monoFlat_Label6";
            this.monoFlat_Label6.Size = new System.Drawing.Size(107, 25);
            this.monoFlat_Label6.TabIndex = 11;
            this.monoFlat_Label6.Text = "صوره المنتح";
            // 
            // PICBOX
            // 
            this.PICBOX.Image = global::D.T_Product_Management.Properties.Resources.no_image_available;
            this.PICBOX.Location = new System.Drawing.Point(46, 57);
            this.PICBOX.Name = "PICBOX";
            this.PICBOX.Size = new System.Drawing.Size(264, 120);
            this.PICBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX.TabIndex = 10;
            this.PICBOX.TabStop = false;
            // 
            // monoFlat_Label5
            // 
            this.monoFlat_Label5.AutoSize = true;
            this.monoFlat_Label5.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label5.Location = new System.Drawing.Point(1092, 22);
            this.monoFlat_Label5.Name = "monoFlat_Label5";
            this.monoFlat_Label5.Size = new System.Drawing.Size(109, 25);
            this.monoFlat_Label5.TabIndex = 9;
            this.monoFlat_Label5.Text = "معرف المنتج";
            // 
            // monoFlat_Label4
            // 
            this.monoFlat_Label4.AutoSize = true;
            this.monoFlat_Label4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label4.Location = new System.Drawing.Point(855, 22);
            this.monoFlat_Label4.Name = "monoFlat_Label4";
            this.monoFlat_Label4.Size = new System.Drawing.Size(110, 25);
            this.monoFlat_Label4.TabIndex = 8;
            this.monoFlat_Label4.Text = "وصف المنتج";
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label3.Location = new System.Drawing.Point(593, 22);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(120, 25);
            this.monoFlat_Label3.TabIndex = 7;
            this.monoFlat_Label3.Text = "الكميه المخزنه";
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(389, 23);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(92, 25);
            this.monoFlat_Label2.TabIndex = 6;
            this.monoFlat_Label2.Text = "ثمن المنتج";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(1308, 22);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(106, 25);
            this.monoFlat_Label1.TabIndex = 5;
            this.monoFlat_Label1.Text = "صنف المنتج";
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.Color.Transparent;
            this.txt_Description.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_Description.Image = null;
            this.txt_Description.Location = new System.Drawing.Point(791, 57);
            this.txt_Description.MaxLength = 32767;
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = false;
            this.txt_Description.Size = new System.Drawing.Size(245, 85);
            this.txt_Description.TabIndex = 1;
            this.txt_Description.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Description.UseSystemPasswordChar = false;
            // 
            // txt_QUT
            // 
            this.txt_QUT.BackColor = System.Drawing.Color.Transparent;
            this.txt_QUT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_QUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_QUT.Image = null;
            this.txt_QUT.Location = new System.Drawing.Point(566, 57);
            this.txt_QUT.MaxLength = 32767;
            this.txt_QUT.Multiline = false;
            this.txt_QUT.Name = "txt_QUT";
            this.txt_QUT.ReadOnly = false;
            this.txt_QUT.Size = new System.Drawing.Size(182, 46);
            this.txt_QUT.TabIndex = 2;
            this.txt_QUT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_QUT.UseSystemPasswordChar = false;
            // 
            // txt_PRICE
            // 
            this.txt_PRICE.BackColor = System.Drawing.Color.Transparent;
            this.txt_PRICE.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_PRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_PRICE.Image = null;
            this.txt_PRICE.Location = new System.Drawing.Point(355, 57);
            this.txt_PRICE.MaxLength = 32767;
            this.txt_PRICE.Multiline = false;
            this.txt_PRICE.Name = "txt_PRICE";
            this.txt_PRICE.ReadOnly = false;
            this.txt_PRICE.Size = new System.Drawing.Size(182, 46);
            this.txt_PRICE.TabIndex = 3;
            this.txt_PRICE.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_PRICE.UseSystemPasswordChar = false;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.Transparent;
            this.txt_ID.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_ID.Image = null;
            this.txt_ID.Location = new System.Drawing.Point(1061, 57);
            this.txt_ID.MaxLength = 32767;
            this.txt_ID.Multiline = false;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = false;
            this.txt_ID.Size = new System.Drawing.Size(182, 46);
            this.txt_ID.TabIndex = 0;
            this.txt_ID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ID.UseSystemPasswordChar = false;
            this.txt_ID.Validated += new System.EventHandler(this.txt_ID_Validated);
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 798);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADD_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "اضافه المنتجات";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_Button btn_ADD;
        private System.Windows.Forms.GroupBox groupBox1;
        private MonoFlat.MonoFlat_Button btn_SelectPic;
        private MonoFlat.MonoFlat_Label monoFlat_Label6;
        private System.Windows.Forms.PictureBox PICBOX;
        private MonoFlat.MonoFlat_Label monoFlat_Label5;
        private MonoFlat.MonoFlat_Label monoFlat_Label4;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_TextBox txt_Description;
        private MonoFlat.MonoFlat_TextBox txt_QUT;
        private MonoFlat.MonoFlat_TextBox txt_PRICE;
        private MonoFlat.MonoFlat_TextBox txt_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MonoFlat.MonoFlat_Button btn_Cancel;
        private CS_ClassLibraryTester.SLCComboBox CMD_CATEGERORIES;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
    }
}