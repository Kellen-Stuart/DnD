using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.Abstractions
{
    public static class ProficiencyBonus
    {
        // Key = Character Level
        // Value = Proficiency Bonus
        private static Dictionary<int, int> ProficiencyTable = new Dictionary<int, int>
        {
            {1, 2},
            {2, 2},
            {3, 2},
            {4, 2},
            {5, 3},
            {6, 3},
            {7, 3},
            {8, 3},
            {9, 4},
            {10, 4},
            {11, 4},
            {12, 4},
            {13, 5},
            {14, 5},
            {15, 5},
            {16, 5},
            {17, 6},
            {18, 6},
            {19, 6},
            {20, 6}
        };
        
        public static int LookupProficiencyBonusByLevel(int characterLevel)
        {
            if(characterLevel < 1 || characterLevel > 20)
                throw new Exception("Character level out of range");

            ProficiencyTable.TryGetValue(characterLevel, out var proficiencyBonus);

            return proficiencyBonus;
        }
    }
}