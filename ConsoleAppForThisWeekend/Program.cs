using System;
using System.Collections.Generic;
using Common.Monsters.Glabrezu;

namespace ConsoleAppForThisWeekend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter players manually rolled initiative
            Dictionary<string, int> initiative = new Dictionary<string, int>
            {
                { "Zazu", 5 },
                { "Girth", 5 }
            };
            
            // Create monsters
            var glabrezu = new Glabrezu();
            var glabrezu2 = new Glabrezu();
            
            // Add monsters to init dict
            
            // Sort the list by initiative
            
            // Execute turns based one by one until monsters are dead
        }
    }
}