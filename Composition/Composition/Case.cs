using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    class Case
    {
        private string _model;
        private string _manufacturer;
        private string _powerSupply;
        private Dimensions _dimensions;

        public Case(string model, string manufacturer, string powerSupply, Dimensions dimensions)
        {
            _model = model;
            _manufacturer = manufacturer;
            _powerSupply = powerSupply;
            _dimensions = dimensions;
        }

        public string Model { get => _model; }
        public string Manufacturer { get => _manufacturer; }
        public string PowerSupply { get => _powerSupply; }
        public Dimensions Dimensions { get => _dimensions; }

        public void pressPowerButton()
        {
            Console.WriteLine("Power button pressed");
        }
    }
}
