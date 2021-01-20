namespace Exercises.MarsRover
{
    public class Direction
    {
        public char Identifier { get; set; }
        public Point PositionChange { get; set; }

        public Direction(char identifier, Point change)
        {
            Identifier = identifier;
            PositionChange = change;
        }

        public override string ToString()
        {
            return $"{Identifier}";
        }

        public static readonly Direction Empty = new Direction(' ', new Point(0, 0));
    }
}
