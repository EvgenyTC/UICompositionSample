using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICompositionSample.Model
{
    public class ImageItem: IContentItem
    {
        string _name;
        public string Name => _name;

        public ImageItem(string name)
        {
            _name = name;
        }

    }
}
