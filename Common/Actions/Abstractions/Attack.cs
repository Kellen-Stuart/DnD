using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;

namespace Common.Actions.Abstractions
{
    // An attack is something that does damage
    // There's two types of attacks
    // 1) Melee Attack
    // 2) Spell Attack
    public abstract class Attack : IAction
    {
        // Both spells and melee attacks have a range
        protected readonly int Range;

        // There is a SINGULAR damage type per attack
        protected readonly DamageType DamageType;

        protected Attack(DamageType damageType, int range)
        {
            Range = range;
        }


        public abstract void Execute(Character character);
        public abstract void Execute(ICollection<Character> characters);
    }
}