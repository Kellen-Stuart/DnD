using System.Collections.Generic;
using Common.Abstractions.DamageTypes;

namespace Common.Weapons
{
    public class Dagger : Weapon
    {
        public Dagger() : base(
            baseDamage: new Dice(1, 4),
            damageType: DamageType.Piercing,
            weaponTypes: new List<WeaponProperties>
            {
                WeaponProperties.Finesse,
                WeaponProperties.Light,
                WeaponProperties.Ranged,
                WeaponProperties.Thrown
            },
            rarity: Rarity.Standard,
            range: new Range(20, 60)
        )
        {
        }
    }
}