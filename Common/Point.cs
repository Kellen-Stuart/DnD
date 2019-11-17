namespace Common
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}