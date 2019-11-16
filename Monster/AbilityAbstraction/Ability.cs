namespace Monster.Abilities
{
    public abstract class Ability
    {
        public int BaseScore { get; private set; }

        public int Modifier { get; private set; }

        protected Ability(int baseScore, int modifier)
        {
            BaseScore = baseScore;
            Modifier = modifier;
        }
    }
}