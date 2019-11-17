using System;

namespace Dice
{
    public static class Dice
    {
        public static int Roll(int numberOfSides, int rolls)
        {
            var total = 0;
            for(var i = 0; i < rolls; i++)
            {
                total += GenerateRandomIntegerBetween(1, numberOfSides);
            }
            
            return total;
        }

        private static int GenerateRandomIntegerBetween(int min, int max)
        {
             var random = new Random();
             return random.Next(min, (max + 1));
        }
    }
}