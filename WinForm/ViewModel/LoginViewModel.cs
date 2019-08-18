using QuickAdmin.API;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using UI.Models;
using UI.Properties;

namespace UI.ViewModel
{
    internal class LoginViewModel : ViewModelBase
    {
        private readonly ISettings settings;
        private ICommand login;
        private string message;
        private readonly LoginForm form;

        public string Username
        {
            get => settings.APIUsr;
            set
            {
                if (settings.APIUsr != value)
                {
                    settings.APIUsr = value;
                }

                OnPropertyChanged(Username);
            }
        }

        public string Key
        {
            get => settings.APIKey;
            set
            {
                if (settings.APIKey != value)
                {
                    settings.APIKey = value;
                }

                OnPropertyChanged(Key);
            }
        }

        public string URL
        {
            get => settings.APIHost;
            set
            {
                if (settings.APIHost != value)
                {
                    settings.APIHost = value;
                }

                OnPropertyChanged(URL);
            }
        }

        public string Version
        {
            get
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                string version = fvi.FileVersion;
                return $"v{version}";
            }
        }

        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged(Message);
            }
        }

        public ICommand Login
        {
            get
            {
                if (login == null)
                {
                    login = new CommandHandler(p => LoginFn());
                }

                return login;
            }
        }

        public LoginViewModel(LoginForm form)
        {
            this.form = form;
            settings = new SettingsModel(Settings.Default);
        }

        private void LoginFn()
        {
            settings.Save();
            if (string.IsNullOrWhiteSpace(URL))
            {
                Message = "URL Store is required. Please check settings tab";
                return;
            }
            IRestAPI api = new RestAPI(URL);
            APIResponse response = api.Login(Username, Key);
            Message = response.Message;
            if (!string.IsNullOrWhiteSpace(response.Token))
            {
                Task.Delay(TimeSpan.FromSeconds(2));
                form.Close();
                new MainForm(api);
            }
        }
    }
}
