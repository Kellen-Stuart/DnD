namespace Common.Abstractions.Size
{
    public enum Size
    {
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan
    }

    public static class SizeChart
    {
        public static Size LookupSize(System.Drawing.Size size)
        {
            var totalSize = TotalSize(size);
            
            if (totalSize <= 5)
                return Size.Tiny;
            if (totalSize > 5 && totalSize <= 10)
                return Size.Small;
            if (totalSize > 10 && totalSize <= 15)
                return Size.Medium;
            if (totalSize > 15 && totalSize <= 20)
                return Size.Large;
            if (totalSize > 20 && totalSize <= 25)
                return Size.Huge;

            return Size.Gargantuan;
        }

        private static decimal TotalSize(System.Drawing.Size size)
        {
            return size.Width + size.Height;
        }
    }
}