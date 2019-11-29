using System;
using System.Drawing;

namespace Common
{
    public static class PointExtensions
    {
        public static int CalculateDistance(this Point a, Point b)
        {
            if (a.X == b.X || a.Y == b.Y)
                return CalculateLinearDistance(a, b);

            return CalculateDiagonalDistance(a, b);
        }

        private static int CalculateLinearDistance(Point a, Point b)
        {
            return (int) (Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }


        private static int CalculateDiagonalDistance(Point a, Point b)
        {
            var xDistance = Math.Abs(b.X - a.X);
            var yDistance = Math.Abs(b.Y - a.Y);
            return (int) Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2));
        }
    }
}