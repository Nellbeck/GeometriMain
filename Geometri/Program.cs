﻿using GeometricLibrary;
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
            // A generic list that works like an array that holds all the instances.

            string[] geometriForm = { "Fyrkant", "Cirkel", "Rektangel", "Parallellogram", "Ellips" };

            for (int indexNumber = 0; indexNumber < geometriForm.Length; indexNumber++)
            {
                Console.WriteLine($"Area {geometriForm[indexNumber]}: {geometriArea[indexNumber].Area()}");
            } // A for loop to loop both the generic list, the array and the method they hold. 
        }
    }
}