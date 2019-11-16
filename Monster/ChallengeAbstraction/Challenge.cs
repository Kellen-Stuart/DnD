namespace Monster.ChallengeAbstraction
{
    public class Challenge
    {
        public int ChallengeLevel { get; private set; }
        public int Experience { get; private set; }

        public Challenge(int challengeLevel, int experience)
        {
            ChallengeLevel = challengeLevel;
            Experience = experience;
        }
    }
}