using Entity;
using UI.Services;
using UI.View;
using QuickAdmin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UI.Models;
using QuickAdmin.API;

namespace UI.Presenter
{
    class CustomersPresenter
    {
        private ICustomersView view;
        private readonly IRestAPI api;
        private readonly IDictionary<string, object> args;
        private readonly ISettings settings;

        public CustomersPresenter(ICustomersView view, IRestAPI api, ISettings settings)
        {
            this.view = view;
            this.settings = settings;

            args = new Dictionary<string, object>() {
                { "start", 0 },
                { "limit", settings.ItemsPerPage },
                { "filter_name", string.Empty }
            };

            this.api = api;
            WireUpEvents();
        }

        private void WireUpEvents() => view.LoadView += View_Load;

        public void Search()
        {
            args["filter_name"] = view.SearchText;
            View_Load(this, EventArgs.Empty);
        }

        public void AddCustomer() => Messenger.Instance.Send(new CustomerView(api, settings, new Customer() { Address = new Address() }) as IView);

        public void EditCustomer(Customer customer) => Messenger.Instance.Send(new CustomerView(api, settings, customer) as IView);

        public async void DeleteCustomer(Customer customer)
        {
            view.Message(api.DeleteCustomer(customer));
            View_Load(this, EventArgs.Empty);
            await Task.Delay(TimeSpan.FromSeconds(3));
            view.Message(string.Empty);
        }

        public void PrevPage()
        {
            int start = (int)args["start"];
            if (start > 0)
            {
                start -= (short)args["limit"];
                args["start"] = start;
                View_Load(this, EventArgs.Empty);
            }
        }

        public void NextPage()
        {
            int start = (int)args["start"];
            start += (short)args["limit"];
            args["start"] = start;
            View_Load(this, EventArgs.Empty);
        }

        private async void View_Load(object sender, EventArgs e)
        {
            view.Loading(true);
            try {
                view.Customers = await Task.Run(() => api.GetCustomers(args));
            }catch(InvalidOperationException ex){
                view.Message(ex.Message);
            } finally { 
                view.Loading(false);
            }
        }
    }
}
