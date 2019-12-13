using System.Collections.Generic;
using Common.Abstractions.DamageTypes;

namespace Common.Weapons
{
    public class Fist : Weapon
    {
        public Fist() : base(
            baseDamage: new Dice(1, 1), 
            weaponTypes: new List<WeaponProperties>
            {
                WeaponProperties.Melee
            },
            damageType: DamageType.Bludgeoning,
            rarity: Rarity.Standard,
            range: new Range(5, null))
        {
        }
    }
}