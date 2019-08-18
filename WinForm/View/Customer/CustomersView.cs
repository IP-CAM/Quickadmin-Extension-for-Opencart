using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entity;
using QuickAdmin.API;
using UI.Models;
using UI.Presenter;

namespace UI.View
{
    internal sealed partial class CustomersView : UserControl, ICustomersView
    {
        private CustomersPresenter presenter;
        public event EventHandler LoadView;

        public string SearchText
        {
            get => materialSingleLineTextField_search.Text;
            set => materialSingleLineTextField_search.Text = value;
        }

        public IList<Customer> Customers
        {
            get => materialListViewBindable_customers.DataSource as IList<Customer>;
            set
            {
                materialLabel_total.Text = value.Count.ToString();
                if (!(materialListViewBindable_customers.DataSource == null))
                    materialFlatButton_frwd.Enabled = value.Count >= (materialListViewBindable_customers.DataSource as IList<Customer>).Count;
                materialListViewBindable_customers.DataSource = value;
            }
        }

        public CustomersView(IRestAPI api, ISettings settings)
        {
            InitializeComponent();
            presenter = new CustomersPresenter(this, api, settings);
        }

        private void CustomersView_Load(object sender, EventArgs e) => LoadView?.Invoke(this, e);

        #region Methods
        private void EditarToolStripMenuItem_Click(object sender, EventArgs e) => MaterialFlatButton_editCustomer_Click(sender, e);

        private void BorrarToolStripMenuItem_Click(object sender, EventArgs e) => MaterialFlatButton_deleteCustomer_Click(sender, e);

        private void RefrescarDatosToolStripMenuItem_Click(object sender, EventArgs e) => LoadView?.Invoke(this, e);

        private void MaterialFlatButton_addCustomer_Click(object sender, EventArgs e) => presenter.AddCustomer();

        private void MaterialFlatButton_editCustomer_Click(object sender, EventArgs e)
        {
            if (materialListViewBindable_customers.SelectedItems.Count == 1)
                presenter.EditCustomer(Customers[materialListViewBindable_customers.SelectedIndices[0]]);
        }

        private void MaterialFlatButton_deleteCustomer_Click(object sender, EventArgs e)
        {
            if (materialListViewBindable_customers.SelectedItems.Count == 1)
                if (DialogResult.Yes == Message("Eliminar registro", "¿Desea eliminar el registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    presenter.DeleteCustomer(Customers[materialListViewBindable_customers.SelectedIndices[0]]);
        }

        private void MaterialFlatButton_prev_Click(object sender, EventArgs e) => presenter.PrevPage();

        private void MaterialFlatButton_frwd_Click(object sender, EventArgs e) => presenter.NextPage();

        private void MaterialSingleLineTextField_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                presenter.Search();
        }

        public void Loading(bool isBusy)
        {
            pictureBox_loading.Enabled = isBusy;
            pictureBox_loading.Visible = isBusy;
        }

        public void Message(string text) => materialLabel_msg.Text = text;

        public DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon) 
            => MessageBox.Show(ParentForm, text, caption, boxButtons, boxIcon);
        #endregion
    }
}
