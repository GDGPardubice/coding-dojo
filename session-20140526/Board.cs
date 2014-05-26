using System.Collections.Generic;

namespace LangtonsAnt
{
    public class Board
    {
        private readonly ISet<Position> _blackCells = new HashSet<Position>();

        public bool IsWhite(Position position)
        {
            return !IsBlack(position);
        }

        public void ChangeColor(Position position)
        {
            if (IsBlack(position)) _blackCells.Remove(position);
            else _blackCells.Add(position);
        }

        public bool IsBlack(Position position)
        {
            return _blackCells.Contains(position);
        }
    }
}