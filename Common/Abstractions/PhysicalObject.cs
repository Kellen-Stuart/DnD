using System;
using System.Collections.Generic;
using Common.Abstractions.Actions;
using Common.Abstractions.DamageTypes;
using Action = Common.Abstractions.Actions.Action;

namespace Common.Abstractions
{
    public abstract class PhysicalObject
    {
        protected Point PointOnMap { get; set; }
        protected int HitPoints { get; set; }
        protected IEnumerable<DamageType> DamageResistances { get; set; }
        protected IEnumerable<DamageType> DamageImmunities { get; set; }
        public IEnumerable<Action> Actions { get; set; }
    }
}