using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная 2а
{

    
        class Triangle
        {
            private double a;//катет
            private double b;//катет
            private double c;//гипотенуза

            public double A
            {
                get
                {
                    return a;
                }
                set
                {
                    a = value;
                }
            }

            public double B
            {
                get
                {
                    return b;
                }
                set
                {
                    b = value;
                }
            }

            public double C
            {
                get
                {
                    return c;
                }
                set
                {
                    c = value;
                }
            }
        public Triangle() { }

            public Triangle(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }

            public void Info()
            {
                Console.WriteLine("Длина стороны А {0}\nДлина стороны B {1}\nДлина стороны C {2}" +
                    "\nПериметр: {3}\nПлощадь: {4}\n", A, B, C, Perimetr(), Area());
            }

            public double Perimetr()
            {
                return A + B + C;
            }

            public double Area()//Расчет площади
            {
                int p = (int)Perimetr();
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }

            public bool Sushest()//Проверка на существование тр-ка
            {
                bool res = ((a + b < c) || (b + c > a) || (c + a > b));
                if (res == true)
                {
                    Console.WriteLine("Треугольник существует");
                }
                else
                {
                    Console.WriteLine("Треугольник не существует");
                }
                return res;
            }

            public void Angle2()
            {
                Console.WriteLine("Углы: ");
                Console.WriteLine("{0:F3}", Math.Acos((B * B + C * C - A * A) / (2 * B * C)) * 180 / Math.PI);
                Console.WriteLine("{0:F3}", Math.Acos((A * A + C * C - B * B) / (2 * A * C)) * 180 / Math.PI);
                Console.WriteLine("{0:F3}", Math.Acos((A * A + B * B - C * C) / (2 * A * B)) * 180 / Math.PI);
            }

            public double MaxArea(params double[] a)//принимает массив площадей
            {
                return a.Max();//используя стандартный метод массива возвр максимальный элемент
            }
            class RectangTriangle : Triangle
            {
                public RectangTriangle(double a, double b, double c) : base(a, b, c)
                {
                    //используем конструктор базового класса
                }

                public void PryamouglChiNe()
                {
                    if ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A))
                    {
                        Console.WriteLine("Треугольник прямоугольный");
                    }
                    else
                    {
                        Console.WriteLine("Треугольник не прямоугольный");
                    }
                }

                public double MinGipot(params double[] a)
                {
                    return a.Min();
                }
                class Program
                {

                    static void Main(string[] args)
                    {

                    Triangle t1 = new Triangle();

                    t1.A = 3;
                    t1.B = 4;
                    t1.C = 5;
                    Console.WriteLine(t1.ToString());

                    Triangle t2 = new Triangle(2, 6, 5);

int k = 3;
                    Triangle[] triangles = new Triangle[k];
                    Random r = new Random();
                    double square = 0;
                    int realTriangles = 0;

                   

                    Console.WriteLine("Average square of " + realTriangles + " triangles is: " + square / realTriangles);
                    Console.ReadKey();

                    }
                }
            }
        }

    }

