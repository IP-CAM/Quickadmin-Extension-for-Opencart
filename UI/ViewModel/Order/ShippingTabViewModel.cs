using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using UI.Services;

namespace UI.ViewModel
{
    internal class ShippingTabViewModel : AddressingTabViewModel
    {
        private OrderTotal curOrderTotal;

        public ShippingTabViewModel(OrderData order, IEnumerable<ShippingMethod> shippingMethods, IEnumerable<Country> countries, Func<int, IEnumerable<Zone>> getZonesFn)
            : base(order, order.ShippingAddress, countries, getZonesFn)
        {
            ShippingMethods = shippingMethods;
            curOrderTotal = (from ot in order.OrderTotals
                             where ot.Code == order.ShippingMethod.Code
                             select ot).FirstOrDefault();
        }

        public IEnumerable<ShippingMethod> ShippingMethods { get; }

        public ShippingMethod ShippingMethod
        {
            get => order.ShippingMethod;
            set
            {
                order.ShippingMethod = value;
                order.OrderTotals.Remove(curOrderTotal);
                curOrderTotal = new OrderTotal()
                {
                    Code = value.Code,
                    Title = value.Title,
                    Value = value.Cost
                };
                order.OrderTotals.Add(curOrderTotal);
                Messenger.Instance.Send(order.OrderTotals);
                OnPropertyChanged(nameof(ShippingMethod));
            }
        }

        protected override void SetAddress() => order.ShippingAddress = Address;
    }
}
