using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_la_vie_console
{
    internal class Grid
    {
        public Cell[,] TabCells;
        private int _width;
        private int _height;

        public Grid(int width, int height)
        {
            _width = width;
            _height = height;
            TabCells = new Cell[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    TabCells[i, j] = new Cell(false);
                }
            }
        }

        /*public void DisplayGrid()
        {
            Console.Clear();

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    Console.Write(TabCells[i, j].isAlive ? "X" : ".");
                }
                Console.WriteLine();
            }
        }*/

        public void Update()
        {

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    int aliveNeighbours = 0;
                    for (int x = i - 1; x <= i + 1; x++)
                    {
                        for (int y = j - 1; y <= j + 1; y++)
                        {
                            if (x >= 0 && x < _width && y >= 0 && y < _height && !(x == i && y == j))
                            {
                                if (TabCells[x, y].isAlive)
                                {
                                    aliveNeighbours++;
                                }
                            }
                        }
                    }
                    if (TabCells[i, j].isAlive)
                    {
                        if (aliveNeighbours < 2 || aliveNeighbours > 3)
                        {
                            TabCells[i, j].PassAway();
                        }
                    }
                    else
                    {
                        if (aliveNeighbours == 3)
                        {
                            TabCells[i, j].ComeAlive();
                        }
                    }
                }
            }
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    TabCells[i, j].Update();
                }
            }
        }
    }
}
