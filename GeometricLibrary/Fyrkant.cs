using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Fyrkant : Geometri // Sub-class that inherit from the base-class.
    {
        public override double InputArea { get; set; } // Property that overrides the one from the base class.
        public Fyrkant()
        {
            Höjd = 8;
            Bredd = 8; 
        } //Constructor that set some values to the propertys from the baseclass.

        public override double Area()
        {
            InputArea = Bredd * Höjd;
            return InputArea;
        } 
    }
}
