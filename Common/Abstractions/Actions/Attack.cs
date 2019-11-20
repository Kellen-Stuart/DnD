using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using Common.Abstractions.DamageTypes;

namespace Common.Abstractions.Actions
{
    // What do ranged and melee have in common?
    public abstract class Attack : IAction
    {
        public DamageType DamageType { get; protected set; }
        
        // Range and Reach are equivalent
        public int Range { get; protected set; }
        
        // Did the attack hit or not?
        public bool Hit { get; protected set; }
        
        public abstract void Execute();

        public abstract void Execute(Vector3 point);

        public abstract void Execute(IEnumerable<Vector3> points);
    }
}