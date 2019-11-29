using System.Collections.Generic;
using System.Numerics;

namespace Common.Actions
{
    public interface IAction
    {
        void Execute(Vector3 point);
        void Execute(IEnumerable<Vector3> points);
    }
}