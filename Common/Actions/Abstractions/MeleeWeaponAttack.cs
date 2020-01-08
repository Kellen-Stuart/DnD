using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Common.Weapons;

namespace Common.Actions.Abstractions
{
    public abstract class MeleeWeaponAttack : Attack
    {
        public Weapon Weapon { get; private set; }
        
        protected MeleeWeaponAttack(DamageType damageType, int range, Weapon weapon) : base(damageType, range)
        {
            Weapon = weapon;
        }

        public abstract override void Execute(Character character);

        public abstract override void Execute(ICollection<Character> characters);
    }
}