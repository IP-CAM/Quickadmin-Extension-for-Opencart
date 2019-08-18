using Bindery;
using Entity;
using MaterialSkin.Controls;
using QuickAdmin.API;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;
using UI.Presenter;

namespace UI.View
{
    internal sealed partial class OrderView : UserControl, IOrderView
    {
        private readonly OrderPresenter presenter;

        public PrintDialog PrintDialog => printDialog_printer;

        public OrderView(IRestAPI api, ISettings settings, Order order)
        {
            InitializeComponent();
            presenter = new OrderPresenter(this, api, settings, order);
        }

        public event EventHandler LoadView;

        private async void OrderView_Load(object sender, EventArgs e)
        {
            LoadView?.Invoke(sender, e);
            await Task.Run(() => { while (pictureBox_loading.Enabled) {; } });
            Create.Binder(presenter.OrderVM)
                .Control(chkbx_sendMail).Property(chk => chk.Checked).Bind(vm => vm.SendEmail);
            // Customer Tab
            Create.Binder(presenter.CustomerTabVM)
                .Control(txtBx_customers).Property(txtbx => txtbx.AutoCompleteCustomSource).Get(vm => vm.Customers)
                .Control(cmbBx_stores).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Stores)
                .Control(cmbBx_stores).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.Store)
                .Control(cmbBx_currencies).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Currencies)
                .Control(cmbBx_currencies).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.Currency)
                .Control(cmbBx_customerGroups).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.CustomerGroups)
                .Control(cmbBx_customerGroups).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.CustomerGroupID)
                .Control(txtBx_cFirstname).Property(txtbx => txtbx.Text).Bind(vm => vm.Firstname)
                .Control(txtBx_cLastname).Property(txtbx => txtbx.Text).Bind(vm => vm.Lastname)
                .Control(txtBx_cEmail).Property(txtbx => txtbx.Text).Bind(vm => vm.Email)
                .Control(txtBx_cPhone).Property(txtbx => txtbx.Text).Bind(vm => vm.Telephone)
                .Control(btn_addCustomer).OnClick(presenter.CustomerTabVM.AddCustomer);
            cmbBx_stores.DisplayMember = nameof(Store.Name);
            cmbBx_currencies.DisplayMember = nameof(Currency.Title);
            cmbBx_customerGroups.ValueMember = nameof(CustomerGroup.ID);
            cmbBx_customerGroups.DisplayMember = nameof(CustomerGroup.Name);
            // Products Tab
            Create.Binder(presenter.ProductsTabVM)
                .Control(cmbBx_products).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Products)
                .Control(txtBx_quantity).Property(txtbx => txtbx.Text).Bind(vm => vm.Quantity)
                .Control(lstVw_products).Property(lstvw => lstvw.DataSource).Get(vm => vm.OrderProducts)
                .Control(btn_addProduct).OnClick(presenter.ProductsTabVM.AddProduct, () => cmbBx_products.SelectedValue)
                .Target(tsmi_delete).OnEvent("Click").Execute(presenter.ProductsTabVM.RmProduct, () =>
                {
                    var menu = tsmi_delete.Owner as MaterialContextMenuStrip;
                    MaterialListView listView = menu.SourceControl as MaterialListView;
                    if (listView.SelectedIndices.Count > 0)
                    {
                        return listView.SelectedItems[0].Tag;
                    }

                    return null;
                });
            // Payment Address Tab
            Create.Binder(presenter.PaymentTabVM)
                .Control(cmbBx_paymentMethods).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.PaymentMethods)
                .Control(cmbBx_paymentMethods).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.PaymentMethod)
                .Control(cmbBx_paAddresses).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Addresses)
                .Control(cmbBx_paAddresses).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.Address)
                .Control(cmbBx_paCountries).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Countries)
                .Control(cmbBx_paCountries).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.CountryID)
                .Control(cmbBx_paZones).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Zones)
                .Control(cmbBx_paZones).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.ZoneID)
                .Control(txtBx_paFirstname).Property(txtbx => txtbx.Text).Bind(vm => vm.Firstname)
                .Control(txtBx_paLastname).Property(txtbx => txtbx.Text).Bind(vm => vm.Lastname)
                .Control(txtBx_paCompany).Property(txtbx => txtbx.Text).Bind(vm => vm.Company)
                .Control(txtBx_paAddress1).Property(txtbx => txtbx.Text).Bind(vm => vm.Address1)
                .Control(txtBx_paAddress2).Property(txtbx => txtbx.Text).Bind(vm => vm.Address2)
                .Control(txtBx_paCity).Property(txtbx => txtbx.Text).Bind(vm => vm.City)
                .Control(txtBx_paPostcode).Property(txtbx => txtbx.Text).Bind(vm => vm.Postcode);
            cmbBx_paCountries.ValueMember = nameof(Country.ID);
            cmbBx_paCountries.DisplayMember = nameof(Country.Name);
            cmbBx_paZones.ValueMember = nameof(Zone.ID);
            cmbBx_paZones.DisplayMember = nameof(Zone.Name);
            // Shipping Address Tab
            Create.Binder(presenter.ShippingTabVM)
                .Control(cmbBx_shippingMethods).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.ShippingMethods)
                .Control(cmbBx_shippingMethods).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.ShippingMethod)
                .Control(cmbBx_saAddresses).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Addresses)
                .Control(cmbBx_saAddresses).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.Address)
                .Control(cmbBx_saCountries).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Countries)
                .Control(cmbBx_saCountries).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.CountryID)
                .Control(cmbBx_saZones).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Zones)
                .Control(cmbBx_saZones).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.ZoneID)
                .Control(txtBx_saFirstname).Property(txtbx => txtbx.Text).Bind(vm => vm.Firstname)
                .Control(txtBx_saLastname).Property(txtbx => txtbx.Text).Bind(vm => vm.Lastname)
                .Control(txtBx_saCompany).Property(txtbx => txtbx.Text).Bind(vm => vm.Company)
                .Control(txtBx_saAddress1).Property(txtbx => txtbx.Text).Bind(vm => vm.Address1)
                .Control(txtBx_saAddress2).Property(txtbx => txtbx.Text).Bind(vm => vm.Address2)
                .Control(txtBx_saCity).Property(txtbx => txtbx.Text).Bind(vm => vm.City)
                .Control(txtBx_saPostcode).Property(txtbx => txtbx.Text).Bind(vm => vm.Postcode);
            cmbBx_saCountries.ValueMember = nameof(Country.ID);
            cmbBx_saCountries.DisplayMember = nameof(Country.Name);
            cmbBx_saZones.ValueMember = nameof(Zone.ID);
            cmbBx_saZones.DisplayMember = nameof(Zone.Name);
            // Total Tab
            Create.Binder(presenter.TotalTabVM)
                .Control(cmbBx_orderStatus).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.OrderStatuses)
                .Control(cmbBx_orderStatus).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.Status)
                .Control(lstVw_totalProducts).Property(lst => lst.DataSource).Get(vm => vm.Products)
                .Control(lbl_totals).Property(lbl => lbl.Text).Get(vm => vm.Totals);
            cmbBx_orderStatus.ValueMember = nameof(OrderStatus.ID);
            cmbBx_orderStatus.DisplayMember = nameof(OrderStatus.Name);
        }

        public void Loading(bool isBusy) => pictureBox_loading.Enabled = pictureBox_loading.Visible = isBusy;

        public void Message(string text) => materialLabel_msg.Text = text;

        public DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon) => MessageBox.Show(ParentForm, text, caption, boxButtons, boxIcon);

        private void MaterialFlatButton_save_Click(object sender, EventArgs e) => presenter.Save();

        private void MaterialFlatButton_backTo_Click(object sender, EventArgs e) => presenter.BackTo(Dispose);

        private void TxtBx_customers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            TextBox s = sender as TextBox;
            presenter.CustomerTabVM.SelectedCustomer.Execute(s.Text);
            s.Text = string.Empty;
        }

        private void ComboBox_products_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth
                : 0;

            int newWidth;
            foreach (Product p in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(p.Name, font).Width + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }
    }
}