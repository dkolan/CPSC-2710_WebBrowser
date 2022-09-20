using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void addHistoryItem(HistoryItem historyItem)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(
                historyItem.title,
                historyItem.url,
                historyItem.date
            );
        }

        public static List<HistoryItem> getAllHistoryItems()
        {
            var adapter = new HistoryTableAdapter();
            var historyItemsList = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem(
                    row.Title,
                    row.URL,
                    row.Date);

                historyItemsList.Add(item);
            }

            return historyItemsList;
        }

        public static List<HistoryItem> searchHistoryItems(string searchTerm)
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();

            var matchList = new List<HistoryItem>();
            foreach (var row in rows)
            {
                if (row.Title.Contains(searchTerm) || row.URL.Contains(searchTerm))
                {
                    var item = new HistoryItem(
                    row.Title,
                    row.URL,
                    row.Date);

                    matchList.Add(item);
                }

            }

            return matchList;
        }

        public static void deleteHistoryItem(string itemToDelete)
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem(
                    row.Title,
                    row.URL,
                    row.Date);

                if (item.ToString() == itemToDelete)
                {
                    adapter.DeleteQuery(row.Id);
                }
            }
        }

        public static void clearHistory()
        {
            var adapter = new HistoryTableAdapter();
            adapter.DeleteAllQuery();
        }
    }
}
