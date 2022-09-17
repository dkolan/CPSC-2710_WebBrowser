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
    public partial class BrowserControl : UserControl
    {
        public BrowserControl()
        {
            InitializeComponent();
        }

        private void toolStripTextBoxAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(toolStripTextBoxAddress.Text);
            }
        }
        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            Navigate(toolStripTextBoxAddress.Text);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void toolStripButtonForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser.Navigate(address);
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripTextBoxAddress.Text = webBrowser.Url.ToString();

            HistoryManager.addHistoryItem(
                new HistoryItem(
                    webBrowser.Url.ToString(),
                    webBrowser.DocumentTitle.ToString(),
                    DateTime.Now
                )
            );
        }

        private void toolStripButtonBookmark_Click(object sender, EventArgs e)
        {
            BookmarkManager.addBookmarkItem(
                new BookmarkItem(
                    webBrowser.Url.ToString(),
                    webBrowser.DocumentTitle.ToString()
                )
            );
        }
    }
}
