using Bindery;
using Entity;
using UI.Presenter;
using System;
using System.Windows.Forms;
using UI.Models;
using QuickAdmin.API;

namespace UI.View
{
    internal sealed partial class CustomerView : UserControl, IView
    {
        private readonly CustomerPresenter presenter;
        public event EventHandler LoadView;

        public CustomerView(IRestAPI api, ISettings settings, Customer customer)
        {
            InitializeComponent();
            presenter = new CustomerPresenter(this, api, settings, customer);
            InitializeAttributes();
        }

        private void InitializeAttributes()
        {
            Action<bool> callback = Dispose;
            // Data Binding
            Create.Binder(presenter.ViewModel)
                .Control(this).OnEvent("Load").Execute(presenter.ViewModel.Load)
                // Shared
                .Control(cmbBx_zones).Property(cmb => cmb.DataSource).Get(vm => vm.Zones)
                .Control(cmbBx_countries).Property(cmb => cmb.DataSource).Get(vm => vm.Countries)
                .Control(cmbBx_groupCustomers).Property(cmb => cmb.DataSource).Get(vm => vm.CustomerGroups)
                // Customer
                .Control(cmbBx_groupCustomers).Property(cmb => cmb.SelectedValue).Bind(vm => vm.CustomerGroupID)
                .Control(txtBx_cfirstname).Property(txtbx => txtbx.Text).Bind(vm => vm.CustomerFisrtname)
                .Control(txtBx_clastname).Property(txtbx => txtbx.Text).Bind(vm => vm.CustomerLastname)
                .Control(txtBx_email).Property(txtbx => txtbx.Text).Bind(vm => vm.Email)
                .Control(txtBx_telephone).Property(txtbx => txtbx.Text).Bind(vm => vm.Telephone)
                .Control(toggle_newsletter).Property(chkbx => chkbx.Checked).Bind(vm => vm.Newsletter)
                .Control(toggle_status).Property(chkbx => chkbx.Checked).Bind(vm => vm.Status)
                .Control(toggle_safe).Property(chkbx => chkbx.Checked).Bind(vm => vm.Safe)
                // Address
                .Control(txtBx_afirstname).Property(txtbx => txtbx.Text).Bind(vm => vm.AddressFirstname)
                .Control(txtBx_alastname).Property(txtbx => txtbx.Text).Bind(vm => vm.AddressLastname)
                .Control(txtBx_company).Property(txtbx => txtbx.Text).Bind(vm => vm.Company)
                .Control(txtBx_address1).Property(txtbx => txtbx.Text).Bind(vm => vm.Address_1)
                .Control(txtBx_address2).Property(txtbx => txtbx.Text).Bind(vm => vm.Address_2)
                .Control(txtBx_city).Property(txtbx => txtbx.Text).Bind(vm => vm.City)
                .Control(txtBx_postcode).Property(txtbx => txtbx.Text).Bind(vm => vm.Postcode)
                .Control(cmbBx_countries).Property(cmbx => cmbx.SelectedValue).Bind(vm => vm.CountryID)
                .Control(cmbBx_zones).Property(cmbx => cmbx.SelectedValue).Bind(vm => vm.ZoneID)
                // Events
                .Control(materialFlatButton_backTo).OnClick(presenter.ViewModel.Back, callback)
                .Control(materialFlatButton_save).OnClick(presenter.ViewModel.Save)
                .Control(materialFlatButton_email).OnClick(presenter.ViewModel.SendMail);
            cmbBx_zones.ValueMember = nameof(Zone.ID);
            cmbBx_zones.DisplayMember = nameof(Zone.Name);
            cmbBx_countries.ValueMember = nameof(Country.ID);
            cmbBx_countries.DisplayMember = nameof(Country.Name);
            cmbBx_groupCustomers.ValueMember = nameof(CustomerGroup.ID);
            cmbBx_groupCustomers.DisplayMember = nameof(CustomerGroup.Name);
        }

        public void Message(string text) 
            => materialLabel_msg.Text = text;

        public DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon)
            => MessageBox.Show(ParentForm, text, caption, boxButtons, boxIcon);

        public void Loading(bool isBusy)
        {
            pictureBox_loading.Enabled = isBusy;
            pictureBox_loading.Visible = isBusy;
        }
    }
}