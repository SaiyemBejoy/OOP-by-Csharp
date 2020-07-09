using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    class MotherBoard
    {
        private string _model;
        private string _manufacturer;
        private int _ramSlots;
        private int _cardSlots;
        private string _bios;

        public MotherBoard(string model, string manufacturer, int ramSlots, int cardSlots, string bios)
        {
            _model = model;
            _manufacturer = manufacturer;
            _ramSlots = ramSlots;
            _cardSlots = cardSlots;
            _bios = bios;
        }

        public void loadProgram(string programName)
        {
            Console.WriteLine("Program " + programName + " is now loading...");
        }

        public string Model { get => _model; }
        public string Manufacturer { get => _manufacturer; }
        public int RamSlots { get => _ramSlots; }
        public int CardSlots { get => _cardSlots; }
        public string Bios { get => _bios; }
    }
}
