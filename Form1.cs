using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void form_Load(object sender, EventArgs e)
        {
            int panelWidth = (int)(this.ClientSize.Width * 0.9);
            int panelHeight = (int)(this.ClientSize.Height * 0.9);
            panel.Size = new Size(panelWidth, panelHeight);

            panel.Location = new Point(
                (this.ClientSize.Width - panelWidth) / 2,
                ((this.ClientSize.Height - panelHeight) / 2) + 12
            );
        }
    }
}
