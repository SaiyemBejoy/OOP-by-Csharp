using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    class Resolution
    {
        private int _width;
        private int _height;

        public Resolution(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int Width { get => _width; }
        public int Height { get => _height; }
    }
}
