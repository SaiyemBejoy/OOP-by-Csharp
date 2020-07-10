using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Monster : ISaveable
    {
        private string _name;
        private int _hitpoint;
        private int _strength;

        public Monster(string name, int hitpoint, int strength)
        {
            _name = name;
            _hitpoint = hitpoint;
            _strength = strength;
        }

        public string Name { get => _name; }
        public int Hitpoint { get => _hitpoint; }
        public int Strength { get => _strength; }

        public override string ToString()
        {
            return "Monster{ " +
                "name=" + _name +
                " hitPoint=" + _hitpoint +
                " strength=" + _strength + " }";
        }

        public List<string> write()
        {
            List<string> values = new List<string>();

            values.Insert(0, _name);
            values.Insert(1, "" + _hitpoint);
            values.Insert(2, "" + _strength);

            return values;
        }
        public void read(List<string> savedValues)
        {
            if (savedValues != null && savedValues.Count > 0)
            {
                _name = savedValues.ElementAt(0);
                _hitpoint = int.Parse(savedValues.ElementAt(1));
                _strength = int.Parse(savedValues.ElementAt(2));
            }
        }
    }
}
