using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Printer
    {
        private int _tonerLevel;
        private int _pagesPrinted;
        private bool _duplex;

        public Printer(int tonerLevel, bool duplex)
        {
            if(_tonerLevel > -1 && _tonerLevel <= 100)
            {
                _tonerLevel = tonerLevel;
            }
            else
            {
                _tonerLevel = -1;
            }
            _duplex = duplex;
            _pagesPrinted = 0;
        }


        public int addToner(int tonerAmount)
        {
            if(tonerAmount > 0 && tonerAmount <= 100)
            {
                if(_tonerLevel + tonerAmount > 100)
                {
                    return -1;
                }
                _tonerLevel += tonerAmount;
                return _tonerLevel;
            }
             return -1;
        }

        public int printPages(int pages)
        {
            int pagesToPring = pages;
            if (_duplex)
            {
                pagesToPring = (pages / 2) + (pages % 2);
                Console.WriteLine("Printing in duplex mode");
            }
            _pagesPrinted += pagesToPring;
            return pagesToPring;
        }
        public int PagesPrinted { get => _pagesPrinted; }
    }
}
