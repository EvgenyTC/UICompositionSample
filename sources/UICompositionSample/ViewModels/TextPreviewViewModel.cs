using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UICompositionSample.Model;

namespace UICompositionSample.ViewModels
{
    public class TextPreviewViewModel
    {
        string _text;
        public string Text => _text;

        public TextPreviewViewModel(TextItem item)
        {
            _text = $"Text preview for {item.Name}";
        }
    }
}
