using System.Collections.Generic;
using Common.Abstractions.DamageTypes;

namespace Common.Weapons.Abstractions
{
    public abstract class Weapon
    {
        public readonly int BaseDamage;
        public static ICollection<WeaponType> WeaponType;
        public DamageType DamageType;

        protected Weapon(int baseDamage, ICollection<WeaponType> weaponTypes, DamageType damageType)
        {
            BaseDamage = baseDamage;
            WeaponType = weaponTypes;
            DamageType = damageType;
        }
    }

    public enum WeaponType
    {
        Melee,
        Ranged,
        Finesse
    }
}