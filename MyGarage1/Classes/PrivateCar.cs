using System;
using System.Collections.Generic;
using System.Text;
using MyGarage1.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace MyGarage1.Classes
{
    class PrivateCar : Vechile
    {
       private bool _kidSafe;
       private int _maxSpeed;

        //Constructors 
        public PrivateCar(int y,int pass,int km,string c,Date d,bool flag,int speed): base(y,pass,km,c,d)
        {
            this._kidSafe = flag;
            this._maxSpeed = speed;
        }
        public PrivateCar() : base() { }
        public PrivateCar(int x) : base(x) { }
    
        // Gets & Sets
        public bool getIfSafe()
        {
            return this._kidSafe;
        }
        public int getMaxSpeed()
        {
            return this._maxSpeed;
        }
        public void setIfSafe(bool f)
        {
            this._kidSafe=f;
        }
        public void setMaxSpeed(int s)
        {
            this._maxSpeed = s;
        }

        public override string fixTime()     // return string : KM until next fix
        {
            int temp=(15000-(this._km%15000));
            string s="You need a fix every 15000KM ,Next fix is about " +temp + " KM";
            return s;
        }

        public override string Horn()
        {
            string s = "PrivateCar siren";
            return s;
        }

        public override void move(Point p1)
        {
            this.setP(p1);
        }

        //public override void draw(Graphics g,string s)
        //{
        //    Image img = Image.FromFile(s); 
        //    SolidBrush br = new SolidBrush(Color.Red);
        //    Pen pen = new Pen(Color.Cyan, 2);
        //    g.DrawImage(img, p.X, p.Y);
        //    //g.FillEllipse(br, X - radius, Y - radius, 2 * radius, 2 * radius);
        //    //g.DrawEllipse(pen, X - radius, Y - radius, 2 * radius, 2 * radius);
        //}
        virtual public void Image_Paint(object sender, EventArgs e)
        {
            // Create image.
            //Image newImage = Image.FromFile(@"C:\Users\אריאל\source\repos\MyGarage1\MyGarage1\Resources\car1.png");

            //// Create Point for upper-left corner of image.
            //Point ulCorner = new Point(100, 100);

            //// Draw image to screen.
            //Graphics g ;
            //g.DrawImage(newImage, ulCorner);
        }
    }
}
