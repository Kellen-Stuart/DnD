using System.Net.Mail;
using System.Numerics;

namespace Map
{
    public static class Random
    {
        public static Map GenerateRandomMap()
        {
            return new Map(10, 10 ,1);
        }
    }
    
    public class Map
    {
        private readonly float _width;
        private readonly float _height;
        private readonly float _zHeight;
        
        public Map(float width, float height, float zHeight)
        {
            _width = width;
            _height = height;
            _zHeight = zHeight;
        }
        
    }
}