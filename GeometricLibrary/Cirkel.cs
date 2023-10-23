using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Cirkel : Geometri
    {
        public int Radie; // A field.
        public Cirkel()
        {
            Radie = 5;
        } // Constructor that gives the field a value.


        public override double Area()
        {
            InputArea = _pi * Radie * Radie;
            return InputArea;
        } // Method to calculate the area of a cirkel.
    }
}
