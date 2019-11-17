using System;
using System.Text.Json;
using Heroes;
using Monster.AbilityAbstraction;
using Monster.DamageAbstraction;
using Monster.Monsters;

namespace DnDConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var girthGurdur = new Hero("Girth Gurdur", 5);
            var glabrezu = new Glabrezu();
            Console.WriteLine(glabrezu.HitPoints);
            glabrezu.TakeDamage(50, DamageType.Poison);
        }
    }
}