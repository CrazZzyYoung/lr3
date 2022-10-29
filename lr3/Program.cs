using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начальный");
            sloj();
            Step();
            Del();
        }
        
        static void sloj()
        {
            Console.WriteLine("Сложение");
            
        }

        static void Step()
        {
            Console.WriteLine("Степень");
            
        }
        static void Del()
        {
            Console.WriteLine("деление");
        }
    }
}