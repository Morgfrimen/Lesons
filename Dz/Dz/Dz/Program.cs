using System;
using System.Collections.Generic;

namespace Dz
{
    class Program
    {
        static List<Gruz> Gruzs = new List<Gruz>();
        static List<Legko> Legkos = new List<Legko>();
        static void Main(string[] args)
        {
            Start();
        }
        static uint GetDataUInt(string v)
        {
            uint x = 0;
            string s;
            bool error = true;
            while (error)
            {
                try
                {
                    s = GetDataString(v);
                    x = Convert.ToUInt32(s);
                    error = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!");
                }
            }
            return x;
        }
        static double GetDataDouble(string v)
        {
            double x = 0;
            string s;
            bool error = true;
            while (error)
            {
                try
                {
                    s = GetDataString(v);
                    x = Convert.ToDouble(s);
                    error = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!");
                }
            }
            return x;
        }
        static string GetDataString(string v)
        {
            Console.Write(v);
            string x = Console.ReadLine();
            return x;
        }
        static uint GetMenu()
        {
            uint x = 0;
            bool error = true;
            while (error)
            {
                try
                {
                    Console.WriteLine("1. Посмотреть все грузовые автомобили");
                    Console.WriteLine("2. Посмотреть все легковые автомобили");
                    Console.WriteLine("3. Добавить грузовой автомобиль");
                    Console.WriteLine("4. Добавить легковой автомобиль");
                    string s = Console.ReadLine();
                    x = Convert.ToUInt32(s);
                    if (x >= 1 && x <= 4) error = false;
                    else
                    {
                        Console.WriteLine("Нет такого пункта меню");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!");
                }
            }
            Console.WriteLine();
            return x;
        }
        private static void AddGruz()
        {
            Gruz gruz = new Gruz();
            gruz.MaxWeight = GetDataDouble("Введите максимальный вес: ");
            Console.WriteLine();
            Gruzs.Add(gruz);
        }
        private static void AddLegko()
        {
            bool error = true;
            while (error)
            {
                Legko legko = new Legko();
                legko.Prestige = GetDataUInt("Введите пристижность(1-Бизнес 2-Бюджет 3-Люкс): ");
                if (legko.Prestige == 1 || legko.Prestige == 2 || legko.Prestige == 3)
                {
                    Console.WriteLine();
                    Legkos.Add(legko);
                    error = false;
                }
                else
                {
                    Console.WriteLine("Нет такой престижности");
                }
            }
        }
        private static void ShowGruz()
        {
            if (Gruzs.Count == 0)
            {
                Console.WriteLine("Грузовые автомобили на складе отсутствуют");
            }
            else
            {
                for (int index = 0; index < Gruzs.Count; index++)
                {
                    Gruz gruz = Gruzs[index];
                    Console.WriteLine($"{index + 1}. Максимальный вес: {gruz.MaxWeight}");
                    Console.WriteLine();
                }
            }
        }
        private static void ShowLegko()
        {
            if (Legkos.Count == 0)
            {
                Console.WriteLine("Легковые автомобили на складе отсутствуют");
            }
            else
            {
                for (int index = 0; index < Legkos.Count; index++)
                {
                    Legko legko = Legkos[index];
                    string str = null;
                    switch (legko.Prestige)
                    {
                        case 1:
                            str = "Бизнес";
                            break;
                        case 2:
                            str = "Бюджет";
                            break;
                        case 3:
                            str = "Люкс";
                            break;
                    }
                    Console.WriteLine($"{index + 1}. Вы выбрали престижность: {str}");
                    Console.WriteLine();
                }
            }
        }
        private static void Start()
        {
            while (true)
            {
                
                switch (GetMenu())
                {
                    case 1:
                        ShowGruz();
                        break;
                    case 2:
                        ShowLegko();
                        break;
                    case 3:
                        AddGruz();
                        break;
                    case 4:
                        AddLegko();
                        break;
                }
            }
        }
    }
}
