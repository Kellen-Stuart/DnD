using System.Collections.Generic;
using Common.Abstractions.DamageTypes;

namespace Common.Abstractions.Actions
{
    // What do ranged and melee have in common?
    public abstract class Attack : Action
    {
        public DamageType DamageType { get; protected set; }
        
        public int Range { get; protected set; }
        
        // Did the attack hit or not?
        public bool Hit { get; protected set; }
        
        public abstract void Execute();

        public abstract void Execute(Character.Character character);

        public abstract void Execute(IEnumerable<Character.Character> characters);
    }
}