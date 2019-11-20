using System;
using System.Numerics;
using Common.Abstractions;

namespace Common
{
    public static class Map
    {
        public static MapObject MapObject = new MapObject(10, 10);
    }
    public class MapObject
    {
        public PhysicalObject[,,] Map { get; private set; }

        public MapObject(int width, int length, int z = 1)
        {
            if (z <= 0 || z > 1)
                throw new Exception("3D not yet supported");

            Map = new PhysicalObject[width, length, z];
        }

        public void AddPhysicalObject(PhysicalObject physicalObject, Vector3 atPoint)
        {
            if ((int)atPoint.Z != 0)
                throw new Exception("3D not yet supported");

            if (Map[(int) atPoint.X, (int) atPoint.Y, (int) atPoint.Z] != null)
                throw new Exception($"Physical Object already exists at point {atPoint.ToString()}");

            Map[(int) atPoint.X, (int) atPoint.Y, (int) atPoint.Z] = physicalObject;
            physicalObject.PointOnMap = atPoint;
        }

        public PhysicalObject GetPhysicalObject(Vector3 atPoint)
        {
            if ((int)atPoint.Z != 0)
                throw new Exception("3D not yet supported");
            
            if (Map[(int) atPoint.X, (int) atPoint.Y, (int) atPoint.Z] == null)
                throw new Exception($"Physical Object does not exist at point {atPoint.ToString()}");

            return Map[(int) atPoint.X, (int) atPoint.Y, (int) atPoint.Z];
        }
    }
}