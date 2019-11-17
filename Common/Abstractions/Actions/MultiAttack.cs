using System.Collections.Generic;
using Common.Abstractions.Actions.BasicActions;

namespace Common.Abstractions.Actions
{
    public class MultiAttack : Attack
    {
        public override void Execute(Character.Character attacker, IEnumerable<Character.Character> receivers)
        {
            throw new System.NotImplementedException();
        }
    }
}