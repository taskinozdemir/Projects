using Exercises.Core.Input;
using System.Collections.Generic;

namespace Exercises.MarsRover.Input
{
    public class RoverCommandInput : MultipleExecutableStep<IRover>
    {
        private const string MESSAGE_TO_BE_SHOWN = "Enter rovers moving commands (LMLMLMLMM):";
        
        protected override string AskForInputMessage { get { return MESSAGE_TO_BE_SHOWN; } }

        private IRover rover;
        private List<ICommand> commands;

        public RoverCommandInput()
        {
            rover = null;
            commands = new List<ICommand>();
        }

        protected override bool IsCompleteMessage()
        {
            return false;
        }

        protected override bool IsValid()
        {
            rover = PreviousStepData as Rover;
            return rover != null && !string.IsNullOrWhiteSpace(UnStructuredData);
        }

        protected override bool ParseData()
        {
            ICommand command;
            commands = new List<ICommand>();
            foreach (char item in UnStructuredData)
            {
                command = CommandManager.Instance.GetCommand(item);
                if (command == null)
                {
                    return false;
                }
                commands.Add(command);
            }
            return true;
        }

        protected override bool DoAction()
        {
            if (rover == null)
            {
                return false;
            }
            foreach (var item in commands)
            {
                rover.ExecuteCommand(item);
            }
            return true;
        }
    }
}
