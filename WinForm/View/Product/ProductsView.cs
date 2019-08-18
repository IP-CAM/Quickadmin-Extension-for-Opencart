using Entity;
using QuickAdmin.API;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Controls;
using UI.Models;
using UI.Presenter;

namespace UI.View
{
    internal sealed partial class ProductsView : UserControl, IProductsView
    {
        private readonly ProductsPresenter presenter;

        public string SearchText
        {
            get => materialSingleLineTextField_search.Text;
            set => materialSingleLineTextField_search.Text = value;
        }

        public ProductsView(IRestAPI api, ISettings settings)
        {
            InitializeComponent();
            presenter = new ProductsPresenter(this, api, settings);
        }

        public event EventHandler LoadView;

        private void MaterialFlatButton_addProduct_Click(object sender, EventArgs e)
            => presenter.AddProduct();

        private void MaterialFlatButton_prev_Click(object sender, EventArgs e)
            => presenter.PrevPage();

        private void MaterialFlatButton_frwd_Click(object sender, EventArgs e)
            => presenter.NextPage();

        private void RefrescarDatosToolStripMenuItem_Click(object sender, EventArgs e)
            => LoadView?.Invoke(this, e);

        private void MaterialSingleLineTextField_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                presenter.Search();
            }
        }

        public void Loading(bool isBusy)
            => pictureBox_loading.Enabled = pictureBox_loading.Visible = isBusy;

        public void Message(string text)
            => materialLabel_msg.Text = text;

        public DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon)
            => MessageBox.Show(ParentForm, text, caption, boxButtons, boxIcon);

        public void ShowProducts(IList<Product> products, IRestAPI api)
        {
            if (flowLayoutPanel_container.Controls.Count > 0)
                materialFlatButton_frwd.Enabled = products.Count > flowLayoutPanel_container.Controls.Count;
            materialLabel_totalProducts.Text = products.Count.ToString();
            for (int i = 0; i < flowLayoutPanel_container.Controls.Count; i++)
                flowLayoutPanel_container.Controls[i].Dispose();

            flowLayoutPanel_container.Controls.Clear();

            MaterialCard[] cards = new MaterialCard[products.Count];
            for (int i = 0; i < products.Count; i++)
            {
                cards[i] = new MaterialCard(products[i], api)
                {
                    PrimaryText = "Editar",
                    SecondaryText = "Eliminar"
                };
            }

            flowLayoutPanel_container.Controls.AddRange(cards);
        }

        private void ProductsView_Load(object sender, EventArgs e) => LoadView?.Invoke(this, e);
    }
}
