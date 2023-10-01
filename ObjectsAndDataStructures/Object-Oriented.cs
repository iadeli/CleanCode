using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndDataStructures
{
    // Object-Oriented Programming (OOP) Approach
    public class Circle
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }

    // In this example, the OOP approach is used to design the  Circle  and  Rectangle  classes.
    // Each class represents a geometric shape and encapsulates both data (properties) and behavior (methods).
    // The classes have properties to store the relevant dimensions (radius for  Circle  and length/width for  Rectangle ) and a method ( CalculateArea() ) to compute the area of the shape. 
}
