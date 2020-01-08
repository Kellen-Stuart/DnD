using System;
using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Common.Actions.Abstractions;
using Common.Weapons;

namespace Common.Actions.Attacks.Physical
{
    public class Dagger : MeleeWeaponAttack
    {
        public Dagger(Character attacker) 
            : base(DamageType.Piercing, attacker.Reach, new Weapons.Dagger())
        {
        }

        public override void Execute(Point point)
        {
            throw new System.NotImplementedException();
        }

        public override void Execute(ICollection<Point> points)
        {
            throw new Exception($"Unable to strike more than one target with {nameof(Weapons.Dagger)}");
        }
    }
}