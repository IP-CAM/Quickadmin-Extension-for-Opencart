using Entity;
using _Product = Entity.Product;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using UI.Services;

namespace UI.ViewModel
{
    internal class ProductsTabViewModel : ViewModelBase
    {
        private OrderData order;
        private OrderProduct orderProduct;

        public ProductsTabViewModel(OrderData order, IEnumerable<_Product> products)
        {
            this.order = order;
            Products = products;
            orderProduct = new OrderProduct() { Quantity = 1 };
            AddProduct = new CommandHandler(AddProductFn);
            RmProduct = new CommandHandler(RmProductFn);
        }

        public BindingList<OrderProduct> OrderProducts => order.Products;

        public IEnumerable<_Product> Products { get; }

        public int Quantity
        {
            get => orderProduct.Quantity;
            set
            {
                orderProduct.Quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public ICommand AddProduct { get; }

        public ICommand RmProduct { get; }

        private void AddProductFn(object obj)
        {
            _Product p = obj as _Product;
            orderProduct.ProductID = p.ID;
            orderProduct.Model = p.Model;
            orderProduct.Name = p.Name;
            orderProduct.Price = p.Price;
            orderProduct.Total = p.Price * Quantity;
            OrderProducts.Add(orderProduct);
            orderProduct = new OrderProduct() { Quantity = 1 };
            Quantity = orderProduct.Quantity;
            Messenger.Instance.Send(order.OrderTotals);
        }

        private void RmProductFn(object obj)
        {
            OrderProducts.Remove(obj as OrderProduct);
            Messenger.Instance.Send(order.OrderTotals);
        }
    }
}
