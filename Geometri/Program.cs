using GeometricLibrary;
// Since GeometricLibrary have a diffrent namespace I have to grant the main class access to that class library.
namespace GeometriMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Geometri> geometriArea = new List<Geometri>() 
            { 
                new Fyrkant(),
                new Cirkel(),
                new Rektangel(),
                new Parallellogram(),
                new Ellips()
            };
            // A list that works like an array of all the instance calls.

            
            string[] geometriForm = { "Fyrkant", "Cirkel", "Rektangel", "Parallellogram", "Ellips" };

            for (int indexNumber = 0; indexNumber < geometriForm.Length; indexNumber++)
            {
                Console.WriteLine($"Area {geometriForm[indexNumber]}: {geometriArea[indexNumber].Area()}");
            } // A for loop to loop the both arrays and the method.
        }
    }
}