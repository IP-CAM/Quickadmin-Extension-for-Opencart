using Entity;
using QuickAdmin.API;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UI.Validators;
using UI.View;
using UI.ViewModel.Product;

namespace UI.Presenter
{
    internal class ProductPresenter
    {
        private readonly IView view;
        private readonly IRestAPI api;
        private Product product;

        public GeneralTabViewModel GeneralTabVM { get; private set; }
        public DataTabViewModel DataTabVM { get; private set; }
        public LinksTabViewModel LinksTabVM { get; private set; }
        public DiscountTabViewModel DiscountTabVM { get; private set; }
        public SpecialTabViewModel SpecialTabVM { get; private set; }
        public ImagesTabViewModel ImagesTabVM { get; private set; }

        public ProductPresenter(IView view, Product product, IRestAPI api)
        {
            this.view = view;
            this.product = product;
            this.api = api;
            WireUpEvents();
        }

        private void WireUpEvents() => view.LoadView += View_LoadView;

        private async void View_LoadView(object sender, EventArgs e)
        {
            view.Loading(true);
            try
            {
                if (product.ID > 0)
                {
                    product = await Task.Run(() => api.GetProduct(product));
                }

                await Task.Run(async () =>
                {
                    GeneralTabVM = new GeneralTabViewModel(product as ProductData, api.GetLanguages());
                    DataTabVM = new DataTabViewModel(product as ProductData, api.GetLengthClasses(), api.GetWeightClasses(), api.GetStockStatuses(), api.GetTaxClasses());
                    LinksTabVM = new LinksTabViewModel(product as ProductData, api.GetStores(), api.GetManufacturers(), await Task.Run(() => api.GetProducts(null)), api.GetCategories());
                    var customer_groups = api.GetCustomerGroups();
                    DiscountTabVM = new DiscountTabViewModel(product as ProductData, customer_groups);
                    SpecialTabVM = new SpecialTabViewModel(product as ProductData, customer_groups);
                    ImagesTabVM = new ImagesTabViewModel(product as ProductData, api.GetServerData().URL_img);
                });
            }
            catch (InvalidOperationException ex)
            {
                view.Message(ex.Message);
            }
            finally
            {
                view.Loading(false);
            }
        }

        public async void Save()
        {
            view.Loading(true);
            if (IsValid())
            {
                string msg = await Task.Run(() => product.ID > 0 ? api.UpdateProduct(product) : api.AddProduct(product));
                view.Message(msg);
                // Extract Product's ID.
                if (product.ID == 0)
                {
                    string id = Regex.Match(msg, @"\d+").Value;
                    if (!string.IsNullOrWhiteSpace(id))
                    {
                        product.ID = int.Parse(id);
                    }
                }
            }
            view.Loading(false);
        }

        private bool IsValid()
        {
            var result = new ProductValidator().Validate(product as ProductData);
            if (!result.IsValid)
            {
                for (int i = 0; i < result.Errors.Count && i < 1; i++)
                {
                    view.Message(result.Errors[i].ErrorMessage);
                }
            }

            return result.IsValid;
        }
    }
}
