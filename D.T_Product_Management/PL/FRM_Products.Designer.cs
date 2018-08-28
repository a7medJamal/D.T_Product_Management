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
            this.btn_Exite = new System.Windows.Forms.Button();
            this.btn_Sava_Excel = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Print_Selected = new System.Windows.Forms.Button();
            this.btn_Image = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_ADD = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(292, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ابحث عن المنتج";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Search.Location = new System.Drawing.Point(475, 57);
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
            this.groupBox2.Controls.Add(this.btn_Exite);
            this.groupBox2.Controls.Add(this.btn_Sava_Excel);
            this.groupBox2.Controls.Add(this.btn_Print);
            this.groupBox2.Controls.Add(this.btn_Print_Selected);
            this.groupBox2.Controls.Add(this.btn_Image);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_ADD);
            this.groupBox2.Location = new System.Drawing.Point(28, 583);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1380, 162);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // btn_Exite
            // 
            this.btn_Exite.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Exite.Location = new System.Drawing.Point(475, 106);
            this.btn_Exite.Name = "btn_Exite";
            this.btn_Exite.Size = new System.Drawing.Size(131, 42);
            this.btn_Exite.TabIndex = 36;
            this.btn_Exite.Text = "الخروج";
            this.btn_Exite.UseVisualStyleBackColor = true;
            // 
            // btn_Sava_Excel
            // 
            this.btn_Sava_Excel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Sava_Excel.Location = new System.Drawing.Point(89, 37);
            this.btn_Sava_Excel.Name = "btn_Sava_Excel";
            this.btn_Sava_Excel.Size = new System.Drawing.Size(249, 42);
            this.btn_Sava_Excel.TabIndex = 35;
            this.btn_Sava_Excel.Text = "حفظ الاصناف فى ملف اكسل";
            this.btn_Sava_Excel.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Print.Location = new System.Drawing.Point(655, 106);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(215, 42);
            this.btn_Print.TabIndex = 34;
            this.btn_Print.Text = "طباعه كل المنتجات";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Print_Selected
            // 
            this.btn_Print_Selected.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Print_Selected.Location = new System.Drawing.Point(362, 37);
            this.btn_Print_Selected.Name = "btn_Print_Selected";
            this.btn_Print_Selected.Size = new System.Drawing.Size(210, 42);
            this.btn_Print_Selected.TabIndex = 33;
            this.btn_Print_Selected.Text = "طباعه المنتج المحدد";
            this.btn_Print_Selected.UseVisualStyleBackColor = true;
            // 
            // btn_Image
            // 
            this.btn_Image.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Image.Location = new System.Drawing.Point(595, 37);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(133, 42);
            this.btn_Image.TabIndex = 32;
            this.btn_Image.Text = "صوره المنتج";
            this.btn_Image.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Location = new System.Drawing.Point(758, 37);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(190, 42);
            this.btn_Edit.TabIndex = 31;
            this.btn_Edit.Text = "تعديل بيانات المنتج";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(969, 37);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(188, 42);
            this.btn_Delete.TabIndex = 30;
            this.btn_Delete.Text = "حذف المنتج المحدد";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_ADD
            // 
            this.btn_ADD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ADD.Location = new System.Drawing.Point(1172, 37);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(129, 42);
            this.btn_ADD.TabIndex = 29;
            this.btn_ADD.Text = "اضافه منتج جديد";
            this.btn_ADD.UseVisualStyleBackColor = true;
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
            this.RightToLeftLayout = true;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView DGV_Data;
        private System.Windows.Forms.Button btn_Exite;
        private System.Windows.Forms.Button btn_Sava_Excel;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Print_Selected;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_ADD;
    }
}