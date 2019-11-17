using System;
using System.Collections.Generic;
using Common.Abstractions.Actions.BasicActions;
using Common.Abstractions.DamageTypes;

namespace Common.Abstractions.Actions
{
    public class UnarmedStrike : MeleeAttack
    {
        private readonly int _strengthModifier;
        
        public UnarmedStrike(int strengthModifier, int proficiency)
        {
            _strengthModifier = strengthModifier;
            Range = 5;
            DamageType = DamageType.Bludgeoning;
        }

        public override void Execute(Character.Character receiver)
        {
            //var damage = attacker.Abilities.Strength.Modifier + 1;
            receiver.TakeDamage( _strengthModifier +  1, DamageType, 1);
        }

        public override void Execute(IEnumerable<Character.Character> characters)
        {
            throw new Exception("Unable to perform Unarmed Strike on multiple enemies");
        }
    }
}