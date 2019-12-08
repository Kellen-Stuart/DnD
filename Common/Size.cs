namespace Common.Abstractions.Size
{
    public enum SizeEnum
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
        public static SizeEnum LookupSize(System.Drawing.Size size)
        {
            var totalSize = TotalSize(size);
            
            if (totalSize <= 5)
                return SizeEnum.Tiny;
            if (totalSize > 5 && totalSize <= 10)
                return SizeEnum.Small;
            if (totalSize > 10 && totalSize <= 15)
                return SizeEnum.Medium;
            if (totalSize > 15 && totalSize <= 20)
                return SizeEnum.Large;
            if (totalSize > 20 && totalSize <= 25)
                return SizeEnum.Huge;

            return SizeEnum.Gargantuan;
        }

        private static decimal TotalSize(System.Drawing.Size size)
        {
            return size.Width + size.Height;
        }
    }
}