
namespace MaterialMES2ERP
{
    partial class GetQRWaiting
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
            this.txbQRInput = new System.Windows.Forms.TextBox();
            this.ptbxQRWait = new System.Windows.Forms.PictureBox();
            this.lbScanQR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxQRWait)).BeginInit();
            this.SuspendLayout();
            // 
            // txbQRInput
            // 
            this.txbQRInput.Location = new System.Drawing.Point(15, 15);
            this.txbQRInput.Margin = new System.Windows.Forms.Padding(4);
            this.txbQRInput.Name = "txbQRInput";
            this.txbQRInput.Size = new System.Drawing.Size(168, 27);
            this.txbQRInput.TabIndex = 0;
            this.txbQRInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQRInput_KeyPress);
            // 
            // ptbxQRWait
            // 
            this.ptbxQRWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxQRWait.Image = global::MaterialMES2ERP.Properties.Resources.QRScan;
            this.ptbxQRWait.Location = new System.Drawing.Point(0, 0);
            this.ptbxQRWait.Margin = new System.Windows.Forms.Padding(4);
            this.ptbxQRWait.Name = "ptbxQRWait";
            this.ptbxQRWait.Size = new System.Drawing.Size(400, 300);
            this.ptbxQRWait.TabIndex = 1;
            this.ptbxQRWait.TabStop = false;
            // 
            // lbScanQR
            // 
            this.lbScanQR.AutoSize = true;
            this.lbScanQR.BackColor = System.Drawing.Color.White;
            this.lbScanQR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScanQR.Location = new System.Drawing.Point(71, 250);
            this.lbScanQR.Name = "lbScanQR";
            this.lbScanQR.Size = new System.Drawing.Size(262, 26);
            this.lbScanQR.TabIndex = 2;
            this.lbScanQR.Text = "Vui lòng quét mã vạch ...";
            // 
            // GetQRWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lbScanQR);
            this.Controls.Add(this.ptbxQRWait);
            this.Controls.Add(this.txbQRInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GetQRWaiting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRWaiting";
            this.Deactivate += new System.EventHandler(this.GetQRWaiting_Deactivate);
            this.Load += new System.EventHandler(this.GetQRWaiting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxQRWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbQRInput;
        private System.Windows.Forms.PictureBox ptbxQRWait;
        private System.Windows.Forms.Label lbScanQR;
    }
}