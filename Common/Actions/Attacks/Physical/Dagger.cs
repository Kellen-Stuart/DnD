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
        public Dagger(Character assailant) : base(assailant, new Weapons.Dagger())
        {
        }

        public override void Execute(Character victim)
        {
            victim.TakeDamage(
                damage: CalculateDamage(),
                DamageType.Piercing,
                numberOfHits: 1
            );
        }

        public override void Execute(ICollection<Character> victims)
        {
            throw new Exception("Unable to perform dagger attack on multiple enemies.");
        }

        private int CalculateDamage()
        {
            return Weapon.BaseDamage.Roll() + Assailant.Abilities.Dexterity.Modifier;
        }
    }
}