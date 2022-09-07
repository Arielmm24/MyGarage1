using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using MyGarage1.Classes;

namespace MyGarage1.Classes
{
    class MiniCar : PrivateCar
    {
        private int fuelTank;
        public MiniCar() : base() { }
        public MiniCar(int x) : base(x) { }
        public MiniCar(int y, int pass, int km, string c, Date d, bool flag, int speed, int f) : base(y, pass, km, c, d, flag, speed)
        {
            this.fuelTank = f;
        }
        public int getFuel()
        {
            return this.fuelTank;
        }
        public void setFuel(int f)
        {
            this.fuelTank = f;
        }
        public override string Horn()
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\אריאל\source\repos\MyGarage1\MyGarage1\Resources\sounds\mini-horn.wav");
            sp.Play();
            string s = "Sport car horn";
            return s;
        }

    }
}
