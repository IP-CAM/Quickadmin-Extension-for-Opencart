using Entity;
using System;
using System.Collections.Generic;

namespace UI.ViewModel
{
    internal class PaymentTabViewModel : AddressingTabViewModel
    {
        public PaymentTabViewModel(OrderData order, IEnumerable<PaymentMethod> methods, IEnumerable<Country> countries, Func<int, IEnumerable<Zone>> getZonesFn) 
            : base(order, order.PaymentAddress, countries, getZonesFn) => PaymentMethods = methods;

        public IEnumerable<PaymentMethod> PaymentMethods { get; }

        public PaymentMethod PaymentMethod
        {
            get => order.PaymentMethod;
            set
            {
                order.PaymentMethod = value;
                OnPropertyChanged(nameof(PaymentMethod));
            }
        }

        protected override void SetAddress() => order.PaymentAddress = Address;
    }
}
