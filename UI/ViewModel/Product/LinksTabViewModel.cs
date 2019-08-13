using Entity;
using System.Collections.Generic;

namespace UI.ViewModel.Product
{
    internal class LinksTabViewModel : ViewModelBase
    {
        private ProductData product;
        private IEnumerable<Store> stores;
        private IEnumerable<Manufacturer> manufacturers;
        private IEnumerable<Entity.Product> products;
        private IEnumerable<Category> categories;

        public LinksTabViewModel(ProductData product, IEnumerable<Store> stores, IEnumerable<Manufacturer> manufacturers, IList<Entity.Product> products, IEnumerable<Category> categories)
        {
            this.product = product;
            this.stores = stores;
            this.manufacturers = manufacturers;
            this.categories = categories;
            this.products = products;
        }

        private ProductData Product
        {
            set => Manufacturer = product.ManufacturerID;
        }
        public IEnumerable<Store> Stores
        {
            get => stores;
            set
            {
                stores = value;
                OnPropertyChanged(nameof(Stores));
            }
        }
        public IEnumerable<Manufacturer> Manufacturers
        {
            get => manufacturers;
            set
            {
                manufacturers = value;
                OnPropertyChanged(nameof(Manufacturers));
            }
        }
        public IEnumerable<Entity.Product> Products
        {
            get => products;
            set
            {
                products = value;
                OnPropertyChanged(nameof(Products));
            }
        }
        public IEnumerable<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }
        public int Manufacturer
        {
            get => product.ManufacturerID;
            set
            {
                product.ManufacturerID = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }

        public IList<int> RelatedStores => product.Stores;
        public IList<int> RelatedCategories => product.Categories;
        public IList<int> RelatedProducts => product.RelatedProducts;
    }
}
