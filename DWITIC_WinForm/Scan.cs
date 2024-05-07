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
    public partial class Scan : Form
    {
        public Scan()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            this.Hide();
        }

        private void btnScanNow_Click(object sender, EventArgs e)
        {

        }

        private void btnClassify_Click(object sender, EventArgs e)
        {

        }
    }
}
