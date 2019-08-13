using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace UI.ViewModel.Product
{
    internal class DiscountTabViewModel : ViewModelBase
    {
        private Discount discount;
        private readonly ProductData product;

        public DiscountTabViewModel(ProductData product, IEnumerable<CustomerGroup> customer_groups)
        {
            this.product = product;
            CustomerGroups = customer_groups;
            AddDiscount = new CommandHandler(AddDiscountFn);
            DeleteDiscount = new CommandHandler(DeleteDiscountFn);
            Discount = new Discount()
            {
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now
            };
        }

        public ICommand AddDiscount { get; }
        public ICommand DeleteDiscount { get; }

        private void DeleteDiscountFn(object index) => Discounts.RemoveAt((int)index);

        public Discount Discount
        {
            get => discount;
            private set
            {
                discount = value;
                Quantity = discount.Quantity;
                Priority = discount.Priority;
                Price = discount.Price;
                StartDate = discount.DateStart;
                EndDate = discount.DateEnd;
                OnPropertyChanged(nameof(Discount));
            }
        }

        public IEnumerable<CustomerGroup> CustomerGroups { get; private set; }

        public IList<Discount> Discounts => product.Discounts as IList<Discount>;

        public int Quantity
        {
            get => Discount.Quantity;
            set
            {
                Discount.Quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public int Priority
        {
            get => Discount.Priority;
            set
            {
                Discount.Priority = value;
                OnPropertyChanged(nameof(Discount.Priority));
            }
        }

        public double Price
        {
            get => Discount.Price;
            set
            {
                Discount.Price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public DateTime StartDate
        {
            get => Discount.DateStart;
            set
            {
                Discount.DateStart = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        public DateTime EndDate
        {
            get => Discount.DateEnd;
            set
            {
                Discount.DateEnd = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        private void AddDiscountFn(object arg)
        {
            Discounts.Add(Discount);
            Discount = new Discount()
            {
                DateEnd = DateTime.Now,
                DateStart = DateTime.Now
            };
        }
    }
}
