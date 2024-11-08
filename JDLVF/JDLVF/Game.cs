using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jeu_de_la_vie_console
{
    internal class Game
    {
        private int n;
        private int iter;
        public Grid grid;
        List<Coords> AliveCellCoords;
        private Random rnd = new Random();

        public Game(int nbCells, int nbIterations, int random)
        {
            n = nbCells;
            iter = nbIterations;
            AliveCellCoords = new List<Coords>();

            for (int i = 0; i < random; i++)
            {
                int x = rnd.Next(0, n);
                int y = rnd.Next(0, n);
                AliveCellCoords.Add(new Coords(x, y));
            }

            grid = new Grid(n, n);

            foreach (Coords coords in AliveCellCoords)
            {
                grid.TabCells[coords.x, coords.y].ComeAlive();
            }
        }

        public void RunGameConsole()
        {
            //grid.DisplayGrid();
            for (int i = 0; i < iter; i++)
            {
                grid.Update();
                //grid.DisplayGrid();
                //Thread.Sleep(1000);
            }
        }
    
    }
}
