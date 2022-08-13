using System;
using System.Collections.Generic;
using System.Linq;


namespace _22._07._2022___Lesson2._Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Uchastniki> uchastniki = new List<Uchastniki>();

            int count = Uchastniki.Vvod_age("Введите кол-во участников: ");

            for (int i = 0; i < count; i++)
            {
                uchastniki.Add(new Uchastniki(i+1));
            }

            void vyvod ()
            {
                Console.WriteLine("Все участники:");

                foreach (var item in uchastniki)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.WriteLine("[1] Добавить участника");
            Console.WriteLine("[2] Удалить участника");
            Console.WriteLine("[3] Изменить возраст");
            Console.WriteLine("[4] Изменить ФИО");
            switch (Console.ReadLine())
                {
                    case "1":
                        {
                        uchastniki.Add(new Uchastniki(uchastniki.Count + 1));
                        Console.WriteLine();
                        vyvod();
                        break;
                        }
                case "2":
                    {
                       vyvod();
                       Console.WriteLine("Введите ID участника: ");
                       uchastniki.RemoveAt(Uchastniki.EnterAge("Введите ID: ") - 1);
                       vyvod();
                       break;
                    }
                case "3":
                    {
                        vyvod();
                        Console.WriteLine("Введите ID участника: ");
                        int age = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите новый возраст: ");
                        uchastniki.ElementAt(age).Age = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        vyvod();
                        break;
                    }
                case "4":
                    {
                        vyvod();
                        Console.WriteLine("Введите ID участника: ");
                        int name = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите новое ФИО: ");
                        uchastniki.ElementAt(name).Name = String.Format(Console.ReadLine());
                        Console.WriteLine();
                        vyvod();
                        break;
                    }
                    default:
                        {
                            Console.WriteLine();
                            break;
                        }
            }
        }
    }
}
