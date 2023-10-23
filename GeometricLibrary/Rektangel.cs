using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Rektangel : Geometri
    {
        public override double InputArea { get; set; }
        public Rektangel()
        {
            Höjd = 15;
            Bredd = 25;
        }
        public override double Area()
        {
            InputArea = Bredd * Höjd;
            return InputArea;
        }
    }
}
