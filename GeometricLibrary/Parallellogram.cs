using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Parallellogram : Geometri
    {
        public override double InputArea { get; set; }
        public Parallellogram()
        {
            Bredd = 5;
            Höjd = 10;
        }
        public override double Area()
        {
            InputArea = Bredd * Höjd;
            return InputArea;
        }
    }
}
