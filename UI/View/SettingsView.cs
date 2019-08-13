using Bindery;
using System;
using System.Windows.Forms;
using UI.Models;
using UI.ViewModel;

namespace UI.View
{
    internal sealed partial class SettingsView : UserControl, IView
    {
        public event EventHandler LoadView;

        public SettingsView(ISettings settings)
        {
            InitializeComponent();
            BindViewModel(settings);
        }

        public void BindViewModel(ISettings settings)
        {
            var viewModel = new SettingsViewModel(settings);
            Create.Binder(viewModel)
                .Control(fileInpt_template).Property(fileInput => fileInput.Text).Bind(vm => vm.TemplateFile)
                .Control(chckBx_saveFile).Property(chckbx => chckbx.Checked).Bind(vm => vm.SaveFiles)
                .OnPropertyChanged(vm => vm.SaveFiles).Subscribe(b => folderInput_dir.Enabled = b)
                .Control(folderInput_dir).Property(fldrInpt => fldrInpt.Text).Bind(vm => vm.FolderToSave)
                .Control(txtBx_nItems).Property(txtBx => txtBx.Text).Bind(vm => vm.ItemsPerPage)
                .Control(chckBx_proxy).Property(chckBx => chckBx.Checked).Bind(vm => vm.UseProxy)
                .OnPropertyChanged(vm => vm.UseProxy).Subscribe(v => prgrssBr_minutes.Enabled = btn_moreMinutes.Enabled = btn_lessMinutes.Enabled = v)
                .Control(prgrssBr_minutes).Property(pgrsBr => pgrsBr.Value).Bind(vm => vm.ProxyTime)
                .Control(lbl_minutes).Property(lbl => lbl.Text).Bind(vm => vm.Minutes)
                .Control(txtBx_APIusr).Property(txtBx => txtBx.Text).Bind(vm => vm.APIusr)
                .Control(txtBx_APIkey).Property(txtBx => txtBx.Text).Bind(vm => vm.APIpwd)
                .Control(txtBx_APIHost).Property(txtBx => txtBx.Text).Bind(vm => vm.APIHost)
                .Control(txtBx_mailHost).Property(txtbx => txtbx.Text).Bind(vm => vm.Host)
                .Control(txtBx_mailPort).Property(txtbx => txtbx.Text).Bind(vm => vm.Port)
                .Control(txtBx_mailEmail).Property(txtbx => txtbx.Text).Bind(vm => vm.Email)
                .Control(txtBx_mailPwd).Property(txtBx => txtBx.Text).Bind(vm => vm.EmailPWD)
                .Control(txtBx_mailSubject).Property(txtBx => txtBx.Text).Bind(vm => vm.Subject)
                .Control(txtBx_mailMsg).Property(txtbx => txtbx.Text).Bind(vm => vm.BodyEmail)
                .Control(lbl_updateMsg).Property(lbl => lbl.Text).Bind(vm => vm.UpdateMessage)
                .OnPropertyChanged(vm => vm.Message).Subscribe(txt => Message(txt))
                .Control(lbl_msg).Property(lbl => lbl.Text).Get(vm => vm.Message)
                // Events
                .Control(this).OnEvent("Load").Execute(viewModel.Load)
                .Control(btn_importConfig).OnClick(viewModel.ImportConfigFile, openFileDialog_import.FileName)
                .Control(btn_exportConfig).OnClick(viewModel.ExportConfigFile, saveFileDialog_export.FileName)
                .Control(btn_lessMinutes).OnClick(viewModel.LessMinutes, prgrssBr_minutes.Step)
                .Control(btn_moreMinutes).OnClick(viewModel.AddMinutes, prgrssBr_minutes.Step)
                .Control(btn_updates).OnClick(viewModel.CheckUpdates)
                .Control(btn_save).OnClick(viewModel.Save);
        }

        public void Loading(bool isBusy) 
            => throw new NotImplementedException();

        public void Message(string text)
            => throw new NotImplementedException();

        public DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon) 
            => MessageBox.Show(ParentForm, text, caption, boxButtons, boxIcon);
    }
}
