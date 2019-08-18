using Entity;
using QuickAdmin.API;
using System.Collections.Generic;

namespace UI.View
{
    internal interface IProductsView : IView
    {
        void ShowProducts(IList<Product> products, IRestAPI api);
        string SearchText { get; set; }
    }
}
