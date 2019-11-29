using System.Collections.Generic;
using System.Drawing;

namespace Common.Actions
{
    public interface IAction
    {
        void Execute(Point point);
        void Execute(IEnumerable<Point> points);
    }
}