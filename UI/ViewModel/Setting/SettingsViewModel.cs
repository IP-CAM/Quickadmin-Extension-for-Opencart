using Squirrel;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using UI.Models;

namespace UI.ViewModel
{
    internal class SettingsViewModel : ViewModelBase
    {
        private string message;
        private string updateMessage;
        private ICommand _save;
        private ICommand _lessMinutes;
        private ICommand _moreMinutes;
        private ICommand _load;
        private ICommand _checkUpdates;
        private ICommand _importConfigFile;
        private ICommand _exportConfigFile;
        private readonly ISettings settings;

        public SettingsViewModel(ISettings settings) => this.settings = settings;

        #region Properties
        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged(nameof(message));
            }
        }

        public string UpdateMessage
        {
            get => updateMessage;
            set
            {
                updateMessage = value;
                OnPropertyChanged(nameof(updateMessage));
            }
        }

        public ICommand Load
        {
            get
            {
                if (_load == null)
                    _load = new CommandHandler(o => LoadConfig());
                return _load;
            }
        }

        public ICommand Save
        {
            get
            {
                if (_save == null)
                    _save = new CommandHandler(o => SaveSettings());
                return _save;
            }
        }

        public ICommand LessMinutes
        {
            get
            {
                if (_lessMinutes == null)
                    _lessMinutes = new CommandHandler(o => FnLessMinutes((short)o));
                return _lessMinutes;
            }
        }

        public ICommand AddMinutes
        {
            get
            {
                if (_moreMinutes == null)
                    _moreMinutes = new CommandHandler(o => FnAddMinutes((short)o));
                return _moreMinutes;
            }
        }

        public ICommand CheckUpdates
        {
            get
            {
                if (_checkUpdates == null)
                    _checkUpdates = new CommandHandler(o => Update());
                return _checkUpdates;
            }
        }

        public ICommand ImportConfigFile
        {
            get
            {
                if (_importConfigFile == null)
                    _importConfigFile = new CommandHandler(p => FnImportConfigFile(p as string));
                return _importConfigFile;
            }
        }

        public ICommand ExportConfigFile
        {
            get
            {
                if (_exportConfigFile == null)
                    _exportConfigFile = new CommandHandler(p => FnExportConfigFile(p as string));
                return _exportConfigFile;
            }
        }

        public string TemplateFile
        {
            get => settings.PDFTemplate;
            set
            {
                if (settings.PDFTemplate == value)
                    return;
                settings.PDFTemplate = value;
                OnPropertyChanged(nameof(TemplateFile));
            }
        }

        public string FolderToSave
        {
            get => settings.PathPDFfiles;
            set
            {
                if (settings.PathPDFfiles == value)
                    return;
                settings.PathPDFfiles = value;
                OnPropertyChanged(nameof(FolderToSave));
            }
        }

        public bool SaveFiles
        {
            get => settings.SaveFiles;
            set
            {
                if (settings.SaveFiles == value)
                    return;
                settings.SaveFiles = value;
                OnPropertyChanged(nameof(SaveFiles));
            }
        }

        public short ItemsPerPage
        {
            get => settings.ItemsPerPage;
            set
            {
                if (settings.ItemsPerPage == value)
                    return;
                settings.ItemsPerPage = value > 0 && value < 20 ? value : (short)20;
                OnPropertyChanged(nameof(ItemsPerPage));
            }
        }

        public bool UseProxy
        {
            get => settings.IsProxyEnabled;
            set
            {
                if (settings.IsProxyEnabled == value)
                    return;
                settings.IsProxyEnabled = value;
                OnPropertyChanged(nameof(UseProxy));
            }
        }

        public int ProxyTime
        {
            // From minutes to %
            get => Minutes * 100 / 60;
            // From % to Min
            set => OnPropertyChanged(nameof(ProxyTime));
        }

        public short Minutes
        {
            get => settings.ProxyTime;
            set => settings.ProxyTime = value;
        }

        public string APIusr
        {
            get => settings.APIUsr;
            set
            {
                if (settings.APIUsr == value)
                    return;
                settings.APIUsr = value;
                OnPropertyChanged(nameof(APIusr));
            }
        }

        public string APIpwd
        {
            get => settings.APIKey;
            set
            {
                if (settings.APIKey == value)
                    return;
                settings.APIKey = value;
                OnPropertyChanged(nameof(APIpwd));
            }
        }

        public string APIHost
        {
            get => settings.APIHost;
            set
            {
                if (settings.APIHost == value)
                    return;
                settings.APIHost = value.Trim();
                OnPropertyChanged(nameof(APIHost));
            }
        }

        public string Host
        {
            get => settings.Host;
            set
            {
                if (settings.Host == value)
                    return;
                settings.Host = value;
                OnPropertyChanged(nameof(Host));
            }
        }

        public short Port
        {
            get => settings.Port;
            set
            {
                if (settings.Port == value)
                    return;
                settings.Port = value;
                OnPropertyChanged(nameof(Port));
            }
        }

        public string Email
        {
            get => settings.Email;
            set
            {
                if (settings.Email == value)
                    return;
                settings.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string EmailPWD
        {
            get => settings.EmailPwd;
            set
            {
                if (settings.EmailPwd == value)
                    return;
                settings.EmailPwd = value;
                OnPropertyChanged(nameof(EmailPWD));
            }
        }

        public string Subject
        {
            get => settings.Subject;
            set
            {
                if (settings.Subject == value)
                    return;
                settings.Subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        public string BodyEmail
        {
            get => settings.BodyMessage;
            set
            {
                if (settings.BodyMessage == value)
                    return;
                settings.BodyMessage = value;
                OnPropertyChanged(nameof(BodyEmail));
            }
        }

        private void FnLessMinutes(short step)
        {
            if (Minutes > 15)
                Minutes -= step;
            ProxyTime = ProxyTime;
        }

        private void FnAddMinutes(short step)
        {
            if (Minutes < 60)
                Minutes += step;
            ProxyTime = ProxyTime;
        }
        #endregion

        private async void SaveSettings()
        {
            settings.Save();
            Message = "Settings saved";
            await Task.Delay(TimeSpan.FromSeconds(3));
            Message = string.Empty;
        }

        private async void Update()
        {
            UpdateMessage = "Checking for new updates...";
            try
            {
                using (UpdateManager mgr = await UpdateManager.GitHubUpdateManager(settings.GitHubUrl))
                {
                    UpdateInfo info = await mgr.CheckForUpdate();
                    if (info.ReleasesToApply.Any())
                    {
                        UpdateMessage = "Updating... please wait.";
                        await mgr.UpdateApp();
                        UpdateMessage = "The updates have been installed succesfully";
                    }
                    else
                        UpdateMessage = "The application is already updated";
                }
            }
            catch {
                UpdateMessage = "Sorry, there was an error checking updates. Please, try again";
            }
        }

        private void LoadConfig() => settings.Load();

        private void FnImportConfigFile(string path) => settings.Import(path);

        private void FnExportConfigFile(string path) => settings.Export(path);
    }
}
