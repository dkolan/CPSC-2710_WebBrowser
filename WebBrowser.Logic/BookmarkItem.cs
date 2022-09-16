using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    class BookmarkItem
    {
        public string utl { get; set; }
        public string title { get; set; }

        public BookmarkItem(string utl, string title)
        {
            this.utl = utl;
            this.title = title;
        }
    }
}
