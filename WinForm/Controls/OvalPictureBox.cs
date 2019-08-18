using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UI.Controls
{
    public partial class OvalPictureBox : PictureBox
    {
        public OvalPictureBox()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(215, 218, 221);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, Width, Height));
                Region = new Region(gp);
            }
        }
    }
}
