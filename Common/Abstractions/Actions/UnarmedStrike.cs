using System;
using System.Collections.Generic;
using System.Linq;
using Common.Abstractions.Actions.BasicActions;
using Common.Abstractions.DamageTypes;

namespace Common.Abstractions.Actions
{
    public class UnarmedStrike : Attack
    {
        public UnarmedStrike()
        {
            Range = 5;
            DamageType = DamageType.Bludgeoning;
        }

        public override void Execute(Character.Character attacker, IEnumerable<Character.Character> receivers)
        {
            if(receivers.Count() != 1)
                throw new Exception("Cannot hit more than one enemy with Unarmed Strike");
            
            var damage = attacker.Abilities.Strength.Modifier + 1;
            foreach (var receiver in receivers)
            {
                receiver.TakeDamage(damage, DamageType, 1);
            }
        }
    }
}