using System;
using System.Collections.Generic;
using System.Linq;
using UniversityPhysics.Enums;
using UniversityPhysics.Helpers;
using UniversityPhysics.UnitsAndConstants;

namespace Unit_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            //Introduction and Initial Display of Unit Types
            Console.WriteLine("Welcome To Unit Converter 2020. \n \nPlease enter" +
                " the type of unit you would like to convert from the list below.");

            List<string> unitTypes = new List<string> {"Mass", "Energy", "Time", "Momentum"};
            foreach (string m in unitTypes)
            {
                Console.WriteLine(m);
            }
            string UnitType = Console.ReadLine();


            //Unit Type Logic that creates the unit object they want to convert with their specified parameter
            switch (UnitType)
            {
                case "Mass":
                    Console.WriteLine("What is the value of the mass?");
                    double massValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Specify unit type (e.g. Kilograms, Solarmass, AMU");
                    string unit = Console.ReadLine();
                    switch (unit)
                    {
                        case "Kilograms":
                            {
                                Mass m = new Mass(massValue, MassMeasure.Kilogram);

                                Console.WriteLine($"Here are the conversions for {massValue} kilograms:\n\n" +
                                    $"eV = {m.eV}\n" +
                                    $"AMU = {m.AMUs}\n" +
                                    $"SolarMass = {m.SolarMasses}\n" +
                                    $"MeV = {m.MeV}\n");
                                break;

                            }
                        case "Solarmass":
                            {
                                Mass m = new Mass(massValue, MassMeasure.Kilogram);
                                Console.WriteLine($"Here are the conversions for {massValue} SolarMasses:\n\n" +
                                    $"Kilograms = {m.Kilograms}\n" +
                                    $"eV = {m.eV}\n" +
                                    $"AMU's = {m.AMUs}\n" +
                                    $"MeV = {m.MeV}\n");
                                break;
                            }
                        case "AMU":
                            {
                                Mass m = new Mass(massValue, MassMeasure.Kilogram);
                                Console.WriteLine($"Here are the conversions for {massValue} AMU's:\n\n" +
                                    $"Kilograms = {m.Kilograms}\n" +
                                    $"eV = {m.eV}\n" +
                                    $"SolarMass = {m.SolarMasses}\n" +
                                    $"MeV = {m.MeV}\n");
                                break;
                            }
                    }

                    

                    break;


            }


            


      

            
            

                

            

            

            

        }
    }
}
