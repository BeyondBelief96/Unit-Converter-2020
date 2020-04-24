using System;
using System.Collections.Generic;
using System.Reflection;    
using System.Text;
using UniversityPhysics.Enums;
using UniversityPhysics.UnitsAndConstants;

namespace Unit_Converter
{
    public class Conversions
    {
        public static void MassConversions(double massvalue, MassMeasure unittype)
        {
            var enumcount = Enum.GetNames(typeof(MassMeasure)).Length;
            Mass m = new Mass(massvalue, unittype);
            Type type = m.GetType();
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine($"Here are the conversions for  {massvalue} {unittype.ToString()}'s:\n\n");
            for (int i = 0; i < enumcount; i++)
            {
                Console.WriteLine($"{Enum.GetName(typeof(MassMeasure), i)} = {properties[i].GetValue(m)}\n");
            }

        }

        public static void EnergyConversions(double eValue, EnergyMeasure unittype)
        {
            var enumcount = Enum.GetNames(typeof(EnergyMeasure)).Length;
            Energy e = new Energy(eValue, unittype);
            Type type = e.GetType();
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine($"Here are the conversions for  {eValue} {unittype.ToString()}'s:\n\n");
            for (int i = 0; i < enumcount; i++)
            {
                Console.WriteLine($"{Enum.GetName(typeof(EnergyMeasure), i)} = {properties[i].GetValue(e)}\n");
            }

        }

        public static void TemperatureConversions(double tempvalue, TemperatureType unittype)
        {
            var enumcount = Enum.GetNames(typeof(TemperatureType)).Length;
            Temperature T = new Temperature(tempvalue, unittype);
            Type type = T.GetType();
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine($"Here are the conversions for {tempvalue} {unittype.ToString()}:\n\n");
            for (int i = 0; i < enumcount; i++)
            {
                    Console.WriteLine($"{Enum.GetName(typeof(TemperatureType), i)} = {properties[i].GetValue(T)}\n");
            }

        }

        public static void LengthConversions(double lengthvalue, LengthMeasure unittype)
        {
            var enumcount = Enum.GetNames(typeof(LengthMeasure)).Length;
            Length L = new Length(lengthvalue, unittype);
            Type type = L.GetType();
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine($"Here are the conversions for  {lengthvalue} {unittype.ToString()}'s:\n\n");
            for (int i = 0; i < enumcount; i++)
            {
                Console.WriteLine($"{Enum.GetName(typeof(LengthMeasure), i)} = {properties[i].GetValue(L)}\n");
            }
        }

        
    }
}
