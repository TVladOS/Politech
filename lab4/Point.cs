using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Point
    {
        String name;
        int x;
        int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public string Name { get => name; set => name = value; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point(String name, int x, int y) : this(x, y)
        {
            this.Name = name;
        }
        public Point() : this(0, 0)
        {
        }

        public Point Vector(Point P)
        {
            int x1 = P.X - this.X;
            int y1 = P.Y - this.Y;
            return new Point(this.Name + P.Name, x1, y1);
        }
        public double VectorLnt()
        {
            return Math.Round(Math.Abs(Math.Sqrt(Math.Pow((this.X), 2) + Math.Pow((this.Y), 2))), 4);
        }

        public double VectorAngl(Point P)
        {
            return Math.Round((this.X * P.X + this.Y * P.Y) / (this.VectorLnt() * P.VectorLnt()), 4);
        }
        public override string ToString()
        {
            return this.Name + " (" + this.X + "," + this.Y + ");";
        }
    }
}
