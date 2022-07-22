using System;
using System.Collections.Generic;

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
            switch (Console.ReadLine())
                {
                    case "1":
                        {
                        uchastniki.Add(new Uchastniki(uchastniki.Count + 1));
                        /*Array.Resize(ref uchastniki, uchastniki.Length + 1);
                        uchastniki[uchastniki.Length - 1] = new Uchastniki(uchastniki.Length);*/
                        vyvod();
                            break;
                        }
                case "2":
                    {
                       vyvod();
                       uchastniki.RemoveAt(Uchastniki.EnterAge("Введите ID: ") - 1);
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
