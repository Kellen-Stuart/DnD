using System.Collections.Generic;
using Common.Abstractions.Actions;
using Common.Abstractions.DamageTypes;

namespace Common.Abstractions
{
    public abstract class PhysicalObject
    {
        protected Point PointOnMap { get; set; }
        protected int HitPoints { get; set; }
        protected IEnumerable<DamageType> DamageResistances { get; set; }
        protected IEnumerable<DamageType> DamageImmunities { get; set; }
        protected IEnumerable<Action> Actions { get; set; }
    }
}