using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Common.Weapons;

namespace Common.Actions.Abstractions
{
    public abstract class MeleeWeaponAttack : Attack
    {
        public Weapon Weapon { get; private set; }
        
        protected MeleeWeaponAttack(Character assailant, Weapon weapon) : base(assailant)
        {
            Weapon = weapon;
        }

        public abstract override void Execute(Character victim);

        public abstract override void Execute(ICollection<Character> victims);
    }
}