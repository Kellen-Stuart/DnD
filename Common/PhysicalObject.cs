using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Common.Abstractions.DamageTypes;

namespace Common
{
    public abstract class PhysicalObject
    {
        public Vector3 PointOnMap { get; set; }
        public int HitPoints { get; set; }
        public IEnumerable<DamageType> DamageResistances { get; set; }
        public IEnumerable<DamageType> DamageImmunities { get; set; }
        
        public System.Drawing.Size Size { get; set; }


        public void TakeDamage(int damage, DamageType damageType, int numberOfHits = 1)
        {
            // Immunity
            if (this.ImmuneTo(damageType))
                return;

            // Resistance
            if (this.ResistantTo(damageType))
            {
                HitPoints -= (damage / 2);
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