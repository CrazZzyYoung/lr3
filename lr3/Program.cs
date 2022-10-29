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
        }
        
        static void sloj()
        {
            Console.WriteLine("Сложение");
            
        }

        static void Step()
        {
            Console.WriteLine("Степень");
        }
    }
}