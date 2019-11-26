namespace Common.Abilities
{
    public class Abilities
    {
        public Strength Strength { get; private set; }
        public Dexterity Dexterity { get; private set; }
        public Constitution Constitution { get; private set; }
        public Intelligence Intelligence { get; private set; }
        public Wisdom Wisdom { get; private set; }
        public Charisma Charisma { get; private set; }
        
        public Abilities(
            Strength strength,
            Dexterity dexterity, 
            Constitution constitution, 
            Intelligence intelligence, 
            Wisdom wisdom, Charisma charisma)
        {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        public enum AbilityEnum
        {
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom
        }
    }
}