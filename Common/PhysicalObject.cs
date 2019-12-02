using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Common.Abstractions.Size;

namespace Common
{
    public abstract class PhysicalObject
    {
        // The order of instance variables should follow DnD Beyond
        
        public SizeEnum Size { get; private set; }
        
        public int ArmorClass { get; private set; }

        public IEnumerable<DamageType> DamageResistances { get; private set; }
        
        public IEnumerable<DamageType> DamageImmunities { get; private set; }
        
        // Not part of DnD Beyond stat sheet
        public Point PointOnMap { get; protected set; }


        public PhysicalObject(
            SizeEnum size,
            int armorClass,
            IEnumerable<DamageType> damageImmunities,
            IEnumerable<DamageType> damageResistances,
            Point pointOnMap
        )
        {
            Size = size;
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
                HitPointCalculation -= (damage / 2);
                return;
            }

            // Condition?

            HitPointCalculation -= damage;
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