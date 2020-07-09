using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Composition
{
    class Monitor
    {
        private string _model;
        private string _manufacturer;
        private int size;
        private Resolution _nativeResolution;

        public Monitor(string model, string manufacturer, int size, Resolution nativeResolution)
        {
            _model = model;
            _manufacturer = manufacturer;
            this.size = size;
            _nativeResolution = nativeResolution;
        }

        public string Model { get => _model; }
        public string Manufacturer { get => _manufacturer; }
        public int Size { get => size;  }
        public Resolution NativeResolution { get => _nativeResolution; }

        public void drawPixelAt(int x, int y, String color)
        {
            Console.WriteLine("Drawing pixel at " + x + "," + y + " in color " + color);
        }
    }
}
