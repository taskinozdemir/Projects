using Exercises.Core.Common;

namespace Exercises.MarsRover
{
    public interface IRover
    {
        DoubleLinkedList<Direction> Direction { get; }
        Point Position { get; }

        void ExecuteCommand(ICommand command);
    }
}