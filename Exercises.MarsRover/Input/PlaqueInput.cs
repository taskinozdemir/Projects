using Exercises.Core.Input;
using CoreConstants = Exercises.Core.Common.Constants;

namespace Exercises.MarsRover.Input
{
    public class PlaqueInput : SingleExecutableStep<IPlaque>
    {
        private const string MESSAGE_TO_BE_SHOWN = "Enter upper-right coordinates of the plateau (5 5):";
        private const int MAX_LENGTH_OF_MESSAGE = 21; //2147483647 2147483647
        private const int MESSAGE_PART_LENGTH = 2;

        private Point UpperRight { get; set; }
        protected override string AskForInputMessage { get { return MESSAGE_TO_BE_SHOWN; } }

        public PlaqueInput()
        {
        }

        protected override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(UnStructuredData) && UnStructuredData.Length <= MAX_LENGTH_OF_MESSAGE && UnStructuredData.Contains(CoreConstants.SEPERATOR_SPACE);
        }

        protected override bool ParseData()
        {
            string[] data = UnStructuredData.Split(CoreConstants.SEPERATOR_SPACE);
            if (data.Length != MESSAGE_PART_LENGTH)
            {
                return false;
            }
            int x;
            if (!int.TryParse(data[0], out x) || x<1)
            {
                return false;
            }
            int y;
            if (!int.TryParse(data[0], out y) || y<1)
            {
                return false;
            }
            UpperRight = new Point(x, y);

            return true;
        }

        protected override bool DoAction()
        {
            Data = new Plaque(UpperRight);
            return true;
        }
    }
}
