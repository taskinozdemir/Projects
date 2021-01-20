namespace Exercises.MarsRover
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.X < p2.X || p1.Y < p2.Y;
        }
        public static bool operator >(Point p1, Point p2)
        {
            return p1.X > p2.X || p1.Y > p2.Y;
        }
    }
}
