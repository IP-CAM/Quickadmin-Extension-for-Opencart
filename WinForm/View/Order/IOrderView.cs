using System.Windows.Forms;

namespace UI.View
{
    internal interface IOrderView : IView
    {
        PrintDialog PrintDialog { get; }
    }
}
