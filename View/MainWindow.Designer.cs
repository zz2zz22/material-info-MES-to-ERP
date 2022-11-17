
namespace MaterialMES2ERP
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnScaleConnect = new FontAwesome.Sharp.IconButton();
            this.btnGuide = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbFinishQtyInfo = new System.Windows.Forms.Label();
            this.lbOrderQtyInfo = new System.Windows.Forms.Label();
            this.lbProdNoInfo = new System.Windows.Forms.Label();
            this.lbOrderNoInfo = new System.Windows.Forms.Label();
            this.lbFinishQty = new System.Windows.Forms.Label();
            this.dtgvWorkOrderMaterials = new System.Windows.Forms.DataGridView();
            this.lbMaterialInfo = new System.Windows.Forms.Label();
            this.lbOrderQty = new System.Windows.Forms.Label();
            this.lbOrderInfo = new System.Windows.Forms.Label();
            this.lbERPCode = new System.Windows.Forms.Label();
            this.lbProductCode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbOngoingOrdersNodata = new System.Windows.Forms.Label();
            this.txbSearchOngoingOrders = new System.Windows.Forms.TextBox();
            this.lbSearchOngoingOrders = new System.Windows.Forms.Label();
            this.lbDTGVOngoingWorkOrder = new System.Windows.Forms.Label();
            this.btnSelectOrderFromMES = new FontAwesome.Sharp.IconButton();
            this.btnRefreshOngoingOrdersList = new FontAwesome.Sharp.IconButton();
            this.dtgvOngoingWorkOrder = new System.Windows.Forms.DataGridView();
            this.panelOrdersInformation = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWorkOrderMaterials)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOngoingWorkOrder)).BeginInit();
            this.panelOrdersInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnScaleConnect);
            this.panelHeader.Controls.Add(this.btnGuide);
            this.panelHeader.Controls.Add(this.btnSetting);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1262, 73);
            this.panelHeader.TabIndex = 0;
            // 
            // btnScaleConnect
            // 
            this.btnScaleConnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnScaleConnect.FlatAppearance.BorderSize = 0;
            this.btnScaleConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScaleConnect.IconChar = FontAwesome.Sharp.IconChar.ScaleBalanced;
            this.btnScaleConnect.IconColor = System.Drawing.Color.Black;
            this.btnScaleConnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScaleConnect.IconSize = 60;
            this.btnScaleConnect.Location = new System.Drawing.Point(984, 0);
            this.btnScaleConnect.Name = "btnScaleConnect";
            this.btnScaleConnect.Size = new System.Drawing.Size(92, 71);
            this.btnScaleConnect.TabIndex = 3;
            this.btnScaleConnect.UseVisualStyleBackColor = true;
            this.btnScaleConnect.Click += new System.EventHandler(this.btnScaleConnect_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnGuide.IconColor = System.Drawing.Color.Black;
            this.btnGuide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuide.IconSize = 60;
            this.btnGuide.Location = new System.Drawing.Point(1076, 0);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(92, 71);
            this.btnGuide.TabIndex = 2;
            this.btnGuide.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSetting.IconColor = System.Drawing.Color.Black;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 60;
            this.btnSetting.Location = new System.Drawing.Point(1168, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(92, 71);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MaterialMES2ERP.Properties.Resources.LogoTechlinkN;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.lbFinishQtyInfo);
            this.panel4.Controls.Add(this.lbOrderQtyInfo);
            this.panel4.Controls.Add(this.lbProdNoInfo);
            this.panel4.Controls.Add(this.lbOrderNoInfo);
            this.panel4.Controls.Add(this.lbFinishQty);
            this.panel4.Controls.Add(this.dtgvWorkOrderMaterials);
            this.panel4.Controls.Add(this.lbMaterialInfo);
            this.panel4.Controls.Add(this.lbOrderQty);
            this.panel4.Controls.Add(this.lbOrderInfo);
            this.panel4.Controls.Add(this.lbERPCode);
            this.panel4.Controls.Add(this.lbProductCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 343);
            this.panel4.TabIndex = 2;
            // 
            // lbFinishQtyInfo
            // 
            this.lbFinishQtyInfo.AutoSize = true;
            this.lbFinishQtyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinishQtyInfo.Location = new System.Drawing.Point(505, 117);
            this.lbFinishQtyInfo.Name = "lbFinishQtyInfo";
            this.lbFinishQtyInfo.Size = new System.Drawing.Size(0, 20);
            this.lbFinishQtyInfo.TabIndex = 13;
            // 
            // lbOrderQtyInfo
            // 
            this.lbOrderQtyInfo.AutoSize = true;
            this.lbOrderQtyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderQtyInfo.Location = new System.Drawing.Point(177, 117);
            this.lbOrderQtyInfo.Name = "lbOrderQtyInfo";
            this.lbOrderQtyInfo.Size = new System.Drawing.Size(0, 20);
            this.lbOrderQtyInfo.TabIndex = 12;
            // 
            // lbProdNoInfo
            // 
            this.lbProdNoInfo.AutoSize = true;
            this.lbProdNoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdNoInfo.Location = new System.Drawing.Point(183, 85);
            this.lbProdNoInfo.Name = "lbProdNoInfo";
            this.lbProdNoInfo.Size = new System.Drawing.Size(0, 20);
            this.lbProdNoInfo.TabIndex = 11;
            // 
            // lbOrderNoInfo
            // 
            this.lbOrderNoInfo.AutoSize = true;
            this.lbOrderNoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderNoInfo.Location = new System.Drawing.Point(98, 55);
            this.lbOrderNoInfo.Name = "lbOrderNoInfo";
            this.lbOrderNoInfo.Size = new System.Drawing.Size(0, 20);
            this.lbOrderNoInfo.TabIndex = 10;
            // 
            // lbFinishQty
            // 
            this.lbFinishQty.AutoSize = true;
            this.lbFinishQty.Location = new System.Drawing.Point(352, 117);
            this.lbFinishQty.Name = "lbFinishQty";
            this.lbFinishQty.Size = new System.Drawing.Size(147, 20);
            this.lbFinishQty.TabIndex = 9;
            this.lbFinishQty.Text = "Khối lượng đã làm:";
            // 
            // dtgvWorkOrderMaterials
            // 
            this.dtgvWorkOrderMaterials.AllowUserToAddRows = false;
            this.dtgvWorkOrderMaterials.AllowUserToDeleteRows = false;
            this.dtgvWorkOrderMaterials.AllowUserToOrderColumns = true;
            this.dtgvWorkOrderMaterials.AllowUserToResizeRows = false;
            this.dtgvWorkOrderMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvWorkOrderMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvWorkOrderMaterials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvWorkOrderMaterials.Location = new System.Drawing.Point(0, 191);
            this.dtgvWorkOrderMaterials.Name = "dtgvWorkOrderMaterials";
            this.dtgvWorkOrderMaterials.ReadOnly = true;
            this.dtgvWorkOrderMaterials.RowHeadersVisible = false;
            this.dtgvWorkOrderMaterials.RowHeadersWidth = 51;
            this.dtgvWorkOrderMaterials.RowTemplate.Height = 24;
            this.dtgvWorkOrderMaterials.Size = new System.Drawing.Size(638, 152);
            this.dtgvWorkOrderMaterials.TabIndex = 8;
            // 
            // lbMaterialInfo
            // 
            this.lbMaterialInfo.AutoSize = true;
            this.lbMaterialInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaterialInfo.Location = new System.Drawing.Point(16, 159);
            this.lbMaterialInfo.Name = "lbMaterialInfo";
            this.lbMaterialInfo.Size = new System.Drawing.Size(349, 20);
            this.lbMaterialInfo.TabIndex = 7;
            this.lbMaterialInfo.Text = "KHỐI LƯỢNG DỰ KIẾN TỪNG MÃ LIỆU:";
            // 
            // lbOrderQty
            // 
            this.lbOrderQty.AutoSize = true;
            this.lbOrderQty.Location = new System.Drawing.Point(16, 117);
            this.lbOrderQty.Name = "lbOrderQty";
            this.lbOrderQty.Size = new System.Drawing.Size(155, 20);
            this.lbOrderQty.TabIndex = 6;
            this.lbOrderQty.Text = "Khối lượng yêu cầu:";
            // 
            // lbOrderInfo
            // 
            this.lbOrderInfo.AutoSize = true;
            this.lbOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderInfo.Location = new System.Drawing.Point(16, 21);
            this.lbOrderInfo.Name = "lbOrderInfo";
            this.lbOrderInfo.Size = new System.Drawing.Size(339, 20);
            this.lbOrderInfo.TabIndex = 4;
            this.lbOrderInfo.Text = "THÔNG TIN ĐƠN ĐANG ĐƯỢC CHỌN:";
            // 
            // lbERPCode
            // 
            this.lbERPCode.AutoSize = true;
            this.lbERPCode.Location = new System.Drawing.Point(16, 55);
            this.lbERPCode.Name = "lbERPCode";
            this.lbERPCode.Size = new System.Drawing.Size(76, 20);
            this.lbERPCode.TabIndex = 0;
            this.lbERPCode.Text = "Mã ERP:";
            // 
            // lbProductCode
            // 
            this.lbProductCode.AutoSize = true;
            this.lbProductCode.Location = new System.Drawing.Point(16, 85);
            this.lbProductCode.Name = "lbProductCode";
            this.lbProductCode.Size = new System.Drawing.Size(161, 20);
            this.lbProductCode.TabIndex = 1;
            this.lbProductCode.Text = "Mã bán thành phẩm:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbOngoingOrdersNodata);
            this.panel3.Controls.Add(this.txbSearchOngoingOrders);
            this.panel3.Controls.Add(this.lbSearchOngoingOrders);
            this.panel3.Controls.Add(this.lbDTGVOngoingWorkOrder);
            this.panel3.Controls.Add(this.btnSelectOrderFromMES);
            this.panel3.Controls.Add(this.btnRefreshOngoingOrdersList);
            this.panel3.Controls.Add(this.dtgvOngoingWorkOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 437);
            this.panel3.TabIndex = 2;
            // 
            // lbOngoingOrdersNodata
            // 
            this.lbOngoingOrdersNodata.AutoSize = true;
            this.lbOngoingOrdersNodata.BackColor = System.Drawing.Color.Transparent;
            this.lbOngoingOrdersNodata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbOngoingOrdersNodata.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOngoingOrdersNodata.Location = new System.Drawing.Point(231, 202);
            this.lbOngoingOrdersNodata.Name = "lbOngoingOrdersNodata";
            this.lbOngoingOrdersNodata.Size = new System.Drawing.Size(171, 38);
            this.lbOngoingOrdersNodata.TabIndex = 6;
            this.lbOngoingOrdersNodata.Text = "NO DATA";
            this.lbOngoingOrdersNodata.Visible = false;
            // 
            // txbSearchOngoingOrders
            // 
            this.txbSearchOngoingOrders.Location = new System.Drawing.Point(87, 54);
            this.txbSearchOngoingOrders.Name = "txbSearchOngoingOrders";
            this.txbSearchOngoingOrders.Size = new System.Drawing.Size(505, 27);
            this.txbSearchOngoingOrders.TabIndex = 5;
            this.txbSearchOngoingOrders.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearchOngoingOrders_KeyPress);
            // 
            // lbSearchOngoingOrders
            // 
            this.lbSearchOngoingOrders.AutoSize = true;
            this.lbSearchOngoingOrders.Location = new System.Drawing.Point(3, 57);
            this.lbSearchOngoingOrders.Name = "lbSearchOngoingOrders";
            this.lbSearchOngoingOrders.Size = new System.Drawing.Size(77, 20);
            this.lbSearchOngoingOrders.TabIndex = 4;
            this.lbSearchOngoingOrders.Text = "Tìm kiếm";
            // 
            // lbDTGVOngoingWorkOrder
            // 
            this.lbDTGVOngoingWorkOrder.AutoSize = true;
            this.lbDTGVOngoingWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDTGVOngoingWorkOrder.Location = new System.Drawing.Point(7, 20);
            this.lbDTGVOngoingWorkOrder.Name = "lbDTGVOngoingWorkOrder";
            this.lbDTGVOngoingWorkOrder.Size = new System.Drawing.Size(430, 20);
            this.lbDTGVOngoingWorkOrder.TabIndex = 3;
            this.lbDTGVOngoingWorkOrder.Text = "DANH SÁCH ĐƠN CHƯA ĐỦ KHỐI LƯỢNG LIỆU:";
            // 
            // btnSelectOrderFromMES
            // 
            this.btnSelectOrderFromMES.BackColor = System.Drawing.Color.Yellow;
            this.btnSelectOrderFromMES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOrderFromMES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOrderFromMES.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnSelectOrderFromMES.IconColor = System.Drawing.Color.Black;
            this.btnSelectOrderFromMES.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectOrderFromMES.IconSize = 30;
            this.btnSelectOrderFromMES.Location = new System.Drawing.Point(341, 379);
            this.btnSelectOrderFromMES.Name = "btnSelectOrderFromMES";
            this.btnSelectOrderFromMES.Size = new System.Drawing.Size(290, 51);
            this.btnSelectOrderFromMES.TabIndex = 2;
            this.btnSelectOrderFromMES.Text = "  CHỌN ĐƠN MỚI TỪ MES";
            this.btnSelectOrderFromMES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectOrderFromMES.UseVisualStyleBackColor = false;
            this.btnSelectOrderFromMES.Click += new System.EventHandler(this.btnSelectOrderFromMES_Click);
            // 
            // btnRefreshOngoingOrdersList
            // 
            this.btnRefreshOngoingOrdersList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefreshOngoingOrdersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshOngoingOrdersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshOngoingOrdersList.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnRefreshOngoingOrdersList.IconColor = System.Drawing.Color.Black;
            this.btnRefreshOngoingOrdersList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshOngoingOrdersList.IconSize = 30;
            this.btnRefreshOngoingOrdersList.Location = new System.Drawing.Point(7, 379);
            this.btnRefreshOngoingOrdersList.Name = "btnRefreshOngoingOrdersList";
            this.btnRefreshOngoingOrdersList.Size = new System.Drawing.Size(147, 51);
            this.btnRefreshOngoingOrdersList.TabIndex = 1;
            this.btnRefreshOngoingOrdersList.Text = "  TẢI LẠI";
            this.btnRefreshOngoingOrdersList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshOngoingOrdersList.UseVisualStyleBackColor = false;
            this.btnRefreshOngoingOrdersList.Click += new System.EventHandler(this.btnRefreshOngoingOrdersList_Click);
            // 
            // dtgvOngoingWorkOrder
            // 
            this.dtgvOngoingWorkOrder.AllowUserToAddRows = false;
            this.dtgvOngoingWorkOrder.AllowUserToDeleteRows = false;
            this.dtgvOngoingWorkOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvOngoingWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOngoingWorkOrder.Location = new System.Drawing.Point(0, 88);
            this.dtgvOngoingWorkOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvOngoingWorkOrder.Name = "dtgvOngoingWorkOrder";
            this.dtgvOngoingWorkOrder.ReadOnly = true;
            this.dtgvOngoingWorkOrder.RowHeadersVisible = false;
            this.dtgvOngoingWorkOrder.RowHeadersWidth = 51;
            this.dtgvOngoingWorkOrder.RowTemplate.Height = 24;
            this.dtgvOngoingWorkOrder.Size = new System.Drawing.Size(636, 284);
            this.dtgvOngoingWorkOrder.TabIndex = 0;
            // 
            // panelOrdersInformation
            // 
            this.panelOrdersInformation.Controls.Add(this.panel3);
            this.panelOrdersInformation.Controls.Add(this.panel4);
            this.panelOrdersInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOrdersInformation.Location = new System.Drawing.Point(0, 73);
            this.panelOrdersInformation.Name = "panelOrdersInformation";
            this.panelOrdersInformation.Size = new System.Drawing.Size(638, 780);
            this.panelOrdersInformation.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(638, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(624, 780);
            this.panel5.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 853);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelOrdersInformation);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 900);
            this.MinimumSize = new System.Drawing.Size(1280, 900);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScaleToMes";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWorkOrderMaterials)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOngoingWorkOrder)).EndInit();
            this.panelOrdersInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvOngoingWorkOrder;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnGuide;
        private System.Windows.Forms.Label lbDTGVOngoingWorkOrder;
        private FontAwesome.Sharp.IconButton btnSelectOrderFromMES;
        private FontAwesome.Sharp.IconButton btnRefreshOngoingOrdersList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbOrderInfo;
        private System.Windows.Forms.Label lbERPCode;
        private System.Windows.Forms.Label lbProductCode;
        private System.Windows.Forms.DataGridView dtgvWorkOrderMaterials;
        private System.Windows.Forms.Label lbMaterialInfo;
        private System.Windows.Forms.Label lbOrderQty;
        private System.Windows.Forms.TextBox txbSearchOngoingOrders;
        private System.Windows.Forms.Label lbSearchOngoingOrders;
        private System.Windows.Forms.Panel panelOrdersInformation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbOngoingOrdersNodata;
        private System.IO.Ports.SerialPort serialPort1;
        private FontAwesome.Sharp.IconButton btnScaleConnect;
        private System.Windows.Forms.Label lbFinishQty;
        private System.Windows.Forms.Label lbFinishQtyInfo;
        private System.Windows.Forms.Label lbOrderQtyInfo;
        private System.Windows.Forms.Label lbProdNoInfo;
        private System.Windows.Forms.Label lbOrderNoInfo;
    }
}

