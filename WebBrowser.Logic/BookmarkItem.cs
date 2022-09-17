using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class BookmarkItem
    {
        public string url { get; set; }
        public string title { get; set; }

        public BookmarkItem(string url, string title)
        {
            this.url = url;
            this.title = title;
        }

        public override string ToString()
        {
            return title + " (" + url + ")";
        }
    }
}
