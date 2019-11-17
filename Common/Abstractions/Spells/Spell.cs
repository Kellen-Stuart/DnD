using Common.Abstractions.Actions;
using Common.Abstractions.Actions.BasicActions;
using Monster.SpellAbstraction;

namespace Common.Abstractions.Spells
{
    public abstract class Spell : MeleeAttack
    {
        public SpellType SpellType { get; private set; }
        //public CastingTime CastingTime { get; private set; }
        //public Duration Duration { get; private set; }
        //private Components Components { get; private set; }
        //public SpellDescription Description { get; private set; }
    }
}