using System;
using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Size;

namespace Common
{
    public abstract class PhysicalObject
    {
        // The order of instance variables should follow DnD Beyond Monster Manual
        public SizeEnum Size { get; private set; }
        
        public int HitPoints { get; protected set; }
        
        public int ArmorClass { get; private set; }

        public ICollection<DamageType> DamageResistances { get; private set; }
        
        public ICollection<DamageType> DamageImmunities { get; private set; }
        
        // Not part of DnD Beyond stat sheet
        public Point PointOnMap { get; protected set; }
        


        public PhysicalObject(
            SizeEnum size,
            int hitPoints,
            int armorClass,
            ICollection<DamageType> damageImmunities,
            ICollection<DamageType> damageResistances,
            Point pointOnMap
        )
        {
            Size = size;
            HitPoints = hitPoints;
            ArmorClass = armorClass;
            DamageImmunities = damageImmunities;
            DamageResistances = damageResistances;
            PointOnMap = pointOnMap;
        }


        public void TakeDamage(int damage, DamageType damageType, int numberOfHits = 1)
        {
            // Immunity
            if (ImmuneTo(damageType))
                return;

            // Resistance
            if (ResistantTo(damageType))
            {
                HitPoints -= damage / 2;
                return;
            }

            // Condition?

            HitPoints -= damage;
        }

        public bool ImmuneTo(DamageType damageType)
        {
            if (DamageImmunities.Contains(damageType))
            {
                Console.WriteLine($"Immune to {damageType}");
                return true;
            }

            return false;
        }

        public bool ResistantTo(DamageType damageType)
        {
            if (DamageResistances.Contains(damageType))
            {
                Console.WriteLine($"Resistance to {damageType}");
                return true;
            }

            return false;
        }
    }
}