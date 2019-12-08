namespace Common
{
    public static class Calculator
    {
        public static int HitPoints(int rolls, int numberOfSides, int modifier)
        {
            return Dice.Roll(
                       rolls: rolls,
                       numberOfSides: numberOfSides
                   ) + modifier;
        }
    }
}