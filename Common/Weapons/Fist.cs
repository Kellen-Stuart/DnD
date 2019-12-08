using System.Collections.Generic;
using Common.Weapons.Abstractions;
using Common.Abstractions.DamageTypes;

namespace Common.Weapons
{
    public class Fist : Weapon
    {
        public Fist() : base(
            baseDamage: 1,
            weaponTypes: new List<WeaponType>
            {
                Weapons.Abstractions.WeaponType.Melee,
                Weapons.Abstractions.WeaponType.Ranged
            },
            damageType: DamageType.Bludgeoning)
        {
        }
    }
}