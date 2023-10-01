using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndDataStructures
{
    // Data-Oriented Programming (DOP) Approach
    public struct Circlee
    {
        public double Radius;
    }

    public struct Rectanglee
    {
        public double Length;
        public double Width;
    }

    public static class ShapeCalculations
    {
        public static double CalculateCircleArea(Circlee circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        public static double CalculateRectangleArea(Rectanglee rectangle)
        {
            return rectangle.Length * rectangle.Width;
        }
    }

    // In this example, the DOP approach is used with structs representing the  Circle  and  Rectangle  shapes. The structs contain fields to store the dimensions.
    // Additionally, a separate static class  ShapeCalculations  is used to define methods that take the respective structs as parameters and compute the area of the shape. 
}
