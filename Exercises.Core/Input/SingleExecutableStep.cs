namespace Exercises.Core.Input
{
    public abstract class SingleExecutableStep<T> : BaseStep<T>
    {
        public override void Execute()
        {
            base.Execute();
            IsCompleted = true;
        }

        protected override bool IsCompleteMessage()
        {
            return false;
        }
    }


}
