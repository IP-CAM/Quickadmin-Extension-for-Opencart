using Bindery;
using System;
using System.Windows.Forms;
using UI.ViewModel.Product;

namespace UI.View
{
    internal partial class ProductGeneralView : UserControl, IView
    {
        public event EventHandler LoadView;
        private readonly DescriptionViewModel vm;

        public ProductGeneralView(DescriptionViewModel descriptionViewModel)
        {
            InitializeComponent();
            this.vm = descriptionViewModel;
        }

        private void HTMLwysiwyg_description_BodyChanged(object sender, EventArgs e) 
            => vm.Description = HTMLwysiwyg_description.getHTML()?.TrimEnd();

        public void Loading(bool isBusy) => throw new NotImplementedException();

        public void Message(string text) => throw new NotImplementedException();

        public DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon) => MessageBox.Show(ParentForm, text, caption, boxButtons, boxIcon);

        private void ProductGeneralView_Load(object sender, EventArgs e)
        {
            LoadView?.Invoke(sender, e);
            Create.Binder(this.vm)
                .Control(txtBx_productName).Property(txtBx => txtBx.Text).Bind(vm => vm.ProductName)
                .Control(txtBx_metatagTitle).Property(txtBx => txtBx.Text).Bind(vm => vm.MetatagTitle)
                .Control(txtBx_metaTagDesc).Property(txtBx => txtBx.Text).Bind(vm => vm.MetatagDescription)
                .Control(txtBx_metaTagKeyWords).Property(txtBx => txtBx.Text).Bind(vm => vm.MetatagKeywords)
                .Control(txtBx_Tags).Property(txtBx => txtBx.Text).Bind(vm => vm.Tags);
            HTMLwysiwyg_description.setHTML(vm.Description);
            HTMLwysiwyg_description.BodyChanged += HTMLwysiwyg_description_BodyChanged;
        }
    }
}
