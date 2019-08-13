using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace UI.View
{
    public partial class WelcomeView : UserControl
    {
        public WelcomeView() => InitializeComponent();

        public void BindViewModel()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            lollipopLabel_version.Text = $"v{version}";
        }

        private void WelcomeView_Load(object sender, System.EventArgs e) => BindViewModel();
    }
}
