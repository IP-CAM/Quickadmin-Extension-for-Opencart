using Entity;
using MaterialSkin.Controls;
using QuickAdmin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;

namespace UI.ViewModel.Product
{
    internal class ImagesTabViewModel : ViewModelBase
    {
        private readonly ProductData product;

        public ImagesTabViewModel(ProductData product, string url_img)
        {
            URLImg = url_img;
            this.product = product;
            ChangeImg = new CommandHandler(ChangeImagePortrait);
            AddImg = new CommandHandler(AddImage);
            RmImg = new CommandHandler(RmImage);
            RmAdditionalImg = new CommandHandler(RmAddImg);
        }

        public ICommand RmAdditionalImg { get; }
        public ICommand ChangeImg { get; }
        public ICommand AddImg { get; }
        public ICommand RmImg { get; }
        public IList<ProductImage> Images => product.Images;
        public string URLImg { get; }

        public event EventHandler<ProductImage[]> ImageAdded;

        public string ImagePortrait
        {
            get => !product.Image.IsNew ? $"{URLImg}/{product.Image.Image}" : product.Image.Image;
            set
            {
                product.Image.Image = value;
                product.Image.IsNew = true;
                product.Image.Name = Path.GetFileNameWithoutExtension(value).Replace(' ', '_').Replace('.', '_');
                OnPropertyChanged(nameof(ImagePortrait));
            }
        }

        private void AddImage(object obj)
        {
            if (obj is OpenFileDialog dialog)
            {
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int size = dialog.FileNames.Length;
                    ProductImage[] newImages = new ProductImage[size];
                    for(int i = 0; i < size; i++)
                    {
                        string filename = dialog.FileNames[i];
                        newImages[i] = new ProductImage()
                        {
                            Image = filename,
                            IsNew = true,
                            Name = Path.GetFileNameWithoutExtension(filename).Replace(' ', '_').Replace('.', '_')
                        };
                        Images.Add(newImages[i]);
                    }
                    ImageAdded?.Invoke(this, newImages);
                }
                dialog.Multiselect = false;
            }
        }

        private void RmImage(object obj) => ImagePortrait = string.Empty;

        private void ChangeImagePortrait(object obj)
        {
            if (obj is OpenFileDialog dialog)
                if (DialogResult.OK == dialog.ShowDialog())
                    ImagePortrait = dialog.FileName;
        }

        private void RmAddImg(object obj) => Images.Remove(obj as ProductImage);
    }
}
