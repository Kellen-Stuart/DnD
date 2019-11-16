using System.ComponentModel.Design;

namespace Dice
{
    public static class D20
    {
        public static int Roll()
        {
            var D20 = new Dice(
                rolls: 1,
                numberOfSides: 20
            );

            return D20.Roll();
        }

        public static int Roll(int numberOfTimes)
        {
            var D20s = new Dice(
                rolls: numberOfTimes,
                numberOfSides: 20
            );

            D20s.Roll();
        }
    }
}