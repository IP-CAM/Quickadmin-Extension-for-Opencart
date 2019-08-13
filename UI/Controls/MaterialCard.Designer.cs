namespace UI.Controls
{
    partial class MaterialCard
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.materialLabel_title = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton_secondary = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton_primary = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lollipopLabel_subtitle = new LollipopLabel();
            this.lollipopLabel_info = new LollipopLabel();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Transparent;
            this.panel_header.Controls.Add(this.pictureBox_image);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(232, 105);
            this.panel_header.TabIndex = 0;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackColor = System.Drawing.Color.White;
            this.pictureBox_image.ErrorImage = global::UI.Properties.Resources.Product_96px;
            this.pictureBox_image.Image = global::UI.Properties.Resources.Product_96px;
            this.pictureBox_image.Location = new System.Drawing.Point(3, 4);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(229, 96);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image.TabIndex = 1;
            this.pictureBox_image.TabStop = false;
            // 
            // materialLabel_title
            // 
            this.materialLabel_title.BackColor = System.Drawing.Color.Gainsboro;
            this.materialLabel_title.Depth = 0;
            this.materialLabel_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_title.Location = new System.Drawing.Point(3, 108);
            this.materialLabel_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_title.Name = "materialLabel_title";
            this.materialLabel_title.Size = new System.Drawing.Size(227, 47);
            this.materialLabel_title.TabIndex = 1;
            this.materialLabel_title.Text = "Title";
            // 
            // materialFlatButton_secondary
            // 
            this.materialFlatButton_secondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_secondary.Depth = 0;
            this.materialFlatButton_secondary.Icon = null;
            this.materialFlatButton_secondary.Location = new System.Drawing.Point(120, 245);
            this.materialFlatButton_secondary.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_secondary.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_secondary.Name = "materialFlatButton_secondary";
            this.materialFlatButton_secondary.Primary = false;
            this.materialFlatButton_secondary.Size = new System.Drawing.Size(110, 37);
            this.materialFlatButton_secondary.TabIndex = 4;
            this.materialFlatButton_secondary.Text = "Secondary";
            this.materialFlatButton_secondary.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton_primary
            // 
            this.materialRaisedButton_primary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton_primary.Depth = 0;
            this.materialRaisedButton_primary.Icon = null;
            this.materialRaisedButton_primary.Location = new System.Drawing.Point(3, 245);
            this.materialRaisedButton_primary.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton_primary.Name = "materialRaisedButton_primary";
            this.materialRaisedButton_primary.Primary = true;
            this.materialRaisedButton_primary.Size = new System.Drawing.Size(110, 37);
            this.materialRaisedButton_primary.TabIndex = 5;
            this.materialRaisedButton_primary.Text = "Primary";
            this.materialRaisedButton_primary.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(3, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 1);
            this.panel1.TabIndex = 6;
            // 
            // lollipopLabel_subtitle
            // 
            this.lollipopLabel_subtitle.BackColor = System.Drawing.Color.White;
            this.lollipopLabel_subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel_subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel_subtitle.Location = new System.Drawing.Point(3, 155);
            this.lollipopLabel_subtitle.Name = "lollipopLabel_subtitle";
            this.lollipopLabel_subtitle.Size = new System.Drawing.Size(227, 31);
            this.lollipopLabel_subtitle.TabIndex = 2;
            this.lollipopLabel_subtitle.Text = "Subtitle";
            // 
            // lollipopLabel_info
            // 
            this.lollipopLabel_info.AutoSize = true;
            this.lollipopLabel_info.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lollipopLabel_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel_info.Location = new System.Drawing.Point(3, 186);
            this.lollipopLabel_info.Name = "lollipopLabel_info";
            this.lollipopLabel_info.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lollipopLabel_info.Size = new System.Drawing.Size(59, 18);
            this.lollipopLabel_info.TabIndex = 3;
            this.lollipopLabel_info.Text = "Information";
            // 
            // MaterialCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel_title);
            this.Controls.Add(this.materialRaisedButton_primary);
            this.Controls.Add(this.lollipopLabel_subtitle);
            this.Controls.Add(this.materialFlatButton_secondary);
            this.Controls.Add(this.lollipopLabel_info);
            this.Controls.Add(this.panel_header);
            this.MaximumSize = new System.Drawing.Size(234, 285);
            this.MinimumSize = new System.Drawing.Size(234, 285);
            this.Name = "MaterialCard";
            this.Size = new System.Drawing.Size(232, 283);
            this.Load += new System.EventHandler(this.MaterialCard_Load);
            this.panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private MaterialSkin.Controls.MaterialLabel materialLabel_title;
        private LollipopLabel lollipopLabel_subtitle;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_secondary;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton_primary;
        private System.Windows.Forms.Panel panel1;
        private LollipopLabel lollipopLabel_info;
    }
}
