using Exercises.Core.Common;

namespace Exercises.MarsRover
{
    public interface IPlaque
    {
        Point UppperRightCorner { get; }

        IRover AddRover(Point landingPoint, DoubleLinkedList<Direction> direction);
    }
}