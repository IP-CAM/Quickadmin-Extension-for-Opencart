namespace UI.View
{
    partial class WelcomeView
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
            this.panel_container = new System.Windows.Forms.Panel();
            this.lollipopLabel_version = new LollipopLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lollipopLabel_text = new LollipopLabel();
            this.panel_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.White;
            this.panel_container.Controls.Add(this.lollipopLabel_version);
            this.panel_container.Controls.Add(this.pictureBox1);
            this.panel_container.Controls.Add(this.lollipopLabel_text);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1050, 576);
            this.panel_container.TabIndex = 0;
            // 
            // lollipopLabel_version
            // 
            this.lollipopLabel_version.AutoSize = true;
            this.lollipopLabel_version.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel_version.Location = new System.Drawing.Point(17, 543);
            this.lollipopLabel_version.Name = "lollipopLabel_version";
            this.lollipopLabel_version.Size = new System.Drawing.Size(54, 17);
            this.lollipopLabel_version.TabIndex = 3;
            this.lollipopLabel_version.Text = "version";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.OpenCart_32px;
            this.pictureBox1.Location = new System.Drawing.Point(1000, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lollipopLabel_text
            // 
            this.lollipopLabel_text.AutoSize = true;
            this.lollipopLabel_text.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel_text.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.lollipopLabel_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel_text.Location = new System.Drawing.Point(412, 248);
            this.lollipopLabel_text.Name = "lollipopLabel_text";
            this.lollipopLabel_text.Size = new System.Drawing.Size(227, 80);
            this.lollipopLabel_text.TabIndex = 0;
            this.lollipopLabel_text.Text = "OpenCart\r\nQuick Admin";
            this.lollipopLabel_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_container);
            this.Name = "WelcomeView";
            this.Size = new System.Drawing.Size(1050, 576);
            this.Load += new System.EventHandler(this.WelcomeView_Load);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private LollipopLabel lollipopLabel_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopLabel lollipopLabel_version;
    }
}
