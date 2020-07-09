using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    class PC
    {
        private Case _case;
        private Monitor _monitor;
        private MotherBoard _motherBoard;

        public PC(Case aCase, Monitor monitor, MotherBoard motherBoard)
        {
            _case = aCase;
            _monitor = monitor;
            _motherBoard = motherBoard;
        }

        public Case Case { get => _case;}
        public Monitor Monitor { get => _monitor; }
        public MotherBoard MotherBoard { get => _motherBoard; }
    }
}
