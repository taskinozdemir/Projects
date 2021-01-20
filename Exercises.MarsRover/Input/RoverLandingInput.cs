using Exercises.Core.Common;
using Exercises.Core.Input;
using CoreConstants = Exercises.Core.Common.Constants;

namespace Exercises.MarsRover.Input
{
    public class RoverLandingInput : MultipleExecutableStep<IRover>
    {
        private const string MESSAGE_TO_BE_SHOWN = "Enter rovers landing cordinates and direction (1 1 N):";
        private const int MESSAGE_PART_LENGTH = 3;

        private IPlaque Plaque { get; set; }
        private Point LandingPoint { get; set; }
        private DoubleLinkedList<Direction> Direction { get; set; }
        protected override string AskForInputMessage { get { return MESSAGE_TO_BE_SHOWN; } }

        public RoverLandingInput()
        {
        }

        protected override bool IsValid()
        {
            Plaque = PreviousStepData as IPlaque;
            return Plaque != null && !string.IsNullOrWhiteSpace(UnStructuredData);
        }

        protected override bool ParseData()
        {
            string[] data = UnStructuredData.Split(CoreConstants.SEPERATOR_SPACE);
            if (data.Length != MESSAGE_PART_LENGTH)
            {
                return false;
            }
            int x;
            if (!int.TryParse(data[0], out x))
            {
                return false;
            }
            int y;
            if (!int.TryParse(data[1], out y))
            {
                return false;
            }
            LandingPoint = new Point(x, y);

            char landingDirection = UnStructuredData[UnStructuredData.Length-1];
            Direction = DirectionManager.Instance.GetDirection(landingDirection);

            return Direction != DoubleLinkedList<Direction>.Empty;
        }

        protected override bool DoAction()
        {
            Data = Plaque.AddRover(LandingPoint, Direction);
            return true;
        }
    }
}
