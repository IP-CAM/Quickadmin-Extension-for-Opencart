namespace UI.Models
{
    internal interface ISettings
    {
        string GitHubUrl { get; }

        string PDFTemplate { get; set; }
        bool SaveFiles { get; set; }
        string PathPDFfiles { get; set; }
        short ItemsPerPage { get; set; }

        bool IsProxyEnabled { get; set; }
        short ProxyTime { get; set; }

        string APIUsr { get; set; }
        string APIKey { get; set; }
        string APIHost { get; set; }

        string Host { get; set; }
        short Port { get; set; }
        string Email { get; set; }
        string EmailPwd { get; set; }
        string Subject { get; set; }
        string BodyMessage { get; set; }


        void Import(string filename);
        void Export(string filename);
        void Save();
        void Reset();
        void Load();
    }
}
