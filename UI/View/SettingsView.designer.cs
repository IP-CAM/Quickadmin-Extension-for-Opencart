namespace UI.View
{
    partial class SettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.toolTip_msg = new System.Windows.Forms.ToolTip(this.components);
            this.folderInput_dir = new LollipopFolderInPut();
            this.fileInpt_template = new LollipopFileInput();
            this.txtBx_nItems = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_exportConfig = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_importConfig = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialTabSelector_settings = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl_settings = new MaterialSkin.Controls.MaterialTabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_minutes = new LollipopLabel();
            this.btn_lessMinutes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_moreMinutes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.prgrssBr_minutes = new MaterialSkin.Controls.MaterialProgressBar();
            this.chckBx_proxy = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel4 = new LollipopLabel();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_folder = new System.Windows.Forms.PictureBox();
            this.pictureBox_file = new System.Windows.Forms.PictureBox();
            this.label_saveFile_desc = new System.Windows.Forms.Label();
            this.label_file_desc = new System.Windows.Forms.Label();
            this.chckBx_saveFile = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel_template = new MaterialSkin.Controls.MaterialLabel();
            this.tabApi = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_APIkey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_APIHost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_APIusr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new System.Windows.Forms.Label();
            this.label_api_pwd_desc = new System.Windows.Forms.Label();
            this.label_api_usr_desc = new System.Windows.Forms.Label();
            this.tabMail = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_mailMsg = new System.Windows.Forms.TextBox();
            this.materialDivider_divider = new MaterialSkin.Controls.MaterialDivider();
            this.txtBx_mailPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_mailSubject = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_mailHost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_mailPwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBx_mailEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_updates = new System.Windows.Forms.TabPage();
            this.btn_updates = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_updateMsg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_msg = new MaterialSkin.Controls.MaterialLabel();
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog_import = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_export = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.materialTabControl_settings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_folder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_file)).BeginInit();
            this.tabApi.SuspendLayout();
            this.tabMail.SuspendLayout();
            this.tabPage_updates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip_msg
            // 
            this.toolTip_msg.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_msg.ToolTipTitle = "Info";
            // 
            // folderInput_dir
            // 
            this.folderInput_dir.FocusedColor = "#508ef5";
            this.folderInput_dir.FontColor = "#999999";
            this.folderInput_dir.IsEnabled = true;
            this.folderInput_dir.Location = new System.Drawing.Point(98, 287);
            this.folderInput_dir.MaxLength = 32767;
            this.folderInput_dir.Name = "folderInput_dir";
            this.folderInput_dir.ReadOnly = true;
            this.folderInput_dir.Size = new System.Drawing.Size(313, 24);
            this.folderInput_dir.TabIndex = 1;
            this.folderInput_dir.Text = "SELECT STORAGE DIRECTORY";
            this.folderInput_dir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip_msg.SetToolTip(this.folderInput_dir, "Carpeta donde serán almacenados los archivos PDF");
            this.folderInput_dir.UseSystemPasswordChar = false;
            // 
            // fileInpt_template
            // 
            this.fileInpt_template.Filter = "Archivos HTML (*.html)|*.*";
            this.fileInpt_template.FocusedColor = "#508ef5";
            this.fileInpt_template.FontColor = "#999999";
            this.fileInpt_template.IsEnabled = true;
            this.fileInpt_template.Location = new System.Drawing.Point(98, 138);
            this.fileInpt_template.MaxLength = 32767;
            this.fileInpt_template.Name = "fileInpt_template";
            this.fileInpt_template.ReadOnly = true;
            this.fileInpt_template.Size = new System.Drawing.Size(313, 24);
            this.fileInpt_template.TabIndex = 0;
            this.fileInpt_template.Text = "SELECT FILE";
            this.fileInpt_template.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip_msg.SetToolTip(this.fileInpt_template, "Seleccionar archivo de plantilla");
            this.fileInpt_template.UseSystemPasswordChar = false;
            // 
            // txtBx_nItems
            // 
            this.txtBx_nItems.Depth = 0;
            this.txtBx_nItems.Hint = "20";
            this.txtBx_nItems.Location = new System.Drawing.Point(638, 136);
            this.txtBx_nItems.MaxLength = 32767;
            this.txtBx_nItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_nItems.Name = "txtBx_nItems";
            this.txtBx_nItems.PasswordChar = '\0';
            this.txtBx_nItems.ReadOnly = false;
            this.txtBx_nItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBx_nItems.SelectedText = "";
            this.txtBx_nItems.SelectionLength = 0;
            this.txtBx_nItems.SelectionStart = 0;
            this.txtBx_nItems.Size = new System.Drawing.Size(58, 23);
            this.txtBx_nItems.TabIndex = 2;
            this.txtBx_nItems.TabStop = false;
            this.toolTip_msg.SetToolTip(this.txtBx_nItems, "Máximo 20");
            this.txtBx_nItems.UseSystemPasswordChar = false;
            // 
            // btn_exportConfig
            // 
            this.btn_exportConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_exportConfig.BackColor = System.Drawing.Color.Transparent;
            this.btn_exportConfig.Depth = 0;
            this.btn_exportConfig.Icon = global::UI.Properties.Resources.Export_32px;
            this.btn_exportConfig.Location = new System.Drawing.Point(286, 376);
            this.btn_exportConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exportConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_exportConfig.Name = "btn_exportConfig";
            this.btn_exportConfig.Primary = false;
            this.btn_exportConfig.Size = new System.Drawing.Size(125, 37);
            this.btn_exportConfig.TabIndex = 25;
            this.btn_exportConfig.Text = "Export";
            this.toolTip_msg.SetToolTip(this.btn_exportConfig, "Exportar configuración");
            this.btn_exportConfig.UseVisualStyleBackColor = false;
            // 
            // btn_importConfig
            // 
            this.btn_importConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_importConfig.BackColor = System.Drawing.Color.Transparent;
            this.btn_importConfig.Depth = 0;
            this.btn_importConfig.Icon = global::UI.Properties.Resources.Import_32px;
            this.btn_importConfig.Location = new System.Drawing.Point(61, 376);
            this.btn_importConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_importConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_importConfig.Name = "btn_importConfig";
            this.btn_importConfig.Primary = false;
            this.btn_importConfig.Size = new System.Drawing.Size(125, 37);
            this.btn_importConfig.TabIndex = 26;
            this.btn_importConfig.Text = "Import";
            this.toolTip_msg.SetToolTip(this.btn_importConfig, "Importar configuración");
            this.btn_importConfig.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialTabSelector_settings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 50);
            this.panel1.TabIndex = 0;
            // 
            // materialTabSelector_settings
            // 
            this.materialTabSelector_settings.BaseTabControl = this.materialTabControl_settings;
            this.materialTabSelector_settings.Depth = 0;
            this.materialTabSelector_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabSelector_settings.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector_settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector_settings.Name = "materialTabSelector_settings";
            this.materialTabSelector_settings.Size = new System.Drawing.Size(1050, 50);
            this.materialTabSelector_settings.TabIndex = 2;
            this.materialTabSelector_settings.Text = "Settings";
            // 
            // materialTabControl_settings
            // 
            this.materialTabControl_settings.Controls.Add(this.tabGeneral);
            this.materialTabControl_settings.Controls.Add(this.tabApi);
            this.materialTabControl_settings.Controls.Add(this.tabMail);
            this.materialTabControl_settings.Controls.Add(this.tabPage_updates);
            this.materialTabControl_settings.Depth = 0;
            this.materialTabControl_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl_settings.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl_settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl_settings.Name = "materialTabControl_settings";
            this.materialTabControl_settings.Padding = new System.Drawing.Point(0, 0);
            this.materialTabControl_settings.SelectedIndex = 0;
            this.materialTabControl_settings.Size = new System.Drawing.Size(1050, 481);
            this.materialTabControl_settings.TabIndex = 4;
            // 
            // tabGeneral
            // 
            this.tabGeneral.AutoScroll = true;
            this.tabGeneral.BackColor = System.Drawing.Color.White;
            this.tabGeneral.Controls.Add(this.materialLabel2);
            this.tabGeneral.Controls.Add(this.btn_exportConfig);
            this.tabGeneral.Controls.Add(this.btn_importConfig);
            this.tabGeneral.Controls.Add(this.lbl_minutes);
            this.tabGeneral.Controls.Add(this.btn_lessMinutes);
            this.tabGeneral.Controls.Add(this.btn_moreMinutes);
            this.tabGeneral.Controls.Add(this.prgrssBr_minutes);
            this.tabGeneral.Controls.Add(this.chckBx_proxy);
            this.tabGeneral.Controls.Add(this.materialLabel1);
            this.tabGeneral.Controls.Add(this.lollipopLabel2);
            this.tabGeneral.Controls.Add(this.lollipopLabel4);
            this.tabGeneral.Controls.Add(this.lollipopLabel3);
            this.tabGeneral.Controls.Add(this.lollipopLabel1);
            this.tabGeneral.Controls.Add(this.txtBx_nItems);
            this.tabGeneral.Controls.Add(this.folderInput_dir);
            this.tabGeneral.Controls.Add(this.pictureBox2);
            this.tabGeneral.Controls.Add(this.pictureBox1);
            this.tabGeneral.Controls.Add(this.pictureBox_folder);
            this.tabGeneral.Controls.Add(this.pictureBox_file);
            this.tabGeneral.Controls.Add(this.fileInpt_template);
            this.tabGeneral.Controls.Add(this.label_saveFile_desc);
            this.tabGeneral.Controls.Add(this.label_file_desc);
            this.tabGeneral.Controls.Add(this.chckBx_saveFile);
            this.tabGeneral.Controls.Add(this.materialLabel_template);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(1042, 455);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.ToolTipText = "Ajustes generales de la aplicación";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(57, 350);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(195, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "Import/Export configuration";
            // 
            // lbl_minutes
            // 
            this.lbl_minutes.AutoSize = true;
            this.lbl_minutes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbl_minutes.Location = new System.Drawing.Point(809, 376);
            this.lbl_minutes.Name = "lbl_minutes";
            this.lbl_minutes.Size = new System.Drawing.Size(16, 17);
            this.lbl_minutes.TabIndex = 24;
            this.lbl_minutes.Text = "0";
            // 
            // btn_lessMinutes
            // 
            this.btn_lessMinutes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_lessMinutes.Depth = 0;
            this.btn_lessMinutes.Icon = null;
            this.btn_lessMinutes.Location = new System.Drawing.Point(600, 371);
            this.btn_lessMinutes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_lessMinutes.Name = "btn_lessMinutes";
            this.btn_lessMinutes.Primary = true;
            this.btn_lessMinutes.Size = new System.Drawing.Size(37, 27);
            this.btn_lessMinutes.TabIndex = 4;
            this.btn_lessMinutes.Text = "-";
            this.btn_lessMinutes.UseVisualStyleBackColor = true;
            // 
            // btn_moreMinutes
            // 
            this.btn_moreMinutes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_moreMinutes.Depth = 0;
            this.btn_moreMinutes.Icon = null;
            this.btn_moreMinutes.Location = new System.Drawing.Point(912, 371);
            this.btn_moreMinutes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_moreMinutes.Name = "btn_moreMinutes";
            this.btn_moreMinutes.Primary = true;
            this.btn_moreMinutes.Size = new System.Drawing.Size(37, 27);
            this.btn_moreMinutes.TabIndex = 5;
            this.btn_moreMinutes.Text = "+";
            this.btn_moreMinutes.UseVisualStyleBackColor = true;
            // 
            // prgrssBr_minutes
            // 
            this.prgrssBr_minutes.Depth = 0;
            this.prgrssBr_minutes.Location = new System.Drawing.Point(600, 360);
            this.prgrssBr_minutes.MouseState = MaterialSkin.MouseState.HOVER;
            this.prgrssBr_minutes.Name = "prgrssBr_minutes";
            this.prgrssBr_minutes.Size = new System.Drawing.Size(349, 5);
            this.prgrssBr_minutes.Step = 5;
            this.prgrssBr_minutes.TabIndex = 22;
            // 
            // chckBx_proxy
            // 
            this.chckBx_proxy.AutoSize = true;
            this.chckBx_proxy.Depth = 0;
            this.chckBx_proxy.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckBx_proxy.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.chckBx_proxy.Location = new System.Drawing.Point(600, 217);
            this.chckBx_proxy.Margin = new System.Windows.Forms.Padding(0);
            this.chckBx_proxy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBx_proxy.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBx_proxy.Name = "chckBx_proxy";
            this.chckBx_proxy.Ripple = true;
            this.chckBx_proxy.Size = new System.Drawing.Size(92, 30);
            this.chckBx_proxy.TabIndex = 3;
            this.chckBx_proxy.Text = "Use Proxy";
            this.chckBx_proxy.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(578, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(127, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "API Configuration";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(600, 252);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(346, 30);
            this.lollipopLabel2.TabIndex = 15;
            this.lollipopLabel2.Text = "When using the proxy service, the data loading becomes faster\r\nbut it is not guan" +
    "rantee that the data is updated.";
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(839, 376);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(57, 17);
            this.lollipopLabel4.TabIndex = 15;
            this.lollipopLabel4.Text = "Minutes";
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(600, 317);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(213, 15);
            this.lollipopLabel3.TabIndex = 15;
            this.lollipopLabel3.Text = "Time to request and update local data";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(597, 94);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(219, 15);
            this.lollipopLabel1.TabIndex = 15;
            this.lollipopLabel1.Text = "Number of items to be shown per page";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.BulletedList_32px;
            this.pictureBox2.Location = new System.Drawing.Point(600, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.DownloadFromCloud_32px;
            this.pictureBox1.Location = new System.Drawing.Point(917, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_folder
            // 
            this.pictureBox_folder.Image = global::UI.Properties.Resources.Open_32px;
            this.pictureBox_folder.Location = new System.Drawing.Point(60, 279);
            this.pictureBox_folder.Name = "pictureBox_folder";
            this.pictureBox_folder.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_folder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_folder.TabIndex = 11;
            this.pictureBox_folder.TabStop = false;
            // 
            // pictureBox_file
            // 
            this.pictureBox_file.Image = global::UI.Properties.Resources.Document_32px;
            this.pictureBox_file.Location = new System.Drawing.Point(60, 130);
            this.pictureBox_file.Name = "pictureBox_file";
            this.pictureBox_file.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_file.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_file.TabIndex = 11;
            this.pictureBox_file.TabStop = false;
            // 
            // label_saveFile_desc
            // 
            this.label_saveFile_desc.AutoSize = true;
            this.label_saveFile_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saveFile_desc.ForeColor = System.Drawing.Color.DimGray;
            this.label_saveFile_desc.Location = new System.Drawing.Point(92, 247);
            this.label_saveFile_desc.Name = "label_saveFile_desc";
            this.label_saveFile_desc.Size = new System.Drawing.Size(207, 15);
            this.label_saveFile_desc.TabIndex = 7;
            this.label_saveFile_desc.Text = "Directory where the tickets are stored";
            // 
            // label_file_desc
            // 
            this.label_file_desc.AutoSize = true;
            this.label_file_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_file_desc.ForeColor = System.Drawing.Color.DimGray;
            this.label_file_desc.Location = new System.Drawing.Point(92, 94);
            this.label_file_desc.Name = "label_file_desc";
            this.label_file_desc.Size = new System.Drawing.Size(296, 15);
            this.label_file_desc.TabIndex = 6;
            this.label_file_desc.Text = "File which the respective design for generating tickets";
            // 
            // chckBx_saveFile
            // 
            this.chckBx_saveFile.AutoSize = true;
            this.chckBx_saveFile.Depth = 0;
            this.chckBx_saveFile.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckBx_saveFile.Location = new System.Drawing.Point(60, 217);
            this.chckBx_saveFile.Margin = new System.Windows.Forms.Padding(0);
            this.chckBx_saveFile.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBx_saveFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBx_saveFile.Name = "chckBx_saveFile";
            this.chckBx_saveFile.Ripple = true;
            this.chckBx_saveFile.Size = new System.Drawing.Size(105, 30);
            this.chckBx_saveFile.TabIndex = 3;
            this.chckBx_saveFile.Text = "Save tickets";
            this.chckBx_saveFile.UseVisualStyleBackColor = true;
            // 
            // materialLabel_template
            // 
            this.materialLabel_template.AutoSize = true;
            this.materialLabel_template.Depth = 0;
            this.materialLabel_template.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_template.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_template.Location = new System.Drawing.Point(57, 72);
            this.materialLabel_template.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_template.Name = "materialLabel_template";
            this.materialLabel_template.Size = new System.Drawing.Size(59, 19);
            this.materialLabel_template.TabIndex = 0;
            this.materialLabel_template.Text = "Tickets";
            // 
            // tabApi
            // 
            this.tabApi.BackColor = System.Drawing.Color.White;
            this.tabApi.Controls.Add(this.label1);
            this.tabApi.Controls.Add(this.txtBx_APIkey);
            this.tabApi.Controls.Add(this.txtBx_APIHost);
            this.tabApi.Controls.Add(this.txtBx_APIusr);
            this.tabApi.Controls.Add(this.label9);
            this.tabApi.Controls.Add(this.label_api_pwd_desc);
            this.tabApi.Controls.Add(this.label_api_usr_desc);
            this.tabApi.Location = new System.Drawing.Point(4, 22);
            this.tabApi.Name = "tabApi";
            this.tabApi.Padding = new System.Windows.Forms.Padding(3);
            this.tabApi.Size = new System.Drawing.Size(1042, 455);
            this.tabApi.TabIndex = 1;
            this.tabApi.Text = "API";
            this.tabApi.ToolTipText = "Ajustar la API";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtBx_APIkey
            // 
            this.txtBx_APIkey.Depth = 0;
            this.txtBx_APIkey.Hint = "Password";
            this.txtBx_APIkey.Location = new System.Drawing.Point(295, 299);
            this.txtBx_APIkey.MaxLength = 32767;
            this.txtBx_APIkey.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_APIkey.Name = "txtBx_APIkey";
            this.txtBx_APIkey.PasswordChar = '\0';
            this.txtBx_APIkey.ReadOnly = false;
            this.txtBx_APIkey.SelectedText = "";
            this.txtBx_APIkey.SelectionLength = 0;
            this.txtBx_APIkey.SelectionStart = 0;
            this.txtBx_APIkey.Size = new System.Drawing.Size(380, 23);
            this.txtBx_APIkey.TabIndex = 1;
            this.txtBx_APIkey.TabStop = false;
            this.txtBx_APIkey.UseSystemPasswordChar = true;
            // 
            // txtBx_APIHost
            // 
            this.txtBx_APIHost.Depth = 0;
            this.txtBx_APIHost.Hint = "URL (i.e: https://my-opencart-store.com/)";
            this.txtBx_APIHost.Location = new System.Drawing.Point(295, 135);
            this.txtBx_APIHost.MaxLength = 32767;
            this.txtBx_APIHost.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_APIHost.Name = "txtBx_APIHost";
            this.txtBx_APIHost.PasswordChar = '\0';
            this.txtBx_APIHost.ReadOnly = false;
            this.txtBx_APIHost.SelectedText = "";
            this.txtBx_APIHost.SelectionLength = 0;
            this.txtBx_APIHost.SelectionStart = 0;
            this.txtBx_APIHost.Size = new System.Drawing.Size(380, 23);
            this.txtBx_APIHost.TabIndex = 0;
            this.txtBx_APIHost.TabStop = false;
            this.txtBx_APIHost.UseSystemPasswordChar = false;
            // 
            // txtBx_APIusr
            // 
            this.txtBx_APIusr.Depth = 0;
            this.txtBx_APIusr.Hint = "User";
            this.txtBx_APIusr.Location = new System.Drawing.Point(295, 214);
            this.txtBx_APIusr.MaxLength = 32767;
            this.txtBx_APIusr.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_APIusr.Name = "txtBx_APIusr";
            this.txtBx_APIusr.PasswordChar = '\0';
            this.txtBx_APIusr.ReadOnly = false;
            this.txtBx_APIusr.SelectedText = "";
            this.txtBx_APIusr.SelectionLength = 0;
            this.txtBx_APIusr.SelectionStart = 0;
            this.txtBx_APIusr.Size = new System.Drawing.Size(380, 23);
            this.txtBx_APIusr.TabIndex = 0;
            this.txtBx_APIusr.TabStop = false;
            this.txtBx_APIusr.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(589, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Domain name";
            // 
            // label_api_pwd_desc
            // 
            this.label_api_pwd_desc.AutoSize = true;
            this.label_api_pwd_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_api_pwd_desc.ForeColor = System.Drawing.Color.DimGray;
            this.label_api_pwd_desc.Location = new System.Drawing.Point(593, 325);
            this.label_api_pwd_desc.Name = "label_api_pwd_desc";
            this.label_api_pwd_desc.Size = new System.Drawing.Size(82, 15);
            this.label_api_pwd_desc.TabIndex = 7;
            this.label_api_pwd_desc.Text = "API Password";
            // 
            // label_api_usr_desc
            // 
            this.label_api_usr_desc.AutoSize = true;
            this.label_api_usr_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_api_usr_desc.ForeColor = System.Drawing.Color.DimGray;
            this.label_api_usr_desc.Location = new System.Drawing.Point(621, 240);
            this.label_api_usr_desc.Name = "label_api_usr_desc";
            this.label_api_usr_desc.Size = new System.Drawing.Size(54, 15);
            this.label_api_usr_desc.TabIndex = 7;
            this.label_api_usr_desc.Text = "API User";
            // 
            // tabMail
            // 
            this.tabMail.BackColor = System.Drawing.Color.White;
            this.tabMail.Controls.Add(this.label2);
            this.tabMail.Controls.Add(this.txtBx_mailMsg);
            this.tabMail.Controls.Add(this.materialDivider_divider);
            this.tabMail.Controls.Add(this.txtBx_mailPort);
            this.tabMail.Controls.Add(this.txtBx_mailSubject);
            this.tabMail.Controls.Add(this.txtBx_mailHost);
            this.tabMail.Controls.Add(this.txtBx_mailPwd);
            this.tabMail.Controls.Add(this.txtBx_mailEmail);
            this.tabMail.Controls.Add(this.label3);
            this.tabMail.Controls.Add(this.label7);
            this.tabMail.Controls.Add(this.label6);
            this.tabMail.Controls.Add(this.label5);
            this.tabMail.Controls.Add(this.label4);
            this.tabMail.Location = new System.Drawing.Point(4, 22);
            this.tabMail.Name = "tabMail";
            this.tabMail.Size = new System.Drawing.Size(1042, 455);
            this.tabMail.TabIndex = 2;
            this.tabMail.Text = "Mailing";
            this.tabMail.ToolTipText = "Ajustes de correo electrónico";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 66);
            this.label2.TabIndex = 17;
            this.label2.Text = "The In-App Email service allows to send custom mails in determinated moments, suc" +
    "h as adding new ustomer or sending ticket purchase.";
            // 
            // txtBx_mailMsg
            // 
            this.txtBx_mailMsg.Location = new System.Drawing.Point(573, 104);
            this.txtBx_mailMsg.Multiline = true;
            this.txtBx_mailMsg.Name = "txtBx_mailMsg";
            this.txtBx_mailMsg.Size = new System.Drawing.Size(415, 311);
            this.txtBx_mailMsg.TabIndex = 5;
            // 
            // materialDivider_divider
            // 
            this.materialDivider_divider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider_divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider_divider.Depth = 0;
            this.materialDivider_divider.Location = new System.Drawing.Point(520, 0);
            this.materialDivider_divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider_divider.Name = "materialDivider_divider";
            this.materialDivider_divider.Size = new System.Drawing.Size(5, 460);
            this.materialDivider_divider.TabIndex = 15;
            // 
            // txtBx_mailPort
            // 
            this.txtBx_mailPort.Depth = 0;
            this.txtBx_mailPort.Hint = "Port";
            this.txtBx_mailPort.Location = new System.Drawing.Point(350, 132);
            this.txtBx_mailPort.MaxLength = 32767;
            this.txtBx_mailPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_mailPort.Name = "txtBx_mailPort";
            this.txtBx_mailPort.PasswordChar = '\0';
            this.txtBx_mailPort.ReadOnly = false;
            this.txtBx_mailPort.SelectedText = "";
            this.txtBx_mailPort.SelectionLength = 0;
            this.txtBx_mailPort.SelectionStart = 0;
            this.txtBx_mailPort.Size = new System.Drawing.Size(85, 23);
            this.txtBx_mailPort.TabIndex = 1;
            this.txtBx_mailPort.TabStop = false;
            this.txtBx_mailPort.UseSystemPasswordChar = false;
            // 
            // txtBx_mailSubject
            // 
            this.txtBx_mailSubject.Depth = 0;
            this.txtBx_mailSubject.Hint = "Subject";
            this.txtBx_mailSubject.Location = new System.Drawing.Point(573, 26);
            this.txtBx_mailSubject.MaxLength = 32767;
            this.txtBx_mailSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_mailSubject.Name = "txtBx_mailSubject";
            this.txtBx_mailSubject.PasswordChar = '\0';
            this.txtBx_mailSubject.ReadOnly = false;
            this.txtBx_mailSubject.SelectedText = "";
            this.txtBx_mailSubject.SelectionLength = 0;
            this.txtBx_mailSubject.SelectionStart = 0;
            this.txtBx_mailSubject.Size = new System.Drawing.Size(415, 23);
            this.txtBx_mailSubject.TabIndex = 4;
            this.txtBx_mailSubject.TabStop = false;
            this.txtBx_mailSubject.UseSystemPasswordChar = false;
            // 
            // txtBx_mailHost
            // 
            this.txtBx_mailHost.Depth = 0;
            this.txtBx_mailHost.Hint = "Host/Domain";
            this.txtBx_mailHost.Location = new System.Drawing.Point(55, 132);
            this.txtBx_mailHost.MaxLength = 32767;
            this.txtBx_mailHost.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_mailHost.Name = "txtBx_mailHost";
            this.txtBx_mailHost.PasswordChar = '\0';
            this.txtBx_mailHost.ReadOnly = false;
            this.txtBx_mailHost.SelectedText = "";
            this.txtBx_mailHost.SelectionLength = 0;
            this.txtBx_mailHost.SelectionStart = 0;
            this.txtBx_mailHost.Size = new System.Drawing.Size(276, 23);
            this.txtBx_mailHost.TabIndex = 0;
            this.txtBx_mailHost.TabStop = false;
            this.txtBx_mailHost.UseSystemPasswordChar = false;
            // 
            // txtBx_mailPwd
            // 
            this.txtBx_mailPwd.Depth = 0;
            this.txtBx_mailPwd.Hint = "Email password";
            this.txtBx_mailPwd.Location = new System.Drawing.Point(55, 327);
            this.txtBx_mailPwd.MaxLength = 32767;
            this.txtBx_mailPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_mailPwd.Name = "txtBx_mailPwd";
            this.txtBx_mailPwd.PasswordChar = '\0';
            this.txtBx_mailPwd.ReadOnly = false;
            this.txtBx_mailPwd.SelectedText = "";
            this.txtBx_mailPwd.SelectionLength = 0;
            this.txtBx_mailPwd.SelectionStart = 0;
            this.txtBx_mailPwd.Size = new System.Drawing.Size(380, 23);
            this.txtBx_mailPwd.TabIndex = 3;
            this.txtBx_mailPwd.TabStop = false;
            this.txtBx_mailPwd.UseSystemPasswordChar = true;
            // 
            // txtBx_mailEmail
            // 
            this.txtBx_mailEmail.Depth = 0;
            this.txtBx_mailEmail.Hint = "Sender email";
            this.txtBx_mailEmail.Location = new System.Drawing.Point(55, 265);
            this.txtBx_mailEmail.MaxLength = 32767;
            this.txtBx_mailEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBx_mailEmail.Name = "txtBx_mailEmail";
            this.txtBx_mailEmail.PasswordChar = '\0';
            this.txtBx_mailEmail.ReadOnly = false;
            this.txtBx_mailEmail.SelectedText = "";
            this.txtBx_mailEmail.SelectionLength = 0;
            this.txtBx_mailEmail.SelectionStart = 0;
            this.txtBx_mailEmail.Size = new System.Drawing.Size(380, 23);
            this.txtBx_mailEmail.TabIndex = 2;
            this.txtBx_mailEmail.TabStop = false;
            this.txtBx_mailEmail.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(340, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(573, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(888, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Message subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(202, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email server and its respective port SMTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(255, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email which is used for sending";
            // 
            // tabPage_updates
            // 
            this.tabPage_updates.BackColor = System.Drawing.Color.White;
            this.tabPage_updates.Controls.Add(this.btn_updates);
            this.tabPage_updates.Controls.Add(this.lbl_updateMsg);
            this.tabPage_updates.Controls.Add(this.label8);
            this.tabPage_updates.Controls.Add(this.pictureBox3);
            this.tabPage_updates.Location = new System.Drawing.Point(4, 22);
            this.tabPage_updates.Name = "tabPage_updates";
            this.tabPage_updates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_updates.Size = new System.Drawing.Size(1042, 455);
            this.tabPage_updates.TabIndex = 3;
            this.tabPage_updates.Text = "Update";
            // 
            // btn_updates
            // 
            this.btn_updates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_updates.Depth = 0;
            this.btn_updates.Icon = null;
            this.btn_updates.Location = new System.Drawing.Point(407, 187);
            this.btn_updates.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_updates.Name = "btn_updates";
            this.btn_updates.Primary = true;
            this.btn_updates.Size = new System.Drawing.Size(237, 44);
            this.btn_updates.TabIndex = 9;
            this.btn_updates.Text = "Search udpates";
            this.btn_updates.UseVisualStyleBackColor = true;
            // 
            // lbl_updateMsg
            // 
            this.lbl_updateMsg.AutoSize = true;
            this.lbl_updateMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updateMsg.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_updateMsg.Location = new System.Drawing.Point(14, 402);
            this.lbl_updateMsg.Name = "lbl_updateMsg";
            this.lbl_updateMsg.Size = new System.Drawing.Size(395, 15);
            this.lbl_updateMsg.TabIndex = 8;
            this.lbl_updateMsg.Text = "Pulse el botón para comprobar si existen actualizaciones del programa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(14, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(613, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Verifying new updates might take time and it\'s not recommended using the software" +
    " while the search is running.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI.Properties.Resources.AvailableUpdates_64px;
            this.pictureBox3.Location = new System.Drawing.Point(493, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_msg);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 45);
            this.panel2.TabIndex = 1;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Depth = 0;
            this.lbl_msg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_msg.Location = new System.Drawing.Point(18, 10);
            this.lbl_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 19);
            this.lbl_msg.TabIndex = 25;
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Depth = 0;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(950, 0);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = true;
            this.btn_save.Size = new System.Drawing.Size(100, 45);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.materialTabControl_settings);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 481);
            this.panel3.TabIndex = 2;
            // 
            // openFileDialog_import
            // 
            this.openFileDialog_import.FileName = "Archivo de configruación";
            this.openFileDialog_import.Filter = "Archivo INI (.ini)|*.ini";
            // 
            // saveFileDialog_export
            // 
            this.saveFileDialog_export.FileName = "Archivo de configuración";
            this.saveFileDialog_export.Filter = "Archivo INI (.ini)|*.ini";
            this.saveFileDialog_export.Title = "Exportar archivo de configuración";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(1050, 576);
            this.panel1.ResumeLayout(false);
            this.materialTabControl_settings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_folder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_file)).EndInit();
            this.tabApi.ResumeLayout(false);
            this.tabApi.PerformLayout();
            this.tabMail.ResumeLayout(false);
            this.tabMail.PerformLayout();
            this.tabPage_updates.ResumeLayout(false);
            this.tabPage_updates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip_msg;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector_settings;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl_settings;
        private System.Windows.Forms.TabPage tabGeneral;
        private MaterialSkin.Controls.MaterialLabel lbl_msg;
        private LollipopLabel lbl_minutes;
        private MaterialSkin.Controls.MaterialRaisedButton btn_lessMinutes;
        private MaterialSkin.Controls.MaterialRaisedButton btn_moreMinutes;
        private MaterialSkin.Controls.MaterialProgressBar prgrssBr_minutes;
        private MaterialSkin.Controls.MaterialCheckBox chckBx_proxy;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel4;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_nItems;
        private LollipopFolderInPut folderInput_dir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_folder;
        private System.Windows.Forms.PictureBox pictureBox_file;
        private LollipopFileInput fileInpt_template;
        private System.Windows.Forms.Label label_saveFile_desc;
        private System.Windows.Forms.Label label_file_desc;
        private MaterialSkin.Controls.MaterialCheckBox chckBx_saveFile;
        private MaterialSkin.Controls.MaterialLabel materialLabel_template;
        private System.Windows.Forms.TabPage tabApi;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_APIkey;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_APIusr;
        private System.Windows.Forms.Label label_api_pwd_desc;
        private System.Windows.Forms.Label label_api_usr_desc;
        private System.Windows.Forms.TabPage tabMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_mailMsg;
        private MaterialSkin.Controls.MaterialDivider materialDivider_divider;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_mailPort;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_mailSubject;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_mailHost;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_mailPwd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_mailEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton btn_save;
        private System.Windows.Forms.TabPage tabPage_updates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialRaisedButton btn_updates;
        private System.Windows.Forms.Label lbl_updateMsg;
        private System.Windows.Forms.OpenFileDialog openFileDialog_import;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_export;
        private MaterialSkin.Controls.MaterialFlatButton btn_exportConfig;
        private MaterialSkin.Controls.MaterialFlatButton btn_importConfig;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBx_APIHost;
        private System.Windows.Forms.Label label9;
    }
}
