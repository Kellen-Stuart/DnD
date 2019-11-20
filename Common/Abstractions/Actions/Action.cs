using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Common.Abstractions.Actions
{
    public interface IAction
    {
        void Execute();
        void Execute(Vector3 point);
        void Execute(IEnumerable<Vector3> points);
    }
}