using Entity;
using QuickAdmin.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using UI.Models;
using UI.Properties;
using UI.Services;
using UI.View;

namespace UI.Presenter
{
    internal class ProductsPresenter
    {
        private readonly IRestAPI api;
        private readonly IProductsView view;
        private readonly IDictionary<string, object> args;

        public ProductsPresenter(IProductsView view, IRestAPI api, ISettings settings)
        {
            this.view = view;
            this.api = api;
            args = new Dictionary<string, object>() {
                { "start", 0 },
                { "limit", settings.ItemsPerPage },
                { "filter_name", string.Empty }
            };
            WireUpEvents();
        }

        private void WireUpEvents()
            => view.LoadView += View_LoadView;

        private async void View_LoadView(object sender, EventArgs e)
        {
            view.Loading(true);
            try
            {
                view.ShowProducts(await Task.Run(() => api.GetProducts(args)), api);
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

        public void Search()
        {
            args["filter_name"] = view.SearchText;
            View_LoadView(this, EventArgs.Empty);
        }

        public void AddProduct()
        {
            var product = new ProductData()
            {
                Image = new ProductImage(),
                DateAvailable = DateTime.Today,
                Descriptions = new Dictionary<int, Description>(),
                Categories = new List<int>(),
                Discounts = new BindingList<Discount>(),
                Specials = new BindingList<SpecialOffer>(),
                RelatedProducts = new List<int>(),
                Images = new List<ProductImage>(),
                Stores = new List<int>()
            };
            IEnumerable<Language> langs = api.GetLanguages();
            foreach (Language lang in langs)
            {
                product.Descriptions.Add(lang.ID, new Description());
            }

            Messenger.Instance.Send(new ProductView(product, api) as IView);
        }

        public async void DeleteCustomer(Product product)
        {
            view.Message(api.DeleteProduct(product));
            View_LoadView(this, EventArgs.Empty);
            await Task.Delay(TimeSpan.FromSeconds(3));
            view.Message(string.Empty);
        }

        public void PrevPage()
        {
            int start = (int)args["start"];
            if (start > 0)
            {
                start -= Settings.Default.nItems;
                args["start"] = start;
                View_LoadView(this, EventArgs.Empty);
            }
        }

        public void NextPage()
        {
            int start = (int)args["start"];
            start += Settings.Default.nItems;
            args["start"] = start;
            View_LoadView(this, EventArgs.Empty);
        }
    }
}
