namespace Exercises.MarsRover
{
    public interface ICommand
    {
        short DirectionChange { get; set; }
        char Identifier { get; set; }
    }
}