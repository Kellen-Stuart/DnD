namespace Common.Abstractions.Challenge
{
    public class Challenge
    {
        public decimal ChallengeLevel { get; private set; }
        public int Experience { get; private set; }

        public Challenge(decimal challengeLevel, int experience)
        {
            ChallengeLevel = challengeLevel;
            Experience = experience;
        }
    }
}