using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICompositionSample.Model
{
    public class TextItem : IContentItem
    {
        string _name;
        public string Name => _name;

        public TextItem(string name)
        {
            _name = name;
        }
    }
}
