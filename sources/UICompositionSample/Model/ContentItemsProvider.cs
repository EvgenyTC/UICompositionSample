using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICompositionSample.Model
{
    public class ContentItemsProvider : IContentItemsProvider
    {
        List<IContentItem> _data;
        public IEnumerable<IContentItem> Data => _data;

        public ContentItemsProvider()
        {
            _data = new List<IContentItem>();
            _data.Add(new TextItem("Text item 1"));
            _data.Add(new ImageItem("Image item 1"));
            _data.Add(new TextItem("Text item 2"));
        }
    }
}
