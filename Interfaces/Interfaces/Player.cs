using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Player : ISaveable
    {
        private string _name;
        private int _hitpoint;
        private int _strength;
        private string _weapon;


        public Player(string name, int hitpoint, int strength)
        {
            _name = name;
            _hitpoint = hitpoint;
            _strength = strength;
            _weapon = "Sword";
        }

        public string Name { get => _name; set => _name = value; }
        public int Hitpoint { get => _hitpoint; set => _hitpoint = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public string Weapon { get => _weapon; set => _weapon = value; }

        public override string ToString()
        {
            return "Player{ " +
                "name=" + _name +
                " hitPoint=" + _hitpoint +
                " strength=" + _strength +
                " weapon=" + _weapon +" }";
        }

        public List<string> write()
        {
            List<string> values = new List<string>();

            values.Insert(0, _name);
            values.Insert(1, "" + _hitpoint);
            values.Insert(2, "" + _strength);
            values.Insert(3, _weapon);

            return values;
        }
        public void read(List<string> savedValues)
        {
            if(savedValues != null && savedValues.Count > 0)
            {
                _name = savedValues.ElementAt(0);
                _hitpoint = int.Parse(savedValues.ElementAt(1));
                _strength = int.Parse(savedValues.ElementAt(2));
                _weapon = savedValues.ElementAt(3);
            }
        }


    }
}
