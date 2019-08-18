namespace UI
{
    partial class MainForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.materialFlatButton_settings = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_customers = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_products = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_orders = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ovalPictureBox1 = new UI.Controls.OvalPictureBox();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.welcomeView = new UI.View.WelcomeView();
            this.panel_menu.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.panel_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_menu.AutoScroll = true;
            this.panel_menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_menu.Controls.Add(this.panel_buttons);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Location = new System.Drawing.Point(0, 64);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(150, 576);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.materialFlatButton_settings);
            this.panel_buttons.Controls.Add(this.materialFlatButton_customers);
            this.panel_buttons.Controls.Add(this.materialFlatButton_products);
            this.panel_buttons.Controls.Add(this.materialFlatButton_orders);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_buttons.Location = new System.Drawing.Point(0, 155);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(150, 421);
            this.panel_buttons.TabIndex = 1;
            // 
            // materialFlatButton_settings
            // 
            this.materialFlatButton_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton_settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_settings.Depth = 0;
            this.materialFlatButton_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton_settings.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton_settings.Icon = global::UI.Properties.Resources.Services_32px;
            this.materialFlatButton_settings.Location = new System.Drawing.Point(0, 385);
            this.materialFlatButton_settings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_settings.Name = "materialFlatButton_settings";
            this.materialFlatButton_settings.Primary = false;
            this.materialFlatButton_settings.Size = new System.Drawing.Size(150, 36);
            this.materialFlatButton_settings.TabIndex = 2;
            this.materialFlatButton_settings.Text = "Settings";
            this.materialFlatButton_settings.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton_customers
            // 
            this.materialFlatButton_customers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialFlatButton_customers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_customers.Depth = 0;
            this.materialFlatButton_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton_customers.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton_customers.Icon = global::UI.Properties.Resources.UserGroups_32px;
            this.materialFlatButton_customers.Location = new System.Drawing.Point(0, 150);
            this.materialFlatButton_customers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_customers.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_customers.Name = "materialFlatButton_customers";
            this.materialFlatButton_customers.Primary = false;
            this.materialFlatButton_customers.Size = new System.Drawing.Size(150, 36);
            this.materialFlatButton_customers.TabIndex = 3;
            this.materialFlatButton_customers.Text = "Customers";
            this.materialFlatButton_customers.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton_products
            // 
            this.materialFlatButton_products.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialFlatButton_products.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_products.Depth = 0;
            this.materialFlatButton_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton_products.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton_products.Icon = global::UI.Properties.Resources.MultipleDevices_32px;
            this.materialFlatButton_products.Location = new System.Drawing.Point(0, 111);
            this.materialFlatButton_products.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_products.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_products.Name = "materialFlatButton_products";
            this.materialFlatButton_products.Primary = false;
            this.materialFlatButton_products.Size = new System.Drawing.Size(150, 36);
            this.materialFlatButton_products.TabIndex = 4;
            this.materialFlatButton_products.Text = "Products";
            this.materialFlatButton_products.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton_orders
            // 
            this.materialFlatButton_orders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialFlatButton_orders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_orders.Depth = 0;
            this.materialFlatButton_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton_orders.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton_orders.Icon = global::UI.Properties.Resources.Pricing_32px;
            this.materialFlatButton_orders.Location = new System.Drawing.Point(0, 72);
            this.materialFlatButton_orders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_orders.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_orders.Name = "materialFlatButton_orders";
            this.materialFlatButton_orders.Primary = false;
            this.materialFlatButton_orders.Size = new System.Drawing.Size(150, 36);
            this.materialFlatButton_orders.TabIndex = 5;
            this.materialFlatButton_orders.Text = "Orders";
            this.materialFlatButton_orders.UseVisualStyleBackColor = true;
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.materialLabel1);
            this.panel_logo.Controls.Add(this.ovalPictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(150, 155);
            this.panel_logo.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 38);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "  OpenCart\r\nQuickAdmin";
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.ovalPictureBox1.Image = global::UI.Properties.Resources.OpenCart_32px;
            this.ovalPictureBox1.Location = new System.Drawing.Point(39, 17);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(73, 73);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ovalPictureBox1.TabIndex = 1;
            this.ovalPictureBox1.TabStop = false;
            // 
            // panel_controls
            // 
            this.panel_controls.BackColor = System.Drawing.Color.White;
            this.panel_controls.Controls.Add(this.welcomeView);
            this.panel_controls.Location = new System.Drawing.Point(150, 64);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(1050, 576);
            this.panel_controls.TabIndex = 2;
            // 
            // welcomeView
            // 
            this.welcomeView.Location = new System.Drawing.Point(0, 0);
            this.welcomeView.Name = "welcomeView";
            this.welcomeView.Size = new System.Drawing.Size(1050, 576);
            this.welcomeView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.panel_controls);
            this.Controls.Add(this.panel_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_menu.ResumeLayout(false);
            this.panel_buttons.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.panel_controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_buttons;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_settings;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_customers;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_products;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_orders;
        private View.WelcomeView welcomeView;
        private Controls.OvalPictureBox ovalPictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

