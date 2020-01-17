using System.Collections.Generic;
using Common.Abstractions.DamageTypes;

namespace Common.Weapons
{
    public abstract class Weapon
    {
        public readonly Dice BaseDamage;
        public static ICollection<WeaponProperties> WeaponType;
        public DamageType DamageType;
        public Rarity Rarity;
        public Range Range;

        protected Weapon(
            Dice baseDamage, 
            ICollection<WeaponProperties> weaponTypes, 
            DamageType damageType,
            Rarity rarity, 
            Range range)
        {
            BaseDamage = baseDamage;
            WeaponType = weaponTypes;
            DamageType = damageType;
            Rarity = rarity;
            Range = range;
        }
    }

    public enum WeaponProperties
    {
        Melee,
        Ranged,
        Finesse,
        Light,
        Thrown
    }
}