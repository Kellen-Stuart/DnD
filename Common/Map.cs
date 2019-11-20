using System;
using System.Numerics;
using Common.Abstractions;

namespace Common
{
    public class Map
    {
        public PhysicalObject[,,] Grid { get; private set; }

        public Map(int width, int length, int z = 1)
        {
            if (z > 1)
                throw new Exception("3D not yet supported");

            Grid = new PhysicalObject[width, length, z];
        }

        public void AddPhysicalObject(PhysicalObject physicalObject, Vector3 atPoint)
        {
            if (point.Z > 1)
                throw new Exception("3D not yet supported");

            if (Grid[(int) atPoint.X, (int) atPoint.Y, (int) atPoint.Z] != null)
                throw new Exception($"Physical Object already exists at point {atPoint.ToString()}");

            Grid[(int) atPoint.X, (int) atPoint.Y, (int) atPoint.Z] = physicalObject;
        }

        public PhysicalObject GetPhysicalObject(Vector3 atPoint)
        {
            if (atPoint.Z > 1)
                throw new Exception("3D not yet supported");
            
            if (Grid[(int) atPoint.X, (int) atPoint.Y, (int) atPoint.Z] == null)
                throw new Exception($"Physical Object does not exist at point {atPoint.ToString()}");

            return Grid[(int) atPoint.X, (int) atPoint.Y, (int) atPoint.Z];
        }
    }
}