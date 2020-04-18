using System;
using System.Collections.Generic;
using System.Text;
using UniversityPhysics.Enums;
using UniversityPhysics.UnitsAndConstants;

namespace Unit_Converter
{
    public class Conversions
    {
        public static void MassConversions(double massvalue, MassMeasure unittype)
        {
            Mass m = new Mass(massvalue, unittype);
            Console.WriteLine($"Here are the conversions for  {massvalue} {unittype.ToString()}'s:\n\n" +
                $"{Enum.GetName(typeof(MassMeasure), 0)} = {m.Kilograms}\n" +
                $"{Enum.GetName(typeof(MassMeasure), 1)} = {m.SolarMasses}\n" +
                $"{Enum.GetName(typeof(MassMeasure), 2)} = {m.AMUs}\n" +
                $"{Enum.GetName(typeof(MassMeasure), 3)} = {m.eV}\n" +
                $"{Enum.GetName(typeof(MassMeasure), 4)} = {m.MeV}\n" +
                $"{Enum.GetName(typeof(MassMeasure), 5)} = {m.PlanckMasses}\n");
        }

        public static void EnergyConversions(double eValue, EnergyMeasure unittype)
        {
            Energy e = new Energy(eValue, unittype);
            Console.WriteLine($"Here are the conversions for  {eValue} {unittype.ToString()}'s:\n\n" +
                $"{Enum.GetName(typeof(EnergyMeasure), 0)} = {e.Joules}\n" +
                $"{Enum.GetName(typeof(EnergyMeasure), 1)} = {e.ElectronVolts}\n" +
                $"{Enum.GetName(typeof(EnergyMeasure), 2)} = {e.MegaElectronVolts}\n" +
                $"{Enum.GetName(typeof(EnergyMeasure), 3)} = {e.KilowattHours}\n");

        }

        public static void TemperatureConversions(double tempvalue, TemperatureType unittype)
        {
            Temperature T = new Temperature(tempvalue, unittype);
            Console.WriteLine($"Here are the conversions for  {tempvalue} {unittype.ToString()}'s:\n\n" +
                $"{Enum.GetName(typeof(TemperatureType), 0)} = {T.Fahrenheit}\n" +
                $"{Enum.GetName(typeof(TemperatureType), 1)} = {T.Celsius}\n" +
                $"{Enum.GetName(typeof(TemperatureType), 2)} = {T.Kelvin}\n");


        }

        
    }
}
