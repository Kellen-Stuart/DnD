using System;

namespace Dice
{
    public class Dice
    {
        public int Rolls { get; private set; }
        public int NumberOfSides { get; private set; }
        public int StaticModifier { get; private set; }
        
        public Dice(
            int rolls,
            int numberOfSides,
            int staticModifier = 0)
        {
            Rolls = rolls;
            NumberOfSides = numberOfSides;
            StaticModifier = staticModifier;
        }

        public int Roll()
        {
            var total = 0;
            for(var i = 0; i < Rolls; i++)
            {
                total += GenerateRandomIntegerBetween(1, NumberOfSides);
            }

            total += StaticModifier;
            
            return total;
        }

        private int GenerateRandomIntegerBetween(int min, int max)
        {
             Random random = new Random();
             return random.Next(min, (max + 1));
        }
    }
}