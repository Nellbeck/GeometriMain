using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Cirkel : Geometri // Sub-class that inherit from the base-class.
    {
        int _radie; // A field.
        public Cirkel()
        {
            _radie = 5;
        } // Constructor that gives the field a value.


        public override double Area()
        {
            InputArea = _pi * _radie * _radie;
            return InputArea;
        } // Method to calculate the area of a cirkel.
    }
}
