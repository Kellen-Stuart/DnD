using System;
using System.Collections.Generic;
using System.Text;

namespace Monster
{
    public class ArmorClass
    {
        public int AC { get; private set; }
        
        public ArmorType ArmorType { get; private set; }
        

        public ArmorClass(int ac, ArmorType armorType = ArmorType.NaturalArmor)
        {
            AC = ac;
        }
    }
}
