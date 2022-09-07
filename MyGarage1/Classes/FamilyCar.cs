using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace MyGarage1.Classes
{
    internal class FamilyCar : PrivateCar
    {
        private int _storge;
        public FamilyCar(int y, int pass, int km, string c, Date d,bool flag, int speed,int s) : base(y, pass, km, c, d,flag,speed)
        {
            this._storge = s;
        }
        public FamilyCar() : base() { }
        public FamilyCar(int x) : base(x) { }

        public int getStorge()
        {
            return this._storge;
        }
        public void setStorge(int s)
        {
            this._storge = s;
        }
        public override string Horn()
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\אריאל\source\repos\MyGarage1\MyGarage1\Resources\sounds\carhorn.wav");
            sp.Play();
            string s = "Family car horn";
            return s;
        }
    }
}
