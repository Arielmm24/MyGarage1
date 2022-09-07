using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage1.Classes
{
    class Date
    {
        public int _day;
        public int _month;
        public int _year;

        //Constructors
        public Date()
        {
            _day = 0;
            _month = 0;
            _year = 0;
        }
       public Date(int d , int m , int y)
        {
            _day = d;
            _month = m;
            _year = y;
        }
        public Date(Date d)
        {
            _day = d._day;
            _month = d._month;
            _year = d._year;
        }
        public Date (DateTime t)
        {
            _day = t.Day;
            _month = t.Month;
            _year = t.Year;
        }

        //Gets & Sets
        public int getDay()
        {
            return _day;
        }
        public int getMonth()
        {
            return _month;
        }
        public int getYear()
        {
            return _year;
        }
        public void setDay(int x) {
            _day = x;
        }
        public void setMonth(int x)
        {
            _month = x;
        }
        public void setYear(int x)
        {
            _year = x;
        }

        public Date subDates(Date d)          // sub : thisDate - Date
        {
            Date t = new Date();
            t._day = this._day - d._day;
            t._month = this._month - d._month;
            t._year = this._year - d._year;

            return t;
        }
        public Date subDates(int d,int m,int y)          // sub : thisDate - d/m/y
        {
            Date t = new Date();
            t._day = this._day - d;
            t._month = this._month - m;
            t._year = this._year - y;

            return t;
        }
        public int subDates(Vechile v)          // returns Now - this.date in days
        {

            int subSum;
            DateTime t = DateTime.Now;
            subSum = (t.Day - this._day) % 30 + (t.Month - this._month) % 12 * 30 ;
            return subSum;
        }
        public static Date operator -(Date d) => -d;
        public void print()               // print d/m/y
        {
            Console.WriteLine(_day + " / " + _month + " / " + _year);
        }
        public string toS()
        {
            string s = "days until fixTime: " + (_day + _month * 30);
            return s;
        }
    }
}
