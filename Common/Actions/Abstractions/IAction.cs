using System.Collections.Generic;
using System.Drawing;

namespace Common.Actions.Abstractions
{
    public interface IAction
    {
        void Execute(Character victim);
        void Execute(ICollection<Character> victims);
    }
}