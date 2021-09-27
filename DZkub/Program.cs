using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = true;
            while (error)
            {
                try
                {
                    Console.WriteLine("Введите число");
                    double chislo = Convert.ToInt32(Console.ReadLine());
                    chislo = chislo * chislo * chislo;
                    Console.WriteLine($"Это число в кубе: {chislo}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!");
                    
                }
            }
        }
    }
}
