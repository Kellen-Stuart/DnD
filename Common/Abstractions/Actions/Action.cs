using System.Collections.Generic;

namespace Common.Abstractions.Actions
{
    public interface Action
    {
        void Execute();
        void Execute(Character.Character character);
        void Execute(IEnumerable<Character.Character> characters);
    }
}