using IniParser;
using IniParser.Model;
using System;
using UI.Properties;

namespace UI.Models
{
    internal class SettingsModel : ISettings
    {
        private readonly Settings settings;

        public SettingsModel(Settings settings) => this.settings = settings;

        public string GitHubUrl => "https://github.com/PerezRE/TecnoPoS";

        public string PDFTemplate
        {
            get => settings.pdfTemplate;
            set => settings.pdfTemplate = value;
        }

        public bool SaveFiles
        {
            get => settings.saveFile;
            set => settings.saveFile = value;
        }

        public string PathPDFfiles
        {
            get => settings.dirFiles;
            set => settings.dirFiles = value;
        }

        public short ItemsPerPage
        {
            get => settings.nItems;
            set => settings.nItems = value;
        }

        public bool IsProxyEnabled
        {
            get => settings.useProxy;
            set => settings.useProxy = value;
        }

        public short ProxyTime
        {
            get => settings.timeProxy;
            set => settings.timeProxy = value;
        }

        public string APIUsr
        {
            get => settings.api_usr;
            set => settings.api_usr = value;
        }

        public string APIKey
        {
            get => settings.api_key;
            set => settings.api_key = value;
        }

        public string APIHost
        {
            get => settings.api_host;
            set => settings.api_host = value;
        }

        public string Host
        {
            get => settings.eHost;
            set => settings.eHost = value;
        }

        public short Port
        {
            get => settings.ePort;
            set => settings.ePort = value;
        }

        public string Email
        {
            get => settings.eEmail;
            set => settings.eEmail = value;
        }

        public string EmailPwd
        {
            get => settings.ePwd;
            set => settings.ePwd = value;
        }

        public string Subject
        {
            get => settings.eSubject;
            set => settings.eSubject = value;
        }

        public string BodyMessage
        {
            get => settings.eMessage;
            set => settings.eMessage = value;
        }

        public void Export(string filename)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = new IniData();
            // General tab settings
            data["general"]["template"] = PDFTemplate;
            data["general"]["save_files"] = Convert.ToString(SaveFiles);
            data["general"]["dir_toSave"] = PathPDFfiles;
            data["general"]["n_items"] = Convert.ToString(ItemsPerPage);
            data["general"]["use_proxy"] = Convert.ToString(IsProxyEnabled);
            data["general"]["time_proxy"] = Convert.ToString(ProxyTime);
            // API Tab settings
            data["api"]["user"] = APIUsr;
            // Mail tab settings
            data["correo"]["host"] = Host;
            data["correo"]["port"] = Convert.ToString(Port);
            data["correo"]["email"] = Email;
            data["correo"]["subject"] = Subject;
            data["correo"]["message"] = BodyMessage;
            // Write file
            parser.WriteFile(filename, data);
        }

        public void Import(string filename)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filename);
            // General tab settings
            PDFTemplate = data["general"]["template"];
            SaveFiles = bool.Parse(data["general"]["save_files"]);
            PathPDFfiles = data["general"]["dir_toSave"];
            ItemsPerPage = short.Parse(data["general"]["n_items"]);
            IsProxyEnabled = bool.Parse(data["general"]["use_proxy"]);
            ProxyTime = Convert.ToInt16(data["general"]["time_proxy"]);
            // API Tab settings
            APIUsr = data["api"]["user"];
            // Mail tab settings
            Host = data["correo"]["host"];
            Port = short.Parse(data["correo"]["port"]);
            Email = data["correo"]["email"];
            Subject = data["correo"]["subject"];
            BodyMessage = data["correo"]["message"];
            Save();
        }

        public void Reset() => settings.Reset();

        public void Save() => settings.Save();

        public void Load() => settings.Reload();
    }
}
