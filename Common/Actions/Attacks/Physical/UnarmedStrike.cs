using System;
using System.Collections.Generic;
using Common.Abstractions.DamageTypes;
using Common.Actions.Abstractions;
using Common.Weapons;

namespace Common.Actions.Attacks.Physical
{
    public class UnarmedStrike : MeleeWeaponAttack
    {
        private readonly Character _attacker;

        // The arguments are all dependent on the character
        public UnarmedStrike(Character attacker) :
            base(
                weapon: new Fist(),
                damageType: DamageType.Bludgeoning,
                range: attacker.Reach
            )
        {
            _attacker = attacker;
        }

        // At this point, we're assuming the attack is a hit
        public override void Execute(Character target)
        {
            target.TakeDamage(
                damage: CalculateDamage(),
                damageType: DamageType,
                numberOfHits: 1);
        }

        public override void Execute(ICollection<Character> characters)
        {
            throw new Exception("Unarmed strike cannot be targeted at multiple points");
        }

        // d20 + proficiency bonus + Str modifier
        private int CalculateDamage()
        {
            return _attacker.Abilities.Strength.Modifier + Weapon.BaseDamage.Roll();
        }
    }
}