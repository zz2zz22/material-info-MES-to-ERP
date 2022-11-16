
namespace MaterialMES2ERP
{
    partial class PickNewMESOrders
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
            this.dtgvSearchMESOrders = new System.Windows.Forms.DataGridView();
            this.lbSearchLabel = new System.Windows.Forms.Label();
            this.txbSearchMESOrders = new System.Windows.Forms.TextBox();
            this.btnConfirm = new FontAwesome.Sharp.IconButton();
            this.lbERPCodeLabel = new System.Windows.Forms.Label();
            this.lbERPCodeInfo = new System.Windows.Forms.Label();
            this.lbSemiProductLabel = new System.Windows.Forms.Label();
            this.lbSemiProdInfo = new System.Windows.Forms.Label();
            this.lbPlanQty = new System.Windows.Forms.Label();
            this.lbPlanQtyInfo = new System.Windows.Forms.Label();
            this.lbFinishQtyInfo = new System.Windows.Forms.Label();
            this.lbFinishQty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchMESOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSearchMESOrders
            // 
            this.dtgvSearchMESOrders.AllowUserToAddRows = false;
            this.dtgvSearchMESOrders.AllowUserToDeleteRows = false;
            this.dtgvSearchMESOrders.AllowUserToResizeRows = false;
            this.dtgvSearchMESOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvSearchMESOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSearchMESOrders.Location = new System.Drawing.Point(16, 59);
            this.dtgvSearchMESOrders.Name = "dtgvSearchMESOrders";
            this.dtgvSearchMESOrders.ReadOnly = true;
            this.dtgvSearchMESOrders.RowHeadersVisible = false;
            this.dtgvSearchMESOrders.RowHeadersWidth = 51;
            this.dtgvSearchMESOrders.RowTemplate.Height = 24;
            this.dtgvSearchMESOrders.Size = new System.Drawing.Size(858, 330);
            this.dtgvSearchMESOrders.TabIndex = 0;
            this.dtgvSearchMESOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSearchMESOrders_CellClick);
            // 
            // lbSearchLabel
            // 
            this.lbSearchLabel.AutoSize = true;
            this.lbSearchLabel.Location = new System.Drawing.Point(12, 19);
            this.lbSearchLabel.Name = "lbSearchLabel";
            this.lbSearchLabel.Size = new System.Drawing.Size(77, 20);
            this.lbSearchLabel.TabIndex = 1;
            this.lbSearchLabel.Text = "Tìm kiếm";
            // 
            // txbSearchMESOrders
            // 
            this.txbSearchMESOrders.Location = new System.Drawing.Point(106, 16);
            this.txbSearchMESOrders.Name = "txbSearchMESOrders";
            this.txbSearchMESOrders.Size = new System.Drawing.Size(645, 27);
            this.txbSearchMESOrders.TabIndex = 2;
            this.txbSearchMESOrders.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearchMESOrders_KeyPress);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Yellow;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnConfirm.IconColor = System.Drawing.Color.Black;
            this.btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirm.IconSize = 35;
            this.btnConfirm.Location = new System.Drawing.Point(695, 478);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(175, 63);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbERPCodeLabel
            // 
            this.lbERPCodeLabel.AutoSize = true;
            this.lbERPCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbERPCodeLabel.Location = new System.Drawing.Point(13, 405);
            this.lbERPCodeLabel.Name = "lbERPCodeLabel";
            this.lbERPCodeLabel.Size = new System.Drawing.Size(76, 20);
            this.lbERPCodeLabel.TabIndex = 5;
            this.lbERPCodeLabel.Text = "Mã ERP:";
            // 
            // lbERPCodeInfo
            // 
            this.lbERPCodeInfo.AutoSize = true;
            this.lbERPCodeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbERPCodeInfo.Location = new System.Drawing.Point(95, 405);
            this.lbERPCodeInfo.Name = "lbERPCodeInfo";
            this.lbERPCodeInfo.Size = new System.Drawing.Size(0, 20);
            this.lbERPCodeInfo.TabIndex = 6;
            // 
            // lbSemiProductLabel
            // 
            this.lbSemiProductLabel.AutoSize = true;
            this.lbSemiProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemiProductLabel.Location = new System.Drawing.Point(346, 405);
            this.lbSemiProductLabel.Name = "lbSemiProductLabel";
            this.lbSemiProductLabel.Size = new System.Drawing.Size(161, 20);
            this.lbSemiProductLabel.TabIndex = 7;
            this.lbSemiProductLabel.Text = "Mã bán thành phẩm:";
            // 
            // lbSemiProdInfo
            // 
            this.lbSemiProdInfo.AutoSize = true;
            this.lbSemiProdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemiProdInfo.Location = new System.Drawing.Point(513, 405);
            this.lbSemiProdInfo.Name = "lbSemiProdInfo";
            this.lbSemiProdInfo.Size = new System.Drawing.Size(0, 20);
            this.lbSemiProdInfo.TabIndex = 8;
            // 
            // lbPlanQty
            // 
            this.lbPlanQty.AutoSize = true;
            this.lbPlanQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlanQty.Location = new System.Drawing.Point(13, 457);
            this.lbPlanQty.Name = "lbPlanQty";
            this.lbPlanQty.Size = new System.Drawing.Size(155, 20);
            this.lbPlanQty.TabIndex = 9;
            this.lbPlanQty.Text = "Khối lượng yêu cầu:";
            // 
            // lbPlanQtyInfo
            // 
            this.lbPlanQtyInfo.AutoSize = true;
            this.lbPlanQtyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlanQtyInfo.Location = new System.Drawing.Point(174, 457);
            this.lbPlanQtyInfo.Name = "lbPlanQtyInfo";
            this.lbPlanQtyInfo.Size = new System.Drawing.Size(0, 20);
            this.lbPlanQtyInfo.TabIndex = 10;
            // 
            // lbFinishQtyInfo
            // 
            this.lbFinishQtyInfo.AutoSize = true;
            this.lbFinishQtyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinishQtyInfo.Location = new System.Drawing.Point(174, 508);
            this.lbFinishQtyInfo.Name = "lbFinishQtyInfo";
            this.lbFinishQtyInfo.Size = new System.Drawing.Size(0, 20);
            this.lbFinishQtyInfo.TabIndex = 12;
            // 
            // lbFinishQty
            // 
            this.lbFinishQty.AutoSize = true;
            this.lbFinishQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinishQty.Location = new System.Drawing.Point(13, 508);
            this.lbFinishQty.Name = "lbFinishQty";
            this.lbFinishQty.Size = new System.Drawing.Size(147, 20);
            this.lbFinishQty.TabIndex = 11;
            this.lbFinishQty.Text = "Khối lượng đã làm:";
            // 
            // PickNewMESOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lbFinishQtyInfo);
            this.Controls.Add(this.lbFinishQty);
            this.Controls.Add(this.lbPlanQtyInfo);
            this.Controls.Add(this.lbPlanQty);
            this.Controls.Add(this.lbSemiProdInfo);
            this.Controls.Add(this.lbSemiProductLabel);
            this.Controls.Add(this.lbERPCodeInfo);
            this.Controls.Add(this.lbERPCodeLabel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txbSearchMESOrders);
            this.Controls.Add(this.lbSearchLabel);
            this.Controls.Add(this.dtgvSearchMESOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "PickNewMESOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick new order from MES";
            this.Load += new System.EventHandler(this.PickNewMESOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchMESOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSearchMESOrders;
        private System.Windows.Forms.Label lbSearchLabel;
        private System.Windows.Forms.TextBox txbSearchMESOrders;
        private FontAwesome.Sharp.IconButton btnConfirm;
        private System.Windows.Forms.Label lbERPCodeLabel;
        private System.Windows.Forms.Label lbERPCodeInfo;
        private System.Windows.Forms.Label lbSemiProductLabel;
        private System.Windows.Forms.Label lbSemiProdInfo;
        private System.Windows.Forms.Label lbPlanQty;
        private System.Windows.Forms.Label lbPlanQtyInfo;
        private System.Windows.Forms.Label lbFinishQtyInfo;
        private System.Windows.Forms.Label lbFinishQty;
    }
}