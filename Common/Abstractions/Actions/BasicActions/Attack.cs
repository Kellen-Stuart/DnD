using System;
using System.Collections.Generic;
using Common.Abstractions.DamageTypes;

namespace Common.Abstractions.Actions.BasicActions
{
    public abstract class Attack : Action
    {
        public int Range { get; protected set; }

        public DamageType DamageType { get; protected set; }

        // One downside of inheriting from Action
        public void Execute()
        {
            throw new Exception("Attacks must target an enemy");
        }
        public abstract void Execute(Character.Character character);

        public abstract void Execute(IEnumerable<Character.Character> characters);

    }
}