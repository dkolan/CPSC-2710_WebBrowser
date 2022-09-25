using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var bookmarkItemList = BookmarkManager.getAllBookmarkItems();

            foreach (BookmarkItem item in bookmarkItemList)
            {
                listBoxBookmarkManager.Items.Add(item.ToString());
            }
        }

        private void buttonBookmarkSearch_Click(object sender, EventArgs e)
        {
            listBoxBookmarkManager.Items.Clear();
            List<BookmarkItem> searchResults = BookmarkManager.searchBookmarkItems(textBoxBookmarkSearch.Text);

            foreach (BookmarkItem item in searchResults)
            {
                listBoxBookmarkManager.Items.Add(item.ToString());
            }
        }

        private void buttonBookmarkDelete_Click(object sender, EventArgs e)
        {
            BookmarkManager.deleteBookmarkItem(listBoxBookmarkManager.SelectedItem.ToString());

            var bookmarkItemList = BookmarkManager.getAllBookmarkItems();

            listBoxBookmarkManager.Items.Clear();

            foreach (BookmarkItem item in bookmarkItemList)
            {
                listBoxBookmarkManager.Items.Add(item.ToString());
            }
        }
    }
}
