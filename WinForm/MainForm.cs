using Bindery;
using MaterialSkin;
using MaterialSkin.Controls;
using QuickAdmin.API;
using System.Windows.Forms;
using UI.Services;
using UI.View;
using UI.ViewModel;

namespace UI
{
    public partial class MainForm : MaterialForm
    {
        public MainForm(IRestAPI api)
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manager (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            BindViewModel(new AppMainViewModel(api));
        }

        private void BindViewModel(AppMainViewModel viewModel)
        {
            Messenger.Instance.Register<IView>(this, (view) => viewModel.ShowView(view as UserControl, panel_controls));
            Create.Binder(viewModel)
                .Control(materialFlatButton_orders).OnClick(viewModel.Orders, panel_controls)
                .Control(materialFlatButton_products).OnClick(viewModel.Stock, panel_controls)
                .Control(materialFlatButton_customers).OnClick(viewModel.Customers, panel_controls)
                .Control(materialFlatButton_settings).OnClick(viewModel.Settings, panel_controls);
        }
    }
}
