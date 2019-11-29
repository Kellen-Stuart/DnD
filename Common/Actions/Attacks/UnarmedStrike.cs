using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Numerics;
using Common.Abstractions.DamageTypes;
using Common.Actions.Abstractions;

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

        public override void Execute(Vector3 point)
        {
            throw new Exception("Program does not yet support points");
            // Does a physical object exist at that point? 
//            var physicalObject = Map.MapObject.GetPhysicalObject(point);
//            if (physicalObject != null)
//            {
//                physicalObject.TakeDamage(_strengthModifier + 1, DamageType, 1);
//            }
//            else
//            {
//                Console.WriteLine($"There is no physical object {point.ToString()}");
//            }
        }

        public override void Execute(IEnumerable<Vector3> points)
        {
            throw new Exception("Unarmed strike cannot be targeted at multiple points");
        }
    }
}