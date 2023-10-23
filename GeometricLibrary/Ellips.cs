using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Ellips : Geometri // Sub-class that inherit from the base-class.
    {
        double _radieA;
        double _radieB; // Some fields.
        public Ellips()
        {
            _radieA = 8;
            _radieB = 10;
        } // Constructor that gives the fields some values.

        public override double Area()
        {
            InputArea = _radieA * _radieB * _pi;
            return InputArea;
        } // Method that overrides the one from the base class.
    }
}
