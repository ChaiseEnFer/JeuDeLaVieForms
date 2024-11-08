using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_la_vie_console
{
    internal struct Coords
    {
        private readonly int _x;
        private readonly int _y;

        public int x { get { return _x; } }
        public int y { get { return _y; } }

        public Coords(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
