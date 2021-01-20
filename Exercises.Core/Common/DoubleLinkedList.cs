namespace Exercises.Core.Common
{
    public class DoubleLinkedList<T>
    {
		public T Value { get; set; }

		public DoubleLinkedList<T> PreviousLink { get; set; }
		public DoubleLinkedList<T> NextLink { get; set; }

		public DoubleLinkedList(T value)
		{
			Value = value;
		}

		public DoubleLinkedList<T> this[int index]
		{
            get
            {
                if (index == 0)
                {
					return this;
                }
                if (index > 0)
                {
                    if (NextLink == null)
                    {
						return null;
                    }
					return NextLink[--index];
                }
				if (PreviousLink == null)
				{
					return null;
				}
				return PreviousLink[++index];
			}
		}

		public static readonly DoubleLinkedList<T> Empty = new DoubleLinkedList<T>(default(T));
	}
}
