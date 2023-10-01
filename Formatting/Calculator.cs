using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Formatting
{
    // Here's an example that demonstrates the importance of consistent code formatting in C#
    public class Calculator
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Subtract(int a, int b)
        {
            int difference = a - b;
            return difference;
        }

        public int Multiply(int a, int b)
        {
            int product = a * b;
            return product;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            int quotient = a / b;
            return quotient;
        }
    }

    // In this example, consistent code formatting is applied to enhance readability:  
    // 1. Indentation: The code is consistently indented using a standard number of spaces(usually 4 or 2) to visually represent the structure and hierarchy of the code. 
    // 2. Spacing: There is consistent spacing around operators, such as the addition, subtraction, multiplication, and division operators.This improves readability and makes the code easier to understand.  
    // 3. Braces: The opening and closing braces for classes, methods, and control structures are consistently placed on separate lines, following a standard convention. This helps in visually distinguishing the different code blocks.  
    // 4. Naming Conventions: The naming conventions for classes, methods, variables, and parameters are consistently followed.This ensures that the code is self-explanatory and easy to understand.
    // By adhering to consistent code formatting practices, the code becomes more readable, making it easier for developers to understand and maintain.
    // It also improves collaboration as team members can quickly grasp the structure and logic of the code, leading to more efficient development and reduced chances of introducing errors.
}
