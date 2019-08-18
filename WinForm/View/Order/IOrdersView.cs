using System.Collections.Generic;
using Entity;

namespace UI.View
{
    internal interface IOrdersView : IView
    {
        IList<Order> Orders { get; set; }
        string SearchText { get; set; }
    }
}
