namespace D.T_Product_Management
{
    partial class FRM_PREVIEW
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
            this.PIC_PREVIEW = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PREVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // PIC_PREVIEW
            // 
            this.PIC_PREVIEW.Location = new System.Drawing.Point(12, 12);
            this.PIC_PREVIEW.Name = "PIC_PREVIEW";
            this.PIC_PREVIEW.Size = new System.Drawing.Size(776, 426);
            this.PIC_PREVIEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_PREVIEW.TabIndex = 2;
            this.PIC_PREVIEW.TabStop = false;
            // 
            // FRM_PREVIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PIC_PREVIEW);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PREVIEW";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_PREVIEW";
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PREVIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PIC_PREVIEW;
    }
}