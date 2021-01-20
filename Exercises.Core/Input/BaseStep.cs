using System;

namespace Exercises.Core.Input
{
    public abstract class BaseStep<T> : IStep
    {
        public bool IsCompleted { get; protected set; }
        protected abstract string AskForInputMessage { get;  }
        protected string UnStructuredData { get; set; }
        public T Data { get; protected set; }
        public object PreviousStepData { get; set; }
        public object StepData
        {
            get {
                return Data;
            }
        }

        
        public virtual void Execute()
        {
            if (IsCompleted)
            {
                return;
            }
            ReadData();
            if (IsCompleteMessage())
            {
                return;
            }
            if (!IsValid() || !ParseData() || !DoAction())
            {
                throw new ArgumentException($"Given argument is not valid! { UnStructuredData}");
            }
        }

        protected virtual void ReadData()
        {
            Console.WriteLine(AskForInputMessage);
            UnStructuredData = Console.ReadLine();
        }
        protected abstract bool IsCompleteMessage();
        protected abstract bool IsValid();
        protected abstract bool ParseData();
        protected abstract bool DoAction();
    }
}
