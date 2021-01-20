using System.Collections.Generic;

namespace Exercises.MarsRover
{
    public class CommandManager : ICommandManager
    {
        private static readonly object locker = new object();
        private static ICommandManager instance;

        private const char COMMAND_MOVE_FORWARD = 'M';
        private const char COMMAND_ROTATE_LEFT = 'L';
        private const char COMMAND_ROTATE_RIGHT = 'R';

        private readonly Dictionary<char, ICommand> commands;

        private CommandManager()
        {
            commands = new Dictionary<char, ICommand>
            {
                { COMMAND_MOVE_FORWARD, new Command { Identifier = COMMAND_MOVE_FORWARD, DirectionChange = 0 } },
                { COMMAND_ROTATE_LEFT, new Command { Identifier = COMMAND_ROTATE_LEFT, DirectionChange = -1 } },
                { COMMAND_ROTATE_RIGHT, new Command { Identifier = COMMAND_ROTATE_RIGHT, DirectionChange = 1 } }
            };
        }
        public static ICommandManager Instance
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }
                lock (locker)
                {
                    if (instance != null)
                    {
                        return instance;
                    }
                    instance = new CommandManager();
                }
                return instance;
            }
        }

        public ICommand GetCommand(char identifier)
        {
            ICommand returnValue;
            if (!commands.TryGetValue(identifier, out returnValue))
            {
                return null;
            }
            return returnValue;
        }
    }
}