using System;

namespace Лабораторная_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lab_1, Task 18\n");
            Console.WriteLine("Insert the number: ");

            double n = Convert.ToDouble(Console.ReadLine()); ;
            double result = Math.Pow((n), 3);

            
            Console.WriteLine("\nResult: " + result);
        }
    }
}
