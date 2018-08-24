namespace D.T_Product_Management.PL
{
    partial class FRM_Products
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Sava_Excel = new MonoFlat.MonoFlat_Button();
            this.btn_Exite = new MonoFlat.MonoFlat_Button();
            this.btn_Delete = new MonoFlat.MonoFlat_Button();
            this.btn_Print = new MonoFlat.MonoFlat_Button();
            this.btn_Print_Selected = new MonoFlat.MonoFlat_Button();
            this.btn_Image = new MonoFlat.MonoFlat_Button();
            this.btn_Edit = new MonoFlat.MonoFlat_Button();
            this.btn_ADD = new MonoFlat.MonoFlat_Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(988, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ابحث عن المنتج";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Search.Location = new System.Drawing.Point(286, 58);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(645, 32);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Data);
            this.groupBox1.Location = new System.Drawing.Point(25, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1410, 437);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عرض المنتجات";
            // 
            // DGV_Data
            // 
            this.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Data.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Data.Location = new System.Drawing.Point(3, 20);
            this.DGV_Data.Name = "DGV_Data";
            this.DGV_Data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_Data.RowTemplate.Height = 26;
            this.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Data.Size = new System.Drawing.Size(1401, 411);
            this.DGV_Data.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Sava_Excel);
            this.groupBox2.Controls.Add(this.btn_Exite);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Print);
            this.groupBox2.Controls.Add(this.btn_Print_Selected);
            this.groupBox2.Controls.Add(this.btn_Image);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_ADD);
            this.groupBox2.Location = new System.Drawing.Point(28, 583);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1380, 162);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // btn_Sava_Excel
            // 
            this.btn_Sava_Excel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sava_Excel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Sava_Excel.Image = null;
            this.btn_Sava_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sava_Excel.Location = new System.Drawing.Point(552, 103);
            this.btn_Sava_Excel.Name = "btn_Sava_Excel";
            this.btn_Sava_Excel.Size = new System.Drawing.Size(264, 28);
            this.btn_Sava_Excel.TabIndex = 13;
            this.btn_Sava_Excel.Text = "حفظ الاصناف فى ملف اكسل";
            this.btn_Sava_Excel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Sava_Excel.Click += new System.EventHandler(this.btn_Sava_Excel_Click);
            // 
            // btn_Exite
            // 
            this.btn_Exite.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exite.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Exite.Image = null;
            this.btn_Exite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exite.Location = new System.Drawing.Point(313, 103);
            this.btn_Exite.Name = "btn_Exite";
            this.btn_Exite.Size = new System.Drawing.Size(185, 28);
            this.btn_Exite.TabIndex = 12;
            this.btn_Exite.Text = "الخروج";
            this.btn_Exite.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Exite.Click += new System.EventHandler(this.btn_Exite_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Delete.Image = null;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(914, 34);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(185, 28);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "حذف المنتج المحدد";
            this.btn_Delete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.Transparent;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Print.Image = null;
            this.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.Location = new System.Drawing.Point(853, 103);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(185, 28);
            this.btn_Print.TabIndex = 7;
            this.btn_Print.Text = "طباعه كل المنتجات";
            this.btn_Print.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Print_Selected
            // 
            this.btn_Print_Selected.BackColor = System.Drawing.Color.Transparent;
            this.btn_Print_Selected.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Print_Selected.Image = null;
            this.btn_Print_Selected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print_Selected.Location = new System.Drawing.Point(100, 34);
            this.btn_Print_Selected.Name = "btn_Print_Selected";
            this.btn_Print_Selected.Size = new System.Drawing.Size(185, 28);
            this.btn_Print_Selected.TabIndex = 8;
            this.btn_Print_Selected.Text = "طباعه المنتج المحدد";
            this.btn_Print_Selected.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Print_Selected.Click += new System.EventHandler(this.btn_Print_Selected_Click);
            // 
            // btn_Image
            // 
            this.btn_Image.BackColor = System.Drawing.Color.Transparent;
            this.btn_Image.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Image.Image = null;
            this.btn_Image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Image.Location = new System.Drawing.Point(363, 34);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(185, 28);
            this.btn_Image.TabIndex = 9;
            this.btn_Image.Text = "صوره المنتج";
            this.btn_Image.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Edit.Image = null;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(656, 34);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(185, 28);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "تعديل بيانات المنتج";
            this.btn_Edit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_ADD
            // 
            this.btn_ADD.BackColor = System.Drawing.Color.Transparent;
            this.btn_ADD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ADD.Image = null;
            this.btn_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ADD.Location = new System.Drawing.Point(1160, 34);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(185, 28);
            this.btn_ADD.TabIndex = 4;
            this.btn_ADD.Text = "اضافه منتج جديد";
            this.btn_ADD.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // FRM_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 748);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FRM_Products";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اداره المنتجات";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private MonoFlat.MonoFlat_Button btn_ADD;
        private System.Windows.Forms.GroupBox groupBox1;
        private MonoFlat.MonoFlat_Button btn_Print;
        private MonoFlat.MonoFlat_Button btn_Print_Selected;
        private MonoFlat.MonoFlat_Button btn_Image;
        private MonoFlat.MonoFlat_Button btn_Edit;
        private System.Windows.Forms.GroupBox groupBox2;
        private MonoFlat.MonoFlat_Button btn_Sava_Excel;
        private MonoFlat.MonoFlat_Button btn_Exite;
        public System.Windows.Forms.DataGridView DGV_Data;
        public MonoFlat.MonoFlat_Button btn_Delete;
    }
}