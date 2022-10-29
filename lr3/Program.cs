using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начальный");
            Chislo();
            Vichitanie();
            sloj();
            Step();
            Del();
        }
        static void Chislo()
        {
            Console.WriteLine("Два числа");
           
        }
        static void Vichitanie()

        {
            Console.WriteLine("Вычитание");
            
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