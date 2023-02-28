using System;
using System.Collections.Generic;
using System.Linq;

namespace unificationOfTroops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> soldiers1 = new List<string>
            {
                "Бортников",
                "Басманов",
                "Кочевников",
                "Родионов",
                "Усачев",
                "Купер"
            };

            List<string> soldiers2 = new List<string>
            {
                "Зуйбалов",
                "Островерх",
                "Усманов",
                "Колесников",
                "Наливкин",
                "Нектаров"
            };

            ShowSoldiers(soldiers1);
            ShowSoldiers(soldiers2);

            var filteredSoldiers = soldiers1.Where(soldier => soldier.StartsWith("Б")).ToList();
            soldiers2 = soldiers2.Union(filteredSoldiers).ToList();

            soldiers1 = soldiers1.Except(soldiers2).ToList();

            ShowSoldiers(soldiers1);
            ShowSoldiers(soldiers2);
            Console.ReadLine();
        }

        static void ShowSoldiers(List<string> soldiers)
        {
            foreach (var soldier in soldiers) 
            {
                Console.WriteLine(soldier);
            }

            Console.WriteLine();
        }
    }
}