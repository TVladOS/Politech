using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Triangle : Point
    {
        private int number;

        private Point point1;
        private Point point2;
        private Point point3;

        private Point vector1;
        private Point vector2;
        private Point vector3;

        public Triangle(int num, Point p1, Point p2, Point p3)
        {
            number = num;
            point1 = new Point();
            point2 = new Point();
            point3 = new Point();

            point1 = p1;
            point2 = p2;
            point3 = p3;

            vector1 = new Point();
            vector2 = new Point();
            vector3 = new Point();

            vector1 = p1.Vector(p2);
            vector2 = p3.Vector(p2);
            vector3 = p1.Vector(p3);
        }
        public bool IsTriangle()
        {
            if (vector1.VectorLnt() + vector2.VectorLnt() > vector3.VectorLnt()
                    && vector1.VectorLnt() + vector3.VectorLnt() > vector2.VectorLnt()
                        && vector3.VectorLnt() + vector2.VectorLnt() > vector1.VectorLnt())
                return true;
            else
                return false;
        }

        public bool IsOrthogonal()
        {
            if (vector1.VectorAngl(vector3) == 0 || vector2.VectorAngl(vector1) == 0 || vector3.VectorAngl(vector2) == 0)
                return true;
            else
                return false;
        }
        public double getP()
        {
            return Math.Round(vector1.VectorLnt() + vector2.VectorLnt() + vector3.VectorLnt(), 4);
        }

        public double getS()
        {
            double p = this.getP() / 2;
            return Math.Round(Math.Sqrt(p * (p - vector1.VectorLnt()) * (p - vector2.VectorLnt()) * (p - vector3.VectorLnt())), 4);
        }
        public override string ToString()
        {
            string triengl = "";
            if (this.IsOrthogonal())
                triengl = "\nПрямоугольный треугольник";
            else
                triengl = "\nТреугольник";
            if (this.IsTriangle())
            {
                return triengl + "(" + number + ") " + point1.Name + point2.Name + point3.Name + " :\n"
                        + "---------------\n" + "Точки:\n" + point1.ToString() + "\n" + point2.ToString() + "\n" + point3.ToString() + "\n"
                            + "---------------\n" + "Вектора:\n" + vector1.ToString() + "\n" + vector2.ToString() + "\n" + vector3.ToString() + "\n"
                                + "---------------\n" + "Длины сторон:\n" + vector1.Name + " : " + vector1.VectorLnt() + "\n" + vector2.Name + " : " + vector2.VectorLnt() + "\n" + vector3.Name + " : " + vector3.VectorLnt() + "\n"
                                    + "---------------\n" + "Углы треугольника (cos):\n" + point1.Name + " : " + vector1.VectorAngl(vector3) + "\n" + point2.Name + " : " + vector2.VectorAngl(vector1) + "\n" + point3.Name + " : " + vector3.VectorAngl(vector2) + "\n"
                                        + "---------------\n" + "Периметр треугольника:\n" + this.getP() + "\n"
                                            + "---------------\n" + "Площадь треугольника:\n" + this.getS() + "\n" + "---------------\n";
            }
            else
            {
                return "\nТреугольник не существует\n";
            }
        }
    }
}