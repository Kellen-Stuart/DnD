using System.Collections.Generic;
using System.Drawing;

namespace Common.Actions.Abstractions
{
    public interface IAction
    {
        void Execute(Point point);
        void Execute(ICollection<Point> points);
    }
}