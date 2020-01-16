using System;
using System.Collections.Generic;
using Common.Abstractions.DamageTypes;
using Common.Actions.Abstractions;
using Common.Weapons;

namespace Common.Actions.Attacks.Physical
{
    public class UnarmedStrike : MeleeWeaponAttack
    {
        public UnarmedStrike(Character assailant) :
            base(
                assailant: assailant,
                weapon: new Fist()
            )
        {
        }

        // At this point, we're assuming the attack is a hit
        public override void Execute(Character victim)
        {
            victim.TakeDamage(
                damage: CalculateDamage(),
                damageType: DamageType.Bludgeoning,
                numberOfHits: 1);
        }

        public override void Execute(ICollection<Character> victims)
        {
            throw new Exception("Unarmed strike cannot be targeted at multiple points");
        }

        // d20 + proficiency bonus + Str modifier
        private int CalculateDamage()
        {
            return Assailant.Abilities.Strength.Modifier + Weapon.BaseDamage.Roll();
        }
    }
}