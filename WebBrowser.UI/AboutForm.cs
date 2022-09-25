using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.UI.Properties;

namespace WebBrowser.UI
{
    public partial class AboutForm : Form
    {
        SoundPlayer chiptune;

        public AboutForm()
        {
            InitializeComponent();

            chiptune = new SoundPlayer(Properties.Resources.chiptune);
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            try
            {
                chiptune.PlayLooping();
            } catch (Exception ex)
            {
                return;
            }
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                chiptune.Stop();
                chiptune.Dispose();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (btnMute.Text == "Mute")
            {
                btnMute.Text = "Play";
                chiptune.Stop();
            }
            else
            {
                btnMute.Text = "Mute";
                chiptune.PlayLooping();
            }
        }
    }
}
