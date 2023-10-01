using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Comments
{
    // Here's an example of writing effective comments in C#
    public class Calculator
    {
        // This method calculates the sum of two numbers
        public int Add(int a, int b)
        {
            // Perform the addition operation
            int sum = a + b;

            // Return the sum
            return sum;
        }

        // This method checks if a number is positive
        public bool IsPositive(int number)
        {
            // Check if the number is greater than zero
            bool isPositive = number > 0;

            // Return the result
            return isPositive;
        }
    }

    // In this example, comments are used effectively to provide clarity and understanding: 
    // 1. The comment above the  Add method explains its purpose, which is to calculate the sum of two numbers. 
    // 2. Inside the  Add method, a comment is used to indicate the step where the addition operation is performed. 
    // 3. Similarly, the IsPositive  method has a comment explaining its purpose, which is to check if a number is positive. 
    // 4. Inside the  IsPositive method, a comment is used to indicate the step where the comparison is made to determine if the number is positive.    
    // These comments provide valuable information about the purpose and logic of the code, making it easier for other developers to understand and work with the code.
    // Remember to keep the comments concise, clear, and focused on providing insights that are not immediately obvious from the code itself.
}
