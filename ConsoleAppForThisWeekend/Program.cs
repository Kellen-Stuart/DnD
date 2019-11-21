using System;
using System.Collections.Generic;
using System.Linq;
using Common.Abstractions;
using Common.Abstractions.Character;
using Common.Monsters.Glabrezu;

namespace ConsoleAppForThisWeekend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Monsters
            var glabrezu = new Glabrezu();
            var glabrezu2 = new Glabrezu();
            
            // Create Player Characters
            
            
            // Create List of PhysicalObject
            List<Character> characters = new List<Character>
            {
                glabrezu,
                glabrezu2
            };
            
            // Sort by initiative  
            characters = characters.OrderBy(x => x.Initiative).ToList();
            
            

        }
    }
}