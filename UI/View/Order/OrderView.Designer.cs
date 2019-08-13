using UI.Services;

namespace UI.View
{
    partial class OrderView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            Messenger.Instance.Unregister(presenter);
            Messenger.Instance.Unregister(presenter.TotalTabVM);
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderView));
            this.panel_footer = new System.Windows.Forms.Panel();
            this.chkbx_sendMail = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel_msg = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.materialFlatButton_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_backTo = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl_container = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBx_customers = new System.Windows.Forms.TextBox();
            this.btn_addCustomer = new MaterialSkin.Controls.MaterialFlatButton();
            this.label55 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_cPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_cEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_cLastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_cFirstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbBx_customerGroups = new System.Windows.Forms.ComboBox();
            this.cmbBx_currencies = new System.Windows.Forms.ComboBox();
            this.cmbBx_stores = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstVw_products = new UI.Controls.MaterialListViewBindable();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cntxtMenuStrip_rmProduct = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.tsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBx_products = new System.Windows.Forms.ComboBox();
            this.btn_addProduct = new MaterialSkin.Controls.MaterialFlatButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBx_quantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label52 = new System.Windows.Forms.Label();
            this.cmbBx_paymentMethods = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.cmbBx_paAddresses = new System.Windows.Forms.ComboBox();
            this.cmbBx_paZones = new System.Windows.Forms.ComboBox();
            this.cmbBx_paCountries = new System.Windows.Forms.ComboBox();
            this.txtBx_paFirstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_paPostcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_paCity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_paAddress2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_paAddress1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_paCompany = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBx_paLastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cmbBx_shippingMethods = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbBx_saAddresses = new System.Windows.Forms.ComboBox();
            this.cmbBx_saZones = new System.Windows.Forms.ComboBox();
            this.cmbBx_saCountries = new System.Windows.Forms.ComboBox();
            this.txtBx_saFirstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_saPostcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_saCity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_saAddress2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_saAddress1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_saCompany = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label29 = new System.Windows.Forms.Label();
            this.txtBx_saLastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_totals = new MaterialSkin.Controls.MaterialLabel();
            this.label60 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.lstVw_totalProducts = new UI.Controls.MaterialListViewBindable();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbBx_orderStatus = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.printDialog_printer = new System.Windows.Forms.PrintDialog();
            this.panel_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.materialTabControl_container.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.cntxtMenuStrip_rmProduct.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.chkbx_sendMail);
            this.panel_footer.Controls.Add(this.materialLabel_msg);
            this.panel_footer.Controls.Add(this.pictureBox_loading);
            this.panel_footer.Controls.Add(this.materialFlatButton_save);
            this.panel_footer.Controls.Add(this.materialFlatButton_backTo);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 537);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1050, 39);
            this.panel_footer.TabIndex = 2;
            // 
            // chkbx_sendMail
            // 
            this.chkbx_sendMail.AutoSize = true;
            this.chkbx_sendMail.Depth = 0;
            this.chkbx_sendMail.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkbx_sendMail.Location = new System.Drawing.Point(808, 4);
            this.chkbx_sendMail.Margin = new System.Windows.Forms.Padding(0);
            this.chkbx_sendMail.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbx_sendMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbx_sendMail.Name = "chkbx_sendMail";
            this.chkbx_sendMail.Ripple = true;
            this.chkbx_sendMail.Size = new System.Drawing.Size(98, 30);
            this.chkbx_sendMail.TabIndex = 6;
            this.chkbx_sendMail.Text = "Send email";
            this.chkbx_sendMail.UseVisualStyleBackColor = true;
            // 
            // materialLabel_msg
            // 
            this.materialLabel_msg.AutoSize = true;
            this.materialLabel_msg.Depth = 0;
            this.materialLabel_msg.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_msg.Location = new System.Drawing.Point(125, 10);
            this.materialLabel_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_msg.Name = "materialLabel_msg";
            this.materialLabel_msg.Size = new System.Drawing.Size(0, 19);
            this.materialLabel_msg.TabIndex = 5;
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.Image = global::UI.Properties.Resources.loading_squares;
            this.pictureBox_loading.Location = new System.Drawing.Point(774, 4);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(31, 31);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_loading.TabIndex = 4;
            this.pictureBox_loading.TabStop = false;
            // 
            // materialFlatButton_save
            // 
            this.materialFlatButton_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_save.Depth = 0;
            this.materialFlatButton_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialFlatButton_save.Icon = ((System.Drawing.Image)(resources.GetObject("materialFlatButton_save.Icon")));
            this.materialFlatButton_save.Location = new System.Drawing.Point(923, 0);
            this.materialFlatButton_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_save.Name = "materialFlatButton_save";
            this.materialFlatButton_save.Primary = false;
            this.materialFlatButton_save.Size = new System.Drawing.Size(127, 39);
            this.materialFlatButton_save.TabIndex = 2;
            this.materialFlatButton_save.Text = "Finish";
            this.materialFlatButton_save.UseVisualStyleBackColor = true;
            this.materialFlatButton_save.Click += new System.EventHandler(this.MaterialFlatButton_save_Click);
            // 
            // materialFlatButton_backTo
            // 
            this.materialFlatButton_backTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_backTo.Depth = 0;
            this.materialFlatButton_backTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialFlatButton_backTo.Icon = ((System.Drawing.Image)(resources.GetObject("materialFlatButton_backTo.Icon")));
            this.materialFlatButton_backTo.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton_backTo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_backTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_backTo.Name = "materialFlatButton_backTo";
            this.materialFlatButton_backTo.Primary = false;
            this.materialFlatButton_backTo.Size = new System.Drawing.Size(118, 39);
            this.materialFlatButton_backTo.TabIndex = 3;
            this.materialFlatButton_backTo.Text = "Back";
            this.materialFlatButton_backTo.UseVisualStyleBackColor = true;
            this.materialFlatButton_backTo.Click += new System.EventHandler(this.MaterialFlatButton_backTo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.materialTabControl_container);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 537);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialTabSelector1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 62);
            this.panel2.TabIndex = 2;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl_container;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1044, 56);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl_container
            // 
            this.materialTabControl_container.Controls.Add(this.tabPage1);
            this.materialTabControl_container.Controls.Add(this.tabPage2);
            this.materialTabControl_container.Controls.Add(this.tabPage4);
            this.materialTabControl_container.Controls.Add(this.tabPage5);
            this.materialTabControl_container.Controls.Add(this.tabPage6);
            this.materialTabControl_container.Depth = 0;
            this.materialTabControl_container.Location = new System.Drawing.Point(3, 65);
            this.materialTabControl_container.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl_container.Name = "materialTabControl_container";
            this.materialTabControl_container.SelectedIndex = 0;
            this.materialTabControl_container.Size = new System.Drawing.Size(1044, 469);
            this.materialTabControl_container.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txtBx_customers);
            this.tabPage1.Controls.Add(this.btn_addCustomer);
            this.tabPage1.Controls.Add(this.label55);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label53);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBx_cPhone);
            this.tabPage1.Controls.Add(this.txtBx_cEmail);
            this.tabPage1.Controls.Add(this.txtBx_cLastname);
            this.tabPage1.Controls.Add(this.txtBx_cFirstname);
            this.tabPage1.Controls.Add(this.cmbBx_customerGroups);
            this.tabPage1.Controls.Add(this.cmbBx_currencies);
            this.tabPage1.Controls.Add(this.cmbBx_stores);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1036, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. Customer";
            // 
            // txtBx_customers
            // 
            this.txtBx_customers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBx_customers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBx_customers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_customers.Location = new System.Drawing.Point(163, 68);
            this.txtBx_customers.Name = "txtBx_customers";
            this.txtBx_customers.Size = new System.Drawing.Size(185, 20);
            this.txtBx_customers.TabIndex = 12;
            this.txtBx_customers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBx_customers_KeyUp);
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_addCustomer.Depth = 0;
            this.btn_addCustomer.Icon = ((System.Drawing.Image)(resources.GetObject("btn_addCustomer.Icon")));
            this.btn_addCustomer.Location = new System.Drawing.Point(887, 68);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_addCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Primary = false;
            this.btn_addCustomer.Size = new System.Drawing.Size(44, 38);
            this.btn_addCustomer.TabIndex = 4;
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label55.Location = new System.Drawing.Point(336, 268);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(12, 15);
            this.label55.TabIndex = 8;
            this.label55.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(253, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(275, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Currency";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label53.Location = new System.Drawing.Point(302, 91);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(46, 15);
            this.label53.TabIndex = 2;
            this.label53.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(312, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Store";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(690, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label7.Location = new System.Drawing.Point(675, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label6.Location = new System.Drawing.Point(702, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(747, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(747, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(747, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(747, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(689, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtBx_cPhone
            // 
            this.txtBx_cPhone.Depth = 0;
            this.txtBx_cPhone.Hint = "Telephone";
            this.txtBx_cPhone.Location = new System.Drawing.Point(459, 329);
            this.txtBx_cPhone.MaxLength = 32767;
            this.txtBx_cPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_cPhone.Name = "txtBx_cPhone";
            this.txtBx_cPhone.PasswordChar = '\0';
            this.txtBx_cPhone.ReadOnly = false;
            this.txtBx_cPhone.SelectedText = "";
            this.txtBx_cPhone.SelectionLength = 0;
            this.txtBx_cPhone.SelectionStart = 0;
            this.txtBx_cPhone.Size = new System.Drawing.Size(300, 23);
            this.txtBx_cPhone.TabIndex = 6;
            this.txtBx_cPhone.TabStop = false;
            this.txtBx_cPhone.UseSystemPasswordChar = false;
            // 
            // txtBx_cEmail
            // 
            this.txtBx_cEmail.Depth = 0;
            this.txtBx_cEmail.Hint = "Email";
            this.txtBx_cEmail.Location = new System.Drawing.Point(459, 242);
            this.txtBx_cEmail.MaxLength = 32767;
            this.txtBx_cEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_cEmail.Name = "txtBx_cEmail";
            this.txtBx_cEmail.PasswordChar = '\0';
            this.txtBx_cEmail.ReadOnly = false;
            this.txtBx_cEmail.SelectedText = "";
            this.txtBx_cEmail.SelectionLength = 0;
            this.txtBx_cEmail.SelectionStart = 0;
            this.txtBx_cEmail.Size = new System.Drawing.Size(300, 23);
            this.txtBx_cEmail.TabIndex = 5;
            this.txtBx_cEmail.TabStop = false;
            this.txtBx_cEmail.UseSystemPasswordChar = false;
            // 
            // txtBx_cLastname
            // 
            this.txtBx_cLastname.Depth = 0;
            this.txtBx_cLastname.Hint = "Lastname";
            this.txtBx_cLastname.Location = new System.Drawing.Point(459, 155);
            this.txtBx_cLastname.MaxLength = 32767;
            this.txtBx_cLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_cLastname.Name = "txtBx_cLastname";
            this.txtBx_cLastname.PasswordChar = '\0';
            this.txtBx_cLastname.ReadOnly = false;
            this.txtBx_cLastname.SelectedText = "";
            this.txtBx_cLastname.SelectionLength = 0;
            this.txtBx_cLastname.SelectionStart = 0;
            this.txtBx_cLastname.Size = new System.Drawing.Size(300, 23);
            this.txtBx_cLastname.TabIndex = 4;
            this.txtBx_cLastname.TabStop = false;
            this.txtBx_cLastname.UseSystemPasswordChar = false;
            // 
            // txtBx_cFirstname
            // 
            this.txtBx_cFirstname.Depth = 0;
            this.txtBx_cFirstname.Hint = "Firstname";
            this.txtBx_cFirstname.Location = new System.Drawing.Point(459, 68);
            this.txtBx_cFirstname.MaxLength = 32767;
            this.txtBx_cFirstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_cFirstname.Name = "txtBx_cFirstname";
            this.txtBx_cFirstname.PasswordChar = '\0';
            this.txtBx_cFirstname.ReadOnly = false;
            this.txtBx_cFirstname.SelectedText = "";
            this.txtBx_cFirstname.SelectionLength = 0;
            this.txtBx_cFirstname.SelectionStart = 0;
            this.txtBx_cFirstname.Size = new System.Drawing.Size(300, 23);
            this.txtBx_cFirstname.TabIndex = 3;
            this.txtBx_cFirstname.TabStop = false;
            this.txtBx_cFirstname.UseSystemPasswordChar = false;
            // 
            // cmbBx_customerGroups
            // 
            this.cmbBx_customerGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_customerGroups.FormattingEnabled = true;
            this.cmbBx_customerGroups.Location = new System.Drawing.Point(163, 329);
            this.cmbBx_customerGroups.Name = "cmbBx_customerGroups";
            this.cmbBx_customerGroups.Size = new System.Drawing.Size(185, 21);
            this.cmbBx_customerGroups.TabIndex = 2;
            // 
            // cmbBx_currencies
            // 
            this.cmbBx_currencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_currencies.FormattingEnabled = true;
            this.cmbBx_currencies.Location = new System.Drawing.Point(163, 242);
            this.cmbBx_currencies.Name = "cmbBx_currencies";
            this.cmbBx_currencies.Size = new System.Drawing.Size(185, 21);
            this.cmbBx_currencies.TabIndex = 1;
            // 
            // cmbBx_stores
            // 
            this.cmbBx_stores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_stores.FormattingEnabled = true;
            this.cmbBx_stores.Location = new System.Drawing.Point(163, 155);
            this.cmbBx_stores.Name = "cmbBx_stores";
            this.cmbBx_stores.Size = new System.Drawing.Size(185, 21);
            this.cmbBx_stores.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lstVw_products);
            this.tabPage2.Controls.Add(this.cmbBx_products);
            this.tabPage2.Controls.Add(this.btn_addProduct);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtBx_quantity);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1036, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. Products";
            // 
            // lstVw_products
            // 
            this.lstVw_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVw_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstVw_products.ContextMenuStrip = this.cntxtMenuStrip_rmProduct;
            this.lstVw_products.DataMember = null;
            this.lstVw_products.DataSource = null;
            this.lstVw_products.Depth = 0;
            this.lstVw_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lstVw_products.FullRowSelect = true;
            this.lstVw_products.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVw_products.Location = new System.Drawing.Point(70, 126);
            this.lstVw_products.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVw_products.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVw_products.Name = "lstVw_products";
            this.lstVw_products.OwnerDraw = true;
            this.lstVw_products.Size = new System.Drawing.Size(904, 311);
            this.lstVw_products.TabIndex = 9;
            this.lstVw_products.UseCompatibleStateImageBehavior = false;
            this.lstVw_products.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Product";
            this.columnHeader6.Width = 173;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Model";
            this.columnHeader7.Width = 135;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantity";
            this.columnHeader8.Width = 172;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Unit Price";
            this.columnHeader9.Width = 254;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total";
            this.columnHeader10.Width = 119;
            // 
            // cntxtMenuStrip_rmProduct
            // 
            this.cntxtMenuStrip_rmProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cntxtMenuStrip_rmProduct.Depth = 0;
            this.cntxtMenuStrip_rmProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_delete});
            this.cntxtMenuStrip_rmProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.cntxtMenuStrip_rmProduct.Name = "materialContextMenuStrip_options";
            this.cntxtMenuStrip_rmProduct.Size = new System.Drawing.Size(108, 26);
            // 
            // tsmi_delete
            // 
            this.tsmi_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_delete.Image")));
            this.tsmi_delete.Name = "tsmi_delete";
            this.tsmi_delete.Size = new System.Drawing.Size(107, 22);
            this.tsmi_delete.Text = "Delete";
            // 
            // cmbBx_products
            // 
            this.cmbBx_products.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBx_products.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBx_products.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_products.FormattingEnabled = true;
            this.cmbBx_products.Location = new System.Drawing.Point(591, 52);
            this.cmbBx_products.Name = "cmbBx_products";
            this.cmbBx_products.Size = new System.Drawing.Size(197, 25);
            this.cmbBx_products.TabIndex = 8;
            this.cmbBx_products.DropDown += new System.EventHandler(this.ComboBox_products_DropDown);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_addProduct.Depth = 0;
            this.btn_addProduct.Icon = ((System.Drawing.Image)(resources.GetObject("btn_addProduct.Icon")));
            this.btn_addProduct.Location = new System.Drawing.Point(929, 52);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_addProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Primary = false;
            this.btn_addProduct.Size = new System.Drawing.Size(45, 41);
            this.btn_addProduct.TabIndex = 2;
            this.btn_addProduct.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label13.Location = new System.Drawing.Point(850, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label12.Location = new System.Drawing.Point(703, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Select product";
            // 
            // txtBx_quantity
            // 
            this.txtBx_quantity.Depth = 0;
            this.txtBx_quantity.Hint = "";
            this.txtBx_quantity.Location = new System.Drawing.Point(812, 54);
            this.txtBx_quantity.MaxLength = 32767;
            this.txtBx_quantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_quantity.Name = "txtBx_quantity";
            this.txtBx_quantity.PasswordChar = '\0';
            this.txtBx_quantity.ReadOnly = false;
            this.txtBx_quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBx_quantity.SelectedText = "";
            this.txtBx_quantity.SelectionLength = 0;
            this.txtBx_quantity.SelectionStart = 0;
            this.txtBx_quantity.Size = new System.Drawing.Size(89, 23);
            this.txtBx_quantity.TabIndex = 1;
            this.txtBx_quantity.TabStop = false;
            this.txtBx_quantity.UseSystemPasswordChar = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.label52);
            this.tabPage4.Controls.Add(this.cmbBx_paymentMethods);
            this.tabPage4.Controls.Add(this.label45);
            this.tabPage4.Controls.Add(this.label44);
            this.tabPage4.Controls.Add(this.cmbBx_paAddresses);
            this.tabPage4.Controls.Add(this.cmbBx_paZones);
            this.tabPage4.Controls.Add(this.cmbBx_paCountries);
            this.tabPage4.Controls.Add(this.txtBx_paFirstname);
            this.tabPage4.Controls.Add(this.txtBx_paPostcode);
            this.tabPage4.Controls.Add(this.txtBx_paCity);
            this.tabPage4.Controls.Add(this.txtBx_paAddress2);
            this.tabPage4.Controls.Add(this.txtBx_paAddress1);
            this.tabPage4.Controls.Add(this.txtBx_paCompany);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.txtBx_paLastname);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1036, 443);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "3. Payment details";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label52.Location = new System.Drawing.Point(652, 340);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(66, 16);
            this.label52.TabIndex = 55;
            this.label52.Text = "Postcode";
            // 
            // cmbBx_paymentMethods
            // 
            this.cmbBx_paymentMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_paymentMethods.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_paymentMethods.FormattingEnabled = true;
            this.cmbBx_paymentMethods.ItemHeight = 16;
            this.cmbBx_paymentMethods.Location = new System.Drawing.Point(35, 26);
            this.cmbBx_paymentMethods.Name = "cmbBx_paymentMethods";
            this.cmbBx_paymentMethods.Size = new System.Drawing.Size(189, 24);
            this.cmbBx_paymentMethods.TabIndex = 0;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label45.Location = new System.Drawing.Point(98, 53);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(109, 16);
            this.label45.TabIndex = 49;
            this.label45.Text = "Payment Method";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label44.Location = new System.Drawing.Point(212, 53);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(12, 15);
            this.label44.TabIndex = 48;
            this.label44.Text = "*";
            // 
            // cmbBx_paAddresses
            // 
            this.cmbBx_paAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_paAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_paAddresses.FormattingEnabled = true;
            this.cmbBx_paAddresses.Location = new System.Drawing.Point(327, 26);
            this.cmbBx_paAddresses.Name = "cmbBx_paAddresses";
            this.cmbBx_paAddresses.Size = new System.Drawing.Size(391, 23);
            this.cmbBx_paAddresses.TabIndex = 1;
            // 
            // cmbBx_paZones
            // 
            this.cmbBx_paZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_paZones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_paZones.FormattingEnabled = true;
            this.cmbBx_paZones.Location = new System.Drawing.Point(529, 376);
            this.cmbBx_paZones.Name = "cmbBx_paZones";
            this.cmbBx_paZones.Size = new System.Drawing.Size(189, 25);
            this.cmbBx_paZones.TabIndex = 10;
            // 
            // cmbBx_paCountries
            // 
            this.cmbBx_paCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_paCountries.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_paCountries.FormattingEnabled = true;
            this.cmbBx_paCountries.Location = new System.Drawing.Point(327, 376);
            this.cmbBx_paCountries.Name = "cmbBx_paCountries";
            this.cmbBx_paCountries.Size = new System.Drawing.Size(189, 25);
            this.cmbBx_paCountries.TabIndex = 9;
            // 
            // txtBx_paFirstname
            // 
            this.txtBx_paFirstname.Depth = 0;
            this.txtBx_paFirstname.Hint = "Firstname";
            this.txtBx_paFirstname.Location = new System.Drawing.Point(327, 82);
            this.txtBx_paFirstname.MaxLength = 32767;
            this.txtBx_paFirstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_paFirstname.Name = "txtBx_paFirstname";
            this.txtBx_paFirstname.PasswordChar = '\0';
            this.txtBx_paFirstname.ReadOnly = false;
            this.txtBx_paFirstname.SelectedText = "";
            this.txtBx_paFirstname.SelectionLength = 0;
            this.txtBx_paFirstname.SelectionStart = 0;
            this.txtBx_paFirstname.Size = new System.Drawing.Size(189, 23);
            this.txtBx_paFirstname.TabIndex = 2;
            this.txtBx_paFirstname.TabStop = false;
            this.txtBx_paFirstname.UseSystemPasswordChar = false;
            // 
            // txtBx_paPostcode
            // 
            this.txtBx_paPostcode.Depth = 0;
            this.txtBx_paPostcode.Hint = "Postcode";
            this.txtBx_paPostcode.Location = new System.Drawing.Point(622, 314);
            this.txtBx_paPostcode.MaxLength = 32767;
            this.txtBx_paPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_paPostcode.Name = "txtBx_paPostcode";
            this.txtBx_paPostcode.PasswordChar = '\0';
            this.txtBx_paPostcode.ReadOnly = false;
            this.txtBx_paPostcode.SelectedText = "";
            this.txtBx_paPostcode.SelectionLength = 0;
            this.txtBx_paPostcode.SelectionStart = 0;
            this.txtBx_paPostcode.Size = new System.Drawing.Size(96, 23);
            this.txtBx_paPostcode.TabIndex = 8;
            this.txtBx_paPostcode.TabStop = false;
            this.txtBx_paPostcode.UseSystemPasswordChar = false;
            // 
            // txtBx_paCity
            // 
            this.txtBx_paCity.Depth = 0;
            this.txtBx_paCity.Hint = "City";
            this.txtBx_paCity.Location = new System.Drawing.Point(327, 314);
            this.txtBx_paCity.MaxLength = 32767;
            this.txtBx_paCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_paCity.Name = "txtBx_paCity";
            this.txtBx_paCity.PasswordChar = '\0';
            this.txtBx_paCity.ReadOnly = false;
            this.txtBx_paCity.SelectedText = "";
            this.txtBx_paCity.SelectionLength = 0;
            this.txtBx_paCity.SelectionStart = 0;
            this.txtBx_paCity.Size = new System.Drawing.Size(274, 23);
            this.txtBx_paCity.TabIndex = 7;
            this.txtBx_paCity.TabStop = false;
            this.txtBx_paCity.UseSystemPasswordChar = false;
            // 
            // txtBx_paAddress2
            // 
            this.txtBx_paAddress2.Depth = 0;
            this.txtBx_paAddress2.Hint = "Address #2";
            this.txtBx_paAddress2.Location = new System.Drawing.Point(327, 243);
            this.txtBx_paAddress2.MaxLength = 32767;
            this.txtBx_paAddress2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_paAddress2.Name = "txtBx_paAddress2";
            this.txtBx_paAddress2.PasswordChar = '\0';
            this.txtBx_paAddress2.ReadOnly = false;
            this.txtBx_paAddress2.SelectedText = "";
            this.txtBx_paAddress2.SelectionLength = 0;
            this.txtBx_paAddress2.SelectionStart = 0;
            this.txtBx_paAddress2.Size = new System.Drawing.Size(391, 23);
            this.txtBx_paAddress2.TabIndex = 6;
            this.txtBx_paAddress2.TabStop = false;
            this.txtBx_paAddress2.UseSystemPasswordChar = false;
            // 
            // txtBx_paAddress1
            // 
            this.txtBx_paAddress1.Depth = 0;
            this.txtBx_paAddress1.Hint = "Address #1";
            this.txtBx_paAddress1.Location = new System.Drawing.Point(327, 190);
            this.txtBx_paAddress1.MaxLength = 32767;
            this.txtBx_paAddress1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_paAddress1.Name = "txtBx_paAddress1";
            this.txtBx_paAddress1.PasswordChar = '\0';
            this.txtBx_paAddress1.ReadOnly = false;
            this.txtBx_paAddress1.SelectedText = "";
            this.txtBx_paAddress1.SelectionLength = 0;
            this.txtBx_paAddress1.SelectionStart = 0;
            this.txtBx_paAddress1.Size = new System.Drawing.Size(391, 23);
            this.txtBx_paAddress1.TabIndex = 5;
            this.txtBx_paAddress1.TabStop = false;
            this.txtBx_paAddress1.UseSystemPasswordChar = false;
            // 
            // txtBx_paCompany
            // 
            this.txtBx_paCompany.Depth = 0;
            this.txtBx_paCompany.Hint = "Company";
            this.txtBx_paCompany.Location = new System.Drawing.Point(327, 137);
            this.txtBx_paCompany.MaxLength = 32767;
            this.txtBx_paCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_paCompany.Name = "txtBx_paCompany";
            this.txtBx_paCompany.PasswordChar = '\0';
            this.txtBx_paCompany.ReadOnly = false;
            this.txtBx_paCompany.SelectedText = "";
            this.txtBx_paCompany.SelectionLength = 0;
            this.txtBx_paCompany.SelectionStart = 0;
            this.txtBx_paCompany.Size = new System.Drawing.Size(391, 23);
            this.txtBx_paCompany.TabIndex = 4;
            this.txtBx_paCompany.TabStop = false;
            this.txtBx_paCompany.UseSystemPasswordChar = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label14.Location = new System.Drawing.Point(633, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Lastname";
            // 
            // txtBx_paLastname
            // 
            this.txtBx_paLastname.Depth = 0;
            this.txtBx_paLastname.Hint = "Lastname";
            this.txtBx_paLastname.Location = new System.Drawing.Point(529, 82);
            this.txtBx_paLastname.MaxLength = 32767;
            this.txtBx_paLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_paLastname.Name = "txtBx_paLastname";
            this.txtBx_paLastname.PasswordChar = '\0';
            this.txtBx_paLastname.ReadOnly = false;
            this.txtBx_paLastname.SelectedText = "";
            this.txtBx_paLastname.SelectionLength = 0;
            this.txtBx_paLastname.SelectionStart = 0;
            this.txtBx_paLastname.Size = new System.Drawing.Size(189, 23);
            this.txtBx_paLastname.TabIndex = 3;
            this.txtBx_paLastname.TabStop = false;
            this.txtBx_paLastname.UseSystemPasswordChar = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label17.Location = new System.Drawing.Point(642, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 16);
            this.label17.TabIndex = 39;
            this.label17.Text = "Address #2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label16.Location = new System.Drawing.Point(618, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "Select address";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label24.Location = new System.Drawing.Point(651, 163);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 16);
            this.label24.TabIndex = 37;
            this.label24.Text = "Company";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label15.Location = new System.Drawing.Point(619, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Address #1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(706, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label23.Location = new System.Drawing.Point(607, 404);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 16);
            this.label23.TabIndex = 34;
            this.label23.Text = "Region / State";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(706, 404);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 15);
            this.label22.TabIndex = 33;
            this.label22.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label21.Location = new System.Drawing.Point(463, 403);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 16);
            this.label21.TabIndex = 32;
            this.label21.Text = "Country";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(504, 404);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 15);
            this.label20.TabIndex = 31;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label19.Location = new System.Drawing.Point(553, 340);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = "City";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label25.Location = new System.Drawing.Point(589, 340);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 15);
            this.label25.TabIndex = 29;
            this.label25.Text = "*";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label26.Location = new System.Drawing.Point(431, 108);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 16);
            this.label26.TabIndex = 28;
            this.label26.Text = "Firstname";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label27.Location = new System.Drawing.Point(504, 108);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(12, 15);
            this.label27.TabIndex = 38;
            this.label27.Text = "*";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label28.Location = new System.Drawing.Point(706, 108);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(12, 15);
            this.label28.TabIndex = 36;
            this.label28.Text = "*";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.cmbBx_shippingMethods);
            this.tabPage5.Controls.Add(this.label46);
            this.tabPage5.Controls.Add(this.label47);
            this.tabPage5.Controls.Add(this.cmbBx_saAddresses);
            this.tabPage5.Controls.Add(this.cmbBx_saZones);
            this.tabPage5.Controls.Add(this.cmbBx_saCountries);
            this.tabPage5.Controls.Add(this.txtBx_saFirstname);
            this.tabPage5.Controls.Add(this.txtBx_saPostcode);
            this.tabPage5.Controls.Add(this.txtBx_saCity);
            this.tabPage5.Controls.Add(this.txtBx_saAddress2);
            this.tabPage5.Controls.Add(this.txtBx_saAddress1);
            this.tabPage5.Controls.Add(this.txtBx_saCompany);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.txtBx_saLastname);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.label33);
            this.tabPage5.Controls.Add(this.label34);
            this.tabPage5.Controls.Add(this.label35);
            this.tabPage5.Controls.Add(this.label36);
            this.tabPage5.Controls.Add(this.label37);
            this.tabPage5.Controls.Add(this.label38);
            this.tabPage5.Controls.Add(this.label51);
            this.tabPage5.Controls.Add(this.label39);
            this.tabPage5.Controls.Add(this.label40);
            this.tabPage5.Controls.Add(this.label41);
            this.tabPage5.Controls.Add(this.label42);
            this.tabPage5.Controls.Add(this.label43);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1036, 443);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "4. Shipping details";
            // 
            // cmbBx_shippingMethods
            // 
            this.cmbBx_shippingMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_shippingMethods.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_shippingMethods.FormattingEnabled = true;
            this.cmbBx_shippingMethods.Location = new System.Drawing.Point(35, 26);
            this.cmbBx_shippingMethods.Name = "cmbBx_shippingMethods";
            this.cmbBx_shippingMethods.Size = new System.Drawing.Size(189, 24);
            this.cmbBx_shippingMethods.TabIndex = 0;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label46.Location = new System.Drawing.Point(97, 53);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(109, 16);
            this.label46.TabIndex = 74;
            this.label46.Text = "Shipping Method";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label47.Location = new System.Drawing.Point(212, 53);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(12, 15);
            this.label47.TabIndex = 73;
            this.label47.Text = "*";
            // 
            // cmbBx_saAddresses
            // 
            this.cmbBx_saAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_saAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_saAddresses.FormattingEnabled = true;
            this.cmbBx_saAddresses.Location = new System.Drawing.Point(327, 26);
            this.cmbBx_saAddresses.Name = "cmbBx_saAddresses";
            this.cmbBx_saAddresses.Size = new System.Drawing.Size(391, 23);
            this.cmbBx_saAddresses.TabIndex = 1;
            // 
            // cmbBx_saZones
            // 
            this.cmbBx_saZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_saZones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_saZones.FormattingEnabled = true;
            this.cmbBx_saZones.Location = new System.Drawing.Point(529, 376);
            this.cmbBx_saZones.Name = "cmbBx_saZones";
            this.cmbBx_saZones.Size = new System.Drawing.Size(189, 25);
            this.cmbBx_saZones.TabIndex = 10;
            // 
            // cmbBx_saCountries
            // 
            this.cmbBx_saCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_saCountries.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_saCountries.FormattingEnabled = true;
            this.cmbBx_saCountries.Location = new System.Drawing.Point(327, 376);
            this.cmbBx_saCountries.Name = "cmbBx_saCountries";
            this.cmbBx_saCountries.Size = new System.Drawing.Size(189, 25);
            this.cmbBx_saCountries.TabIndex = 9;
            // 
            // txtBx_saFirstname
            // 
            this.txtBx_saFirstname.Depth = 0;
            this.txtBx_saFirstname.Hint = "Firstname";
            this.txtBx_saFirstname.Location = new System.Drawing.Point(327, 82);
            this.txtBx_saFirstname.MaxLength = 32767;
            this.txtBx_saFirstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_saFirstname.Name = "txtBx_saFirstname";
            this.txtBx_saFirstname.PasswordChar = '\0';
            this.txtBx_saFirstname.ReadOnly = false;
            this.txtBx_saFirstname.SelectedText = "";
            this.txtBx_saFirstname.SelectionLength = 0;
            this.txtBx_saFirstname.SelectionStart = 0;
            this.txtBx_saFirstname.Size = new System.Drawing.Size(189, 23);
            this.txtBx_saFirstname.TabIndex = 2;
            this.txtBx_saFirstname.TabStop = false;
            this.txtBx_saFirstname.UseSystemPasswordChar = false;
            // 
            // txtBx_saPostcode
            // 
            this.txtBx_saPostcode.Depth = 0;
            this.txtBx_saPostcode.Hint = "Postcode";
            this.txtBx_saPostcode.Location = new System.Drawing.Point(622, 314);
            this.txtBx_saPostcode.MaxLength = 32767;
            this.txtBx_saPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_saPostcode.Name = "txtBx_saPostcode";
            this.txtBx_saPostcode.PasswordChar = '\0';
            this.txtBx_saPostcode.ReadOnly = false;
            this.txtBx_saPostcode.SelectedText = "";
            this.txtBx_saPostcode.SelectionLength = 0;
            this.txtBx_saPostcode.SelectionStart = 0;
            this.txtBx_saPostcode.Size = new System.Drawing.Size(96, 23);
            this.txtBx_saPostcode.TabIndex = 8;
            this.txtBx_saPostcode.TabStop = false;
            this.txtBx_saPostcode.UseSystemPasswordChar = false;
            // 
            // txtBx_saCity
            // 
            this.txtBx_saCity.Depth = 0;
            this.txtBx_saCity.Hint = "City";
            this.txtBx_saCity.Location = new System.Drawing.Point(327, 314);
            this.txtBx_saCity.MaxLength = 32767;
            this.txtBx_saCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_saCity.Name = "txtBx_saCity";
            this.txtBx_saCity.PasswordChar = '\0';
            this.txtBx_saCity.ReadOnly = false;
            this.txtBx_saCity.SelectedText = "";
            this.txtBx_saCity.SelectionLength = 0;
            this.txtBx_saCity.SelectionStart = 0;
            this.txtBx_saCity.Size = new System.Drawing.Size(274, 23);
            this.txtBx_saCity.TabIndex = 7;
            this.txtBx_saCity.TabStop = false;
            this.txtBx_saCity.UseSystemPasswordChar = false;
            // 
            // txtBx_saAddress2
            // 
            this.txtBx_saAddress2.Depth = 0;
            this.txtBx_saAddress2.Hint = "Address #2";
            this.txtBx_saAddress2.Location = new System.Drawing.Point(327, 243);
            this.txtBx_saAddress2.MaxLength = 32767;
            this.txtBx_saAddress2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_saAddress2.Name = "txtBx_saAddress2";
            this.txtBx_saAddress2.PasswordChar = '\0';
            this.txtBx_saAddress2.ReadOnly = false;
            this.txtBx_saAddress2.SelectedText = "";
            this.txtBx_saAddress2.SelectionLength = 0;
            this.txtBx_saAddress2.SelectionStart = 0;
            this.txtBx_saAddress2.Size = new System.Drawing.Size(391, 23);
            this.txtBx_saAddress2.TabIndex = 6;
            this.txtBx_saAddress2.TabStop = false;
            this.txtBx_saAddress2.UseSystemPasswordChar = false;
            // 
            // txtBx_saAddress1
            // 
            this.txtBx_saAddress1.Depth = 0;
            this.txtBx_saAddress1.Hint = "Address #1";
            this.txtBx_saAddress1.Location = new System.Drawing.Point(327, 190);
            this.txtBx_saAddress1.MaxLength = 32767;
            this.txtBx_saAddress1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_saAddress1.Name = "txtBx_saAddress1";
            this.txtBx_saAddress1.PasswordChar = '\0';
            this.txtBx_saAddress1.ReadOnly = false;
            this.txtBx_saAddress1.SelectedText = "";
            this.txtBx_saAddress1.SelectionLength = 0;
            this.txtBx_saAddress1.SelectionStart = 0;
            this.txtBx_saAddress1.Size = new System.Drawing.Size(391, 23);
            this.txtBx_saAddress1.TabIndex = 5;
            this.txtBx_saAddress1.TabStop = false;
            this.txtBx_saAddress1.UseSystemPasswordChar = false;
            // 
            // txtBx_saCompany
            // 
            this.txtBx_saCompany.Depth = 0;
            this.txtBx_saCompany.Hint = "Company";
            this.txtBx_saCompany.Location = new System.Drawing.Point(327, 137);
            this.txtBx_saCompany.MaxLength = 32767;
            this.txtBx_saCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_saCompany.Name = "txtBx_saCompany";
            this.txtBx_saCompany.PasswordChar = '\0';
            this.txtBx_saCompany.ReadOnly = false;
            this.txtBx_saCompany.SelectedText = "";
            this.txtBx_saCompany.SelectionLength = 0;
            this.txtBx_saCompany.SelectionStart = 0;
            this.txtBx_saCompany.Size = new System.Drawing.Size(391, 23);
            this.txtBx_saCompany.TabIndex = 4;
            this.txtBx_saCompany.TabStop = false;
            this.txtBx_saCompany.UseSystemPasswordChar = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label29.Location = new System.Drawing.Point(633, 107);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 16);
            this.label29.TabIndex = 65;
            this.label29.Text = "Lastname";
            // 
            // txtBx_saLastname
            // 
            this.txtBx_saLastname.Depth = 0;
            this.txtBx_saLastname.Hint = "Lastname";
            this.txtBx_saLastname.Location = new System.Drawing.Point(529, 82);
            this.txtBx_saLastname.MaxLength = 32767;
            this.txtBx_saLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_saLastname.Name = "txtBx_saLastname";
            this.txtBx_saLastname.PasswordChar = '\0';
            this.txtBx_saLastname.ReadOnly = false;
            this.txtBx_saLastname.SelectedText = "";
            this.txtBx_saLastname.SelectionLength = 0;
            this.txtBx_saLastname.SelectionStart = 0;
            this.txtBx_saLastname.Size = new System.Drawing.Size(189, 23);
            this.txtBx_saLastname.TabIndex = 3;
            this.txtBx_saLastname.TabStop = false;
            this.txtBx_saLastname.UseSystemPasswordChar = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label30.Location = new System.Drawing.Point(637, 269);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(76, 16);
            this.label30.TabIndex = 64;
            this.label30.Text = "Address #2";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label31.Location = new System.Drawing.Point(618, 52);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(99, 16);
            this.label31.TabIndex = 61;
            this.label31.Text = "Select address";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label32.Location = new System.Drawing.Point(652, 163);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(66, 16);
            this.label32.TabIndex = 62;
            this.label32.Text = "Company";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label33.Location = new System.Drawing.Point(619, 216);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 16);
            this.label33.TabIndex = 67;
            this.label33.Text = "Address #1";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label34.Location = new System.Drawing.Point(706, 216);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(12, 15);
            this.label34.TabIndex = 59;
            this.label34.Text = "*";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label35.Location = new System.Drawing.Point(601, 404);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(93, 16);
            this.label35.TabIndex = 58;
            this.label35.Text = "Region / State";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label36.Location = new System.Drawing.Point(706, 404);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(12, 15);
            this.label36.TabIndex = 57;
            this.label36.Text = "*";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label37.Location = new System.Drawing.Point(463, 404);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(53, 16);
            this.label37.TabIndex = 56;
            this.label37.Text = "Country";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label38.Location = new System.Drawing.Point(504, 404);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(12, 15);
            this.label38.TabIndex = 55;
            this.label38.Text = "*";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label51.Location = new System.Drawing.Point(652, 339);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(66, 16);
            this.label51.TabIndex = 54;
            this.label51.Text = "Postcode";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label39.Location = new System.Drawing.Point(553, 339);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(30, 16);
            this.label39.TabIndex = 54;
            this.label39.Text = "City";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label40.Location = new System.Drawing.Point(589, 340);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(12, 15);
            this.label40.TabIndex = 53;
            this.label40.Text = "*";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label41.Location = new System.Drawing.Point(431, 108);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(67, 16);
            this.label41.TabIndex = 52;
            this.label41.Text = "Firstname";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label42.Location = new System.Drawing.Point(504, 108);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(12, 15);
            this.label42.TabIndex = 63;
            this.label42.Text = "*";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label43.Location = new System.Drawing.Point(706, 108);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(12, 15);
            this.label43.TabIndex = 60;
            this.label43.Text = "*";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.flowLayoutPanel1);
            this.tabPage6.Controls.Add(this.label60);
            this.tabPage6.Controls.Add(this.label54);
            this.tabPage6.Controls.Add(this.lstVw_totalProducts);
            this.tabPage6.Controls.Add(this.cmbBx_orderStatus);
            this.tabPage6.Controls.Add(this.label48);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1036, 443);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "5. Total";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lbl_totals);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 77);
            this.flowLayoutPanel1.TabIndex = 81;
            // 
            // lbl_totals
            // 
            this.lbl_totals.AutoSize = true;
            this.lbl_totals.Depth = 0;
            this.lbl_totals.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_totals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_totals.Location = new System.Drawing.Point(3, 0);
            this.lbl_totals.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_totals.Name = "lbl_totals";
            this.lbl_totals.Size = new System.Drawing.Size(52, 19);
            this.lbl_totals.TabIndex = 0;
            this.lbl_totals.Text = "Totals";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label60.Location = new System.Drawing.Point(962, -12);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(12, 15);
            this.label60.TabIndex = 80;
            this.label60.Text = "*";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label54.Location = new System.Drawing.Point(962, 54);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(12, 15);
            this.label54.TabIndex = 80;
            this.label54.Text = "*";
            // 
            // lstVw_totalProducts
            // 
            this.lstVw_totalProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVw_totalProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lstVw_totalProducts.DataMember = null;
            this.lstVw_totalProducts.DataSource = null;
            this.lstVw_totalProducts.Depth = 0;
            this.lstVw_totalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lstVw_totalProducts.FullRowSelect = true;
            this.lstVw_totalProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVw_totalProducts.Location = new System.Drawing.Point(51, 108);
            this.lstVw_totalProducts.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVw_totalProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVw_totalProducts.Name = "lstVw_totalProducts";
            this.lstVw_totalProducts.OwnerDraw = true;
            this.lstVw_totalProducts.Size = new System.Drawing.Size(923, 313);
            this.lstVw_totalProducts.TabIndex = 79;
            this.lstVw_totalProducts.UseCompatibleStateImageBehavior = false;
            this.lstVw_totalProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Product";
            this.columnHeader11.Width = 221;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Model";
            this.columnHeader13.Width = 138;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Quantity";
            this.columnHeader14.Width = 143;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Unit price";
            this.columnHeader15.Width = 234;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Total";
            this.columnHeader16.Width = 119;
            // 
            // cmbBx_orderStatus
            // 
            this.cmbBx_orderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_orderStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_orderStatus.FormattingEnabled = true;
            this.cmbBx_orderStatus.Location = new System.Drawing.Point(785, 25);
            this.cmbBx_orderStatus.Name = "cmbBx_orderStatus";
            this.cmbBx_orderStatus.Size = new System.Drawing.Size(189, 25);
            this.cmbBx_orderStatus.TabIndex = 0;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label48.Location = new System.Drawing.Point(874, 53);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(82, 16);
            this.label48.TabIndex = 77;
            this.label48.Text = "Order Status";
            // 
            // printDialog_printer
            // 
            this.printDialog_printer.UseEXDialog = true;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_footer);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(1050, 576);
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.materialTabControl_container.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.cntxtMenuStrip_rmProduct.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_footer;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_save;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_backTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl_container;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_cPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_cEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_cLastname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_cFirstname;
        private System.Windows.Forms.ComboBox cmbBx_customerGroups;
        private System.Windows.Forms.ComboBox cmbBx_currencies;
        private System.Windows.Forms.ComboBox cmbBx_stores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_quantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBx_paZones;
        private System.Windows.Forms.ComboBox cmbBx_paCountries;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_paFirstname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_paPostcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_paCity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_paAddress2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_paAddress1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_paCompany;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_paLastname;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbBx_paAddresses;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbBx_saAddresses;
        private System.Windows.Forms.ComboBox cmbBx_saZones;
        private System.Windows.Forms.ComboBox cmbBx_saCountries;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_saFirstname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_saPostcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_saCity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_saAddress2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_saAddress1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_saCompany;
        private System.Windows.Forms.Label label29;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_saLastname;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cmbBx_paymentMethods;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox cmbBx_shippingMethods;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox cmbBx_orderStatus;
        private System.Windows.Forms.Label label48;
        private MaterialSkin.Controls.MaterialContextMenuStrip cntxtMenuStrip_rmProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private MaterialSkin.Controls.MaterialFlatButton btn_addProduct;
        private System.Windows.Forms.ComboBox cmbBx_products;
        private System.Windows.Forms.Label label53;
        private Controls.MaterialListViewBindable lstVw_products;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.PictureBox pictureBox_loading;
        private Controls.MaterialListViewBindable lstVw_totalProducts;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label label54;
        private MaterialSkin.Controls.MaterialLabel materialLabel_msg;
        private System.Windows.Forms.Label label55;
        private MaterialSkin.Controls.MaterialFlatButton btn_addCustomer;
        private System.Windows.Forms.TextBox txtBx_customers;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lbl_totals;
        private MaterialSkin.Controls.MaterialCheckBox chkbx_sendMail;
        private System.Windows.Forms.PrintDialog printDialog_printer;
    }
}
