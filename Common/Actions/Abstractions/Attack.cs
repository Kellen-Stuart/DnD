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
        protected Character Assailant;
        
        protected Attack(Character assailant)
        {
            Assailant = assailant;
        }

        public abstract void Execute(Character victim);
        public abstract void Execute(ICollection<Character> victims);
    }
}