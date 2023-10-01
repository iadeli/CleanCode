using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Functions
{
    // In this example, we have a function called  `CalculateSum`  that takes an array of integers as input and calculates the sum of all the numbers in the array. 
    public class Calculator
    {
        public int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }

    // The function is clean and concise for several reasons:
    // 1. Single Responsibility: The function has a single responsibility, which is to calculate the sum of the numbers.It doesn't perform any unrelated tasks.
    // 2. Descriptive Naming: The function name,  `CalculateSum` , clearly indicates its purpose.It accurately describes what the function does, making it easier to understand.
    // 3. Limited Function Length: The function is short and focused.It performs a specific task and doesn't contain unnecessary or unrelated code. This improves readability and maintainability.
    // 4. Proper Use of Parameters: The function takes an array of integers as a parameter, clearly indicating the expected input.This helps other developers understand how to use the function correctly.
    // 5. Clear Return Value: The function returns an integer value, which is the calculated sum.The return type accurately represents the result of the operation.
}
