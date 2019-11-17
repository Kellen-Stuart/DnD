namespace Common.Abstractions
{
    public class Speed
    {
        public int _speed { get; private set; }

        public Speed(int speed)
        {
            _speed = speed;
        }

        public override string ToString()
        {
            return $"{_speed} feet";
        }
    }
}
