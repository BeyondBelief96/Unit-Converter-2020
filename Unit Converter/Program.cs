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
            Console.WriteLine("Welcome To SI Unit Converter 2020. \n \nPlease enter" +
                " the type of unit you would like to convert from the list below:\n");

            List<string> unitTypes = new List<string> {"Mass", "Energy", "Time"};
            foreach (string m in unitTypes)
            {
                Console.WriteLine(m);
            }
            string UnitType = Console.ReadLine();


            //Unit Type Logic that creates the unit object they want to convert with their specified parameter
            switch (UnitType)
            {
                case "Mass":
                    {
                        Console.WriteLine("Enter the value of the mass: ");
                        double massValue = double.Parse(Console.ReadLine());

                        Console.WriteLine("Specify unit type from the list: Kilograms, Solarmass, AMU, eV, MeV, PlanckMass");
                        string unit = Console.ReadLine();
                        switch (unit)
                        {
                            case "Kilograms":
                                {
                                    Conversions.MassConversions(massValue, MassMeasure.Kilogram);
                                    break;
                                }
                            case "Solarmass":
                                {
                                    Conversions.MassConversions(massValue, MassMeasure.SolarMass);
                                    break;
                                }
                            case "AMU":
                                {
                                    Conversions.MassConversions(massValue, MassMeasure.AtomicMassUnit);
                                    break;
                                }
                            case "eV":
                                {
                                    Conversions.MassConversions(massValue, MassMeasure.eV);
                                    break;
                                }
                            case "MeV":
                                {
                                    Conversions.MassConversions(massValue, MassMeasure.MeV);

                                    break;
                                }
                            case "PlanckMass":
                                {
                                    Conversions.MassConversions(massValue, MassMeasure.PlanckMass);

                                    break;
                                }

                        }
                        break;
                    }

                case "Energy":
                    {
                        Console.WriteLine("Enter the value of the energy: ");
                        double eValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Specify the unit type from the list: Joules, eV, MeV, kWh");
                        string unit = Console.ReadLine();
                        switch (unit)
                        {
                            case "Joules":
                                {
                                    Conversions.EnergyConversions(eValue, EnergyMeasure.Joule);
                                    break;
                                }
                            case "eV":
                                {
                                    Conversions.EnergyConversions(eValue, EnergyMeasure.eV);
                                    break;
                                }
                            case "MeV":
                                {
                                    Conversions.EnergyConversions(eValue, EnergyMeasure.MeV);
                                    break;
                                }
                            case "kWh":
                                {
                                    Conversions.EnergyConversions(eValue, EnergyMeasure.kWh);
                                    break;
                                }
                        }
                        break;
                    }
                case "Temperature":
                    {
                        Console.WriteLine("Enter the value of the temperature: ");
                        double tempValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Specify the unit type from the list: Fahrenheit = F, Celcius = C, Kelvin = K");
                        string unit = Console.ReadLine();
                        switch (unit)
                        {
                            case "F":
                                {
                                    Conversions.TemperatureConversions(tempValue, TemperatureType.Fahrenheit);
                                    break;
                                }
                            case "C":
                                {
                                    Conversions.TemperatureConversions(tempValue, TemperatureType.Celsius);
                                    break;
                                }
                            case "K":
                                {
                                    Conversions.TemperatureConversions(tempValue, TemperatureType.Kelvin);
                                    break;
                                }
                        }
                        break;
                    }



            }


            


      

            
            

                

            

            

            

        }
    }
}
