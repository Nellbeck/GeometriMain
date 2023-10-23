using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Parallellogram : Geometri // Sub-class that inherit from the base-class.
    {
        public override double InputArea { get; set; } // Property that overrides the one from the base class.
        public Parallellogram()
        {
            Bredd = 5; 
            Höjd = 10;
        } //Constructor that set some values to the propertys from the baseclass.
        public override double Area()
        {
            InputArea = Bredd * Höjd;
            return InputArea;
        }// Method that overrides the one from the base class.
    }
}
