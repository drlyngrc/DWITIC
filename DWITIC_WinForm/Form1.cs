using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWITIC_WinForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Upload upload = new Upload();
            upload.Show();

            this.Hide();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan();
            scan.Show();

            this.Hide();
        }
    }
}
