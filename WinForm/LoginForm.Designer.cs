namespace UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBx_url = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_msg = new LollipopLabel();
            this.lbl_version = new LollipopLabel();
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBx_key = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.Tag = "";
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Store";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtBx_url);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_msg);
            this.panel1.Controls.Add(this.lbl_version);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txtBx_key);
            this.panel1.Controls.Add(this.txtBx_username);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 213);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.api_32px;
            this.pictureBox1.Location = new System.Drawing.Point(457, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // txtBx_url
            // 
            this.txtBx_url.Depth = 0;
            this.txtBx_url.Hint = "http://my-store.com";
            this.txtBx_url.Location = new System.Drawing.Point(117, 12);
            this.txtBx_url.MaxLength = 32767;
            this.txtBx_url.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_url.Name = "txtBx_url";
            this.txtBx_url.PasswordChar = '\0';
            this.txtBx_url.ReadOnly = false;
            this.txtBx_url.SelectedText = "";
            this.txtBx_url.SelectionLength = 0;
            this.txtBx_url.SelectionStart = 0;
            this.txtBx_url.Size = new System.Drawing.Size(282, 23);
            this.txtBx_url.TabIndex = 32;
            this.txtBx_url.TabStop = false;
            this.txtBx_url.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::UI.Properties.Resources.OpenCart_32px;
            this.pictureBox2.Location = new System.Drawing.Point(457, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbl_msg.Location = new System.Drawing.Point(3, 11);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 17);
            this.lbl_msg.TabIndex = 29;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbl_version.Location = new System.Drawing.Point(3, 193);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(54, 17);
            this.lbl_version.TabIndex = 30;
            this.lbl_version.Text = "version";
            // 
            // btn_login
            // 
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Depth = 0;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(117, 159);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(282, 23);
            this.btn_login.TabIndex = 28;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // txtBx_key
            // 
            this.txtBx_key.Depth = 0;
            this.txtBx_key.Hint = "Key";
            this.txtBx_key.Location = new System.Drawing.Point(117, 110);
            this.txtBx_key.MaxLength = 32767;
            this.txtBx_key.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_key.Name = "txtBx_key";
            this.txtBx_key.PasswordChar = '*';
            this.txtBx_key.ReadOnly = false;
            this.txtBx_key.SelectedText = "";
            this.txtBx_key.SelectionLength = 0;
            this.txtBx_key.SelectionStart = 0;
            this.txtBx_key.Size = new System.Drawing.Size(282, 23);
            this.txtBx_key.TabIndex = 27;
            this.txtBx_key.TabStop = false;
            this.txtBx_key.UseSystemPasswordChar = false;
            // 
            // txtBx_username
            // 
            this.txtBx_username.Depth = 0;
            this.txtBx_username.Hint = "Username";
            this.txtBx_username.Location = new System.Drawing.Point(117, 61);
            this.txtBx_username.MaxLength = 32767;
            this.txtBx_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_username.Name = "txtBx_username";
            this.txtBx_username.PasswordChar = '\0';
            this.txtBx_username.ReadOnly = false;
            this.txtBx_username.SelectedText = "";
            this.txtBx_username.SelectionLength = 0;
            this.txtBx_username.SelectionStart = 0;
            this.txtBx_username.Size = new System.Drawing.Size(282, 23);
            this.txtBx_username.TabIndex = 26;
            this.txtBx_username.TabStop = false;
            this.txtBx_username.UseSystemPasswordChar = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 303);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | OpenCart QuickAdmin";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_url;
        private System.Windows.Forms.PictureBox pictureBox2;
        private LollipopLabel lbl_msg;
        private LollipopLabel lbl_version;
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_key;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_username;
    }
}