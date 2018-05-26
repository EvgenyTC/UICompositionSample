using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UICompositionSample.Model;

namespace UICompositionSample.ViewModels
{
    public class ImagePreviewViewModel
    {
        string _text;
        public string Text => _text;

        public ImagePreviewViewModel(ImageItem item)
        {
            _text = $"Image preview for {item.Name}";
        }

    }
}
