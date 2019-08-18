using UI.Model;
using UI.Repository2.Common;
using UI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UI.ViewModel
{
    public class CustomersViewModel : ViewModelBase
    {
        #region Attributes
        private int total;
        private string search;
        private string message;
        private int currentCustomerID;
        private BindingList<CustomerModel> customers;
        private readonly IRepository<CustomerModel> repository;
        private int startItems;
        private bool changeNextPage;
        private bool changePrevPage;
        private bool loading;
        private bool enabled;
        #endregion

        public CustomersViewModel(IRepository<CustomerModel> repository) => this.repository = repository;

        #region Commands
        private ICommand _load;
        private ICommand _prev;
        private ICommand _fwrd;
        private ICommand _add;
        private ICommand _update;
        private ICommand _delete;
        private ICommand _search;
        private ICommand _selectedCustomerID;
        #endregion

        #region Properties
        public int Total
        {
            get => total;
            set
            {
                if (total == value)
                    return;
                total = value;
                OnPropertyChanged(nameof(total));
            }
        }

        public bool ChangeNextPage
        {
            get => changeNextPage;
            set
            {
                changeNextPage = value;
                OnPropertyChanged(nameof(changeNextPage));
            }
        }

        public bool ChangePrevPage
        {
            get => changePrevPage;
            set
            {
                changePrevPage = value;
                OnPropertyChanged(nameof(changePrevPage));
            }
        }

        public bool Loading
        {
            get => loading;
            set
            {
                loading = value;
                OnPropertyChanged(nameof(loading));
            }
        }

        public bool Enabled
        {
            get => enabled;
            set
            {
                if (enabled == value)
                    return;
                enabled = value;
                OnPropertyChanged(nameof(enabled));
            }
        }

        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged(nameof(message));
            }
        }

        public string SearchParam
        {
            get => search;
            set
            {
                if (search == value)
                    return;
                search = value;
                OnPropertyChanged(nameof(search));
            }
        }

        public BindingList<CustomerModel> Customers
        {
            get
            {
                if (customers == null)
                    customers = new BindingList<CustomerModel>();
                return customers;
            }
        }

        public ICommand Load
        {
            get
            {
                if (_load == null)
                    _load = new CommandHandler(p => LoadData());
                return _load;
            }
        }

        public ICommand Previous
        {
            get
            {
                if (_prev == null)
                    _prev = new CommandHandler(p => LoadData());
                if (startItems > 0)
                    startItems -= Properties.Settings.Default.nItems;
                return _prev;
            }
        }

        public ICommand Forward
        {
            get
            {
                if (_fwrd == null)
                    _fwrd = new CommandHandler(p => LoadData());
                startItems += Properties.Settings.Default.nItems;
                return _fwrd;
            }
        }

        public ICommand Add
        {
            get
            {

                if (_add == null)
                    _add = new CommandHandler(p => AddCustomer());
                return _add;
            }
        }

        public ICommand Edit
        {
            get
            {
                if (_update == null)
                    _update = new CommandHandler(p => EditCustomer());
                return _update;
            }
        }

        public ICommand Delete
        {
            get
            {
                if (_delete == null)
                    _delete = new CommandHandler(p => DeleteCustomer());
                return _delete;
            }
        }

        public ICommand Search
        {
            get
            {
                if (_search == null)
                    _search = new CommandHandler(p => LoadData());
                return _search;
            }
        }

        public ICommand SelectedCustomer
        {
            get
            {
                if (_selectedCustomerID == null)
                    _selectedCustomerID = new CommandHandler(id => CustomerSelectedHandle(int.Parse((string)id)));
                return _selectedCustomerID;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load a list of customers.
        /// </summary>
        private async void LoadData()
        {
            try
            {
                Loading = true;
                Customers.Clear();
                ICollection<CustomerModel> collection = await repository.GetAllAsync(new Dictionary<string, object>()
                    {
                        { "start", startItems },
                        { "limit", Properties.Settings.Default.nItems },
                        { "filter_name", SearchParam },
                        //{ "filter_email", SearchParam },
                    });
                foreach (CustomerModel c in collection)
                    Customers.Add(c);
                Total = Customers.Count;
                ChangeNextPage = Total > 0;
                ChangePrevPage = startItems > 0;
                Enabled = true;
            }
            catch {
                Enabled = false;
                Message = "No se han podido cargar los datos. Verífique la configuración";
                ChangeNextPage = ChangePrevPage = false;
            }
            finally {
                Loading = false;
            }
        }

        /// <summary>
        /// Send a message, indicating to create a new customer.
        /// </summary>
        private void AddCustomer() => Messenger.Instance.Send(new NotificationMessage<int>(NotifyAction.AddCustomer, 0));

        /// <summary>
        /// Opens a new GUI for updating customer data.
        /// </summary>
        private void EditCustomer() => Messenger.Instance.Send(new NotificationMessage<int>(NotifyAction.EditCustomer, currentCustomerID));

        /// <summary>
        /// Deletes a customer.
        /// </summary>
        private async void DeleteCustomer()
        {
            Message = repository.Delete(new CustomerModel() { ID = currentCustomerID });
            LoadData();
            await Task.Delay(TimeSpan.FromSeconds(4));
            Message = string.Empty;
        }

        /// <summary>
        /// Get the current selected customer's ID
        /// </summary>
        /// <param name="id">Customer's ID</param>
        private void CustomerSelectedHandle(int id) => currentCustomerID = id;
        #endregion
    }
}
