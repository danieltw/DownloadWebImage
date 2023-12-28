using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadWebImage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.MainIcon;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbxFileExt.SelectedIndex = 0;
            cbxConCurrentAction.SelectedIndex = 0;
        }
    }
}
