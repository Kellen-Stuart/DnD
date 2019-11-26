using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Common.Abstractions.Actions
{
    public abstract class MeleeAttack : Attack
    {
        public override void Execute()
        {
            throw new Exception("Melee Attacks must target a character");
        }

        public abstract override void Execute(Vector3 point);

        public abstract override void Execute(IEnumerable<Vector3> points);

        public abstract override void Execute(PhysicalObject physicalObject);

        public abstract override void Execute(IEnumerable<PhysicalObject> physicalObjects);
    }
}