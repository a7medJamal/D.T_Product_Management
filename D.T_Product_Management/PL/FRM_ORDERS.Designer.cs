namespace D.T_Product_Management.PL
{
    partial class FRM_ORDERS
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btbDeletSelectRow = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnExite = new System.Windows.Forms.Button();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderSUM = new System.Windows.Forms.TextBox();
            this.btnSelectCust = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCustFirstName = new System.Windows.Forms.TextBox();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustMail = new System.Windows.Forms.TextBox();
            this.CustPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderDescription = new System.Windows.Forms.TextBox();
            this.txtOrderSeller = new System.Windows.Forms.TextBox();
            this.datOrderData = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DGW = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.datOrderData);
            this.groupBox1.Controls.Add(this.txtOrderSeller);
            this.groupBox1.Controls.Add(this.txtOrderDescription);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفانوره";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CustPicture);
            this.groupBox2.Controls.Add(this.txtCustMail);
            this.groupBox2.Controls.Add(this.txtCustPhone);
            this.groupBox2.Controls.Add(this.txtCustLastName);
            this.groupBox2.Controls.Add(this.txtCustFirstName);
            this.groupBox2.Controls.Add(this.txtCustID);
            this.groupBox2.Controls.Add(this.btnSelectCust);
            this.groupBox2.Location = new System.Drawing.Point(683, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGW);
            this.groupBox3.Location = new System.Drawing.Point(24, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1341, 343);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            // 
            // btbDeletSelectRow
            // 
            this.btbDeletSelectRow.Location = new System.Drawing.Point(24, 596);
            this.btbDeletSelectRow.Name = "btbDeletSelectRow";
            this.btbDeletSelectRow.Size = new System.Drawing.Size(201, 31);
            this.btbDeletSelectRow.TabIndex = 0;
            this.btbDeletSelectRow.Text = "حذف السطر المحدد";
            this.btbDeletSelectRow.UseVisualStyleBackColor = true;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(401, 652);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(117, 29);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "فاتوره جديده";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // btnExite
            // 
            this.btnExite.Location = new System.Drawing.Point(879, 652);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(117, 29);
            this.btnExite.TabIndex = 3;
            this.btnExite.Text = "خروج";
            this.btnExite.UseVisualStyleBackColor = true;
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Location = new System.Drawing.Point(732, 652);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(117, 29);
            this.btnPrintOrder.TabIndex = 4;
            this.btnPrintOrder.Text = "طباعه الفانوره";
            this.btnPrintOrder.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(558, 652);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(117, 29);
            this.btnSaveOrder.TabIndex = 5;
            this.btnSaveOrder.Text = "حفظ الفانوره";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1036, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "المجموع";
            // 
            // btnOrderSUM
            // 
            this.btnOrderSUM.Location = new System.Drawing.Point(1117, 601);
            this.btnOrderSUM.Name = "btnOrderSUM";
            this.btnOrderSUM.Size = new System.Drawing.Size(236, 26);
            this.btnOrderSUM.TabIndex = 7;
            // 
            // btnSelectCust
            // 
            this.btnSelectCust.Location = new System.Drawing.Point(217, 22);
            this.btnSelectCust.Name = "btnSelectCust";
            this.btnSelectCust.Size = new System.Drawing.Size(112, 34);
            this.btnSelectCust.TabIndex = 8;
            this.btnSelectCust.Text = "تحديد العميل";
            this.btnSelectCust.UseVisualStyleBackColor = true;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(358, 24);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(156, 26);
            this.txtCustID.TabIndex = 8;
            // 
            // txtCustFirstName
            // 
            this.txtCustFirstName.Location = new System.Drawing.Point(311, 65);
            this.txtCustFirstName.Name = "txtCustFirstName";
            this.txtCustFirstName.Size = new System.Drawing.Size(203, 26);
            this.txtCustFirstName.TabIndex = 9;
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Location = new System.Drawing.Point(311, 109);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(203, 26);
            this.txtCustLastName.TabIndex = 10;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(311, 151);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(203, 26);
            this.txtCustPhone.TabIndex = 11;
            // 
            // txtCustMail
            // 
            this.txtCustMail.Location = new System.Drawing.Point(311, 184);
            this.txtCustMail.Name = "txtCustMail";
            this.txtCustMail.Size = new System.Drawing.Size(203, 26);
            this.txtCustMail.TabIndex = 12;
            // 
            // CustPicture
            // 
            this.CustPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustPicture.Location = new System.Drawing.Point(0, 11);
            this.CustPicture.Name = "CustPicture";
            this.CustPicture.Size = new System.Drawing.Size(211, 199);
            this.CustPicture.TabIndex = 0;
            this.CustPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "معرف العميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "البريد الالكترونى";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "رقم الهاتف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "الاسم العائلى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "الاسم الشخصى";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(116, 27);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(156, 26);
            this.txtOrderID.TabIndex = 17;
            // 
            // txtOrderDescription
            // 
            this.txtOrderDescription.Location = new System.Drawing.Point(53, 69);
            this.txtOrderDescription.Multiline = true;
            this.txtOrderDescription.Name = "txtOrderDescription";
            this.txtOrderDescription.Size = new System.Drawing.Size(238, 66);
            this.txtOrderDescription.TabIndex = 18;
            // 
            // txtOrderSeller
            // 
            this.txtOrderSeller.Location = new System.Drawing.Point(91, 189);
            this.txtOrderSeller.Name = "txtOrderSeller";
            this.txtOrderSeller.Size = new System.Drawing.Size(200, 26);
            this.txtOrderSeller.TabIndex = 19;
            // 
            // datOrderData
            // 
            this.datOrderData.Location = new System.Drawing.Point(91, 157);
            this.datOrderData.Name = "datOrderData";
            this.datOrderData.Size = new System.Drawing.Size(200, 26);
            this.datOrderData.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "رقم الفاتوره";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "تاريخ البيع";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "وصف الفاتوره";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "اسم البائع";
            // 
            // DGW
            // 
            this.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW.Location = new System.Drawing.Point(3, 22);
            this.DGW.Name = "DGW";
            this.DGW.RowTemplate.Height = 26;
            this.DGW.Size = new System.Drawing.Size(1332, 315);
            this.DGW.TabIndex = 0;
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 706);
            this.Controls.Add(this.btnOrderSUM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnPrintOrder);
            this.Controls.Add(this.btnExite);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btbDeletSelectRow);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MaximizeBox = false;
            this.Name = "FRM_ORDERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتوره البيع";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datOrderData;
        private System.Windows.Forms.TextBox txtOrderSeller;
        private System.Windows.Forms.TextBox txtOrderDescription;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CustPicture;
        private System.Windows.Forms.TextBox txtCustMail;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustLastName;
        private System.Windows.Forms.TextBox txtCustFirstName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button btnSelectCust;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGW;
        private System.Windows.Forms.Button btbDeletSelectRow;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnExite;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnOrderSUM;
    }
}