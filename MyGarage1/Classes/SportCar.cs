using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace MyGarage1.Classes
{
    class SportCar : PrivateCar
    {
        private int _vEngine;
        public SportCar() : base() { }
        public SportCar(int x) : base(x) { }
        public SportCar(int y, int pass, int km, string c, Date d, bool flag, int speed, int v) : base(y, pass, km, c, d, flag, speed)
        {
            this._vEngine = v;
        }
        public int getVengine()
        {
            return this._vEngine;
        }
        public void setVengine(int v)
        {
            this._vEngine = v;
        }
        public override string Horn()
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\אריאל\source\repos\MyGarage1\MyGarage1\Resources\sounds\clown-horn.wav");
            sp.Play();
            string s = "Sport car horn";
            return s;
        }

    }
}
