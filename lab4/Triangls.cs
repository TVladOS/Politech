using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Triangls : Point
    {
        BookT[] triangls;
        int LastTriangleNumber;
        public struct BookT
        {
            public int num;

            public Point p1;
            public Point p2;
            public Point p3;

            public double p;

            public double s;

            public bool isOrt;
            public BookT(int num, Point p1, Point p2, Point p3, double p, double s, bool isOrt)
            {
                this.num = num;
                this.p1 = p1;
                this.p2 = p2;
                this.p3 = p3;
                this.p = p;
                this.s = s;
                this.isOrt = isOrt;
            }
            public string BookToString()
            {
                string result = "";

                result = this.num + " (" + this.s + ");";

                return result;
            }

            public double getS()
            {
                return this.s;
            }

            public bool IsOrt()
            {
                return this.isOrt;
            }
        }
        public Triangls()
        {
            triangls = new BookT[0];
            LastTriangleNumber = -1;
        }

        public Triangls(int N)
        {
            triangls = new BookT[N];
            LastTriangleNumber = -1;
        }

        public bool addTriangle(int num, Point p1, Point p2, Point p3, double p, double s, bool isOrt)
        {
            if (LastTriangleNumber + 1 < triangls.Length)
            {
                triangls[++LastTriangleNumber] = new BookT(num, p1, p2, p3, p, s, isOrt);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < triangls.Length; i++)
            {
                result += triangls[i].BookToString() + Environment.NewLine;
            }

            return result;
        }
        public string ShowAllTriangls()
        {
            string triangl = "";
            for (int i = 0; i < triangls.Length; i++)
            {
                string name = "";
                if (triangls[i].IsOrt())
                    name = "\nПрямоугольный треугольник";
                else
                    name = "\nТреугольник";
                    triangl += "Загруженые значения:" +  name + "(" + triangls[i].num + ") " + triangls[i].p1.Name + triangls[i].p2.Name + triangls[i].p3.Name + " :\n"
                    + "---------------\n" + "Точки:\n" + triangls[i].p1.ToString() + Environment.NewLine + triangls[i].p2.ToString() + Environment.NewLine + triangls[i].p3.ToString() + Environment.NewLine
                        + "---------------\n" + "Вектора:\n" + triangls[i].p1.Vector(triangls[i].p2).ToString() + Environment.NewLine + triangls[i].p3.Vector(triangls[i].p2).ToString() + Environment.NewLine + triangls[i].p1.Vector(triangls[i].p3).ToString() + Environment.NewLine
                            + "---------------\n" + "Длины сторон:\n" + triangls[i].p1.Vector(triangls[i].p2).Name + " : " + triangls[i].p1.Vector(triangls[i].p2).VectorLnt() + Environment.NewLine + triangls[i].p3.Vector(triangls[i].p2).Name + " : " + triangls[i].p3.Vector(triangls[i].p2).VectorLnt() + Environment.NewLine + triangls[i].p1.Vector(triangls[i].p3).Name + " : " + triangls[i].p1.Vector(triangls[i].p3).VectorLnt() + Environment.NewLine
                                + "---------------\n" + "Углы треугольника (cos):\n" + triangls[i].p1.Name + " : " + triangls[i].p1.Vector(triangls[i].p2).VectorAngl(triangls[i].p1.Vector(triangls[i].p3)) + Environment.NewLine + triangls[i].p2.Name + " : " + triangls[i].p3.Vector(triangls[i].p2).VectorAngl(triangls[i].p1.Vector(triangls[i].p2)) + Environment.NewLine + triangls[i].p3.Name + " : " + triangls[i].p1.Vector(triangls[i].p3).VectorAngl(triangls[i].p3.Vector(triangls[i].p2)) + Environment.NewLine
                                    + "---------------\n" + "Периметр треугольника:\n" + triangls[i].p + Environment.NewLine
                                        + "---------------\n" + "Площадь треугольника:\n" + triangls[i].s + Environment.NewLine + "---------------\n";

            }
            return triangl;
        }
        public string ReturnResult()
        {
            string result = "";
            double min = 0, max = 0;
            bool minones = true;

            for (int i = 0; i < triangls.Length; i++)
            {
                if (minones)
                {
                    min = triangls[i].getS();
                    max = triangls[i].getS();
                    minones = false;
                }
                double newmin = triangls[i].getS();
                double newmax = triangls[i].getS();
                if (newmin < min)
                    min = newmin;
                if (newmax > max)
                    max = newmax;
            }

            int numMin = 0, numMax = 0;

            for (int i = 0; i < triangls.Length; i++)
            {
                if (min == triangls[i].getS())
                    numMin = i + 1;
                if (max == triangls[i].getS())
                    numMax = i + 1;
            }

            int numFirst = 0, numSecond = 0;
            string sameT = "";

            for (int i = 0; i < triangls.Length; i++)
            {
                for (int t = 0; t < triangls.Length; t++)
                {
                    if (triangls[i].IsOrt() && triangls[t].IsOrt())
                    {
                        if (triangls[i].getS() == triangls[t].getS() && i != t)
                        {
                            numFirst = t + 1;
                            numSecond = i + 1;
                            sameT = "Номера одинаковых прямоугольных треугольнтков :" + numFirst + "," + numSecond + ".";
                            break;
                        }
                        else
                        {
                            sameT = "Нет одиноковых прямоугольных треугольников.";
                        }
                    }
                }
            }

            return result =  "Минимальная площадь (" + min + "). У треугольника №" + numMin + ";" + Environment.NewLine
                                + "Максимальная площадь (" + max + ") .У треугольника №" + numMax + ";" + Environment.NewLine
                                    + sameT + Environment.NewLine;
        }
        public void saveTo(string path)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    foreach (BookT s in triangls)
                    {
                        writer.Write(s.num);

                        writer.Write(s.p1.Name);
                        writer.Write(s.p1.X);
                        writer.Write(s.p1.Y);

                        writer.Write(s.p2.Name);
                        writer.Write(s.p2.X);
                        writer.Write(s.p2.Y);

                        writer.Write(s.p3.Name);
                        writer.Write(s.p3.X);
                        writer.Write(s.p3.Y);

                        writer.Write(s.p);
                        writer.Write(s.s);
                        writer.Write(s.isOrt);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}