using System;
using System.Collections.Generic;

namespace Common.Abstractions.Actions
{
    public abstract class MeleeAttack : Attack
    {
        public override void Execute()
        {
            throw new Exception("Melee Attacks must target an enemy");
        }
        
        public abstract override void Execute(Character.Character character);

        public abstract override void Execute(IEnumerable<Character.Character> characters);

        
    }
}