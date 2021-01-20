using Exercises.Core.Common;
using Exercises.Core.Input;

namespace Exercises.MarsRover.Input
{
    public static class MarsRoverExercise
    {
        private static readonly DoubleLinkedList<IStep> PlaqueStep = new DoubleLinkedList<IStep>(new PlaqueInput());
        private static readonly DoubleLinkedList<IStep> RoverLandingInput = new DoubleLinkedList<IStep>(new RoverLandingInput());
        private static readonly DoubleLinkedList<IStep> RoverCommandInput = new DoubleLinkedList<IStep>(new RoverCommandInput());


        public static IInputStrategy GetExecuteStrategy() {
            PlaqueStep.PreviousLink = null;
            PlaqueStep.NextLink = RoverLandingInput;
            RoverLandingInput.PreviousLink = PlaqueStep;
            RoverLandingInput.NextLink = RoverCommandInput;
            RoverCommandInput.PreviousLink = RoverLandingInput;
            RoverCommandInput.NextLink = null;

            IInputStrategy strategy = new IterativeInputStrategy(PlaqueStep);

            return strategy;
        } 
    }
}
