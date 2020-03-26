using System;
using System.Linq;

namespace Лабораторная_2
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

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void Info()
        {
            Console.WriteLine("Длина стороны А {0}\nДлина стороны B {1}\nДлина стороны C {2}" +
                "\nПериметр: {3}\nПлощадь: {4}\n", A, B, C, Perimeter(), Area());
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Area()//Расчет площади
        {
            int p = (int)Perimeter();
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool Existence()//Проверка на существование тр-ка
        {
            bool res = ((a + b > c) || (b + c > a) || (c + a > b));
            if (res)
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

            public void Check()
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
                    

                    Console.ReadKey();

                }
            }
        }
    }
}

