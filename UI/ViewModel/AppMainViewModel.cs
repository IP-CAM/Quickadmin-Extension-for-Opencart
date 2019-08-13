using QuickAdmin.API;
using System.Windows.Forms;
using System.Windows.Input;
using UI.Models;
using UI.Proxy;
using UI.View;

namespace UI.ViewModel
{
    internal class AppMainViewModel : ViewModelBase
    {
        private RestAPIProxy api;
        private IView currentView;
        private readonly ISettings settings;

        private ICommand _ordersCmd;
        private ICommand _stockCmd;
        private ICommand _customersCmd;
        private ICommand _settingsCmd;

        private IRestAPI API => settings.IsProxyEnabled ? api as IRestAPI : api.API as IRestAPI;

        public AppMainViewModel(IRestAPI api)
        {
            settings = new SettingsModel(Properties.Settings.Default);
            api = new RestAPIProxy(api as RestAPI, settings.ProxyTime);
        }

        #region Commands
        public ICommand Orders
        {
            get
            {
                if (_ordersCmd == null)
                {
                    _ordersCmd = new CommandHandler(c => OrderSection(c as Panel));
                }

                return _ordersCmd;
            }
        }

        public ICommand Stock
        {
            get
            {
                if (_stockCmd == null)
                {
                    _stockCmd = new CommandHandler(c => StockSection(c as Panel));
                }

                return _stockCmd;
            }
        }

        public ICommand Customers
        {
            get
            {
                if (_customersCmd == null)
                {
                    _customersCmd = new CommandHandler(c => CustomersSection(c as Panel));
                }

                return _customersCmd;
            }
        }

        public ICommand Settings
        {
            get
            {
                if (_settingsCmd == null)
                {
                    _settingsCmd = new CommandHandler(c => SettingsSection(c as Panel));
                }

                return _settingsCmd;
            }
        }
        #endregion

        private void CustomersSection(Panel panel)
        {
            if (currentView is CustomersView)
            {
                return;
            }

            DisposeControls(panel);
            currentView = new CustomersView(API, settings);
            ShowView(currentView as UserControl, panel);
        }

        private void OrderSection(Panel panel)
        {
            if (currentView is OrdersView)
            {
                return;
            }

            DisposeControls(panel);
            currentView = new OrdersView(API, settings);
            ShowView(currentView as UserControl, panel);
        }

        private void StockSection(Panel panel)
        {
            if (currentView is ProductsView)
            {
                return;
            }

            DisposeControls(panel);
            currentView = new ProductsView(API, settings);
            ShowView(currentView as UserControl, panel);
        }

        private void SettingsSection(Panel panel)
        {
            if (currentView is SettingsView)
            {
                return;
            }

            DisposeControls(panel);
            currentView = new SettingsView(settings);
            ShowView(currentView as UserControl, panel);
        }

        public void ShowView(UserControl view, Panel panel)
        {
            if (!panel.Controls.Contains(view))
            {
                panel.Controls.Add(view);
            }

            view.BringToFront();
            view.Show();
        }

        private void DisposeControls(Panel panel)
        {
            foreach (UserControl ctrl in panel.Controls)
            {
                ctrl.Dispose();
            }

            panel.Controls.Clear();
        }
    }
}
