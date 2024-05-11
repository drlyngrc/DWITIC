using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWITIC
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.Size = new Size(594, 328);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 554)
            {
                timer1.Stop();
                Main fm1 = new Main();
                fm1.Show();

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
