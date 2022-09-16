using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void addBookmarkItem(BookmarkItem bookmarkItem)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(
                bookmarkItem.title,
                bookmarkItem.url
            );
        }

        public static List<BookmarkItem> getAllBookmarkItems()
        {
            var adapter = new BookmarksTableAdapter();
            var bookmarkItemsList = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem(
                    row.Title,
                    row.URL
                );

                bookmarkItemsList.Add(item);
            }

            return bookmarkItemsList;
        }
    }
}
