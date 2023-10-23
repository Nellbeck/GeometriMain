namespace GeometricLibrary
{
    public abstract class Geometri // Base class.
    {
        public int Höjd { get; set; }
        public int Bredd { get; set; }
        public abstract double InputArea { get; set; } // Some propertys.
        public double _pi = 3.14F;

        public abstract double Area(); // Base class method.
    }
}