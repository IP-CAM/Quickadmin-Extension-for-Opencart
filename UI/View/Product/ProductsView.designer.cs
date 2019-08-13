using UI.Services;

namespace UI.View
{
    partial class ProductsView
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
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            this.materialContextMenuStrip_options = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.refrescarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip_msg = new System.Windows.Forms.ToolTip(this.components);
            this.materialFlatButton_addProduct = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox_iconSearch = new System.Windows.Forms.PictureBox();
            this.materialFlatButton_prev = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_frwd = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel_productsview = new System.Windows.Forms.Panel();
            this.materialLabel_msg = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel_container = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_totalProducts = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialContextMenuStrip_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).BeginInit();
            this.panel_productsview.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip_options
            // 
            this.materialContextMenuStrip_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip_options.Depth = 0;
            this.materialContextMenuStrip_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrescarDatosToolStripMenuItem});
            this.materialContextMenuStrip_options.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip_options.Name = "materialContextMenuStrip_options";
            this.materialContextMenuStrip_options.Size = new System.Drawing.Size(121, 26);
            this.materialContextMenuStrip_options.Text = "Acciones";
            // 
            // refrescarDatosToolStripMenuItem
            // 
            this.refrescarDatosToolStripMenuItem.Image = global::UI.Properties.Resources.Refresh_32px;
            this.refrescarDatosToolStripMenuItem.Name = "refrescarDatosToolStripMenuItem";
            this.refrescarDatosToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.refrescarDatosToolStripMenuItem.Text = "Recargar";
            this.refrescarDatosToolStripMenuItem.Click += new System.EventHandler(this.RefrescarDatosToolStripMenuItem_Click);
            // 
            // toolTip_msg
            // 
            this.toolTip_msg.AutoPopDelay = 5000;
            this.toolTip_msg.InitialDelay = 1500;
            this.toolTip_msg.ReshowDelay = 100;
            // 
            // materialFlatButton_addProduct
            // 
            this.materialFlatButton_addProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_addProduct.Depth = 0;
            this.materialFlatButton_addProduct.Icon = ((System.Drawing.Image)(resources.GetObject("materialFlatButton_addProduct.Icon")));
            this.materialFlatButton_addProduct.Location = new System.Drawing.Point(896, 58);
            this.materialFlatButton_addProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_addProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_addProduct.Name = "materialFlatButton_addProduct";
            this.materialFlatButton_addProduct.Primary = false;
            this.materialFlatButton_addProduct.Size = new System.Drawing.Size(44, 38);
            this.materialFlatButton_addProduct.TabIndex = 1;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_addProduct, "Agregar producto");
            this.materialFlatButton_addProduct.UseVisualStyleBackColor = true;
            this.materialFlatButton_addProduct.Click += new System.EventHandler(this.MaterialFlatButton_addProduct_Click);
            // 
            // pictureBox_iconSearch
            // 
            this.pictureBox_iconSearch.Image = global::UI.Properties.Resources.Search_32px;
            this.pictureBox_iconSearch.Location = new System.Drawing.Point(112, 43);
            this.pictureBox_iconSearch.Name = "pictureBox_iconSearch";
            this.pictureBox_iconSearch.Size = new System.Drawing.Size(53, 53);
            this.pictureBox_iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_iconSearch.TabIndex = 13;
            this.pictureBox_iconSearch.TabStop = false;
            this.toolTip_msg.SetToolTip(this.pictureBox_iconSearch, "Buscar");
            // 
            // materialFlatButton_prev
            // 
            this.materialFlatButton_prev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_prev.Depth = 0;
            this.materialFlatButton_prev.Icon = global::UI.Properties.Resources.Back_32px;
            this.materialFlatButton_prev.Location = new System.Drawing.Point(9, 6);
            this.materialFlatButton_prev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_prev.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_prev.Name = "materialFlatButton_prev";
            this.materialFlatButton_prev.Primary = false;
            this.materialFlatButton_prev.Size = new System.Drawing.Size(55, 36);
            this.materialFlatButton_prev.TabIndex = 0;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_prev, "Página anterior");
            this.materialFlatButton_prev.UseVisualStyleBackColor = true;
            this.materialFlatButton_prev.Click += new System.EventHandler(this.MaterialFlatButton_prev_Click);
            // 
            // materialFlatButton_frwd
            // 
            this.materialFlatButton_frwd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_frwd.Depth = 0;
            this.materialFlatButton_frwd.Icon = global::UI.Properties.Resources.Forward_32px;
            this.materialFlatButton_frwd.Location = new System.Drawing.Point(72, 6);
            this.materialFlatButton_frwd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_frwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_frwd.Name = "materialFlatButton_frwd";
            this.materialFlatButton_frwd.Primary = false;
            this.materialFlatButton_frwd.Size = new System.Drawing.Size(55, 36);
            this.materialFlatButton_frwd.TabIndex = 1;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_frwd, "Siguiente página");
            this.materialFlatButton_frwd.UseVisualStyleBackColor = true;
            this.materialFlatButton_frwd.Click += new System.EventHandler(this.MaterialFlatButton_frwd_Click);
            // 
            // panel_productsview
            // 
            this.panel_productsview.Controls.Add(this.materialLabel_msg);
            this.panel_productsview.Controls.Add(this.panel1);
            this.panel_productsview.Controls.Add(this.flowLayoutPanel_container);
            this.panel_productsview.Controls.Add(this.materialLabel1);
            this.panel_productsview.Controls.Add(this.materialLabel_totalProducts);
            this.panel_productsview.Controls.Add(this.materialFlatButton_addProduct);
            this.panel_productsview.Controls.Add(this.pictureBox_iconSearch);
            this.panel_productsview.Controls.Add(this.materialSingleLineTextField_search);
            this.panel_productsview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_productsview.Location = new System.Drawing.Point(0, 0);
            this.panel_productsview.Name = "panel_productsview";
            this.panel_productsview.Size = new System.Drawing.Size(1050, 576);
            this.panel_productsview.TabIndex = 1;
            // 
            // materialLabel_msg
            // 
            this.materialLabel_msg.AutoSize = true;
            this.materialLabel_msg.Depth = 0;
            this.materialLabel_msg.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_msg.Location = new System.Drawing.Point(108, 490);
            this.materialLabel_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_msg.Name = "materialLabel_msg";
            this.materialLabel_msg.Size = new System.Drawing.Size(0, 19);
            this.materialLabel_msg.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_loading);
            this.panel1.Controls.Add(this.materialFlatButton_frwd);
            this.panel1.Controls.Add(this.materialFlatButton_prev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 45);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.Image = global::UI.Properties.Resources.loading_squares;
            this.pictureBox_loading.Location = new System.Drawing.Point(1004, 6);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(31, 31);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_loading.TabIndex = 3;
            this.pictureBox_loading.TabStop = false;
            // 
            // flowLayoutPanel_container
            // 
            this.flowLayoutPanel_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_container.AutoScroll = true;
            this.flowLayoutPanel_container.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_container.ContextMenuStrip = this.materialContextMenuStrip_options;
            this.flowLayoutPanel_container.Location = new System.Drawing.Point(112, 105);
            this.flowLayoutPanel_container.Name = "flowLayoutPanel_container";
            this.flowLayoutPanel_container.Size = new System.Drawing.Size(828, 382);
            this.flowLayoutPanel_container.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(848, 490);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Total:";
            // 
            // materialLabel_totalProducts
            // 
            this.materialLabel_totalProducts.AutoSize = true;
            this.materialLabel_totalProducts.Depth = 0;
            this.materialLabel_totalProducts.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_totalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_totalProducts.Location = new System.Drawing.Point(902, 490);
            this.materialLabel_totalProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_totalProducts.Name = "materialLabel_totalProducts";
            this.materialLabel_totalProducts.Size = new System.Drawing.Size(17, 19);
            this.materialLabel_totalProducts.TabIndex = 18;
            this.materialLabel_totalProducts.Text = "0";
            // 
            // materialSingleLineTextField_search
            // 
            this.materialSingleLineTextField_search.Depth = 0;
            this.materialSingleLineTextField_search.Hint = "Search...";
            this.materialSingleLineTextField_search.Location = new System.Drawing.Point(171, 58);
            this.materialSingleLineTextField_search.MaxLength = 32767;
            this.materialSingleLineTextField_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_search.Name = "materialSingleLineTextField_search";
            this.materialSingleLineTextField_search.PasswordChar = '\0';
            this.materialSingleLineTextField_search.ReadOnly = false;
            this.materialSingleLineTextField_search.SelectedText = "";
            this.materialSingleLineTextField_search.SelectionLength = 0;
            this.materialSingleLineTextField_search.SelectionStart = 0;
            this.materialSingleLineTextField_search.Size = new System.Drawing.Size(443, 23);
            this.materialSingleLineTextField_search.TabIndex = 0;
            this.materialSingleLineTextField_search.TabStop = false;
            this.materialSingleLineTextField_search.UseSystemPasswordChar = false;
            this.materialSingleLineTextField_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MaterialSingleLineTextField_search_KeyUp);
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_productsview);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(1050, 576);
            this.Load += new System.EventHandler(this.ProductsView_Load);
            this.materialContextMenuStrip_options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).EndInit();
            this.panel_productsview.ResumeLayout(false);
            this.panel_productsview.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip_options;
        private System.Windows.Forms.ToolStripMenuItem refrescarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip_msg;
        private System.Windows.Forms.Panel panel_productsview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_container;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_addProduct;
        private System.Windows.Forms.PictureBox pictureBox_iconSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_search;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_prev;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_frwd;
        private MaterialSkin.Controls.MaterialLabel materialLabel_totalProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_loading;
        private MaterialSkin.Controls.MaterialLabel materialLabel_msg;
    }
}
