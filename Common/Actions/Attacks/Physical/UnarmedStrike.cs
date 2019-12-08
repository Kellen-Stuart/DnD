using System;
using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Common.Actions.Abstractions;
using Common.Weapons;

namespace Common.Actions.Attacks.Physical
{
    public class UnarmedStrike : MeleeWeaponAttack
    {
        private readonly Character _attacker;

        // The arguments are all dependent on the character
        public UnarmedStrike(Character attacker) :
            base(
                weapon: new Fist(),
                damageType: DamageType.Bludgeoning,
                range: attacker.Reach
            )
        {
            _attacker = attacker;
        }

        // TODO: this method is violating SRP
        public override void Execute(Point point)
        {
            // Get the target
            var target = Global.Map.GetPhysicalObject(point); // assuming there is in fact a target and not null

            // Is the attack within range? 
            if (Range >= _attacker.PointOnMap.CalculateDistance(point))
            {
                // Does the attack hit? 
                if (_attacker.RollToHit >= target.ArmorClass)
                {
                    target.TakeDamage(
                        damage: CalculateDamage(),
                        damageType: DamageType,
                        numberOfHits: 1);
                }
                else
                {
                    Console.WriteLine($"Attacker has missed ${nameof(UnarmedStrike)}!");
                }
            }
            else
            {
                Console.WriteLine($"Attacker is not in range of the target.");
            }
        }
        
        public override void Execute(ICollection<Point> points)
        {
            throw new Exception("Unarmed strike cannot be targeted at multiple points");
        }

        // d20 + proficiency bonus + Str modifier
        private int CalculateDamage()
        {
            return _attacker.Abilities.Strength.Modifier + Weapon.BaseDamage;
        }
    }
}