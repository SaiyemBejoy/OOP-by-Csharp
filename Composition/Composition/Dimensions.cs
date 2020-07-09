using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    class Dimensions
    {
        private int _width;
        private int _height;
        private int _depth;

        public Dimensions(int width, int height, int depth)
        {
            _width = width;
            _height = height;
            _depth = depth;
        }

        public int Width { get => _width; }
        public int Height { get => _height; }
        public int Depth { get => _depth;  }
    }
}
