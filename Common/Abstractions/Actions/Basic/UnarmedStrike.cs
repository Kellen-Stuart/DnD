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
            // Does a physical object exist at that point? 
            var physicalObject = Map.MapObject.GetPhysicalObject(point);
            if (physicalObject != null)
            {
                physicalObject.TakeDamage( _strengthModifier +  1, DamageType, 1);
            }
            else
            {
                Console.WriteLine($"There is no physical object {point.ToString()}");
            }
        }

        public override void Execute(IEnumerable<Vector3> points)
        {
            throw new Exception("Impossible to perform Unarmed Strike on multiple points.");
        }
    }
}