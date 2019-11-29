using System.Collections.Generic;
using System.Numerics;
using Common.Abstractions.DamageTypes;

namespace Common.Actions.Abstractions
{
    public abstract class MeleeAttack : Attack
    {
        protected MeleeAttack(DamageType damageType, int range) : base(damageType, range)
        {
        }
        
        public abstract override void Execute(Vector3 point);

        public abstract override void Execute(IEnumerable<Vector3> points);
    }
}