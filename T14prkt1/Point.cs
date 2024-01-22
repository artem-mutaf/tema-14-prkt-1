using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14prkt1
{
    class Point
    {
        double x;

        double y;
        static int count;

        

        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {
            x = 1.0;
            y = 1.0;
        }
        static Point()
        {
            int count = 0;
        }
        public double GetX
        {
            get { return x; }
            set { x = value; }
        }
        public double GetY
        {
            get{ return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return $"{x}\n{y}\n{count}";
        }
    }
}
