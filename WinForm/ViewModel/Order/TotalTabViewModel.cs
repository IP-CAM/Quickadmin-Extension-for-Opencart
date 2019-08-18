using Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UI.Services;

namespace UI.ViewModel
{
    internal class TotalTabViewModel : ViewModelBase
    {
        private readonly OrderData order;
        private string total;

        public TotalTabViewModel(OrderData order, IEnumerable<OrderStatus> statuses)
        {
            this.order = order;
            OrderStatuses = statuses;
            CalculateTotals(order.OrderTotals);
            Messenger.Instance.Register<BindingList<OrderTotal>>(this, CalculateTotals);
        }

        private void CalculateTotals(BindingList<OrderTotal> totals)
        {
            // Calculate subtotal
            decimal subtotal = 0;
            foreach (OrderProduct op in order.Products)
                subtotal += op.Total;
            OrderTotal subtotalOT = (from o_total in totals where o_total.Code == "sub_total" select o_total).First();
            OrderTotal total = (from o_total in totals where o_total.Code == "total" select o_total).First();
            subtotalOT.Value = subtotal;
            total.Value = subtotal;
            foreach (OrderTotal ot in totals)
            {
                if (ot.Code != "sub_total" && ot.Code != "total")
                    total.Value += ot.Value;
            }
            order.Total = total.Value;
            // Update total string
            StringBuilder sb = new StringBuilder();
            var _totals = totals.OrderBy(o => o.SortOrder);
            foreach (OrderTotal o in _totals)
                sb.AppendLine($"{o.Title}: ${o.Value.ToString("#.##")}");
            Totals = sb.ToString();
        }

        public IEnumerable<OrderStatus> OrderStatuses { get; }

        public BindingList<OrderProduct> Products => order.Products;

        public int Status 
        {
            get => order.OrderStatus;
            set
            {
                order.OrderStatus = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public string Totals {
            get => total;
            set {
                total = value;
                OnPropertyChanged(nameof(Totals));
            }
        }
    }
}
