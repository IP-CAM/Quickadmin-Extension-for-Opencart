using Entity;
using QuickAdmin.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using UI.Models;
using UI.Services;
using UI.View;

namespace UI.Presenter
{
    internal class OrdersPresenter
    {
        private readonly IOrdersView view;
        private readonly IRestAPI api;
        private readonly ISettings settings;
        private readonly IDictionary<string, object> args;

        public OrdersPresenter(IOrdersView view, IRestAPI api, ISettings settings)
        {
            this.view = view;
            this.settings = settings;
            this.api = api;
            args = new Dictionary<string, object>() {
                { "start", 0 },
                { "limit", settings.ItemsPerPage },
                { "filter_customer", string.Empty }
            };
            WireUpEvents();
        }

        private void WireUpEvents() => view.LoadView += View_LoadView;

        private async void View_LoadView(object sender, EventArgs e)
        {
            view.Loading(true);
            try
            {
                view.Orders = await Task.Run(() => api.GetOrders(args));
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

        internal async void DeleteOrder(Order order)
        {
            view.Loading(true);
            view.Message(await Task.Run(() => api.DeleteOrder(order)));
            View_LoadView(this, EventArgs.Empty);
            view.Loading(false);
            await Task.Delay(TimeSpan.FromSeconds(4));
            view.Message(string.Empty);
        }

        internal void NextPage()
        {
            int start = (int)args["start"];
            start += (short)args["limit"];
            args["start"] = start;
            View_LoadView(this, EventArgs.Empty);
        }

        internal void PrevPage()
        {
            int start = (int)args["start"];
            if (start > 0)
            {
                start -= (short)args["limit"];
                args["start"] = start;
                View_LoadView(this, EventArgs.Empty);
            }
        }

        internal void OverView(Order order) => Messenger.Instance.Send(new OrderReviewView(api, settings, order));

        internal void UpdateOrder(Order order) => Messenger.Instance.Send(new OrderView(api, settings, order));

        internal void AddOrder() => Messenger.Instance.Send(new OrderView(api, settings,
            new OrderData()
            {
                DateAdded = DateTime.Today,
                Customer = new Customer(),
                Currency = new Currency(),
                OrderTotals = new BindingList<OrderTotal>() {
                new OrderTotal()
                {
                    SortOrder = 1,
                    Title = "Subtotal",
                    Code = "sub_total",
                },
                new OrderTotal()
                {
                    SortOrder = 9,
                    Code = "total",
                    Title = "Total",
                },
            },
                PaymentAddress = new Address(),
                PaymentCustomField = new PaymentCustomField(),
                PaymentMethod = new PaymentMethod(),
                ShippingAddress = new Address(),
                ShippingMethod = new ShippingMethod(),
                Store = new Store(),
                Products = new BindingList<OrderProduct>(),
                UserAgent = "TecnoPoS/v2 (WinForms .NET Framework; Win32 x86)",
            }));

        internal void Search()
        {
            args["filter_customer"] = view.SearchText;
            View_LoadView(this, EventArgs.Empty);
        }
    }
}
