namespace Common.Abstractions.Actions.BasicActions
{
    public abstract class Spell : Monster.ActionAbstraction.Action
    {
        // Every spell has a level from 0 - 9
        public int Level { get; protected set; }
    }
}