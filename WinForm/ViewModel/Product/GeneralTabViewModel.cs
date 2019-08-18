using Entity;
using System.Collections.Generic;

namespace UI.ViewModel.Product
{
    internal class GeneralTabViewModel
    {
        private readonly ProductData product;

        public IEnumerable<Language> Languages { get; private set; }
        public IDictionary<int, DescriptionViewModel> DescriptionVMs { get; private set; }

        public GeneralTabViewModel(ProductData product, IEnumerable<Language> languages)
        {
            this.product = product;
            Languages = languages;
            BuildDescriptionViewModels();
        }

        private void BuildDescriptionViewModels()
        {
            DescriptionVMs = new Dictionary<int, DescriptionViewModel>();
            foreach (Language language in Languages)
                DescriptionVMs.Add(language.ID, new DescriptionViewModel(product.Descriptions[language.ID]));
        }
    }
}