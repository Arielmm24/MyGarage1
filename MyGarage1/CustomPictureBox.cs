using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGarage1.Classes
{
    public class CustomPictureBox : PictureBox
    {
        Point point;
        public SoundPlayer sp;
        public CustomPictureBox(IContainer container)
        {
            container.Add(this);
        }
        
        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)   // Move object
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
                
            }
            //else
            //    if (e.Button == MouseButtons.Right)
            //    this.Visible = false;
            //base.OnMouseMove(e);
        }
        protected override void OnMouseClick(MouseEventArgs e)    // Delete objects at right click
        {
            if (e.Button == MouseButtons.Right)
                this.Visible = false;
            base.OnMouseMove(e);
        }
        protected override void OnMouseHover(EventArgs e)    // show text when cursor is on for a moment
        {
            base.OnMouseHover(e);
        }
    }
}
