namespace Monster.SpellAbstraction
{
    public abstract class Spell
    {
        public SpellType SpellType { get; private set; }
        public CastingTime CastingTime { get; private set; }
        public int Range { get; set; }
        public Duration Duration { get; private set; }
        //private Components Components { get; private set; }
        public SpellDescription Description { get; private set; }
    }
}