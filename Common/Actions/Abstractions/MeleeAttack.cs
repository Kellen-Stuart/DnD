using System.Collections.Generic;
using System.Drawing;
using Common.Abstractions.DamageTypes;

namespace Common.Actions.Abstractions
{
    public abstract class MeleeAttack : Attack
    {
        protected MeleeAttack(DamageType damageType, int range) : base(damageType, range)
        {
        }
        
        public abstract override void Execute(Point point);

        public abstract override void Execute(IEnumerable<Point> points);
    }
}