using Exercises.Core.Common;

namespace Exercises.MarsRover
{
    public interface IDirectionManager
    {
        DoubleLinkedList<Direction> GetDirection(char identifier);
    }
}