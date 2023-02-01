
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
            this.lbEmpCode = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.btnScaleConnect = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbOrderQtyInfo = new System.Windows.Forms.Label();
            this.lbProdNoInfo = new System.Windows.Forms.Label();
            this.lbOrderNoInfo = new System.Windows.Forms.Label();
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
            this.btnSelectOrderFromMES = new FontAwesome.Sharp.IconButton();
            this.btnRefreshOngoingOrdersList = new FontAwesome.Sharp.IconButton();
            this.dtgvOngoingWorkOrder = new System.Windows.Forms.DataGridView();
            this.panelOrdersInformation = new System.Windows.Forms.Panel();
            this.panelScaleMainLogic = new System.Windows.Forms.Panel();
            this.txbLOTInput = new System.Windows.Forms.TextBox();
            this.btnDecreaseWeight = new System.Windows.Forms.Button();
            this.btnOKWeight = new System.Windows.Forms.Button();
            this.btnScan = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_sumScaleQty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxChooseReplenishmentType = new System.Windows.Forms.ComboBox();
            this.btnSaveMES = new FontAwesome.Sharp.IconButton();
            this.dtgv_allScannedMat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_scaleWait = new System.Windows.Forms.Panel();
            this.lb_scaleQty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWorkOrderMaterials)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOngoingWorkOrder)).BeginInit();
            this.panelOrdersInformation.SuspendLayout();
            this.panelScaleMainLogic.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_allScannedMat)).BeginInit();
            this.pnl_scaleWait.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lbEmpCode);
            this.panelHeader.Controls.Add(this.lbEmpName);
            this.panelHeader.Controls.Add(this.btnScaleConnect);
            this.panelHeader.Controls.Add(this.btnSetting);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1006, 54);
            this.panelHeader.TabIndex = 0;
            // 
            // lbEmpCode
            // 
            this.lbEmpCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmpCode.AutoSize = true;
            this.lbEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpCode.Location = new System.Drawing.Point(546, 16);
            this.lbEmpCode.Name = "lbEmpCode";
            this.lbEmpCode.Size = new System.Drawing.Size(0, 20);
            this.lbEmpCode.TabIndex = 5;
            // 
            // lbEmpName
            // 
            this.lbEmpName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpName.Location = new System.Drawing.Point(274, 16);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(0, 20);
            this.lbEmpName.TabIndex = 4;
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
            this.btnScaleConnect.Location = new System.Drawing.Point(820, 0);
            this.btnScaleConnect.Name = "btnScaleConnect";
            this.btnScaleConnect.Size = new System.Drawing.Size(92, 52);
            this.btnScaleConnect.TabIndex = 3;
            this.btnScaleConnect.UseVisualStyleBackColor = true;
            this.btnScaleConnect.Click += new System.EventHandler(this.btnScaleConnect_Click);
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
            this.btnSetting.Location = new System.Drawing.Point(912, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(92, 52);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MaterialMES2ERP.Properties.Resources.LogoTechlinkN;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.lbOrderQtyInfo);
            this.panel4.Controls.Add(this.lbProdNoInfo);
            this.panel4.Controls.Add(this.lbOrderNoInfo);
            this.panel4.Controls.Add(this.dtgvWorkOrderMaterials);
            this.panel4.Controls.Add(this.lbMaterialInfo);
            this.panel4.Controls.Add(this.lbOrderQty);
            this.panel4.Controls.Add(this.lbOrderInfo);
            this.panel4.Controls.Add(this.lbERPCode);
            this.panel4.Controls.Add(this.lbProductCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 299);
            this.panel4.TabIndex = 2;
            // 
            // lbOrderQtyInfo
            // 
            this.lbOrderQtyInfo.AutoSize = true;
            this.lbOrderQtyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderQtyInfo.Location = new System.Drawing.Point(177, 99);
            this.lbOrderQtyInfo.Name = "lbOrderQtyInfo";
            this.lbOrderQtyInfo.Size = new System.Drawing.Size(0, 20);
            this.lbOrderQtyInfo.TabIndex = 12;
            // 
            // lbProdNoInfo
            // 
            this.lbProdNoInfo.AutoSize = true;
            this.lbProdNoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdNoInfo.Location = new System.Drawing.Point(183, 67);
            this.lbProdNoInfo.Name = "lbProdNoInfo";
            this.lbProdNoInfo.Size = new System.Drawing.Size(0, 20);
            this.lbProdNoInfo.TabIndex = 11;
            // 
            // lbOrderNoInfo
            // 
            this.lbOrderNoInfo.AutoSize = true;
            this.lbOrderNoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderNoInfo.Location = new System.Drawing.Point(98, 37);
            this.lbOrderNoInfo.Name = "lbOrderNoInfo";
            this.lbOrderNoInfo.Size = new System.Drawing.Size(0, 20);
            this.lbOrderNoInfo.TabIndex = 10;
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
            this.dtgvWorkOrderMaterials.Location = new System.Drawing.Point(0, 167);
            this.dtgvWorkOrderMaterials.Name = "dtgvWorkOrderMaterials";
            this.dtgvWorkOrderMaterials.ReadOnly = true;
            this.dtgvWorkOrderMaterials.RowHeadersVisible = false;
            this.dtgvWorkOrderMaterials.RowHeadersWidth = 51;
            this.dtgvWorkOrderMaterials.RowTemplate.Height = 24;
            this.dtgvWorkOrderMaterials.Size = new System.Drawing.Size(573, 132);
            this.dtgvWorkOrderMaterials.TabIndex = 8;
            // 
            // lbMaterialInfo
            // 
            this.lbMaterialInfo.AutoSize = true;
            this.lbMaterialInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaterialInfo.Location = new System.Drawing.Point(16, 131);
            this.lbMaterialInfo.Name = "lbMaterialInfo";
            this.lbMaterialInfo.Size = new System.Drawing.Size(349, 20);
            this.lbMaterialInfo.TabIndex = 7;
            this.lbMaterialInfo.Text = "KHỐI LƯỢNG DỰ KIẾN TỪNG MÃ LIỆU:";
            // 
            // lbOrderQty
            // 
            this.lbOrderQty.AutoSize = true;
            this.lbOrderQty.Location = new System.Drawing.Point(16, 99);
            this.lbOrderQty.Name = "lbOrderQty";
            this.lbOrderQty.Size = new System.Drawing.Size(155, 20);
            this.lbOrderQty.TabIndex = 6;
            this.lbOrderQty.Text = "Khối lượng yêu cầu:";
            // 
            // lbOrderInfo
            // 
            this.lbOrderInfo.AutoSize = true;
            this.lbOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderInfo.Location = new System.Drawing.Point(12, 12);
            this.lbOrderInfo.Name = "lbOrderInfo";
            this.lbOrderInfo.Size = new System.Drawing.Size(339, 20);
            this.lbOrderInfo.TabIndex = 4;
            this.lbOrderInfo.Text = "THÔNG TIN ĐƠN ĐANG ĐƯỢC CHỌN:";
            // 
            // lbERPCode
            // 
            this.lbERPCode.AutoSize = true;
            this.lbERPCode.Location = new System.Drawing.Point(16, 37);
            this.lbERPCode.Name = "lbERPCode";
            this.lbERPCode.Size = new System.Drawing.Size(76, 20);
            this.lbERPCode.TabIndex = 0;
            this.lbERPCode.Text = "Mã ERP:";
            // 
            // lbProductCode
            // 
            this.lbProductCode.AutoSize = true;
            this.lbProductCode.Location = new System.Drawing.Point(16, 67);
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
            this.panel3.Controls.Add(this.btnSelectOrderFromMES);
            this.panel3.Controls.Add(this.btnRefreshOngoingOrdersList);
            this.panel3.Controls.Add(this.dtgvOngoingWorkOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 361);
            this.panel3.TabIndex = 2;
            // 
            // lbOngoingOrdersNodata
            // 
            this.lbOngoingOrdersNodata.AutoSize = true;
            this.lbOngoingOrdersNodata.BackColor = System.Drawing.Color.Transparent;
            this.lbOngoingOrdersNodata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbOngoingOrdersNodata.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOngoingOrdersNodata.Location = new System.Drawing.Point(193, 146);
            this.lbOngoingOrdersNodata.Name = "lbOngoingOrdersNodata";
            this.lbOngoingOrdersNodata.Size = new System.Drawing.Size(171, 38);
            this.lbOngoingOrdersNodata.TabIndex = 6;
            this.lbOngoingOrdersNodata.Text = "NO DATA";
            this.lbOngoingOrdersNodata.Visible = false;
            // 
            // txbSearchOngoingOrders
            // 
            this.txbSearchOngoingOrders.Location = new System.Drawing.Point(87, 12);
            this.txbSearchOngoingOrders.Name = "txbSearchOngoingOrders";
            this.txbSearchOngoingOrders.Size = new System.Drawing.Size(427, 27);
            this.txbSearchOngoingOrders.TabIndex = 5;
            this.txbSearchOngoingOrders.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearchOngoingOrders_KeyPress);
            // 
            // lbSearchOngoingOrders
            // 
            this.lbSearchOngoingOrders.AutoSize = true;
            this.lbSearchOngoingOrders.Location = new System.Drawing.Point(3, 15);
            this.lbSearchOngoingOrders.Name = "lbSearchOngoingOrders";
            this.lbSearchOngoingOrders.Size = new System.Drawing.Size(77, 20);
            this.lbSearchOngoingOrders.TabIndex = 4;
            this.lbSearchOngoingOrders.Text = "Tìm kiếm";
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
            this.btnSelectOrderFromMES.Location = new System.Drawing.Point(343, 300);
            this.btnSelectOrderFromMES.Name = "btnSelectOrderFromMES";
            this.btnSelectOrderFromMES.Size = new System.Drawing.Size(222, 51);
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
            this.btnRefreshOngoingOrdersList.Location = new System.Drawing.Point(3, 300);
            this.btnRefreshOngoingOrdersList.Name = "btnRefreshOngoingOrdersList";
            this.btnRefreshOngoingOrdersList.Size = new System.Drawing.Size(147, 51);
            this.btnRefreshOngoingOrdersList.TabIndex = 1;
            this.btnRefreshOngoingOrdersList.Text = "  LÀM MỚI";
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
            this.dtgvOngoingWorkOrder.Location = new System.Drawing.Point(0, 46);
            this.dtgvOngoingWorkOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvOngoingWorkOrder.Name = "dtgvOngoingWorkOrder";
            this.dtgvOngoingWorkOrder.ReadOnly = true;
            this.dtgvOngoingWorkOrder.RowHeadersVisible = false;
            this.dtgvOngoingWorkOrder.RowHeadersWidth = 51;
            this.dtgvOngoingWorkOrder.RowTemplate.Height = 24;
            this.dtgvOngoingWorkOrder.Size = new System.Drawing.Size(565, 247);
            this.dtgvOngoingWorkOrder.TabIndex = 0;
            this.dtgvOngoingWorkOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOngoingWorkOrder_CellClick);
            // 
            // panelOrdersInformation
            // 
            this.panelOrdersInformation.Controls.Add(this.panel3);
            this.panelOrdersInformation.Controls.Add(this.panel4);
            this.panelOrdersInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOrdersInformation.Location = new System.Drawing.Point(0, 54);
            this.panelOrdersInformation.Name = "panelOrdersInformation";
            this.panelOrdersInformation.Size = new System.Drawing.Size(573, 667);
            this.panelOrdersInformation.TabIndex = 3;
            // 
            // panelScaleMainLogic
            // 
            this.panelScaleMainLogic.Controls.Add(this.txbLOTInput);
            this.panelScaleMainLogic.Controls.Add(this.btnDecreaseWeight);
            this.panelScaleMainLogic.Controls.Add(this.btnOKWeight);
            this.panelScaleMainLogic.Controls.Add(this.btnScan);
            this.panelScaleMainLogic.Controls.Add(this.panel1);
            this.panelScaleMainLogic.Controls.Add(this.cbxChooseReplenishmentType);
            this.panelScaleMainLogic.Controls.Add(this.btnSaveMES);
            this.panelScaleMainLogic.Controls.Add(this.dtgv_allScannedMat);
            this.panelScaleMainLogic.Controls.Add(this.label2);
            this.panelScaleMainLogic.Controls.Add(this.pnl_scaleWait);
            this.panelScaleMainLogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScaleMainLogic.Location = new System.Drawing.Point(573, 54);
            this.panelScaleMainLogic.Name = "panelScaleMainLogic";
            this.panelScaleMainLogic.Size = new System.Drawing.Size(433, 667);
            this.panelScaleMainLogic.TabIndex = 4;
            // 
            // txbLOTInput
            // 
            this.txbLOTInput.Location = new System.Drawing.Point(7, 254);
            this.txbLOTInput.Name = "txbLOTInput";
            this.txbLOTInput.Size = new System.Drawing.Size(233, 27);
            this.txbLOTInput.TabIndex = 18;
            this.txbLOTInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbLOTInput_KeyDown);
            // 
            // btnDecreaseWeight
            // 
            this.btnDecreaseWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseWeight.Location = new System.Drawing.Point(4, 494);
            this.btnDecreaseWeight.Name = "btnDecreaseWeight";
            this.btnDecreaseWeight.Size = new System.Drawing.Size(130, 52);
            this.btnDecreaseWeight.TabIndex = 17;
            this.btnDecreaseWeight.Text = "TRỪ KL";
            this.btnDecreaseWeight.UseVisualStyleBackColor = true;
            this.btnDecreaseWeight.Click += new System.EventHandler(this.btnDecreaseWeight_Click);
            // 
            // btnOKWeight
            // 
            this.btnOKWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKWeight.Location = new System.Drawing.Point(296, 493);
            this.btnOKWeight.Name = "btnOKWeight";
            this.btnOKWeight.Size = new System.Drawing.Size(122, 52);
            this.btnOKWeight.TabIndex = 16;
            this.btnOKWeight.Text = "CỘNG KL";
            this.btnOKWeight.UseVisualStyleBackColor = true;
            this.btnOKWeight.Click += new System.EventHandler(this.btnOKWeight_Click);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Yellow;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnScan.IconColor = System.Drawing.Color.Black;
            this.btnScan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScan.Location = new System.Drawing.Point(269, 240);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(152, 54);
            this.btnScan.TabIndex = 15;
            this.btnScan.Text = "SCAN MÃ LIỆU";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lb_sumScaleQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(220, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 176);
            this.panel1.TabIndex = 9;
            // 
            // lb_sumScaleQty
            // 
            this.lb_sumScaleQty.AutoSize = true;
            this.lb_sumScaleQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sumScaleQty.Location = new System.Drawing.Point(20, 83);
            this.lb_sumScaleQty.Name = "lb_sumScaleQty";
            this.lb_sumScaleQty.Size = new System.Drawing.Size(98, 44);
            this.lb_sumScaleQty.TabIndex = 2;
            this.lb_sumScaleQty.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng khối lượng đã cân\r\n";
            // 
            // cbxChooseReplenishmentType
            // 
            this.cbxChooseReplenishmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseReplenishmentType.FormattingEnabled = true;
            this.cbxChooseReplenishmentType.Items.AddRange(new object[] {
            "领料 - Picking Material",
            "补料 - Feed Material",
            "退料 - Return Material"});
            this.cbxChooseReplenishmentType.Location = new System.Drawing.Point(6, 606);
            this.cbxChooseReplenishmentType.Name = "cbxChooseReplenishmentType";
            this.cbxChooseReplenishmentType.Size = new System.Drawing.Size(233, 28);
            this.cbxChooseReplenishmentType.TabIndex = 13;
            this.cbxChooseReplenishmentType.SelectionChangeCommitted += new System.EventHandler(this.cbxChooseReplenishmentType_SelectionChangeCommitted);
            // 
            // btnSaveMES
            // 
            this.btnSaveMES.BackColor = System.Drawing.Color.Red;
            this.btnSaveMES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMES.ForeColor = System.Drawing.Color.Yellow;
            this.btnSaveMES.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSaveMES.IconColor = System.Drawing.Color.Black;
            this.btnSaveMES.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveMES.Location = new System.Drawing.Point(251, 584);
            this.btnSaveMES.Name = "btnSaveMES";
            this.btnSaveMES.Size = new System.Drawing.Size(170, 71);
            this.btnSaveMES.TabIndex = 12;
            this.btnSaveMES.Text = "NHẬP MES";
            this.btnSaveMES.UseVisualStyleBackColor = false;
            this.btnSaveMES.Click += new System.EventHandler(this.btnSaveMES_Click);
            // 
            // dtgv_allScannedMat
            // 
            this.dtgv_allScannedMat.AllowUserToAddRows = false;
            this.dtgv_allScannedMat.AllowUserToDeleteRows = false;
            this.dtgv_allScannedMat.AllowUserToOrderColumns = true;
            this.dtgv_allScannedMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_allScannedMat.Location = new System.Drawing.Point(6, 27);
            this.dtgv_allScannedMat.MultiSelect = false;
            this.dtgv_allScannedMat.Name = "dtgv_allScannedMat";
            this.dtgv_allScannedMat.ReadOnly = true;
            this.dtgv_allScannedMat.RowHeadersVisible = false;
            this.dtgv_allScannedMat.RowHeadersWidth = 51;
            this.dtgv_allScannedMat.RowTemplate.Height = 24;
            this.dtgv_allScannedMat.Size = new System.Drawing.Size(415, 207);
            this.dtgv_allScannedMat.TabIndex = 10;
            this.dtgv_allScannedMat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_allScannedMat_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "CHI TIẾT:";
            // 
            // pnl_scaleWait
            // 
            this.pnl_scaleWait.BackColor = System.Drawing.Color.Black;
            this.pnl_scaleWait.Controls.Add(this.lb_scaleQty);
            this.pnl_scaleWait.Controls.Add(this.label3);
            this.pnl_scaleWait.ForeColor = System.Drawing.Color.White;
            this.pnl_scaleWait.Location = new System.Drawing.Point(7, 311);
            this.pnl_scaleWait.Name = "pnl_scaleWait";
            this.pnl_scaleWait.Size = new System.Drawing.Size(207, 176);
            this.pnl_scaleWait.TabIndex = 8;
            // 
            // lb_scaleQty
            // 
            this.lb_scaleQty.AutoSize = true;
            this.lb_scaleQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scaleQty.Location = new System.Drawing.Point(11, 83);
            this.lb_scaleQty.Name = "lb_scaleQty";
            this.lb_scaleQty.Size = new System.Drawing.Size(98, 44);
            this.lb_scaleQty.TabIndex = 3;
            this.lb_scaleQty.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khối lượng từ cân";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panelScaleMainLogic);
            this.Controls.Add(this.panelOrdersInformation);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScaleToMes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWorkOrderMaterials)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOngoingWorkOrder)).EndInit();
            this.panelOrdersInformation.ResumeLayout(false);
            this.panelScaleMainLogic.ResumeLayout(false);
            this.panelScaleMainLogic.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_allScannedMat)).EndInit();
            this.pnl_scaleWait.ResumeLayout(false);
            this.pnl_scaleWait.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvOngoingWorkOrder;
        private FontAwesome.Sharp.IconButton btnSetting;
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
        private System.Windows.Forms.Panel panelScaleMainLogic;
        private System.Windows.Forms.Label lbOngoingOrdersNodata;
        private System.IO.Ports.SerialPort serialPort1;
        private FontAwesome.Sharp.IconButton btnScaleConnect;
        private System.Windows.Forms.Label lbOrderQtyInfo;
        private System.Windows.Forms.Label lbProdNoInfo;
        private System.Windows.Forms.Label lbOrderNoInfo;
        private System.Windows.Forms.Panel pnl_scaleWait;
        private System.Windows.Forms.ComboBox cbxChooseReplenishmentType;
        private FontAwesome.Sharp.IconButton btnSaveMES;
        private System.Windows.Forms.DataGridView dtgv_allScannedMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_sumScaleQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_scaleQty;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnScan;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbEmpCode;
        private System.Windows.Forms.Button btnDecreaseWeight;
        private System.Windows.Forms.Button btnOKWeight;
        private System.Windows.Forms.TextBox txbLOTInput;
    }
}

