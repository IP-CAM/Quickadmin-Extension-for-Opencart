namespace UI.View
{
    partial class ProductGeneralView
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
            this.txtBx_productName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_metatagTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip_info = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_Tags = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBx_metaTagDesc = new LollipopTextBox();
            this.txtBx_metaTagKeyWords = new LollipopTextBox();
            this.HTMLwysiwyg_description = new HTMLWYSIWYG.htmlwysiwyg();
            this.SuspendLayout();
            // 
            // txtBx_productName
            // 
            this.txtBx_productName.Depth = 0;
            this.txtBx_productName.Hint = "Product name";
            this.txtBx_productName.Location = new System.Drawing.Point(62, 31);
            this.txtBx_productName.MaxLength = 32767;
            this.txtBx_productName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_productName.Name = "txtBx_productName";
            this.txtBx_productName.PasswordChar = '\0';
            this.txtBx_productName.ReadOnly = false;
            this.txtBx_productName.SelectedText = "";
            this.txtBx_productName.SelectionLength = 0;
            this.txtBx_productName.SelectionStart = 0;
            this.txtBx_productName.Size = new System.Drawing.Size(310, 23);
            this.txtBx_productName.TabIndex = 0;
            this.txtBx_productName.TabStop = false;
            this.txtBx_productName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(305, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // txtBx_metatagTitle
            // 
            this.txtBx_metatagTitle.Depth = 0;
            this.txtBx_metatagTitle.Hint = "Meta Tag Title";
            this.txtBx_metatagTitle.Location = new System.Drawing.Point(62, 92);
            this.txtBx_metatagTitle.MaxLength = 32767;
            this.txtBx_metatagTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_metatagTitle.Name = "txtBx_metatagTitle";
            this.txtBx_metatagTitle.PasswordChar = '\0';
            this.txtBx_metatagTitle.ReadOnly = false;
            this.txtBx_metatagTitle.SelectedText = "";
            this.txtBx_metatagTitle.SelectionLength = 0;
            this.txtBx_metatagTitle.SelectionStart = 0;
            this.txtBx_metatagTitle.Size = new System.Drawing.Size(310, 23);
            this.txtBx_metatagTitle.TabIndex = 1;
            this.txtBx_metatagTitle.TabStop = false;
            this.toolTip_info.SetToolTip(this.txtBx_metatagTitle, "Título de la ventana del navegador");
            this.txtBx_metatagTitle.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(269, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meta Tag Title";
            // 
            // toolTip_info
            // 
            this.toolTip_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_info.ToolTipTitle = "Info.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(62, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meta Tag Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(62, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Meta Tag Keywords";
            // 
            // txtBx_Tags
            // 
            this.txtBx_Tags.Depth = 0;
            this.txtBx_Tags.Hint = "Tags";
            this.txtBx_Tags.Location = new System.Drawing.Point(429, 31);
            this.txtBx_Tags.MaxLength = 32767;
            this.txtBx_Tags.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_Tags.Name = "txtBx_Tags";
            this.txtBx_Tags.PasswordChar = '\0';
            this.txtBx_Tags.ReadOnly = false;
            this.txtBx_Tags.SelectedText = "";
            this.txtBx_Tags.SelectionLength = 0;
            this.txtBx_Tags.SelectionStart = 0;
            this.txtBx_Tags.Size = new System.Drawing.Size(310, 23);
            this.txtBx_Tags.TabIndex = 4;
            this.txtBx_Tags.TabStop = false;
            this.txtBx_Tags.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(660, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product Tags";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(360, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(360, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label8.Location = new System.Drawing.Point(902, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Description";
            // 
            // txtBx_metaTagDesc
            // 
            this.txtBx_metaTagDesc.FocusedColor = "#508ef5";
            this.txtBx_metaTagDesc.FontColor = "#999999";
            this.txtBx_metaTagDesc.IsEnabled = true;
            this.txtBx_metaTagDesc.Location = new System.Drawing.Point(62, 172);
            this.txtBx_metaTagDesc.MaxLength = 32767;
            this.txtBx_metaTagDesc.Multiline = true;
            this.txtBx_metaTagDesc.Name = "txtBx_metaTagDesc";
            this.txtBx_metaTagDesc.ReadOnly = false;
            this.txtBx_metaTagDesc.Size = new System.Drawing.Size(310, 80);
            this.txtBx_metaTagDesc.TabIndex = 2;
            this.txtBx_metaTagDesc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBx_metaTagDesc.UseSystemPasswordChar = false;
            // 
            // txtBx_metaTagKeyWords
            // 
            this.txtBx_metaTagKeyWords.FocusedColor = "#508ef5";
            this.txtBx_metaTagKeyWords.FontColor = "#999999";
            this.txtBx_metaTagKeyWords.IsEnabled = true;
            this.txtBx_metaTagKeyWords.Location = new System.Drawing.Point(62, 290);
            this.txtBx_metaTagKeyWords.MaxLength = 32767;
            this.txtBx_metaTagKeyWords.Multiline = true;
            this.txtBx_metaTagKeyWords.Name = "txtBx_metaTagKeyWords";
            this.txtBx_metaTagKeyWords.ReadOnly = false;
            this.txtBx_metaTagKeyWords.Size = new System.Drawing.Size(310, 80);
            this.txtBx_metaTagKeyWords.TabIndex = 3;
            this.txtBx_metaTagKeyWords.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBx_metaTagKeyWords.UseSystemPasswordChar = false;
            // 
            // HTMLwysiwyg_description
            // 
            this.HTMLwysiwyg_description.AutoScroll = true;
            this.HTMLwysiwyg_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HTMLwysiwyg_description.Changed = false;
            this.HTMLwysiwyg_description.Location = new System.Drawing.Point(429, 92);
            this.HTMLwysiwyg_description.Name = "HTMLwysiwyg_description";
            this.HTMLwysiwyg_description.ShowAlignCenterButton = true;
            this.HTMLwysiwyg_description.ShowAlignLeftButton = true;
            this.HTMLwysiwyg_description.ShowAlignRightButton = true;
            this.HTMLwysiwyg_description.ShowBackColorButton = true;
            this.HTMLwysiwyg_description.ShowBolButton = true;
            this.HTMLwysiwyg_description.ShowBulletButton = true;
            this.HTMLwysiwyg_description.ShowCopyButton = true;
            this.HTMLwysiwyg_description.ShowCutButton = true;
            this.HTMLwysiwyg_description.ShowFontFamilyButton = false;
            this.HTMLwysiwyg_description.ShowFontSizeButton = false;
            this.HTMLwysiwyg_description.ShowIndentButton = false;
            this.HTMLwysiwyg_description.ShowItalicButton = true;
            this.HTMLwysiwyg_description.ShowJustifyButton = true;
            this.HTMLwysiwyg_description.ShowLinkButton = true;
            this.HTMLwysiwyg_description.ShowNewButton = false;
            this.HTMLwysiwyg_description.ShowOrderedListButton = true;
            this.HTMLwysiwyg_description.ShowOutdentButton = false;
            this.HTMLwysiwyg_description.ShowPasteButton = true;
            this.HTMLwysiwyg_description.ShowPrintButton = false;
            this.HTMLwysiwyg_description.ShowTxtBGButton = true;
            this.HTMLwysiwyg_description.ShowTxtColorButton = true;
            this.HTMLwysiwyg_description.ShowUnderlineButton = true;
            this.HTMLwysiwyg_description.ShowUnlinkButton = true;
            this.HTMLwysiwyg_description.Size = new System.Drawing.Size(545, 278);
            this.HTMLwysiwyg_description.TabIndex = 5;
            // 
            // ProductGeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HTMLwysiwyg_description);
            this.Controls.Add(this.txtBx_Tags);
            this.Controls.Add(this.txtBx_metaTagDesc);
            this.Controls.Add(this.txtBx_metaTagKeyWords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_metatagTitle);
            this.Controls.Add(this.txtBx_productName);
            this.Name = "ProductGeneralView";
            this.Size = new System.Drawing.Size(1022, 398);
            this.Load += new System.EventHandler(this.ProductGeneralView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_productName;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_metatagTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LollipopTextBox txtBx_metaTagKeyWords;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_Tags;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private LollipopTextBox txtBx_metaTagDesc;
        private System.Windows.Forms.Label label8;
        private HTMLWYSIWYG.htmlwysiwyg HTMLwysiwyg_description;
    }
}
