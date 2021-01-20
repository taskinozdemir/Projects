namespace Exercises.Core.Input
{
    public abstract class MultipleExecutableStep<T> : BaseStep<T>
    {
        protected override bool IsCompleteMessage()
        {
            IsCompleted = string.IsNullOrWhiteSpace(UnStructuredData);
            return IsCompleted;
        }
    }
}
