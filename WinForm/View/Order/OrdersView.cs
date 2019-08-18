using Entity;
using QuickAdmin.API;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Models;
using UI.Presenter;

namespace UI.View
{
    internal sealed partial class OrdersView : UserControl, IOrdersView
    {
        public IList<Order> Orders
        {
            get => materialListViewBindable_orders.DataSource as IList<Order>;
            set
            {
                materialLabel_total.Text = value.Count.ToString();
                if (!(materialListViewBindable_orders.DataSource == null))
                    materialFlatButton_frwd.Enabled = value.Count > (materialListViewBindable_orders.DataSource as IList<Order>).Count;
                materialListViewBindable_orders.DataSource = value;
            }
        }

        public string SearchText
        {
            get => materialSingleLineTextField_search.Text;
            set => materialSingleLineTextField_search.Text = value;
        }

        public event EventHandler LoadView;

        private OrdersPresenter presenter;

        public OrdersView(IRestAPI api, ISettings settings)
        {
            InitializeComponent();
            presenter = new OrdersPresenter(this, api, settings);
        }

        private void OrdersView_Load(object sender, EventArgs e) 
            => LoadView?.Invoke(this, e);

        private void MaterialFlatButton_addOrder_Click(object sender, EventArgs e) 
            => presenter.AddOrder();

        private void MaterialFlatButton_editOrder_Click(object sender, EventArgs e)
        {
            if (materialListViewBindable_orders.SelectedItems.Count == 1)
                presenter.UpdateOrder(Orders[materialListViewBindable_orders.SelectedIndices[0]]);
        }

        private void MaterialFlatButton_view_Click(object sender, EventArgs e)
        {
            if (materialListViewBindable_orders.SelectedItems.Count == 1)
                presenter.OverView(Orders[materialListViewBindable_orders.SelectedIndices[0]]);
        }

        private void MaterialFlatButton_deleteOrder_Click(object sender, EventArgs e)
        {
            if (materialListViewBindable_orders.SelectedItems.Count == 1)
                if (DialogResult.Yes == Message("Eliminar registro", "¿Desea eliminar el registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    presenter.DeleteOrder(Orders[materialListViewBindable_orders.SelectedIndices[0]]);
        }

        private void MaterialFlatButton_frwd_Click(object sender, EventArgs e)
            => presenter.NextPage();

        private void MaterialFlatButton_pre_Click(object sender, EventArgs e)
            => presenter.PrevPage();

        private void VerToolStripMenuItem_Click(object sender, EventArgs e)
            => MaterialFlatButton_view_Click(sender, e);

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
            => MaterialFlatButton_editOrder_Click(sender, e);

        private void RefrescarDatosToolStripMenuItem_Click(object sender, EventArgs e)
            => LoadView?.Invoke(this, e);

        private void BorrarToolStripMenuItem_Click(object sender, EventArgs e)
            => MaterialFlatButton_deleteOrder_Click(sender, e);

        public void Loading(bool isBusy)
            => pictureBox_loading.Enabled = pictureBox_loading.Visible = isBusy;

        public void Message(string text) 
            => materialLabel_msg.Text = text;

        public DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon)
            => MessageBox.Show(ParentForm, text, caption, boxButtons, boxIcon);

        private void MaterialSingleLineTextField_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                presenter.Search();
        }
    }
}
