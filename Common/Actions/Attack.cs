using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;

namespace Common.Actions
{
    // An attack is something that does damage
    // There's two types of attacks
    // 1) Melee Attack
    // 2) Spell Attack
    public abstract class Attack : IAction
    {
        protected Attack(DamageType damageType, int range)
        {
            Range = range;
        }
        
        // There is a SINGULAR damage type per attack
        protected readonly DamageType DamageType;
        
        // Both spells and melee attacks have a range
        protected readonly int Range;

        // You either attack a single point or multiple points
        public abstract void Execute(Point point);

        public abstract void Execute(IEnumerable<Point> points);
    }
}