using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Ellips : Geometri
    {
        double RadieA;
        double RadieB; // Some fields.
        public Ellips()
        {
            RadieA = 8;
            RadieB = 10;
        } // Constructor that gives the fields some values.

        public override double Area()
        {
            InputArea = RadieA * RadieB * _pi;
            return InputArea;
        } // Method that overrides the one from the base class.
    }
}
