using System;
using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;
using Common.Actions.Abstractions;
using static Common.Map.Map;

namespace Common.Actions.Attacks
{
    public class UnarmedStrike : MeleeAttack
    {
        private readonly Character _attacker;

        // The arguments are all dependent on the character
        public UnarmedStrike(Character attacker) :
            base(
                damageType: DamageType.Bludgeoning,
                range: attacker.Reach
            )
        {
            _attacker = attacker;
        }

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

        private int CalculateDamage()
        {
            return _attacker.Abilities.Strength.Modifier + 1;
        }

        public override void Execute(IEnumerable<Point> points)
        {
            throw new Exception("Unarmed strike cannot be targeted at multiple points");
        }
    }
}