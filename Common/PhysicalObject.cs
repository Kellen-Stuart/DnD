using System;
using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Size = Common.Abstractions.Size.Size;

namespace Common
{
    public abstract class PhysicalObject
    {
        // The order of instance variables should follow DnD Beyond Monster Manual
        public Size Size { get; private set; }
        
        protected Dice HitDice { get; set; }

        public static int HitPoints { get; private set; }

        public int Average => HitDice.Average();
        
        public int ArmorClass { get; private set; }

        public ICollection<DamageType> DamageResistances { get; private set; }
        
        public ICollection<DamageType> DamageImmunities { get; private set; }
        
        // Not part of DnD Beyond stat sheet
        public Point PointOnMap { get; protected set; }
        


        public PhysicalObject(
            Size size,
            Dice hitDice,
            int armorClass,
            ICollection<DamageType> damageImmunities,
            ICollection<DamageType> damageResistances,
            Point pointOnMap
        )
        {
            Size = size;
            HitDice = hitDice;
            ArmorClass = armorClass;
            DamageImmunities = damageImmunities;
            DamageResistances = damageResistances;
            PointOnMap = pointOnMap;
            
            // HitPoints will change with each new object creation
            HitPoints = HitDice.Roll();
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

            HitPoints-= damage;
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