using UI.Services;

namespace UI.View
{
    partial class CustomerView
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
            Messenger.Instance.Unregister(this);
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_address = new System.Windows.Forms.Panel();
            this.cmbBx_zones = new System.Windows.Forms.ComboBox();
            this.cmbBx_countries = new System.Windows.Forms.ComboBox();
            this.txtBx_afirstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_postcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_city = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_address2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_address1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_company = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBx_alastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.toggle_safe = new LollipopToggle();
            this.toggle_status = new LollipopToggle();
            this.toggle_newsletter = new LollipopToggle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBx_groupCustomers = new System.Windows.Forms.ComboBox();
            this.txtBx_telephone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_clastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_cfirstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.materialLabel_msg = new MaterialSkin.Controls.MaterialLabel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.materialFlatButton_email = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_backTo = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolTip_tip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel_address.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.panel_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 576);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.Address_32px;
            this.pictureBox2.Location = new System.Drawing.Point(996, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.ContactDetails_32px;
            this.pictureBox1.Location = new System.Drawing.Point(476, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.panel_address);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(538, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 449);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // panel_address
            // 
            this.panel_address.BackColor = System.Drawing.Color.White;
            this.panel_address.Controls.Add(this.cmbBx_zones);
            this.panel_address.Controls.Add(this.cmbBx_countries);
            this.panel_address.Controls.Add(this.txtBx_afirstname);
            this.panel_address.Controls.Add(this.txtBx_postcode);
            this.panel_address.Controls.Add(this.txtBx_city);
            this.panel_address.Controls.Add(this.txtBx_address2);
            this.panel_address.Controls.Add(this.txtBx_address1);
            this.panel_address.Controls.Add(this.txtBx_company);
            this.panel_address.Controls.Add(this.label13);
            this.panel_address.Controls.Add(this.txtBx_alastname);
            this.panel_address.Controls.Add(this.label17);
            this.panel_address.Controls.Add(this.label24);
            this.panel_address.Controls.Add(this.label15);
            this.panel_address.Controls.Add(this.label14);
            this.panel_address.Controls.Add(this.label23);
            this.panel_address.Controls.Add(this.label22);
            this.panel_address.Controls.Add(this.label21);
            this.panel_address.Controls.Add(this.label20);
            this.panel_address.Controls.Add(this.label16);
            this.panel_address.Controls.Add(this.label19);
            this.panel_address.Controls.Add(this.label18);
            this.panel_address.Controls.Add(this.label11);
            this.panel_address.Controls.Add(this.label10);
            this.panel_address.Controls.Add(this.label12);
            this.panel_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_address.Location = new System.Drawing.Point(3, 28);
            this.panel_address.Name = "panel_address";
            this.panel_address.Size = new System.Drawing.Size(484, 418);
            this.panel_address.TabIndex = 0;
            // 
            // cmbBx_zones
            // 
            this.cmbBx_zones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_zones.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_zones.FormattingEnabled = true;
            this.cmbBx_zones.Location = new System.Drawing.Point(247, 328);
            this.cmbBx_zones.Name = "cmbBx_zones";
            this.cmbBx_zones.Size = new System.Drawing.Size(139, 25);
            this.cmbBx_zones.TabIndex = 8;
            // 
            // cmbBx_countries
            // 
            this.cmbBx_countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_countries.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_countries.FormattingEnabled = true;
            this.cmbBx_countries.Location = new System.Drawing.Point(88, 328);
            this.cmbBx_countries.Name = "cmbBx_countries";
            this.cmbBx_countries.Size = new System.Drawing.Size(139, 25);
            this.cmbBx_countries.TabIndex = 7;
            // 
            // txtBx_afirstname
            // 
            this.txtBx_afirstname.Depth = 0;
            this.txtBx_afirstname.Hint = "Firstname";
            this.txtBx_afirstname.Location = new System.Drawing.Point(88, 34);
            this.txtBx_afirstname.MaxLength = 32767;
            this.txtBx_afirstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_afirstname.Name = "txtBx_afirstname";
            this.txtBx_afirstname.PasswordChar = '\0';
            this.txtBx_afirstname.ReadOnly = false;
            this.txtBx_afirstname.SelectedText = "";
            this.txtBx_afirstname.SelectionLength = 0;
            this.txtBx_afirstname.SelectionStart = 0;
            this.txtBx_afirstname.Size = new System.Drawing.Size(139, 23);
            this.txtBx_afirstname.TabIndex = 0;
            this.txtBx_afirstname.TabStop = false;
            this.txtBx_afirstname.UseSystemPasswordChar = false;
            // 
            // txtBx_postcode
            // 
            this.txtBx_postcode.Depth = 0;
            this.txtBx_postcode.Hint = "Postcode";
            this.txtBx_postcode.Location = new System.Drawing.Point(290, 266);
            this.txtBx_postcode.MaxLength = 32767;
            this.txtBx_postcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_postcode.Name = "txtBx_postcode";
            this.txtBx_postcode.PasswordChar = '\0';
            this.txtBx_postcode.ReadOnly = false;
            this.txtBx_postcode.SelectedText = "";
            this.txtBx_postcode.SelectionLength = 0;
            this.txtBx_postcode.SelectionStart = 0;
            this.txtBx_postcode.Size = new System.Drawing.Size(96, 23);
            this.txtBx_postcode.TabIndex = 6;
            this.txtBx_postcode.TabStop = false;
            this.txtBx_postcode.UseSystemPasswordChar = false;
            // 
            // txtBx_city
            // 
            this.txtBx_city.Depth = 0;
            this.txtBx_city.Hint = "City";
            this.txtBx_city.Location = new System.Drawing.Point(88, 266);
            this.txtBx_city.MaxLength = 32767;
            this.txtBx_city.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_city.Name = "txtBx_city";
            this.txtBx_city.PasswordChar = '\0';
            this.txtBx_city.ReadOnly = false;
            this.txtBx_city.SelectedText = "";
            this.txtBx_city.SelectionLength = 0;
            this.txtBx_city.SelectionStart = 0;
            this.txtBx_city.Size = new System.Drawing.Size(189, 23);
            this.txtBx_city.TabIndex = 5;
            this.txtBx_city.TabStop = false;
            this.txtBx_city.UseSystemPasswordChar = false;
            // 
            // txtBx_address2
            // 
            this.txtBx_address2.Depth = 0;
            this.txtBx_address2.Hint = "Address #2";
            this.txtBx_address2.Location = new System.Drawing.Point(88, 195);
            this.txtBx_address2.MaxLength = 32767;
            this.txtBx_address2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_address2.Name = "txtBx_address2";
            this.txtBx_address2.PasswordChar = '\0';
            this.txtBx_address2.ReadOnly = false;
            this.txtBx_address2.SelectedText = "";
            this.txtBx_address2.SelectionLength = 0;
            this.txtBx_address2.SelectionStart = 0;
            this.txtBx_address2.Size = new System.Drawing.Size(298, 23);
            this.txtBx_address2.TabIndex = 4;
            this.txtBx_address2.TabStop = false;
            this.txtBx_address2.UseSystemPasswordChar = false;
            // 
            // txtBx_address1
            // 
            this.txtBx_address1.Depth = 0;
            this.txtBx_address1.Hint = "Address #1";
            this.txtBx_address1.Location = new System.Drawing.Point(88, 142);
            this.txtBx_address1.MaxLength = 32767;
            this.txtBx_address1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_address1.Name = "txtBx_address1";
            this.txtBx_address1.PasswordChar = '\0';
            this.txtBx_address1.ReadOnly = false;
            this.txtBx_address1.SelectedText = "";
            this.txtBx_address1.SelectionLength = 0;
            this.txtBx_address1.SelectionStart = 0;
            this.txtBx_address1.Size = new System.Drawing.Size(298, 23);
            this.txtBx_address1.TabIndex = 3;
            this.txtBx_address1.TabStop = false;
            this.txtBx_address1.UseSystemPasswordChar = false;
            // 
            // txtBx_company
            // 
            this.txtBx_company.Depth = 0;
            this.txtBx_company.Hint = "Company";
            this.txtBx_company.Location = new System.Drawing.Point(88, 89);
            this.txtBx_company.MaxLength = 32767;
            this.txtBx_company.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_company.Name = "txtBx_company";
            this.txtBx_company.PasswordChar = '\0';
            this.txtBx_company.ReadOnly = false;
            this.txtBx_company.SelectedText = "";
            this.txtBx_company.SelectionLength = 0;
            this.txtBx_company.SelectionStart = 0;
            this.txtBx_company.Size = new System.Drawing.Size(298, 23);
            this.txtBx_company.TabIndex = 2;
            this.txtBx_company.TabStop = false;
            this.txtBx_company.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label13.Location = new System.Drawing.Point(301, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Lastname";
            // 
            // txtBx_alastname
            // 
            this.txtBx_alastname.Depth = 0;
            this.txtBx_alastname.Hint = "Lastname";
            this.txtBx_alastname.Location = new System.Drawing.Point(247, 34);
            this.txtBx_alastname.MaxLength = 32767;
            this.txtBx_alastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_alastname.Name = "txtBx_alastname";
            this.txtBx_alastname.PasswordChar = '\0';
            this.txtBx_alastname.ReadOnly = false;
            this.txtBx_alastname.SelectedText = "";
            this.txtBx_alastname.SelectionLength = 0;
            this.txtBx_alastname.SelectionStart = 0;
            this.txtBx_alastname.Size = new System.Drawing.Size(139, 23);
            this.txtBx_alastname.TabIndex = 1;
            this.txtBx_alastname.TabStop = false;
            this.txtBx_alastname.UseSystemPasswordChar = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label17.Location = new System.Drawing.Point(305, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Address #2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label24.Location = new System.Drawing.Point(320, 115);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 16);
            this.label24.TabIndex = 18;
            this.label24.Text = "Company";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label15.Location = new System.Drawing.Point(287, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Address #1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(374, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label23.Location = new System.Drawing.Point(275, 356);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 16);
            this.label23.TabIndex = 18;
            this.label23.Text = "Region / State";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(374, 356);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 15);
            this.label22.TabIndex = 18;
            this.label22.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label21.Location = new System.Drawing.Point(156, 355);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 16);
            this.label21.TabIndex = 18;
            this.label21.Text = "Country";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(215, 356);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 15);
            this.label20.TabIndex = 18;
            this.label20.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label16.Location = new System.Drawing.Point(320, 292);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 16);
            this.label16.TabIndex = 18;
            this.label16.Text = "Postcode";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label19.Location = new System.Drawing.Point(229, 292);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 16);
            this.label19.TabIndex = 18;
            this.label19.Text = "City";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(265, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 15);
            this.label18.TabIndex = 18;
            this.label18.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label11.Location = new System.Drawing.Point(142, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Firstname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(215, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(374, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lollipopLabel3);
            this.panel2.Controls.Add(this.lollipopLabel2);
            this.panel2.Controls.Add(this.lollipopLabel1);
            this.panel2.Controls.Add(this.toggle_safe);
            this.panel2.Controls.Add(this.toggle_status);
            this.panel2.Controls.Add(this.toggle_newsletter);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbBx_groupCustomers);
            this.panel2.Controls.Add(this.txtBx_telephone);
            this.panel2.Controls.Add(this.txtBx_email);
            this.panel2.Controls.Add(this.txtBx_clastname);
            this.panel2.Controls.Add(this.txtBx_cfirstname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 418);
            this.panel2.TabIndex = 0;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(333, 328);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(37, 17);
            this.lollipopLabel3.TabIndex = 22;
            this.lollipopLabel3.Text = "Safe";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(203, 328);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(48, 17);
            this.lollipopLabel2.TabIndex = 21;
            this.lollipopLabel2.Text = "Status";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(80, 328);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(74, 17);
            this.lollipopLabel1.TabIndex = 20;
            this.lollipopLabel1.Text = "Newsletter";
            // 
            // toggle_safe
            // 
            this.toggle_safe.AutoSize = true;
            this.toggle_safe.EllipseBorderColor = "#3b73d1";
            this.toggle_safe.EllipseColor = "#508ef5";
            this.toggle_safe.Location = new System.Drawing.Point(328, 348);
            this.toggle_safe.Name = "toggle_safe";
            this.toggle_safe.Size = new System.Drawing.Size(47, 19);
            this.toggle_safe.TabIndex = 7;
            this.toggle_safe.Text = "lollipopToggle1";
            this.toggle_safe.UseVisualStyleBackColor = true;
            // 
            // toggle_status
            // 
            this.toggle_status.AutoSize = true;
            this.toggle_status.EllipseBorderColor = "#3b73d1";
            this.toggle_status.EllipseColor = "#508ef5";
            this.toggle_status.Location = new System.Drawing.Point(204, 348);
            this.toggle_status.Name = "toggle_status";
            this.toggle_status.Size = new System.Drawing.Size(47, 19);
            this.toggle_status.TabIndex = 6;
            this.toggle_status.Text = "lollipopToggle1";
            this.toggle_status.UseVisualStyleBackColor = true;
            // 
            // toggle_newsletter
            // 
            this.toggle_newsletter.AutoSize = true;
            this.toggle_newsletter.EllipseBorderColor = "#3b73d1";
            this.toggle_newsletter.EllipseColor = "#508ef5";
            this.toggle_newsletter.Location = new System.Drawing.Point(94, 348);
            this.toggle_newsletter.Name = "toggle_newsletter";
            this.toggle_newsletter.Size = new System.Drawing.Size(47, 19);
            this.toggle_newsletter.TabIndex = 5;
            this.toggle_newsletter.Text = "lollipopToggle1";
            this.toggle_newsletter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(304, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(312, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(291, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lastname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(291, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Firstname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(364, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(364, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(364, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label25.Location = new System.Drawing.Point(366, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 15);
            this.label25.TabIndex = 18;
            this.label25.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(364, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(245, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer group";
            // 
            // cmbBx_groupCustomers
            // 
            this.cmbBx_groupCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_groupCustomers.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBx_groupCustomers.FormattingEnabled = true;
            this.cmbBx_groupCustomers.Location = new System.Drawing.Point(80, 34);
            this.cmbBx_groupCustomers.Name = "cmbBx_groupCustomers";
            this.cmbBx_groupCustomers.Size = new System.Drawing.Size(298, 25);
            this.cmbBx_groupCustomers.TabIndex = 0;
            // 
            // txtBx_telephone
            // 
            this.txtBx_telephone.Depth = 0;
            this.txtBx_telephone.Hint = "Telephone";
            this.txtBx_telephone.Location = new System.Drawing.Point(80, 248);
            this.txtBx_telephone.MaxLength = 32767;
            this.txtBx_telephone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_telephone.Name = "txtBx_telephone";
            this.txtBx_telephone.PasswordChar = '\0';
            this.txtBx_telephone.ReadOnly = false;
            this.txtBx_telephone.SelectedText = "";
            this.txtBx_telephone.SelectionLength = 0;
            this.txtBx_telephone.SelectionStart = 0;
            this.txtBx_telephone.Size = new System.Drawing.Size(298, 23);
            this.txtBx_telephone.TabIndex = 4;
            this.txtBx_telephone.TabStop = false;
            this.txtBx_telephone.UseSystemPasswordChar = false;
            // 
            // txtBx_email
            // 
            this.txtBx_email.Depth = 0;
            this.txtBx_email.Hint = "E-Mail";
            this.txtBx_email.Location = new System.Drawing.Point(80, 195);
            this.txtBx_email.MaxLength = 32767;
            this.txtBx_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_email.Name = "txtBx_email";
            this.txtBx_email.PasswordChar = '\0';
            this.txtBx_email.ReadOnly = false;
            this.txtBx_email.SelectedText = "";
            this.txtBx_email.SelectionLength = 0;
            this.txtBx_email.SelectionStart = 0;
            this.txtBx_email.Size = new System.Drawing.Size(298, 23);
            this.txtBx_email.TabIndex = 3;
            this.txtBx_email.TabStop = false;
            this.txtBx_email.UseSystemPasswordChar = false;
            // 
            // txtBx_clastname
            // 
            this.txtBx_clastname.Depth = 0;
            this.txtBx_clastname.Hint = "Lastname";
            this.txtBx_clastname.Location = new System.Drawing.Point(80, 142);
            this.txtBx_clastname.MaxLength = 32767;
            this.txtBx_clastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_clastname.Name = "txtBx_clastname";
            this.txtBx_clastname.PasswordChar = '\0';
            this.txtBx_clastname.ReadOnly = false;
            this.txtBx_clastname.SelectedText = "";
            this.txtBx_clastname.SelectionLength = 0;
            this.txtBx_clastname.SelectionStart = 0;
            this.txtBx_clastname.Size = new System.Drawing.Size(298, 23);
            this.txtBx_clastname.TabIndex = 2;
            this.txtBx_clastname.TabStop = false;
            this.txtBx_clastname.UseSystemPasswordChar = false;
            // 
            // txtBx_cfirstname
            // 
            this.txtBx_cfirstname.Depth = 0;
            this.txtBx_cfirstname.Hint = "Firstname";
            this.txtBx_cfirstname.Location = new System.Drawing.Point(80, 89);
            this.txtBx_cfirstname.MaxLength = 32767;
            this.txtBx_cfirstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_cfirstname.Name = "txtBx_cfirstname";
            this.txtBx_cfirstname.PasswordChar = '\0';
            this.txtBx_cfirstname.ReadOnly = false;
            this.txtBx_cfirstname.SelectedText = "";
            this.txtBx_cfirstname.SelectionLength = 0;
            this.txtBx_cfirstname.SelectionStart = 0;
            this.txtBx_cfirstname.Size = new System.Drawing.Size(298, 23);
            this.txtBx_cfirstname.TabIndex = 1;
            this.txtBx_cfirstname.TabStop = false;
            this.txtBx_cfirstname.UseSystemPasswordChar = false;
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.Image = global::UI.Properties.Resources.loading_squares;
            this.pictureBox_loading.Location = new System.Drawing.Point(854, 4);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(31, 31);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_loading.TabIndex = 4;
            this.pictureBox_loading.TabStop = false;
            // 
            // materialLabel_msg
            // 
            this.materialLabel_msg.AutoSize = true;
            this.materialLabel_msg.Depth = 0;
            this.materialLabel_msg.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_msg.Location = new System.Drawing.Point(150, 9);
            this.materialLabel_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_msg.Name = "materialLabel_msg";
            this.materialLabel_msg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel_msg.Size = new System.Drawing.Size(0, 19);
            this.materialLabel_msg.TabIndex = 2;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.materialFlatButton_email);
            this.panel_footer.Controls.Add(this.materialFlatButton_backTo);
            this.panel_footer.Controls.Add(this.pictureBox_loading);
            this.panel_footer.Controls.Add(this.materialLabel_msg);
            this.panel_footer.Controls.Add(this.materialFlatButton_save);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 537);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1050, 39);
            this.panel_footer.TabIndex = 1;
            // 
            // materialFlatButton_email
            // 
            this.materialFlatButton_email.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_email.Depth = 0;
            this.materialFlatButton_email.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialFlatButton_email.Enabled = false;
            this.materialFlatButton_email.Icon = global::UI.Properties.Resources.Envelope_32px;
            this.materialFlatButton_email.Location = new System.Drawing.Point(888, 0);
            this.materialFlatButton_email.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_email.Name = "materialFlatButton_email";
            this.materialFlatButton_email.Primary = false;
            this.materialFlatButton_email.Size = new System.Drawing.Size(46, 39);
            this.materialFlatButton_email.TabIndex = 3;
            this.toolTip_tip.SetToolTip(this.materialFlatButton_email, "Enviar correo de bienvenida");
            this.materialFlatButton_email.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton_backTo
            // 
            this.materialFlatButton_backTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_backTo.Depth = 0;
            this.materialFlatButton_backTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialFlatButton_backTo.Icon = global::UI.Properties.Resources.BackTo_32px;
            this.materialFlatButton_backTo.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton_backTo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_backTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_backTo.Name = "materialFlatButton_backTo";
            this.materialFlatButton_backTo.Primary = false;
            this.materialFlatButton_backTo.Size = new System.Drawing.Size(118, 39);
            this.materialFlatButton_backTo.TabIndex = 3;
            this.materialFlatButton_backTo.Text = "Regresar";
            this.materialFlatButton_backTo.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton_save
            // 
            this.materialFlatButton_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_save.Depth = 0;
            this.materialFlatButton_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialFlatButton_save.Icon = global::UI.Properties.Resources.Save_32px;
            this.materialFlatButton_save.Location = new System.Drawing.Point(934, 0);
            this.materialFlatButton_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_save.Name = "materialFlatButton_save";
            this.materialFlatButton_save.Primary = false;
            this.materialFlatButton_save.Size = new System.Drawing.Size(116, 39);
            this.materialFlatButton_save.TabIndex = 0;
            this.materialFlatButton_save.Text = "Guardar";
            this.materialFlatButton_save.UseVisualStyleBackColor = true;
            // 
            // toolTip_tip
            // 
            this.toolTip_tip.ToolTipTitle = "Info";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerView";
            this.Size = new System.Drawing.Size(1050, 576);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel_address.ResumeLayout(false);
            this.panel_address.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_footer;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBx_groupCustomers;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_telephone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_clastname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_cfirstname;
        private System.Windows.Forms.Panel panel_address;
        private System.Windows.Forms.ComboBox cmbBx_zones;
        private System.Windows.Forms.ComboBox cmbBx_countries;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_afirstname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_postcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_city;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_address2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_address1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_company;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_alastname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
        private LollipopToggle toggle_safe;
        private LollipopToggle toggle_status;
        private LollipopToggle toggle_newsletter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private MaterialSkin.Controls.MaterialLabel materialLabel_msg;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_backTo;
        private System.Windows.Forms.PictureBox pictureBox_loading;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_email;
        private System.Windows.Forms.ToolTip toolTip_tip;
        private System.Windows.Forms.Label label25;
    }
}
