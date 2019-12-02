namespace Common
{
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
            return _rolls * _numberOfSides;
        }
    }

    public static class StaticDice
    {
        public static int Roll(int rolls, int numberOfSides)
        {
            return rolls * numberOfSides;
        }
    }
}