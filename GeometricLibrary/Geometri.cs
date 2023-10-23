namespace GeometricLibrary
{
    public class Geometri // Base class.
    {
        public int Höjd { get; set; }
        public int Bredd { get; set; }
        public virtual double InputArea { get; set; } // Some propertys.
        public double _pi = 3.14F;

        public virtual double Area() // Base class method.
        {
            InputArea = Höjd * Bredd;

            return InputArea;
        }
    }
}