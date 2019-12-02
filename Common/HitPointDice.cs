using System;

namespace Common
{
    public class HitPointDice
    {
        public readonly Dice Dice;
        public int ConstitutionModifier { get; set; }

        public HitPointDice(Dice dice, int constitutionModifier)
        {
            dice = Dice;
            ConstitutionModifier = constitutionModifier;
        }
        
        
        
    }
}