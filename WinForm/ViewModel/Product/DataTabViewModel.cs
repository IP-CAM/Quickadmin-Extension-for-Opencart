using Entity;
using System;
using System.Collections.Generic;

namespace UI.ViewModel.Product
{
    internal class DataTabViewModel : ViewModelBase
    {
        private readonly ProductData product;

        public DataTabViewModel(ProductData product, IEnumerable<Length> lengths, IEnumerable<Weight> weights, IEnumerable<StockStatus> stockStatuses, IEnumerable<Tax> taxes)
        {
            this.product = product;
            Lengths = lengths;
            Weights = weights;
            StockStatuses = stockStatuses;
            Taxes = taxes;
        }

        private ProductData Product
        {
            set
            {
                MPN = product.MPN;
                SKU = product.SKU;
                UPC = product.UPC;
                EAN = product.EAN;
                JAN = product.JAN;
                ISBN = product.ISBN;
                Model = product.Model;
                Location = product.Location;
                Price = product.Price;
                Status = product.Status;
                TaxClass = product.TaxClassID;
                Quantity = product.Quantity;
                MinimumQuantity = product.Minimum;
                SubtractStock = product.Subtract;
                StockStatus = product.StockStatusID;
                Weight = product.Weight;
                WeightClass = product.WeightClassID;
                Length = product.Length;
                Width = product.Width;
                LengthClass = product.LengthClassID;
                RequireShipping = product.Shipping;
                ReleaseDate = product.DateAvailable;
            }
        }

        public string MPN
        {
            get => product.MPN;
            set
            {
                product.MPN = value;
                OnPropertyChanged(nameof(MPN));
            }
        }

        public string SKU
        {
            get => product.SKU;
            set
            {
                product.SKU = value;
                OnPropertyChanged(nameof(SKU));
            }
        }

        public string UPC
        {
            get => product.UPC;
            set
            {
                product.UPC = value;
                OnPropertyChanged(nameof(UPC));
            }
        }

        public string EAN
        {
            get => product.EAN;
            set
            {
                product.EAN = value;
                OnPropertyChanged(nameof(EAN));
            }
        }

        public string JAN
        {
            get => product.JAN;
            set
            {
                product.JAN = value;
                OnPropertyChanged(nameof(JAN));
            }
        }

        public string ISBN
        {
            get => product.ISBN;
            set
            {
                product.ISBN = value;
                OnPropertyChanged(nameof(ISBN));
            }
        }

        public string Model
        {
            get => product.Model;
            set
            {
                product.Model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        public string Location
        {
            get => product.Location;
            set
            {
                product.Location = value;
                OnPropertyChanged(nameof(Location));
            }
        }

        public decimal Price
        {
            get => product.Price;
            set
            {
                product.Price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public bool Status
        {
            get => product.Status;
            set
            {
                product.Status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public int TaxClass
        {
            get => product.TaxClassID;
            set
            {
                product.TaxClassID = value;
                OnPropertyChanged(nameof(TaxClass));
            }
        }

        public int Quantity
        {
            get => product.Quantity;
            set
            {
                product.Quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public int MinimumQuantity
        {
            get => product.Minimum;
            set
            {
                product.Minimum = value;
                OnPropertyChanged(nameof(MinimumQuantity));
            }
        }

        public bool SubtractStock
        {
            get => product.Subtract;
            set
            {
                product.Subtract = value;
                OnPropertyChanged(nameof(SubtractStock));
            }
        }

        public int StockStatus
        {
            get => product.StockStatusID;
            set
            {
                product.StockStatusID = value;
                OnPropertyChanged(nameof(StockStatus));
            }
        }

        public double Weight
        {
            get => product.Weight;
            set
            {
                product.Weight = value;
                OnPropertyChanged(nameof(Weight));
            }
        }

        public int WeightClass
        {
            get => product.WeightClassID;
            set
            {
                product.WeightClassID = value;
                OnPropertyChanged(nameof(WeightClass));
            }
        }

        public double Length
        {
            get => product.Length;
            set
            {
                product.Length = value;
                OnPropertyChanged(nameof(Length));
            }
        }

        public double Width
        {
            get => product.Width;
            set
            {
                product.Width = value;
                OnPropertyChanged(nameof(Width));
            }
        }

        public int LengthClass
        {
            get => product.LengthClassID;
            set
            {
                product.LengthClassID = value;
                OnPropertyChanged(nameof(LengthClass));
            }
        }

        public bool RequireShipping
        {
            get => product.Shipping;
            set
            {
                product.Shipping = value;
                OnPropertyChanged(nameof(RequireShipping));
            }
        }

        public DateTime ReleaseDate
        {
            get => product.DateAvailable;
            set
            {
                product.DateAvailable = value;
                OnPropertyChanged(nameof(ReleaseDate));
            }
        }

        public IEnumerable<StockStatus> StockStatuses { get; private set; }
        public IEnumerable<Tax> Taxes { get; private set; }
        public IEnumerable<Length> Lengths { get; private set; }
        public IEnumerable<Weight> Weights { get; private set; }
    }
}
