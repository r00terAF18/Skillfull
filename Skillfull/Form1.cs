using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Skillfull;

namespace Skillfull
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnCopyCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("document.cookie");
            statusStripLbl.Text = "Command copied to the clipboard";
        }

        private void cookieTxt_TextChanged(object sender, EventArgs e)
        {
            statusStripLbl.Text = "Cookies entered successfully";
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cookieTxt.Text) || String.IsNullOrWhiteSpace(cookieTxt.Text))
            {
                statusStripLbl.Text = "Cookies must be pressent, please paste them in";
            }
            if (String.IsNullOrEmpty(urlTxt.Text) || String.IsNullOrWhiteSpace(urlTxt.Text))
            {
                statusStripLbl.Text = "How am I supposed to know which course to download, give me a link you dum dum XD";
            }

            string appArg = $"-c \"{cookieTxt.Text}\" -i \"{urlTxt.Text}\"";
            // MessageBox.Show(appArg);
            string appPath = Path.Combine(Directory.GetCurrentDirectory(), "main.exe");
            // Process.Start(appPath, appArg);
            Downloader dl = new Downloader(cookieTxt.Text, urlTxt.Text);
        }

        //public static void runCommand(string appPath, string appArg)
        //{

        //}
    }
}
