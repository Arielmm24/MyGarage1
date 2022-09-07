using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Media;

namespace MyGarage1.Classes
{
    class Truck : Vechile
    {
        private string _role;
        public Truck() : base() { }
        public Truck(int x) : base(x) { }
        public Truck(int y, int pass, int km, string c, Date d, string r) : base(y, pass, km, c, d)
        {
            this._role = r;
        }

        // Gets & Sets
        public string getRole()
        {
            return this._role;
        }
        public void setRole(string r)
        {
            this._role = r;
        }
        public override string fixTime()
        {
            int temp = (20000 - (this._km % 20000));
            string s = "You need a fix every 20000KM ,Next fix is about " + temp + " KM";
            return s;
        }

        public override string Horn()
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\אריאל\source\repos\MyGarage1\MyGarage1\Resources\sounds\truck horn1.wav");
            sp.Play();
            string s = "Truck Horn";
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
