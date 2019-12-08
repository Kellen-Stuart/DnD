using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Common.Weapons.Abstractions;

namespace Common.Actions.Abstractions
{
    public abstract class MeleeWeaponAttack : Attack
    {
        public Weapon Weapon { get; private set; }
        
        protected MeleeWeaponAttack(DamageType damageType, int range, Weapons.Abstractions.Weapon weapon) : base(damageType, range)
        {
            Weapon = weapon;
        }
        
        public abstract override void Execute(Point point);

        public abstract override void Execute(ICollection<Point> points);
    }
}