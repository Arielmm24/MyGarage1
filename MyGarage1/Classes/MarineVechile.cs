using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MyGarage1.Classes
{
    class MarineVechile : Vechile
    {
        private int _weight;
        public MarineVechile(int y, int pass, int km, string c, Date d, int w) : base(y, pass, km, c, d)
        {
            this._weight = w;
        }
        public int getWeight()
        {
            return this._weight;
        }
        public void setWeight(int w)
        {
            this._weight = w;
        }
        public override string fixTime()
        {
            int temp = (this._km % 8000);
            string s = "Next fix is about " + temp + " days";
            return s;
        }

        public override string Horn()
        {
            string s = "Sea Ride Horn";
            return s;
        }

        public override void move(Point p1)
        {
            this.setP(p1);
        }

        //public override void draw(Graphics g)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
