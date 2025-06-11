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
        //Constructor
        public form()
        {
            InitializeComponent();
        }
        
        //Functions
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            PointF point1 = new PointF((this.Size.Width / 2), (this.Size.Height / 2) - 150.0f);
            PointF point2 = new PointF((this.Size.Width / 2) + 150.0f, (this.Size.Height / 2) + 150.0f);
            PointF point3 = new PointF((this.Size.Width / 2) - 150.0f, (this.Size.Height / 2) + 150.0f);

            using (Pen outlinePen = new Pen(Color.Black, 5))
            {
                g.DrawLine(outlinePen, point1, point2);
                g.DrawLine(outlinePen, point2, point3);
                g.DrawLine(outlinePen, point3, point1);
            }
        }

        private void Generate(object sender, EventArgs e)
        {
            La.Text = a.Value.ToString();
            Lb.Text = b.Value.ToString();
            Lc.Text = c.Value.ToString();
        }

        //Operations
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.Value = 0;
            b.Value = 0;
            c.Value = 0;
            Generate(sender, e);
        }
    }
}
