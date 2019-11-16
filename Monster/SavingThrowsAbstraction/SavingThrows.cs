namespace Monster.SavingThrowsAbstraction
{
    public class SavingThrows
    {
        public int StrengthModifier { get; private set; }
        public int DexterityModifier { get; private set; }
        public int ConstitutionModifier { get; private set; }
        public int IntelligenceModifier { get; private set; }
        public int WisdomModifier { get; private set; }
        public int CharismaModifier { get; private set; }
        
        public SavingThrows(
            int strengthModifier = 0, 
            int dexterityModifier = 0, 
            int constitutionModifier = 0,
            int intelligenceModifier = 0, 
            int wisdomModifier = 0, 
            int charismaModifier = 0)
        {
            StrengthModifier = strengthModifier;
            DexterityModifier = dexterityModifier;
            ConstitutionModifier = constitutionModifier;
            IntelligenceModifier = intelligenceModifier;
            WisdomModifier = wisdomModifier;
            CharismaModifier = charismaModifier;
        }
    }
}