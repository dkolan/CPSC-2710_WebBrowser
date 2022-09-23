using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class Browser : Form
    {
        public HistoryManagerForm hmf;
        public Browser()
        {
            InitializeComponent();
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dan Kolan\n" + "dzk0077");
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserControl bc = new BrowserControl();
            bc.Dock = DockStyle.Fill;
            TabPage tp = new TabPage("New Tab");
            tp.Controls.Add(bc);
            this.tabControl1.TabPages.Add(tp);
            this.tabControl1.SelectTab(tp);
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            newTabToolStripMenuItem_Click(sender, e);
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != 0)
            {
                this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
                if (tabControl1.TabCount > 1)
                {
                    this.tabControl1.SelectTab(tabControl1.TabCount - 1);
                }
            }
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManagerForm hm = new HistoryManagerForm();
            hm.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkManagerForm bm = new BookmarkManagerForm();
            bm.ShowDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hmf = new HistoryManagerForm();
            hmf.buttonClearHistory_Click(sender, e);
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var focusedBrowser = this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls.Find("webBrowser", true)[0];

            System.Windows.Forms.WebBrowser fb = (System.Windows.Forms.WebBrowser)focusedBrowser;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML |*.html";
            sfd.Title = "Save an HTML File";
            sfd.FileName = fb.DocumentTitle;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.Unicode))
                {
                    sw.Write(fb.DocumentText);
                }
            }
        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var focusedBrowser = this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls.Find("webBrowser", true)[0];

            System.Windows.Forms.WebBrowser fb = (System.Windows.Forms.WebBrowser)focusedBrowser;

            fb.ShowPrintDialog();
        }
    }
}
