namespace Common.Abstractions.Actions.BasicActions
{
    public class Cantrip : Spell
    {
        // Cantrips do not use a spell slot
        // Cantrips can be cast on the same turn that a spell is cast using
        // a bonus action 
        public Cantrip()
        {
            // All cantrips are level 0 spells
            Level = 0;
        }
    }
}