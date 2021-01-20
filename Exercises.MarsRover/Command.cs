namespace Exercises.MarsRover
{
    public class Command : ICommand
    {
        public char Identifier { get; set; }

        public short DirectionChange { get; set; }

        public Command()
        {
        }
    }
}
