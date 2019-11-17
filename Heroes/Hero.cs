using System;

namespace Heroes
{
    public class Hero
    {
        public Hero(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public string Name { get; private set; }
        public int Level { get; private set; }

        public void Action(Monster monster, Action action)
        {
            
        }
    }
}