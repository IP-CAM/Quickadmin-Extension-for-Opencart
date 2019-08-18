using Entity;
using System.Collections.Generic;

namespace UI.View
{
    internal interface ICustomersView : IView
    {
        IList<Customer> Customers { get; set; }
        string SearchText { get; set; }
    }
}
