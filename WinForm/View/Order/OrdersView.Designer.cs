namespace UI.View
{
    partial class OrdersView
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFlatButton_prev = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_frwd = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel_msg = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.materialListViewBindable_orders = new UI.Controls.MaterialListViewBindable();
            this.ch_id_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_customer_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_status_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_total_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_date_added_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_modificado_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialContextMenuStrip_options = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refrescarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel_total = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton_editOrder = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_addOrder = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_viewOrder = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_deleteOrder = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox_iconSearch = new System.Windows.Forms.PictureBox();
            this.materialSingleLineTextField_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.toolTip_msg = new System.Windows.Forms.ToolTip(this.components);
            this.panel_container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.materialContextMenuStrip_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.panel1);
            this.panel_container.Controls.Add(this.materialLabel_msg);
            this.panel_container.Controls.Add(this.pictureBox_loading);
            this.panel_container.Controls.Add(this.materialListViewBindable_orders);
            this.panel_container.Controls.Add(this.materialLabel_total);
            this.panel_container.Controls.Add(this.materialLabel1);
            this.panel_container.Controls.Add(this.materialFlatButton_editOrder);
            this.panel_container.Controls.Add(this.materialFlatButton_addOrder);
            this.panel_container.Controls.Add(this.materialFlatButton_viewOrder);
            this.panel_container.Controls.Add(this.materialFlatButton_deleteOrder);
            this.panel_container.Controls.Add(this.pictureBox_iconSearch);
            this.panel_container.Controls.Add(this.materialSingleLineTextField_search);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1050, 576);
            this.panel_container.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialFlatButton_prev);
            this.panel1.Controls.Add(this.materialFlatButton_frwd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 45);
            this.panel1.TabIndex = 17;
            // 
            // materialFlatButton_prev
            // 
            this.materialFlatButton_prev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_prev.Depth = 0;
            this.materialFlatButton_prev.Icon = global::UI.Properties.Resources.Back_32px;
            this.materialFlatButton_prev.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton_prev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_prev.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_prev.Name = "materialFlatButton_prev";
            this.materialFlatButton_prev.Primary = false;
            this.materialFlatButton_prev.Size = new System.Drawing.Size(55, 36);
            this.materialFlatButton_prev.TabIndex = 0;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_prev, "Página anterior");
            this.materialFlatButton_prev.UseVisualStyleBackColor = true;
            this.materialFlatButton_prev.Click += new System.EventHandler(this.MaterialFlatButton_pre_Click);
            // 
            // materialFlatButton_frwd
            // 
            this.materialFlatButton_frwd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_frwd.Depth = 0;
            this.materialFlatButton_frwd.Icon = global::UI.Properties.Resources.Forward_32px;
            this.materialFlatButton_frwd.Location = new System.Drawing.Point(67, 6);
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
            // materialLabel_msg
            // 
            this.materialLabel_msg.AutoSize = true;
            this.materialLabel_msg.Depth = 0;
            this.materialLabel_msg.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_msg.Location = new System.Drawing.Point(108, 491);
            this.materialLabel_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_msg.Name = "materialLabel_msg";
            this.materialLabel_msg.Size = new System.Drawing.Size(0, 19);
            this.materialLabel_msg.TabIndex = 15;
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.Image = global::UI.Properties.Resources.loading_squares;
            this.pictureBox_loading.Location = new System.Drawing.Point(492, 278);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(31, 31);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_loading.TabIndex = 2;
            this.pictureBox_loading.TabStop = false;
            // 
            // materialListViewBindable_orders
            // 
            this.materialListViewBindable_orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewBindable_orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_id_,
            this.ch_customer_,
            this.ch_status_,
            this.ch_total_,
            this.ch_date_added_,
            this.ch_modificado_});
            this.materialListViewBindable_orders.ContextMenuStrip = this.materialContextMenuStrip_options;
            this.materialListViewBindable_orders.DataMember = null;
            this.materialListViewBindable_orders.DataSource = null;
            this.materialListViewBindable_orders.Depth = 0;
            this.materialListViewBindable_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListViewBindable_orders.FullRowSelect = true;
            this.materialListViewBindable_orders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListViewBindable_orders.HideSelection = false;
            this.materialListViewBindable_orders.Location = new System.Drawing.Point(112, 102);
            this.materialListViewBindable_orders.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewBindable_orders.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListViewBindable_orders.Name = "materialListViewBindable_orders";
            this.materialListViewBindable_orders.OwnerDraw = true;
            this.materialListViewBindable_orders.Size = new System.Drawing.Size(791, 382);
            this.materialListViewBindable_orders.TabIndex = 14;
            this.materialListViewBindable_orders.UseCompatibleStateImageBehavior = false;
            this.materialListViewBindable_orders.View = System.Windows.Forms.View.Details;
            // 
            // ch_id_
            // 
            this.ch_id_.Text = "ID";
            // 
            // ch_customer_
            // 
            this.ch_customer_.Text = "Customer";
            this.ch_customer_.Width = 130;
            // 
            // ch_status_
            // 
            this.ch_status_.Text = "Status";
            this.ch_status_.Width = 140;
            // 
            // ch_total_
            // 
            this.ch_total_.Text = "Total";
            this.ch_total_.Width = 120;
            // 
            // ch_date_added_
            // 
            this.ch_date_added_.Text = "Date added";
            this.ch_date_added_.Width = 150;
            // 
            // ch_modificado_
            // 
            this.ch_modificado_.Text = "Date modified";
            this.ch_modificado_.Width = 171;
            // 
            // materialContextMenuStrip_options
            // 
            this.materialContextMenuStrip_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip_options.Depth = 0;
            this.materialContextMenuStrip_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.toolStripSeparator1,
            this.refrescarDatosToolStripMenuItem});
            this.materialContextMenuStrip_options.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip_options.Name = "materialContextMenuStrip_options";
            this.materialContextMenuStrip_options.Size = new System.Drawing.Size(113, 98);
            this.materialContextMenuStrip_options.Text = "Actions";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Image = global::UI.Properties.Resources.Eye_32px;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verToolStripMenuItem.Text = "View";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.VerToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::UI.Properties.Resources.CurrencyExchange_32px;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Update";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.EditarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Image = global::UI.Properties.Resources.Delete_32px;
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem.Text = "Delete";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.BorrarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // refrescarDatosToolStripMenuItem
            // 
            this.refrescarDatosToolStripMenuItem.Image = global::UI.Properties.Resources.Refresh_32px;
            this.refrescarDatosToolStripMenuItem.Name = "refrescarDatosToolStripMenuItem";
            this.refrescarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refrescarDatosToolStripMenuItem.Text = "Reload";
            this.refrescarDatosToolStripMenuItem.Click += new System.EventHandler(this.RefrescarDatosToolStripMenuItem_Click);
            // 
            // materialLabel_total
            // 
            this.materialLabel_total.AutoSize = true;
            this.materialLabel_total.Depth = 0;
            this.materialLabel_total.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_total.Location = new System.Drawing.Point(870, 492);
            this.materialLabel_total.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_total.Name = "materialLabel_total";
            this.materialLabel_total.Size = new System.Drawing.Size(17, 19);
            this.materialLabel_total.TabIndex = 13;
            this.materialLabel_total.Text = "0";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(816, 492);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Total:";
            // 
            // materialFlatButton_editOrder
            // 
            this.materialFlatButton_editOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_editOrder.Depth = 0;
            this.materialFlatButton_editOrder.Icon = global::UI.Properties.Resources.CurrencyExchange_32px;
            this.materialFlatButton_editOrder.Location = new System.Drawing.Point(910, 153);
            this.materialFlatButton_editOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_editOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_editOrder.Name = "materialFlatButton_editOrder";
            this.materialFlatButton_editOrder.Primary = false;
            this.materialFlatButton_editOrder.Size = new System.Drawing.Size(44, 38);
            this.materialFlatButton_editOrder.TabIndex = 3;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_editOrder, "Actualizar datos de venta");
            this.materialFlatButton_editOrder.UseVisualStyleBackColor = true;
            this.materialFlatButton_editOrder.Click += new System.EventHandler(this.MaterialFlatButton_editOrder_Click);
            // 
            // materialFlatButton_addOrder
            // 
            this.materialFlatButton_addOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_addOrder.Depth = 0;
            this.materialFlatButton_addOrder.Icon = global::UI.Properties.Resources.AddTag_32px;
            this.materialFlatButton_addOrder.Location = new System.Drawing.Point(910, 102);
            this.materialFlatButton_addOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_addOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_addOrder.Name = "materialFlatButton_addOrder";
            this.materialFlatButton_addOrder.Primary = false;
            this.materialFlatButton_addOrder.Size = new System.Drawing.Size(44, 38);
            this.materialFlatButton_addOrder.TabIndex = 2;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_addOrder, "Agregar nueva venta");
            this.materialFlatButton_addOrder.UseVisualStyleBackColor = true;
            this.materialFlatButton_addOrder.Click += new System.EventHandler(this.MaterialFlatButton_addOrder_Click);
            // 
            // materialFlatButton_viewOrder
            // 
            this.materialFlatButton_viewOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_viewOrder.Depth = 0;
            this.materialFlatButton_viewOrder.Icon = global::UI.Properties.Resources.Eye_32px;
            this.materialFlatButton_viewOrder.Location = new System.Drawing.Point(910, 203);
            this.materialFlatButton_viewOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_viewOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_viewOrder.Name = "materialFlatButton_viewOrder";
            this.materialFlatButton_viewOrder.Primary = false;
            this.materialFlatButton_viewOrder.Size = new System.Drawing.Size(44, 38);
            this.materialFlatButton_viewOrder.TabIndex = 4;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_viewOrder, "Ver orden de venta");
            this.materialFlatButton_viewOrder.UseVisualStyleBackColor = true;
            this.materialFlatButton_viewOrder.Click += new System.EventHandler(this.MaterialFlatButton_view_Click);
            // 
            // materialFlatButton_deleteOrder
            // 
            this.materialFlatButton_deleteOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_deleteOrder.Depth = 0;
            this.materialFlatButton_deleteOrder.Icon = global::UI.Properties.Resources.Delete_32px;
            this.materialFlatButton_deleteOrder.Location = new System.Drawing.Point(910, 253);
            this.materialFlatButton_deleteOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_deleteOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_deleteOrder.Name = "materialFlatButton_deleteOrder";
            this.materialFlatButton_deleteOrder.Primary = false;
            this.materialFlatButton_deleteOrder.Size = new System.Drawing.Size(44, 38);
            this.materialFlatButton_deleteOrder.TabIndex = 4;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_deleteOrder, "Eliminar venta");
            this.materialFlatButton_deleteOrder.UseVisualStyleBackColor = true;
            this.materialFlatButton_deleteOrder.Click += new System.EventHandler(this.MaterialFlatButton_deleteOrder_Click);
            // 
            // pictureBox_iconSearch
            // 
            this.pictureBox_iconSearch.Image = global::UI.Properties.Resources.Search_32px;
            this.pictureBox_iconSearch.Location = new System.Drawing.Point(112, 43);
            this.pictureBox_iconSearch.Name = "pictureBox_iconSearch";
            this.pictureBox_iconSearch.Size = new System.Drawing.Size(53, 53);
            this.pictureBox_iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_iconSearch.TabIndex = 7;
            this.pictureBox_iconSearch.TabStop = false;
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
            // toolTip_msg
            // 
            this.toolTip_msg.AutoPopDelay = 5000;
            this.toolTip_msg.InitialDelay = 1500;
            this.toolTip_msg.ReshowDelay = 100;
            // 
            // OrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_container);
            this.Name = "OrdersView";
            this.Size = new System.Drawing.Size(1050, 576);
            this.Load += new System.EventHandler(this.OrdersView_Load);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.materialContextMenuStrip_options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_editOrder;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_addOrder;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_deleteOrder;
        private System.Windows.Forms.PictureBox pictureBox_iconSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_search;
        private System.Windows.Forms.ToolTip toolTip_msg;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip_options;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refrescarDatosToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel_total;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Controls.MaterialListViewBindable materialListViewBindable_orders;
        private System.Windows.Forms.ColumnHeader ch_id_;
        private System.Windows.Forms.ColumnHeader ch_customer_;
        private System.Windows.Forms.ColumnHeader ch_status_;
        private System.Windows.Forms.ColumnHeader ch_total_;
        private System.Windows.Forms.ColumnHeader ch_date_added_;
        private System.Windows.Forms.ColumnHeader ch_modificado_;
        private MaterialSkin.Controls.MaterialLabel materialLabel_msg;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_viewOrder;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_prev;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_frwd;
        private System.Windows.Forms.PictureBox pictureBox_loading;
    }
}
