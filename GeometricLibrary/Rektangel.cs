using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Rektangel : Geometri // Sub-class that inherit from the base-class.
    {
        public override double InputArea { get; set; } // Property that overrides the one from the base class.
        public Rektangel()
        {
            Höjd = 15;
            Bredd = 25;
        } //Constructor that set some values to the propertys from the baseclass.
        public override double Area()
        {
            InputArea = Bredd * Höjd;
            return InputArea;
        }// Method that overrides the one from the base class.
    }
}
