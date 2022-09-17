using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        public string url { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }

        public HistoryItem(string url, string title, DateTime date)
        {
            this.url = url;
            this.title = title;
            this.date = date;
        }

        public override string ToString()
        {
            return "[" + date + "] " + title + " (" + url + ")";
        }
    }
}
