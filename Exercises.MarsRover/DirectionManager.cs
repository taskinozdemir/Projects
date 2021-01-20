using Exercises.Core.Common;
using System.Collections.Generic;

namespace Exercises.MarsRover
{
    public class DirectionManager : IDirectionManager
    {
        private static readonly object locker = new object();
        private static IDirectionManager instance;

        private readonly Dictionary<char, DoubleLinkedList<Direction>> linkedDirections;

        public static IDirectionManager Instance
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
                    instance = new DirectionManager();
                }
                return instance;
            }
        }

        private DirectionManager()
        {
            linkedDirections = CreateDirectionDictionary();
        }

        public DoubleLinkedList<Direction> GetDirection(char identifier)
        {
            DoubleLinkedList<Direction> returnValue;
            if (!linkedDirections.TryGetValue(identifier, out returnValue))
            {
                return DoubleLinkedList<Direction>.Empty;
            }
            return returnValue;
        }

        private static Dictionary<char, DoubleLinkedList<Direction>> CreateDirectionDictionary()
        {
            DoubleLinkedList<Direction>[] ordered = GetOrderedDirections();

            var directions = new Dictionary<char, DoubleLinkedList<Direction>>();

            DoubleLinkedList<Direction> previous = ordered[ordered.Length - 1];
            foreach (var current in ordered)
            {
                current.PreviousLink = previous;
                previous.NextLink = current;
                directions.Add(current.Value.Identifier, current);

                previous = current;
            }

            return directions;
        }
        private static DoubleLinkedList<Direction>[] GetOrderedDirections()
        {
            var north = new DoubleLinkedList<Direction>(new Direction('N', new Point(0, 1)));
            var east = new DoubleLinkedList<Direction>(new Direction('E', new Point(1, 0)));
            var south = new DoubleLinkedList<Direction>(new Direction('S', new Point(0, -1)));
            var west = new DoubleLinkedList<Direction>(new Direction('W', new Point(-1, 0)));

            return new DoubleLinkedList<Direction>[] { north, east, south, west };
        }
    }
}
