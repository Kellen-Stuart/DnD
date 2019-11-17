using System;
using System.Net.Mail;
using Common;
using Common.Abstractions;

namespace Battle
{
    public class BattleMap
    {
        public PhysicalObject[,] Map { get; private set; }

        // TODO: extend to be more interesting than a simple 10 x 10 grid
        public BattleMap()
        {
            Map = new PhysicalObject[10, 10];
        }

        // TODO: two physical objects cannot exist at the same point
        public void InjectObject(PhysicalObject physicalObject, Point point)
        {
            if (Map[point.X, point.Y] != null)
                Map[point.X, point.Y] = physicalObject;
        }
    }
}