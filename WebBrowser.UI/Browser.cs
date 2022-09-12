using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.UI;

namespace WebBrowser.UI
{
    public partial class Browser : Form
    {
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
    }
}
