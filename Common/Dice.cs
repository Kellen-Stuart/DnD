using System;
using System.Security.Cryptography;
using Common.Map;

namespace Common
{
    // Anything that has to do with Rolling Dice / Calculations will go in this class
    public class Dice
    {
        private readonly int _rolls;
        private readonly int _numberOfSides;

        public Dice(int rolls, int numberOfSides)
        {
            _rolls = rolls;
            _numberOfSides = numberOfSides;
        }

        public int Roll()
        {
            return Roll(_rolls, _numberOfSides);
        }
        
        public static int Roll(int rolls, int numberOfSides)
        {
            int total = 0;
            foreach (int roll in rolls)
            {
                total += RandomNumberGenerator.GetInt32(1, (numberOfSides + 1));
            }

            return total;
        }

        public static int RollHitPoints(int rolls, int numberOfSides, int constitutionModifier = 0)
        {
            int hitPoints = Roll(rolls, numberOfSides);
            
            int staticModifier = rolls * constitutionModifier;
            return hitPoints + staticModifier;
        }
    }
}