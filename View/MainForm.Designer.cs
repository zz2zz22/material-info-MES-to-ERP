
namespace MaterialMES2ERP
{
    partial class MainForm
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
            this.btExport = new XanderUI.XUIButton();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.txtTest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btExport
            // 
            this.btExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btExport.ButtonImage = global::MaterialMES2ERP.Properties.Resources.excel;
            this.btExport.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btExport.ButtonText = "Export Excel";
            this.btExport.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btExport.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btExport.CornerRadius = 5;
            this.btExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExport.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btExport.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btExport.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btExport.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btExport.Location = new System.Drawing.Point(26, 46);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(115, 45);
            this.btExport.TabIndex = 11;
            this.btExport.TextColor = System.Drawing.Color.DodgerBlue;
            this.btExport.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(12, 120);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(1238, 541);
            this.dtgv.TabIndex = 10;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(161, 61);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(524, 22);
            this.txtTest.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btExport);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIButton btExport;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox txtTest;
    }
}

