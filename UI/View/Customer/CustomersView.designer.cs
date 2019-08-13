namespace UI.View
{
    partial class CustomersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersView));
            this.materialContextMenuStrip_options = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refrescarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip_msg = new System.Windows.Forms.ToolTip(this.components);
            this.materialFlatButton_prev = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_frwd = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_editCustomer = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_addCustomer = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_deleteCustomer = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox_iconSearch = new System.Windows.Forms.PictureBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel_total = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.materialListViewBindable_customers = new UI.Controls.MaterialListViewBindable();
            this.ch_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_msg = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialContextMenuStrip_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).BeginInit();
            this.panel_container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip_options
            // 
            this.materialContextMenuStrip_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip_options.Depth = 0;
            this.materialContextMenuStrip_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.toolStripSeparator1,
            this.refrescarDatosToolStripMenuItem});
            this.materialContextMenuStrip_options.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip_options.Name = "materialContextMenuStrip_options";
            this.materialContextMenuStrip_options.Size = new System.Drawing.Size(113, 76);
            this.materialContextMenuStrip_options.Text = "Actions";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.editarToolStripMenuItem.Text = "Update";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.EditarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Image = global::UI.Properties.Resources.Denied_32px;
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
            // toolTip_msg
            // 
            this.toolTip_msg.AutoPopDelay = 5000;
            this.toolTip_msg.InitialDelay = 1500;
            this.toolTip_msg.ReshowDelay = 100;
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
            this.materialFlatButton_prev.Click += new System.EventHandler(this.MaterialFlatButton_prev_Click);
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
            // materialFlatButton_editCustomer
            // 
            this.materialFlatButton_editCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_editCustomer.Depth = 0;
            this.materialFlatButton_editCustomer.Icon = ((System.Drawing.Image)(resources.GetObject("materialFlatButton_editCustomer.Icon")));
            this.materialFlatButton_editCustomer.Location = new System.Drawing.Point(910, 153);
            this.materialFlatButton_editCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_editCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_editCustomer.Name = "materialFlatButton_editCustomer";
            this.materialFlatButton_editCustomer.Primary = false;
            this.materialFlatButton_editCustomer.Size = new System.Drawing.Size(44, 38);
            this.materialFlatButton_editCustomer.TabIndex = 3;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_editCustomer, "Actualizar cliente");
            this.materialFlatButton_editCustomer.UseVisualStyleBackColor = true;
            this.materialFlatButton_editCustomer.Click += new System.EventHandler(this.MaterialFlatButton_editCustomer_Click);
            // 
            // materialFlatButton_addCustomer
            // 
            this.materialFlatButton_addCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_addCustomer.Depth = 0;
            this.materialFlatButton_addCustomer.Icon = ((System.Drawing.Image)(resources.GetObject("materialFlatButton_addCustomer.Icon")));
            this.materialFlatButton_addCustomer.Location = new System.Drawing.Point(910, 102);
            this.materialFlatButton_addCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_addCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_addCustomer.Name = "materialFlatButton_addCustomer";
            this.materialFlatButton_addCustomer.Primary = false;
            this.materialFlatButton_addCustomer.Size = new System.Drawing.Size(44, 38);
            this.materialFlatButton_addCustomer.TabIndex = 2;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_addCustomer, "Agregar cliente");
            this.materialFlatButton_addCustomer.UseVisualStyleBackColor = true;
            this.materialFlatButton_addCustomer.Click += new System.EventHandler(this.MaterialFlatButton_addCustomer_Click);
            // 
            // materialFlatButton_deleteCustomer
            // 
            this.materialFlatButton_deleteCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_deleteCustomer.Depth = 0;
            this.materialFlatButton_deleteCustomer.Icon = global::UI.Properties.Resources.Denied_32px;
            this.materialFlatButton_deleteCustomer.Location = new System.Drawing.Point(910, 204);
            this.materialFlatButton_deleteCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_deleteCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_deleteCustomer.Name = "materialFlatButton_deleteCustomer";
            this.materialFlatButton_deleteCustomer.Primary = false;
            this.materialFlatButton_deleteCustomer.Size = new System.Drawing.Size(44, 38);
            this.materialFlatButton_deleteCustomer.TabIndex = 4;
            this.toolTip_msg.SetToolTip(this.materialFlatButton_deleteCustomer, "Eliminar cliente");
            this.materialFlatButton_deleteCustomer.UseVisualStyleBackColor = true;
            this.materialFlatButton_deleteCustomer.Click += new System.EventHandler(this.MaterialFlatButton_deleteCustomer_Click);
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
            this.toolTip_msg.SetToolTip(this.pictureBox_iconSearch, "Buscar");
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.panel1);
            this.panel_container.Controls.Add(this.materialLabel_total);
            this.panel_container.Controls.Add(this.pictureBox_loading);
            this.panel_container.Controls.Add(this.materialListViewBindable_customers);
            this.panel_container.Controls.Add(this.materialLabel1);
            this.panel_container.Controls.Add(this.materialLabel_msg);
            this.panel_container.Controls.Add(this.materialFlatButton_editCustomer);
            this.panel_container.Controls.Add(this.materialFlatButton_addCustomer);
            this.panel_container.Controls.Add(this.materialFlatButton_deleteCustomer);
            this.panel_container.Controls.Add(this.pictureBox_iconSearch);
            this.panel_container.Controls.Add(this.materialSingleLineTextField_search);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1050, 576);
            this.panel_container.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialFlatButton_prev);
            this.panel1.Controls.Add(this.materialFlatButton_frwd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 45);
            this.panel1.TabIndex = 16;
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
            this.materialLabel_total.TabIndex = 15;
            this.materialLabel_total.Text = "0";
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
            // materialListViewBindable_customers
            // 
            this.materialListViewBindable_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewBindable_customers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_id,
            this.ch_name,
            this.ch_email});
            this.materialListViewBindable_customers.ContextMenuStrip = this.materialContextMenuStrip_options;
            this.materialListViewBindable_customers.DataMember = null;
            this.materialListViewBindable_customers.DataSource = null;
            this.materialListViewBindable_customers.Depth = 0;
            this.materialListViewBindable_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListViewBindable_customers.FullRowSelect = true;
            this.materialListViewBindable_customers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListViewBindable_customers.HideSelection = false;
            this.materialListViewBindable_customers.Location = new System.Drawing.Point(112, 102);
            this.materialListViewBindable_customers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewBindable_customers.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListViewBindable_customers.Name = "materialListViewBindable_customers";
            this.materialListViewBindable_customers.OwnerDraw = true;
            this.materialListViewBindable_customers.Size = new System.Drawing.Size(791, 382);
            this.materialListViewBindable_customers.TabIndex = 14;
            this.materialListViewBindable_customers.UseCompatibleStateImageBehavior = false;
            this.materialListViewBindable_customers.View = System.Windows.Forms.View.Details;
            // 
            // ch_id
            // 
            this.ch_id.Text = "#";
            this.ch_id.Width = 123;
            // 
            // ch_name
            // 
            this.ch_name.Text = "Customer name";
            this.ch_name.Width = 286;
            // 
            // ch_email
            // 
            this.ch_email.Text = "Email";
            this.ch_email.Width = 294;
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
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Total:";
            // 
            // materialLabel_msg
            // 
            this.materialLabel_msg.AutoSize = true;
            this.materialLabel_msg.Depth = 0;
            this.materialLabel_msg.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_msg.Location = new System.Drawing.Point(112, 492);
            this.materialLabel_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_msg.Name = "materialLabel_msg";
            this.materialLabel_msg.Size = new System.Drawing.Size(0, 19);
            this.materialLabel_msg.TabIndex = 2;
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
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_container);
            this.Name = "CustomersView";
            this.Size = new System.Drawing.Size(1050, 576);
            this.Load += new System.EventHandler(this.CustomersView_Load);
            this.materialContextMenuStrip_options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).EndInit();
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip_options;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refrescarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip_msg;
        private System.Windows.Forms.Panel panel_container;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_editCustomer;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_addCustomer;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_deleteCustomer;
        private System.Windows.Forms.PictureBox pictureBox_iconSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_search;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_prev;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_frwd;
        private Controls.MaterialListViewBindable materialListViewBindable_customers;
        private MaterialSkin.Controls.MaterialLabel materialLabel_msg;
        private System.Windows.Forms.ColumnHeader ch_id;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_email;
        private MaterialSkin.Controls.MaterialLabel materialLabel_total;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_loading;
    }
}
