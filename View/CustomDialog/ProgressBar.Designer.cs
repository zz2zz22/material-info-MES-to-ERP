
namespace MaterialMES2ERP
{
    partial class ProgressBar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xuipgbProgress = new XanderUI.XUIFlatProgressBar();
            this.lbLoading = new System.Windows.Forms.Label();
            this.lbCustomAnnounce = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MaterialMES2ERP.Properties.Resources.totoro_ring;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // xuipgbProgress
            // 
            this.xuipgbProgress.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.xuipgbProgress.BarThickness = 5;
            this.xuipgbProgress.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuipgbProgress.InocmpletedColor = System.Drawing.Color.White;
            this.xuipgbProgress.Location = new System.Drawing.Point(285, 83);
            this.xuipgbProgress.MaxValue = 100;
            this.xuipgbProgress.Name = "xuipgbProgress";
            this.xuipgbProgress.Size = new System.Drawing.Size(396, 36);
            this.xuipgbProgress.TabIndex = 1;
            this.xuipgbProgress.Value = 50;
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.Location = new System.Drawing.Point(285, 47);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(273, 25);
            this.lbLoading.TabIndex = 2;
            this.lbLoading.Text = "Đang chạy, vui lòng chờ ....";
            // 
            // lbCustomAnnounce
            // 
            this.lbCustomAnnounce.AutoSize = true;
            this.lbCustomAnnounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomAnnounce.Location = new System.Drawing.Point(301, 122);
            this.lbCustomAnnounce.Name = "lbCustomAnnounce";
            this.lbCustomAnnounce.Size = new System.Drawing.Size(0, 20);
            this.lbCustomAnnounce.TabIndex = 3;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 206);
            this.Controls.Add(this.lbCustomAnnounce);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.xuipgbProgress);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProgressBar";
            this.Text = "ProgressBar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIFlatProgressBar xuipgbProgress;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.Label lbCustomAnnounce;
    }
}