using System;
using System.Collections.Generic;
using Common.Abstractions;
using Common.Abstractions.Actions.BasicActions;
using Common.Abstractions.DamageTypes;

namespace Common.Actions
{
    public class UnarmedStrike : Attack
    {
        public UnarmedStrike()
        {
            Range = 5;
            DamageType = DamageType.Bludgeoning;
        }

        public override void ExecuteAttack(PhysicalObject attacker, PhysicalObject receiver)
        {
            
        }

        public override void ExecuteAttack(PhysicalObject attacker, IEnumerable<PhysicalObject> receivers)
        {
            throw new Exception("Cannot attack multiple physical objects with Unarmed Strike");
        }
    }
}