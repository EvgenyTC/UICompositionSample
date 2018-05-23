using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UICompositionSample.Model;

namespace UICompositionSample.ViewModels
{
    public class MainViewModel: Screen
    {
        ObservableCollection<IContentItem> _items;
        public ObservableCollection<IContentItem> Items => _items;

        object _previewViewModel;
        public object PreviewViewModel
        {
            get => _previewViewModel;
            set
            {
                if (_previewViewModel != value)
                {
                    _previewViewModel = value;
                    NotifyOfPropertyChange(nameof(PreviewViewModel));
                }
            }
        }

        IContentItem _selectedItem;
        public IContentItem SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    UpdatePreview(_selectedItem);
                    NotifyOfPropertyChange(nameof(SelectedItem));
                }
            }
        }

        public MainViewModel(IContentItemsProvider provider)
        {
            _items = new ObservableCollection<IContentItem>(provider.Data);
            SelectedItem = _items.FirstOrDefault();
        }

        private void UpdatePreview(IContentItem item)
        {
            if (item is TextItem)
            {
                PreviewViewModel = new TextPreviewViewModel(item as TextItem);
            }
            else if (item is ImageItem)
            {
                PreviewViewModel = new ImagePreviewViewModel(item as ImageItem);
            }
            else
            {
                PreviewViewModel = null;
            }
        }
    }
}
