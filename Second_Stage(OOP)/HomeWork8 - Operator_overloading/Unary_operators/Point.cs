using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unary_operators
{
    class Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator ++(Point p1)
        {
            return new Point(p1.x + 1, p1.y + 1);
        }
        public static Point operator --(Point p1)
        {
            return new Point(p1.x - 1, p1.y - 1);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", this.x, this.y);
        }
    }
}
