using Bindery;
using MaterialSkin;
using MaterialSkin.Controls;
using UI.ViewModel;

namespace UI
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manager (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            var loginViewModel = new LoginViewModel(this);
            Create.Binder(loginViewModel)
                .Control(txtBx_username).Property(txtBx => txtBx.Text).Bind(vm => vm.Username)
                .Control(txtBx_key).Property(txtBx => txtBx.Text).Bind(vm => vm.Key)
                .Control(txtBx_url).Property(txtBx => txtBx.Text).Bind(vm => vm.URL)
                .Control(lbl_version).Property(lbl => lbl.Text).Get(vm => vm.Version)
                .Control(lbl_msg).Property(lbl => lbl.Text).Get(vm => vm.Message)
                .Control(btn_login).OnClick(loginViewModel.Login);
        }
    }
}
