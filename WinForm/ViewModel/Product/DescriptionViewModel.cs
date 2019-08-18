
using Entity;

namespace UI.ViewModel.Product
{
    internal class DescriptionViewModel : ViewModelBase
    {
        private readonly Description description;

        public DescriptionViewModel(Description description) => this.description = description;

        public string ProductName
        {
            get => description.Name;
            set
            {
                description.Name = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }

        public string MetatagTitle
        {
            get => description.MetaTitle;
            set
            {
                description.MetaTitle = value;
                OnPropertyChanged(nameof(MetatagTitle));
            }
        }

        public string MetatagDescription
        {
            get => description.MetaDescription;
            set
            {
                description.MetaDescription = value;
                OnPropertyChanged(nameof(MetatagDescription));
            }
        }

        public string MetatagKeywords
        {
            get => description.MetaKeyword;
            set
            {
                description.MetaKeyword = value;
                OnPropertyChanged(nameof(MetatagKeywords));
            }
        }

        public string Tags
        {
            get => description.Tag;
            set
            {
                description.Tag = value;
                OnPropertyChanged(nameof(Tags));
            }
        }

        public string Description
        {
            get => description.DescriptionText;
            set
            {
                description.DescriptionText = value;
                OnPropertyChanged(nameof(Description));
            }
        }
    }
}
