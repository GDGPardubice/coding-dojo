namespace LangtonsAnt
{
    public enum Direction
    {
        North, East, South, West
    };

    public static class DirectionExtension
    {
        public static Direction GetDirectionOnLeft(this Direction direction)
        {
            if (direction == Direction.North)
                return Direction.West;
            return direction - 1;
        }
        public static Direction GetDirectionOnRight(this Direction direction)
        {
            if (direction == Direction.West)
                return Direction.North;
            return direction + 1;
        }
    };
}