namespace LangtonsAnt
{
    public class Position
    {
        private readonly int _x;
        private readonly int _y;

        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var position = (Position)obj;
            if (_x != position._x || _y != position._y)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_x * 397) ^ _y;
            }
        }


    }
}