using Exercises.Core.Common;
using System;

namespace Exercises.MarsRover
{
    public class Rover : IRover
    {
        private static readonly Point LowerLeftCorner = new Point(0, 0);
        public Point UpperRightCorner { get; private set; }
        public Point Position { get; private set; }
        public DoubleLinkedList<Direction> Direction { get; private set; }

        public Rover(Point upperRightCorner, Point landingPoint, DoubleLinkedList<Direction> direction)
        {
            UpperRightCorner = upperRightCorner;
            CheckPosition(landingPoint);
            Position = landingPoint;
            Direction = direction;
        }

        public void ExecuteCommand(ICommand command)
        {
            if (command.DirectionChange == 0)
            {
                var newPosition = Position + Direction.Value.PositionChange;
                CheckPosition(newPosition);
                Position = newPosition;
            }
            Direction = Direction[command.DirectionChange];
        }
        public override string ToString()
        {
            return $"{Position} {Direction.Value}";
        }

        private void CheckPosition(Point newPosition)
        {
            if (newPosition < LowerLeftCorner || newPosition > UpperRightCorner)
            {
                throw new ArgumentException("Rover can not be in out of Plaque.");
            }
        }
    }
}
