namespace Exercises.MarsRover
{
    public interface ICommandManager
    {
        ICommand GetCommand(char identifier);
    }
}