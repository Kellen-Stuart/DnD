using System;
using System.Collections.Generic;
using System.Numerics;
using Common.Abstractions.DamageTypes;

namespace Common.Abstractions.Actions.Basic
{
    public class UnarmedStrike : MeleeAttack
    {
        private readonly int _strengthModifier;
        
        public UnarmedStrike(int strengthModifier)
        {
            _strengthModifier = strengthModifier;
            Range = 5;
            DamageType = DamageType.Bludgeoning;
        }

        public override void Execute(Vector3 point)
        {
            point.TakeDamage( _strengthModifier +  1, DamageType, 1);
        }

        public override void Execute(IEnumerable<Vector3> points)
        {
            throw new Exception("Impossible to perform Unarmed Strike on multiple points.");
        }
    }
}