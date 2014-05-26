namespace LangtonsAnt
{
    

    public class Ant
    {
        private readonly Position _position;
        private Direction _direction = Direction.North;

        public Ant(Position position)
        {
            _position = position;
        }

        public bool IsOrientedToNorth()
        {
            return _direction == Direction.North;
        }

        public void TurnRight()
        {
            _direction = _direction.GetDirectionOnRight();
        }

        public bool IsOrientedToEast()
        {
            return _direction == Direction.East;
        }

        public void TurnLeft()
        {
            _direction = _direction.GetDirectionOnLeft();
        }

        public bool IsOrientedToWest()
        {
            return _direction == Direction.West;
        }

        public bool IsOrientedToSouth()
        {
            return _direction == Direction.South;
        }

        public Position GetPosition()
        {
            return _position;
        }
    }
}