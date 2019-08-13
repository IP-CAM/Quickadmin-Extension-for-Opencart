using System.Windows.Forms;

namespace UI.View
{
    internal interface IOrderReviewView : IView
    {
        PrintDialog PrintDialog { get; }
    }
}
