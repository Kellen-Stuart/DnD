using System;
using System.Drawing;
using System.Security.Cryptography;
using Common.Map;

public static class Global
{
    public static Map Map = Common.Map.Random.GenerateRandomSquareMap();
}

namespace Common.Map
{
    public static class Random
    {
        public static Map GenerateRandomSquareMap()
        {
            return new Map(
                width: RandomNumberGenerator.GetInt32(5, 100),
                height: RandomNumberGenerator.GetInt32(5, 100)
            );
        }
    }

    public class Map
    {
        private readonly int _width;
        private readonly int _height;
        private readonly PhysicalObject[,] _map;

        public Map(int width, int height)
        {
            _width = width;
            _height = height;
            _map = new PhysicalObject[_width, _height];
        }

        public void InsertPhysicalObject(PhysicalObject physicalObject, Point point)
        {
            if (PhysicalObjectExists(point))
                throw new Exception(
                    $"Unable to insert physical object at point: {point.ToString()}. " +
                    $"Another physical object exists here.");

            _map[point.X, point.Y] = physicalObject;
        }

        public PhysicalObject GetPhysicalObject(Point point)
        {
            return _map[point.X, point.Y];
        }

        public bool PhysicalObjectExists(Point point)
        {
            if (_map[point.X, point.Y] != null)
                return true;

            return false;
        }
    }
}