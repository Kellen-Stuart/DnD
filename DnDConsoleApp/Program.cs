

using System;
using System.Collections.Generic;
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
        }
    }
}