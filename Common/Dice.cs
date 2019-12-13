using System.Security.Cryptography;

namespace Common
{
    // Anything that has to do with Rolling Dice / Calculations will go in this class
    public class Dice
    {
        private readonly int _rolls;
        private readonly int _numberOfSides;
        private readonly int _modifier;

        public Dice(int rolls, int numberOfSides, int modifier = 0)
        {
            _rolls = rolls;
            _numberOfSides = numberOfSides;
            _modifier = modifier;
        }

        public virtual int Roll()
        {
            return Roll(_rolls, _numberOfSides, _modifier);
        }

        public int Average()
        {
            return (_rolls * _numberOfSides + _modifier) / 2;
        }

    public static int Roll(int rolls, int numberOfSides, int modifier = 0)
        {
            var total = 0;
            for(var i=0; i < rolls; i++)
            {
                total += RandomNumberGenerator.GetInt32(1, (numberOfSides + 1));
            }

            return total + modifier;
        }
        
    }
}