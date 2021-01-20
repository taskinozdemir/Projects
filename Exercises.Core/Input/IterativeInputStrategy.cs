using Exercises.Core.Common;
using System;

namespace Exercises.Core.Input
{
    public class IterativeInputStrategy : IInputStrategy
    {
        public DoubleLinkedList<IStep> Steps { get; set; }

        public IterativeInputStrategy(DoubleLinkedList<IStep> steps)
        {
            Steps = steps;
        }
        public void Execute()
        {
            if (Steps == null || Steps == DoubleLinkedList<IStep>.Empty)
            {
                return;
            }

            DoubleLinkedList<IStep> current;
            var next = Steps;
            int direction = 1;
            while (next != null)
            {
                current = next;
                if (!current.Value.IsCompleted)
                {
                    current.Value.Execute();
                    if(!current.Value.IsCompleted)
                    {
                        direction = 1;
                    }
                }
                next = current[direction];
                if (direction == 1)
                {
                    if(next == null)
                    {
                        direction = -1;
                        next = current[direction];
                    }
                    else
                    {
                        next.Value.PreviousStepData = current.Value.StepData;
                    }
                }
            }

            Console.Write(Steps.Value.StepData.ToString());
        }
    }
}
