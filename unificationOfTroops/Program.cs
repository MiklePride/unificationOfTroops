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
                "Родионов",
                "Островерх",
                "Усманов",
                "Колесников",
                "Наливкин",
                "Нектаров"
            };

            var filteredSoldiers = soldiers1.Where(soldier => soldier.StartsWith("Б")).ToList();
            var unitedSoldiers = soldiers2.Union(filteredSoldiers).ToList();
            soldiers2 = unitedSoldiers;
        }
    }
}