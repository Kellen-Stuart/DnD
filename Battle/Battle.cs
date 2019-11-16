using System.Collections.Generic;

namespace Battle
{
    public class Battle
    {
        public IEnumerable<Hero> Heroes { get; private set; }
        public IEnumerable<Monster.MonsterAbstraction.Monster> Monsters { get; private set; }

        public Battle(IEnumerable<Hero> heroes, IEnumerable<Monster.MonsterAbstraction.Monster> monsters)
        {
            Heroes = heroes;
            Monsters = monsters;
        }
    }

    public class Hero
    {
        public string Name { get; private set; }
        public int Initiative { get; private set; }

        public Hero(string name, int initiative)
        {
            Name = name;
            Initiative = initiative;
        }
    }
}