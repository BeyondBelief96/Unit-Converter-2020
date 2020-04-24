using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UniversityPhysics.Enums;
using UniversityPhysics.Helpers;
using UniversityPhysics.UnitsAndConstants;

namespace Unit_Converter
{
    class Program
    {       
        static void Main(string[] args)
        {
            Length L1 = new Length(10, LengthMeasure.Meter);
            Length L2 = new Length(20, LengthMeasure.Meter);

            var L3 = L2 - L1;

            //Introduction and Initial Display of Unit Types
            Console.WriteLine("Welcome To SI Unit Converter 2020. \n \nPlease enter" +
                " the type of unit you would like to convert from the list below:\n");

            List<string> unitTypes = new List<string> {"Length", "Mass", "Energy", "Temperature"};
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
                case "Length":
                    {
                        Console.WriteLine("Enter the value of the length: ");
                        double lengthvalue = double.Parse(Console.ReadLine());

                        Console.WriteLine("Specify the unit type from the list: Meters = m, Kilometers = km, Centimeters = cm, Millimeters = mm, Nanometers = nm ");
                        string unit = Console.ReadLine();
                        switch (unit)
                        {
                            case "m":
                                {
                                    Conversions.LengthConversions(lengthvalue, LengthMeasure.Meter);
                                    break;
                                }
                            case "km":
                                {
                                    Conversions.LengthConversions(lengthvalue, LengthMeasure.Kilometer);
                                    break;
                                }
                            case "cm":
                                {
                                    Conversions.LengthConversions(lengthvalue, LengthMeasure.Centimeter);
                                    break;
                                }
                            case "mm":
                                {
                                    Conversions.LengthConversions(lengthvalue, LengthMeasure.Millimeter);
                                    break;
                                }
                            case "nm":
                                {
                                    Conversions.LengthConversions(lengthvalue, LengthMeasure.Nanometer);

                                    break;
                                }

                        }

                        break;
                    }



            }

            


            


      

            
            

                

            

            

            

        }
    }
}
