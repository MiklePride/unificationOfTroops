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
                "Родионов",
                "Басманов",
                "Кочевников",
                "Бортников",
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

            for (int i = 0; i < filteredSoldiers.Count; i++)
            {
                for (int j = 0; j < soldiers1.Count; j++)
                {
                    if (soldiers1[j] == filteredSoldiers[i])
                    {
                        soldiers1.RemoveAt(j);
                        j--;
                    }
                }
            }

            var unitedSoldiers = soldiers2.Union(filteredSoldiers).ToList();
            soldiers2 = unitedSoldiers;
        }
    }
}