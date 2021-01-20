namespace Exercises.Core.Input
{
    public interface IStep
    {
        /// <summary>
        /// Previous Steps Output Data
        /// </summary>
        object PreviousStepData { get; set; }
        /// <summary>
        /// Current Step Output Data
        /// </summary>
        object StepData { get; }
        /// <summary>
        /// For multiple executable steps it shows step is completed
        /// </summary>
        bool IsCompleted { get; }

        /// <summary>
        /// Execute Step
        /// </summary>
        void Execute();
    }
}
