using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace UI.ViewModel.Product
{
    internal class SpecialTabViewModel : ViewModelBase
    {
        private SpecialOffer specialOffer;
        private readonly ProductData product;

        public SpecialTabViewModel(ProductData product, IEnumerable<CustomerGroup> customerGroups)
        {
            this.product = product;
            CustomerGroups = customerGroups;
            AddSpecialOffer = new CommandHandler(AddSpecialOfferFn);
            DeleteSpecialOffer = new CommandHandler(DeleteSpecialOfferFn);
            SpecialOffer = new SpecialOffer()
            {
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now
            };
        }

        public ICommand AddSpecialOffer { get; }
        public ICommand DeleteSpecialOffer { get; }

        private void DeleteSpecialOfferFn(object index) => SpecialOffers.RemoveAt((int)index);

        public SpecialOffer SpecialOffer
        {
            get => specialOffer;
            private set
            {
                specialOffer = value;
                CustomerGroup = specialOffer.CustomerGroupID;
                Priority = specialOffer.Priority;
                Price = specialOffer.Price;
                StartDate = specialOffer.DateStart;
                EndDate = specialOffer.DateEnd;
                OnPropertyChanged(nameof(SpecialOffer));
            }
        }

        public IEnumerable<CustomerGroup> CustomerGroups { get; private set; }

        public IList<SpecialOffer> SpecialOffers => product.Specials;

        public int CustomerGroup
        {
            get => SpecialOffer.CustomerGroupID;
            set
            {
                SpecialOffer.CustomerGroupID = value;
                OnPropertyChanged(nameof(CustomerGroup));
            }
        }

        public int Priority
        {
            get => SpecialOffer.Priority;
            set
            {
                SpecialOffer.Priority = value;
                OnPropertyChanged(nameof(SpecialOffer.Priority));
            }
        }

        public double Price
        {
            get => SpecialOffer.Price;
            set
            {
                SpecialOffer.Price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public DateTime StartDate
        {
            get => SpecialOffer.DateStart;
            set
            {
                SpecialOffer.DateStart = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        public DateTime EndDate
        {
            get => SpecialOffer.DateEnd;
            set
            {
                SpecialOffer.DateEnd = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        private void AddSpecialOfferFn(object arg)
        {
            SpecialOffers.Add(SpecialOffer);
            SpecialOffer = new SpecialOffer()
            {
                DateEnd = DateTime.Now,
                DateStart = DateTime.Now
            };
        }
    }
}
