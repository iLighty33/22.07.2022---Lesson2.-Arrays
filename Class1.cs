using System;
using System.Collections.Generic;
using System.Linq; // язык в языке.
using System.Text; // Для работы со string
using System.Threading.Tasks; // работа с многопоточностью

// namespace - название проекта
namespace _22._07._2022___Lesson2._Arrays
{
    // Участники соревнований по спортивному ориентированию
   public class Uchastniki
    {

        string Vvod(string text)
        {
             Console.Write(text);
            return Console.ReadLine();
        }

       public static int Vvod_age(string text)
        {

            try
            {
                Console.Write(text);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Вы ввели что-то не то, попробуйте заново\n");
                
                return Vvod_age(text);
            }
        }

            public Uchastniki(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public static int EnterAge(string text)
        {

            try
            {
                Console.Write(text);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Вы ввели что-то не то, попробуйте заново\n");

                return EnterAge(text);
            }
        }

        public Uchastniki(int id)
        {
            Id = id;
            Name = Vvod("Введите ФИО участника: ");
            Age = Vvod_age("Введите возраст участника: ");
        }

       

        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID Участника: {Id} \nФИО Участника: {Name}\nВозраст Участника: {Age}";
        }
    }
}
