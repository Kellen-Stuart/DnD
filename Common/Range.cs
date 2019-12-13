namespace Common
{
    public class Range
    {
        private readonly int? _shortRange;
        private readonly int? _longRange;

        public Range(int? shortRange, int? longRange)
        {
            _shortRange = shortRange;
            _longRange = longRange;
        }
    }
}