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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var historyItemList = HistoryManager.getAllHistoryItems();

            foreach (HistoryItem item in historyItemList)
            {
                listBoxHistoryManager.Items.Add(item.ToString());
            }
        }

        private void buttonHistorySearch_Click(object sender, EventArgs e)
        {
            listBoxHistoryManager.Items.Clear();
            List<HistoryItem> searchResults = HistoryManager.searchHistoryItems(textBoxHistorySearch.Text);

            foreach (HistoryItem item in searchResults)
            {
                listBoxHistoryManager.Items.Add(item.ToString());
            }
        }

        private void buttonDeleteHistoryItem_Click(object sender, EventArgs e)
        {
            HistoryManager.deleteHistoryItem(listBoxHistoryManager.SelectedItem.ToString());

            var historyItemList = HistoryManager.getAllHistoryItems();

            listBoxHistoryManager.Items.Clear();

            foreach (HistoryItem item in historyItemList)
            {
                listBoxHistoryManager.Items.Add(item.ToString());
            }
        }

        public void buttonClearHistory_Click(object sender, EventArgs e)
        {
            HistoryManager.clearHistory();

            listBoxHistoryManager.Items.Clear();
        }
    }
}
