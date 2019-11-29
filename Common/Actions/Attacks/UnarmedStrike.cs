using System;
using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Common.Actions.Abstractions;
using static Common.Map.Map;

namespace Common.Actions.Attacks
{
    public class UnarmedStrike : MeleeAttack
    {
        private readonly int _strengthModifier;
        private readonly int _reach;

        public UnarmedStrike(int strengthModifier, int reach) :
            base(
                damageType: DamageType.Bludgeoning,
                range: reach
            )
        {
            _strengthModifier = strengthModifier;
        }

        public override void Execute(Point point)
        {
            var target = Global.Map.GetPhysicalObject(point);
            target.TakeDamage(_strengthModifier + 1, DamageType, 1);
        }

        public override void Execute(IEnumerable<Point> points)
        {
            throw new Exception("Unarmed strike cannot be targeted at multiple points");
        }
    }
}