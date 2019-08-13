using Bindery;
using Entity;
using QuickAdmin.API;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;
using UI.ViewModel;

namespace UI.View
{
    internal sealed partial class OrderReviewView : UserControl, IOrderReviewView
    {
        private readonly OrderReviewViewModel viewModel;
        public event EventHandler LoadView;

        public PrintDialog PrintDialog => printDialog_printer;

        public OrderReviewView(IRestAPI api, ISettings settings, Order order)
        {
            InitializeComponent();
            viewModel = new OrderReviewViewModel(this, api, settings, order);
        }

        public void Loading(bool isBusy) => pictureBox_loading.Enabled = pictureBox_loading.Visible = isBusy;

        public void Message(string text) => lbl_msg.Text = text;

        public DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon) => MessageBox.Show(ParentForm, text, caption, boxButtons, boxIcon);

        private async void OrderReviewView_Load(object sender, EventArgs e)
        {
            viewModel.Load.Execute(null);
            await Task.Run(() => { while (pictureBox_loading.Enabled) ; });
            Action<bool> callback = Dispose;
            Create.Binder(viewModel).Control(lbl_affiliate).Property(txt => txt.Text).Get(vm => vm.Affiliate)
                .Control(groupBox_info).Property(gbx => gbx.Text).Get(vm => vm.OrderNo)
                .Control(lbl_customer).Property(txt => txt.Text).Get(vm => vm.CustomerName)
                .Control(lbl_date).Property(txt => txt.Text).Get(vm => vm.Date)
                .Control(lbl_email).Property(txt => txt.Text).Get(vm => vm.CustomerEmail)
                .Control(lbl_group).Property(txt => txt.Text).Get(vm => vm.CustomerGroup)
                .Control(lbl_invoice).Property(txt => txt.Text).Get(vm => vm.Invoice)
                .Control(lbl_paymentInfo).Property(txt => txt.Text).Get(vm => vm.PaymentInfo)
                .Control(lbl_phone).Property(txt => txt.Text).Get(vm => vm.CustomerTelephone)
                .Control(lbl_reward).Property(txt => txt.Text).Get(vm => vm.Reward)
                .Control(lbl_shippingInfo).Property(txt => txt.Text).Get(vm => vm.ShippingInfo)
                .Control(lbl_store).Property(txt => txt.Text).Get(vm => vm.Store)
                .Control(lbl_payment).Property(txt => txt.Text).Get(vm => vm.PaymentMethod)
                .Control(lbl_shipping).Property(txt => txt.Text).Get(vm => vm.ShippingMethod)
                .Control(lbl_totals).Property(txt => txt.Text).Get(vm => vm.Totals)
                .Control(lstVw_products).Property(lst => lst.DataSource).Get(vm => vm.Products)
                .Control(chkbx_email).Property(chk => chk.Checked).Bind(vm => vm.SendMail)
                .Control(chkbx_ticket).Property(chk => chk.Checked).Bind(vm => vm.PrintTicket)
                .Control(btn_backTo).OnClick(viewModel.BackTo, callback)
                .Control(btn_save).OnClick(viewModel.Save);
        }
    }
}
