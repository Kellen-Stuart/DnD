using System.Collections.Generic;
using Common.Abstractions.DamageTypes;

namespace Common.Abstractions.Actions.BasicActions
{
    public abstract class Attack : Action
    {
        public int Range { get; protected set; }

        public DamageType DamageType { get; protected set; }

        public abstract void Execute(Character.Character attacker, IEnumerable<Character.Character> receivers);
    }
}