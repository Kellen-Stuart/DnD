namespace Common
{
    public static class Calculate
    {
        public static int PassivePerception(int wisdomModifier)
        {
            return 10 + wisdomModifier;
        }

        public static int Initiative(int dexterityModifier)
        {
            return Dice.Roll(1, 20) + dexterityModifier;
        }
    }
}