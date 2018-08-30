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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CMD_CATEGERORIES = new System.Windows.Forms.ComboBox();
            this.PICBOX = new System.Windows.Forms.PictureBox();
            this.btn_SelectPic = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_QUT = new System.Windows.Forms.TextBox();
            this.txt_PRICE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CMD_CATEGERORIES);
            this.groupBox1.Controls.Add(this.PICBOX);
            this.groupBox1.Controls.Add(this.btn_SelectPic);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.txt_QUT);
            this.groupBox1.Controls.Add(this.txt_PRICE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه المنتجات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(577, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "الثمن";
            // 
            // CMD_CATEGERORIES
            // 
            this.CMD_CATEGERORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMD_CATEGERORIES.FormattingEnabled = true;
            this.CMD_CATEGERORIES.Location = new System.Drawing.Point(687, 43);
            this.CMD_CATEGERORIES.Name = "CMD_CATEGERORIES";
            this.CMD_CATEGERORIES.Size = new System.Drawing.Size(216, 29);
            this.CMD_CATEGERORIES.TabIndex = 12;
            // 
            // PICBOX
            // 
            this.PICBOX.Image = global::D.T_Product_Management.Properties.Resources.no_image_available;
            this.PICBOX.Location = new System.Drawing.Point(6, 43);
            this.PICBOX.Name = "PICBOX";
            this.PICBOX.Size = new System.Drawing.Size(301, 162);
            this.PICBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX.TabIndex = 11;
            this.PICBOX.TabStop = false;
            // 
            // btn_SelectPic
            // 
            this.btn_SelectPic.Location = new System.Drawing.Point(97, 211);
            this.btn_SelectPic.Name = "btn_SelectPic";
            this.btn_SelectPic.Size = new System.Drawing.Size(102, 34);
            this.btn_SelectPic.TabIndex = 4;
            this.btn_SelectPic.Text = "........";
            this.btn_SelectPic.UseVisualStyleBackColor = true;
            this.btn_SelectPic.Click += new System.EventHandler(this.btn_SelectPic_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(944, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "معرف المنتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(944, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "وصف المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(538, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "الكميه المخزنه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(100, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "صوره المنتج";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_ID.Location = new System.Drawing.Point(687, 101);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(216, 32);
            this.txt_ID.TabIndex = 0;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            this.txt_ID.Validated += new System.EventHandler(this.txt_ID_Validated);
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Description.Location = new System.Drawing.Point(652, 151);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Description.Size = new System.Drawing.Size(251, 94);
            this.txt_Description.TabIndex = 1;
            // 
            // txt_QUT
            // 
            this.txt_QUT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_QUT.Location = new System.Drawing.Point(342, 43);
            this.txt_QUT.MaxLength = 7;
            this.txt_QUT.Name = "txt_QUT";
            this.txt_QUT.Size = new System.Drawing.Size(190, 32);
            this.txt_QUT.TabIndex = 3;
            this.txt_QUT.TextChanged += new System.EventHandler(this.txt_QUT_TextChanged);
            this.txt_QUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QUT_KeyPress);
            // 
            // txt_PRICE
            // 
            this.txt_PRICE.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_PRICE.Location = new System.Drawing.Point(342, 109);
            this.txt_PRICE.MaxLength = 5;
            this.txt_PRICE.Name = "txt_PRICE";
            this.txt_PRICE.Size = new System.Drawing.Size(190, 32);
            this.txt_PRICE.TabIndex = 4;
            this.txt_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PRICE_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(944, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "صنف المنتج";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عرض المنتجات ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 301);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(359, 307);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(156, 37);
            this.btn_ADD.TabIndex = 2;
            this.btn_ADD.Text = "اضافه";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(681, 307);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 37);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 706);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_PRODUCT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافه المنتجات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SelectPic;
        public System.Windows.Forms.PictureBox PICBOX;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_PRICE;
        public System.Windows.Forms.Button btn_ADD;
        public System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.TextBox txt_ID;
        public System.Windows.Forms.TextBox txt_Description;
        public System.Windows.Forms.TextBox txt_QUT;
        public System.Windows.Forms.ComboBox CMD_CATEGERORIES;
    }
}