using Entity;
using QuickAdmin.API;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Services;
using UI.View;

namespace UI.Controls
{
    // TODO: Separate Business Logic out from this control: MVP
    public partial class MaterialCard : UserControl
    {
        private readonly Product product;
        private readonly IRestAPI api;

        public MaterialCard(Product product, IRestAPI api)
        {
            InitializeComponent();
            this.product = product;
            this.api = api;
        }

        public Image Image
        {
            get => pictureBox_image.Image;
            set => pictureBox_image.Image = value;
        }

        public Image PrimaryIcon
        {
            get => materialRaisedButton_primary.Icon;
            set => materialRaisedButton_primary.Icon = value;
        }

        public Image SecondaryIcon
        {
            get => materialFlatButton_secondary.Icon;
            set => materialFlatButton_secondary.Icon = value;
        }

        public string PrimaryText
        {
            get => materialRaisedButton_primary.Text;
            set => materialRaisedButton_primary.Text = value;
        }

        public string SecondaryText
        {
            get => materialFlatButton_secondary.Text;
            set => materialFlatButton_secondary.Text = value;
        }

        public string Title
        {
            get => materialLabel_title.Text;
            set => materialLabel_title.Text = value;
        }

        public string Subtitle
        {
            get => lollipopLabel_subtitle.Text;
            set => lollipopLabel_subtitle.Text = value;
        }

        public string Info
        {
            get => lollipopLabel_info.Text;
            set => lollipopLabel_info.Text = value;
        }

        #region Related ViewModel Methods

        private void MaterialCard_Load(object sender, EventArgs e)
        {
            Title = product.Name;
            Subtitle = product.Model;
            Info = $"Cantidad: {product.Quantity}{Environment.NewLine}Precio: ${product.Price}{Environment.NewLine}{(product.Status ? "Habilitado" : "Deshabilitado")}";
            if (!string.IsNullOrWhiteSpace(product.Image))
                pictureBox_image.LoadAsync(product.Image);
            materialRaisedButton_primary.Click += MaterialRaisedButton_primary_Click;
            materialFlatButton_secondary.Click += MaterialFlatButton_secondary_Click;
        }

        private void MaterialRaisedButton_primary_Click(object sender, EventArgs e) 
            => Messenger.Instance.Send(new ProductView(product, api));

        private async void MaterialFlatButton_secondary_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(ParentForm, "¿Desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                await Task.Run(() => api.DeleteProduct(product));
                Dispose(true);
            }
        }
        #endregion
    }
}
