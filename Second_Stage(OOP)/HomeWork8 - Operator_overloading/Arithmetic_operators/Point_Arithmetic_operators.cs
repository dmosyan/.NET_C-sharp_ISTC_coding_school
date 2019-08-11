using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    class Point_Arithmetic_operators
    {
        private int x,y;

        public Point_Arithmetic_operators(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point_Arithmetic_operators operator +(Point_Arithmetic_operators p1, Point_Arithmetic_operators p2)
        {
            return new Point_Arithmetic_operators(p1.x + p2.x, p1.y + p2.y);
        }
        public static Point_Arithmetic_operators operator -(Point_Arithmetic_operators p1, Point_Arithmetic_operators p2)
        {
            return new Point_Arithmetic_operators(p1.x - p2.x, p1.y - p2.y);
        }
        public static Point_Arithmetic_operators operator *(Point_Arithmetic_operators p1, Point_Arithmetic_operators p2)
        {
            return new Point_Arithmetic_operators(p1.x * p2.x, p1.y * p2.y);
        }
        public static Point_Arithmetic_operators operator /(Point_Arithmetic_operators p1, Point_Arithmetic_operators p2)
        {
            return new Point_Arithmetic_operators(p1.x / p2.x, p1.y / p2.y);
        }
        public static Point_Arithmetic_operators operator %(Point_Arithmetic_operators p1, Point_Arithmetic_operators p2)
        {
            return new Point_Arithmetic_operators(p1.x % p2.x, p1.y % p2.y);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", this.x, this.y);
        }


    }
}
