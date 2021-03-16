using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<County> Countries = new List<County>();
            while (true)
            {
                Console.WriteLine("1. Добавить");
                Console.WriteLine("2. Вывести все");
                ConsoleKeyInfo PressedKey = Console.ReadKey(true);
                if (PressedKey.KeyChar == '1')
                {
                    Console.WriteLine("Введите название: ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Введите форму правления: ");
                    string Form = Console.ReadLine();
                    Console.WriteLine("Введите площадь: ");
                    float Square = Convert.ToSingle(Console.ReadLine());
                    Countries.Add(new County(Name, Form, Square));
                    Console.Clear();
                }
                if (PressedKey.KeyChar == '2')
                {
                    for (int i = 0; i < Countries.Count; i++)
                    {
                        Console.WriteLine("Название: " + Countries[i].Name + " Форма правления: " + Countries[i].Form + " Площадь: " + Countries[i].Square);
                    }
                }
            }
        }
    }
}
