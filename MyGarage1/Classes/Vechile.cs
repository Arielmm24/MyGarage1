using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;

namespace MyGarage1.Classes

{
    [Serializable]
    abstract class Vechile
    {
        public int _year;
        public int _passenger_load;
        public int _km;
        public string _company;
        public Date _lastFix;
        public Point p;
        Image _img { get; set; }

        //Constructors
        public Vechile()
        {
        }
        public Vechile(int x)
        {
            _km = x;
        }
        public Vechile(int y,int pass,int km,string c,Date d)
        {
            this._year = y;
            this._passenger_load = pass;
            this._km = km;
            this._company = c;
            this._lastFix.setDay(d.getDay());
            this._lastFix.setMonth(d.getMonth());
            this._lastFix.setYear(d.getYear());
        }
        public Vechile(Vechile v)
        {
            this._year = v._year;
            this._passenger_load = v._passenger_load;
            this._km = v._km;
            this._company = v._company;
            this._lastFix.setDay(v._lastFix.getDay());
            this._lastFix.setMonth(v._lastFix.getMonth());
            this._lastFix.setYear(v._lastFix.getYear());
        }

        internal bool isInside(int xP, int yP)
        {
            if ((113 < Math.Abs(xP - p.X)) && (Math.Abs(xP - p.X) < 780) && (223 < Math.Abs(yP - p.Y)) && (Math.Abs(yP - p.Y) < 686))
                return true;
            else
                return false;
        }

        // Gets & Sets
        public int getYear()
        {
            return _year;
        }
        public int getPassLoad()
        {
            return _passenger_load;
        }
        public int getKM()
        {
            return _km;
        }
        public string getCompany()
        {
            return _company;
        }
        public Date getLastFix()
        {
            return _lastFix;
        }
        public Point getP()
        {
            return this.p;
        }
        public void setYear(int y)
        {
            this._year = y;
        }
        public void setPassLoad(int x)
        {
            this._passenger_load = x;
        }
        public void setKM(int k)
        {
            this._km= k;
        }
        public void setCompany(string s)
        {
            this._company = s;
        }
        public void setLastFix(Date d)
        {
            this._lastFix.setDay(d.getDay());
            this._lastFix.setMonth(d.getMonth());
            this._lastFix.setYear(d.getYear());
        }
        public void setP(Point p1)
        {
            this.p = p1;
        }
        public void setP(int x,int y)
        {
            this.p.X=x;
            this.p.Y = y;
        }

        public abstract string fixTime();     // return date of the next fixTime
        public abstract string Horn();       // return the horn noise of the specipic vechile
        public abstract void move(Point p1);          // represent the movement in the garage
        public void draw(Graphics g,string s)
        {
            Image img = Image.FromFile(s);
            SolidBrush br = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Cyan, 2);
            g.DrawImage(img, p.X, p.Y);
        }

        [Serializable]
        public class VechileList
        {
            protected SortedList vechiles;

            public VechileList()
            {
                vechiles = new SortedList();
            }
            public int NextIndex
            {
                get
                {
                    return vechiles.Count;
                }
                //!!!
                // !! there is no set !!
            }
            public Vechile this[int index]
            {
                get
                {
                    if (index >= vechiles.Count)
                        return (Vechile)null;
                    //SortedList internal method
                    return (Vechile)vechiles.GetByIndex(index);
                }
                set
                {
                    if (index <= vechiles.Count)
                        vechiles[index] = value; //!!!		
                }
            }

            public void Remove(int element)
            {
                if (element >= 0 && element < vechiles.Count)
                {
                    for (int i = element; i < vechiles.Count - 1; i++)
                        vechiles[i] = vechiles[i + 1];
                    vechiles.RemoveAt(vechiles.Count - 1);
                }
            }

            // new method
            public void DrawAll(Graphics g)
            {
                //    Vechile prev, cur;
                //    for (int i = 1; i < vechiles.Count; i++)
                //    {
                //        prev = (Vechile)vechiles[i - 1];
                //        cur = (Vechile)vechiles[i];
                //        g.DrawLine(Pens.Yellow, prev.p.X, prev.p.Y, cur.p.X, cur.p.Y);

                //        ((Vechile)vechiles[i]).draw(g);
                //    }
                //    for (int i = 0; i < vechiles.Count; i++)
                //        ((Vechile)vechiles[i]).draw(g);
            }

            
        }
    }
}
