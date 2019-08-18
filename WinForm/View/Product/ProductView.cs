using Bindery;
using Entity;
using MaterialSkin.Controls;
using QuickAdmin.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Presenter;

namespace UI.View
{
    public sealed partial class ProductView : UserControl, IView
    {
        public event EventHandler LoadView;
        private readonly ProductPresenter presenter;

        public ProductView(Product product, IRestAPI api)
        {
            InitializeComponent();
            presenter = new ProductPresenter(this, product, api);
        }

        private void MaterialFlatButton_backTo_Click(object sender, EventArgs e) => Dispose(true);

        private void MaterialFlatButton_save_Click(object sender, EventArgs e) => presenter.Save();

        private async void ProductView_Load(object sender, EventArgs e)
        {
            LoadView?.Invoke(sender, e);
            await Task.Run(() => { while (pictureBox_loading.Enabled) {; } });
            // General Tab
            BuildDescriptionTabs();
            // Data Tab
            Create.Binder(presenter.DataTabVM)
                .Control(cmbBx_taxclass).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Taxes)
                .Control(cmbBx_lengthClass).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Lengths)
                .Control(cmbBx_weightClass).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Weights)
                .Control(cmbBx_stockStatus).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.StockStatuses)
                .Control(txtBx_mpn).Property(txtbx => txtbx.Text).Bind(vm => vm.MPN)
                .Control(txtBx_sku).Property(txtbx => txtbx.Text).Bind(vm => vm.SKU)
                .Control(txtBx_upc).Property(txtbx => txtbx.Text).Bind(vm => vm.UPC)
                .Control(txtBx_ean).Property(txtbx => txtbx.Text).Bind(vm => vm.EAN)
                .Control(txtBx_jan).Property(txtbx => txtbx.Text).Bind(vm => vm.JAN)
                .Control(txtBx_isbn).Property(txtbx => txtbx.Text).Bind(vm => vm.ISBN)
                .Control(txtBx_model).Property(txtbx => txtbx.Text).Bind(vm => vm.Model)
                .Control(txtBx_location).Property(txtbx => txtbx.Text).Bind(vm => vm.Location)
                .Control(txtBx_price).Property(txtbx => txtbx.Text).Bind(vm => vm.Price)
                .Control(chkBx_status).Property(chkbx => chkbx.Checked).Bind(vm => vm.Status)
                .Control(cmbBx_taxclass).Property(cmbBx => cmbBx.SelectedValue).Bind(vm => vm.TaxClass)
                .Control(materialTextField_quantity).Property(txtbx => txtbx.Text).Bind(vm => vm.Quantity)
                .Control(materialTextField_minQuantity).Property(txtbx => txtbx.Text).Bind(vm => vm.MinimumQuantity)
                .Control(chkBx_subtractStock).Property(chkbx => chkbx.Checked).Bind(vm => vm.SubtractStock)
                .Control(cmbBx_stockStatus).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.StockStatus)
                .Control(txtBx_weight).Property(txtbx => txtbx.Text).Bind(vm => vm.Weight)
                .Control(cmbBx_weightClass).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.WeightClass)
                .Control(materialTextField_Length).Property(txtbx => txtbx.Text).Bind(vm => vm.Length)
                .Control(materialTextField_width).Property(txtbx => txtbx.Text).Bind(vm => vm.Width)
                .Control(cmbBx_lengthClass).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.LengthClass)
                .Control(materialCheckBox_shippingRequired).Property(chkBx => chkBx.Checked).Bind(vm => vm.RequireShipping)
                .Control(dateTimePicker_dateAvailable).Property(dtpkr => dtpkr.Value).Bind(vm => vm.ReleaseDate);
            // Links Tab
            Create.Binder(presenter.LinksTabVM)
                .Control(cmbBx_manufacturer).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.Manufacturers)
                .Control(cmbBx_manufacturer).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.Manufacturer);
            ShowLabelsLinkTab();
            // Discount tab
            Create.Binder(presenter.DiscountTabVM)
                .Control(cmbBx_DisGroupCustomer).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.CustomerGroups)
                .Control(cmbBx_DisGroupCustomer).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.Discount.CustomerGroupID)
                .Control(txtBx_discountQuantity).Property(txtbx => txtbx.Text).Bind(vm => vm.Discount.Quantity)
                .Control(txtBx_discountPriority).Property(txtbx => txtbx.Text).Bind(vm => vm.Discount.Priority)
                .Control(txtBx_discountPrice).Property(txtbx => txtbx.Text).Bind(vm => vm.Discount.Price)
                .Control(dateTimePicker_discountDateEnd).Property(date => date.Value).Bind(vm => vm.Discount.DateStart)
                .Control(dateTimePicker_discountDateStart).Property(date => date.Value).Bind(vm => vm.Discount.DateEnd)
                .Control(btn_addDiscount).OnClick(presenter.DiscountTabVM.AddDiscount)
                .Control(lstView_discounts).Property(lv => lv.DataSource).Get(vm => vm.Discounts);
            tsmi_rmDiscount.Click += Tsmi_removeDiscount_Click;
            // Special tab
            Create.Binder(presenter.SpecialTabVM)
                .Control(cmbBx_SpecGroupCustomer).Property(cmbbx => cmbbx.DataSource).Get(vm => vm.CustomerGroups)
                .Control(cmbBx_SpecGroupCustomer).Property(cmbbx => cmbbx.SelectedValue).Bind(vm => vm.SpecialOffer.CustomerGroupID)
                .Control(txtBx_specialPrice).Property(txtbx => txtbx.Text).Bind(vm => vm.SpecialOffer.Price)
                .Control(txtBx_specialPriority).Property(txtbx => txtbx.Text).Bind(vm => vm.SpecialOffer.Priority)
                .Control(dateTimePicker_SpecDateStart).Property(date => date.Value).Bind(vm => vm.SpecialOffer.DateStart)
                .Control(dateTimePicker_SpecDateEnd).Property(date => date.Value).Bind(vm => vm.SpecialOffer.DateEnd)
                .Control(btn_addSpecials).OnClick(presenter.SpecialTabVM.AddSpecialOffer)
                .Control(lstView_specials).Property(lv => lv.DataSource).Get(vm => vm.SpecialOffers);
            tsmi_rmSpecial.Click += Tsmi_rmSpecial_Click;
            // Images Tab
            ImagesTabVM_ShowImages();
            presenter.ImagesTabVM.ImageAdded += ImagesTabVM_ImageAdded;
            Create.Binder(presenter.ImagesTabVM)
                .Control(picBx_image).Property(picBx => picBx.ImageLocation).Bind(vm => vm.ImagePortrait)
                .Control(picBx_image).OnClick(presenter.ImagesTabVM.ChangeImg, openFileDialog_Images)
                .Control(btn_addImages).OnClick(presenter.ImagesTabVM.AddImg, openFileDialog_Images)
                .Control(btn_delImg).OnClick(presenter.ImagesTabVM.RmImg)
                .Target(toolStripMenuItem_suprImage).OnEvent("Click").Execute(presenter.ImagesTabVM.RmAdditionalImg, () =>
                {
                    var menu = toolStripMenuItem_suprImage.Owner as MaterialContextMenuStrip;
                    PictureBox pic = menu.SourceControl as PictureBox;
                    object img = pic.Tag;
                    flowLayoutPanel_aditionalImages.Controls.Remove(pic);
                    pic.Dispose();
                    return img;
                });
            cmbBx_taxclass.ValueMember = nameof(Tax.ID);
            cmbBx_taxclass.DisplayMember = nameof(Tax.Title);
            cmbBx_weightClass.ValueMember = nameof(Weight.ID);
            cmbBx_weightClass.DisplayMember = nameof(Weight.Title);
            cmbBx_lengthClass.ValueMember = nameof(Length.ID);
            cmbBx_lengthClass.DisplayMember = nameof(Length.Title);
            cmbBx_stockStatus.ValueMember = nameof(StockStatus.ID);
            cmbBx_stockStatus.DisplayMember = nameof(StockStatus.Name);
            cmbBx_manufacturer.ValueMember = nameof(Manufacturer.ID);
            cmbBx_manufacturer.DisplayMember = nameof(Manufacturer.Name);
            cmbBx_SpecGroupCustomer.ValueMember = nameof(CustomerGroup.ID);
            cmbBx_SpecGroupCustomer.DisplayMember = nameof(CustomerGroup.Name);
            cmbBx_DisGroupCustomer.ValueMember = nameof(CustomerGroup.ID);
            cmbBx_DisGroupCustomer.DisplayMember = nameof(CustomerGroup.Name);
        }

        private void BuildDescriptionTabs()
        {
            foreach (Language language in presenter.GeneralTabVM.Languages)
            {
                tabControl_langs.TabPages.Add(language.ID.ToString(), language.Name);
                tabControl_langs.TabPages[language.ID.ToString()].Controls.Add(new ProductGeneralView(presenter.GeneralTabVM.DescriptionVMs[language.ID]));
            }
        }

        private void ImagesTabVM_ImageAdded(object sender, ProductImage[] imgs)
        {
            PictureBox[] pics = new PictureBox[imgs.Length];
            for (int i = 0; i < imgs.Length; i++)
            {
                ProductImage img = imgs[i];
                pics[i] = new PictureBox()
                {
                    ImageLocation = img.Image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 120,
                    Height = 100,
                    ContextMenuStrip = cntxtMenuStrip_optionsImages,
                    Tag = img
                };
            }
            flowLayoutPanel_aditionalImages.Controls.AddRange(pics);
        }

        private void ImagesTabVM_ShowImages()
        {
            PictureBox[] pics = new PictureBox[presenter.ImagesTabVM.Images.Count];
            for (int i = 0; i < presenter.ImagesTabVM.Images.Count; i++)
            {
                ProductImage img = presenter.ImagesTabVM.Images[i];
                pics[i] = new PictureBox()
                {
                    ImageLocation = $"{presenter.ImagesTabVM.URLImg}{img.Image}",
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 120,
                    Height = 100,
                    ContextMenuStrip = cntxtMenuStrip_optionsImages,
                    Tag = img
                };
            }
            flowLayoutPanel_aditionalImages.Controls.AddRange(pics);
        }

        private async void ShowLabelsLinkTab()
        {
            flwLytPnl_stores.Controls.AddRange(await StoresChckBxs());
            flowLayoutPanel_categories.Controls.AddRange(await CategoriesChkBxs());
            flowLayoutPanel_relatedProducts.Controls.AddRange(await RelatedProductsChckBxs());
        }

        private Task<CheckBox[]> CategoriesChkBxs()
        {
            return Task.Run(() =>
            {
                IList<CheckBox> chkbxs = new List<CheckBox>();
                foreach (Category category in presenter.LinksTabVM.Categories)
                {
                    var chkbx = new CheckBox()
                    {
                        Tag = category.ID,
                        Text = category.Name,
                        Checked = presenter.LinksTabVM.RelatedCategories.Contains(category.ID),
                        AutoSize = true
                    };
                    chkbx.CheckedChanged += Category_CheckedChanged;
                    chkbxs.Add(chkbx);
                }
                return chkbxs.ToArray();
            });
        }

        private Task<CheckBox[]> StoresChckBxs()
        {
            return Task.Run(() =>
            {
                IList<CheckBox> lbls_checkboxes = new List<CheckBox>();
                foreach (Store store in presenter.LinksTabVM.Stores)
                {
                    var chkbx = new CheckBox()
                    {
                        Tag = store.ID,
                        Text = store.Name,
                        Checked = presenter.LinksTabVM.RelatedStores.Contains(store.ID),
                        AutoSize = true
                    };
                    chkbx.CheckedChanged += Store_CheckedChanged;
                    lbls_checkboxes.Add(chkbx);
                }
                return lbls_checkboxes.ToArray();
            });
        }

        private Task<CheckBox[]> RelatedProductsChckBxs()
        {
            return Task.Run(() =>
            {
                IList<CheckBox> lbls_checkboxes = new List<CheckBox>();
                foreach (Product product in presenter.LinksTabVM.Products)
                {
                    var chkbox = new CheckBox()
                    {
                        Tag = product.ID,
                        Text = $"{product.Model} {product.Name}",
                        Checked = presenter.LinksTabVM.RelatedProducts.Contains(product.ID),
                        AutoSize = true
                    };
                    chkbox.CheckedChanged += RelatedProduct_CheckedChanged;
                    lbls_checkboxes.Add(chkbox);
                }
                return lbls_checkboxes.ToArray();
            });
        }

        private void Tsmi_rmSpecial_Click(object sender, EventArgs e)
        {
            if (lstView_specials.SelectedIndices.Count > 0)
            {
                int index = lstView_specials.SelectedIndices[0];
                presenter.SpecialTabVM.DeleteSpecialOffer.Execute(index);
            }
        }

        private void Tsmi_removeDiscount_Click(object sender, EventArgs e)
        {
            if (lstView_discounts.SelectedIndices.Count > 0)
            {
                int i = lstView_discounts.SelectedIndices[0];
                presenter.DiscountTabVM.DeleteDiscount.Execute(i);
            }
        }

        private void RelatedProduct_CheckedChanged(object sender, EventArgs e)
        {
            int product_id = (int)(sender as CheckBox).Tag;
            if (presenter.LinksTabVM.RelatedProducts.Contains(product_id))
            {
                presenter.LinksTabVM.RelatedProducts.Remove(product_id);
            }
            else
            {
                presenter.LinksTabVM.RelatedProducts.Add(product_id);
            }
        }

        private void Category_CheckedChanged(object sender, EventArgs e)
        {
            int category_id = (int)(sender as CheckBox).Tag;
            if (presenter.LinksTabVM.RelatedCategories.Contains(category_id))
            {
                presenter.LinksTabVM.RelatedCategories.Remove(category_id);
            }
            else
            {
                presenter.LinksTabVM.RelatedCategories.Add(category_id);
            }
        }

        private void Store_CheckedChanged(object sender, EventArgs e)
        {
            int store_id = (int)(sender as CheckBox).Tag;
            if (presenter.LinksTabVM.RelatedStores.Contains(store_id))
            {
                presenter.LinksTabVM.RelatedStores.Remove(store_id);
            }
            else
            {
                presenter.LinksTabVM.RelatedStores.Add(store_id);
            }
        }

        public void Loading(bool isBusy) => pictureBox_loading.Enabled = pictureBox_loading.Visible = isBusy;

        public void Message(string text) => lbl_msg.Text = text;

        public DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon) => MessageBox.Show(ParentForm, text, caption, boxButtons, boxIcon);
    }
}