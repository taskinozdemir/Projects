using Exercises.Core.Common;
using System.Collections.Generic;
using System.Text;

namespace Exercises.MarsRover
{
    public class Plaque : IPlaque
    {
        public Point UppperRightCorner { get; private set; }
        public List<IRover> Squad { get; private set; }

        public Plaque(Point upperRight)
        {
            UppperRightCorner = upperRight;

            Squad = new List<IRover>();
        }

        public IRover AddRover(Point landingPoint, DoubleLinkedList<Direction> direction)
        {
            IRover rover = new Rover(UppperRightCorner, landingPoint, direction);
            Squad.Add(rover);

            return rover;
        }

        public override string ToString()
        {
            if (Squad == null || Squad.Count == 0)
            {
                return string.Empty;
            }

            const int MESSAGE_LENGTH_OF_EACH_ROVER = 7;
            StringBuilder message = new StringBuilder(MESSAGE_LENGTH_OF_EACH_ROVER * Squad.Count);
            foreach (var rover in Squad)
            {
                message.AppendLine(rover.ToString());
            }

            return message.ToString();
        }
    }
}
