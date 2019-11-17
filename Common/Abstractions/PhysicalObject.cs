using System;
using System.Collections.Generic;
using Common.Abstractions.Actions;
using Common.Abstractions.DamageTypes;
using Action = Common.Abstractions.Actions.Action;

namespace Common.Abstractions
{
    public abstract class PhysicalObject
    {
        public Point PointOnMap { get; set; }
        public int HitPoints { get; set; }
        public IEnumerable<DamageType> DamageResistances { get; set; }
        public IEnumerable<DamageType> DamageImmunities { get; set; }
        public IEnumerable<Action> Actions { get; set; }
    }
}