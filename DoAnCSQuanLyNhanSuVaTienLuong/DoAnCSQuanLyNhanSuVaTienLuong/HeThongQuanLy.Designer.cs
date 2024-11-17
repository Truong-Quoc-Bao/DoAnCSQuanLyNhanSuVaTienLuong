namespace DoAnCSQuanLyNhanSuVaTienLuong
{
    partial class HeThongQuanLy
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
            this.btnChamCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChamCong
            // 
            this.btnChamCong.Location = new System.Drawing.Point(416, 51);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(137, 23);
            this.btnChamCong.TabIndex = 0;
            this.btnChamCong.Text = "Chấm Công";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // HeThongQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChamCong);
            this.Name = "HeThongQuanLy";
            this.Text = "HeThongQuanLy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChamCong;
    }
}