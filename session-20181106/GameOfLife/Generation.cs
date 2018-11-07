using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    public class Generation
    {
        public Generation()
        {

        }
        public Generation(Cell[] cells)
        {
            if (cells.Length <= 2)
            {
                cells.ToList().ForEach(c => deadCells.Add(c));            
            }
        }
        
        public bool Empty
        {
            get
            {
                return deadCells.Count == 0;
            }
        }

        private HashSet<Cell> deadCells = new HashSet<Cell>();
        public HashSet<Cell> DeadCells
        {
            get
            {
                return deadCells;
            }
        }
    }
}