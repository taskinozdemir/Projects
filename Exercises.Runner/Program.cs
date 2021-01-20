using Exercises.MarsRover.Input;

namespace Exercises
{
    internal static class Runner
    {
        static void Main(string[] args)
        {
            var strategy = MarsRoverExercise.GetExecuteStrategy();
            strategy.Execute();
        }
    }
}
