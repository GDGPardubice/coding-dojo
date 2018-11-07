using System;

namespace GameOfLife
{
    public class Game
    {
        private Generation generation;

        public Game(Generation generation)
        {
            this.generation = generation;
        }

        public Generation nextGeneration()
        {
            return generation;
        }

    }

   
}

