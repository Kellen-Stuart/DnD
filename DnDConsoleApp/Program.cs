﻿using System;
using System.Collections.Generic;
using System.Linq;
using Common;
using Common.Abstractions.Actions.BasicActions;
using Common.Abstractions.Character;
using Common.Monsters.Glabrezu;

namespace DnDConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var glabrezu = new Glabrezu(new Point(0, 0));
            var goodGlabrezu = new Glabrezu(new Point(1, 0));

            while (glabrezu.HitPoints > 0 && goodGlabrezu.HitPoints > 0)
            {
                Console.WriteLine("Glabrezu's Turn");
                PerformTurn(glabrezu, goodGlabrezu);
                Console.WriteLine($"Good Glabrezu's health is now {goodGlabrezu.HitPoints}");

                Console.WriteLine("Good Glabrezu's Turn");
                PerformTurn(goodGlabrezu, glabrezu);
                Console.WriteLine($"Glabrezu health is now {glabrezu.HitPoints}");
            }

            if (glabrezu.HitPoints > 0)
                Console.WriteLine("Glabrezu Wins!");
            else
            {
                Console.WriteLine("Good Glabrezu Wins!");
            }
        }

        public static void PerformTurn(Character character, Character enemy)
        {
            Console.WriteLine("Actions:");
            var count = 0;
            foreach (var action in character.Actions)
            {
                Console.WriteLine($"{count}: {action.ToString().Substring(action.ToString().LastIndexOf('.') + 1)}");
            }

            int choice = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine("");
            character.Actions.ElementAt(choice).Execute(enemy);
        }
    }
}