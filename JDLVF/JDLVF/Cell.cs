using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_la_vie_console
{
    internal class Cell
    {
        private bool _isAlive;
        private bool _nextState;

        public bool isAlive { get => _isAlive; set => _isAlive = value; }
        public bool nextState { get => _nextState; set => _nextState = value; }

        public Cell(bool state) 
        { 
        
        }

        public void ComeAlive()
        {
            _nextState = true;
        }

        public void PassAway() 
        {
            _nextState = false;
        }

        public void Update()
        {
            _isAlive = _nextState;
        }
    }
}
