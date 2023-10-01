using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    // Here's an example of handling errors and exceptions in a clean and organized manner in C#
    public class ErrorHandlingExample
    {
        public static void Main()
        {
            try
            {
                // Code that may throw an exception
                int result = Divide(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                // Handle specific exception type
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine($"Exception Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle general exception
                Console.WriteLine("An error occurred.");
                Console.WriteLine($"Exception Details: {ex.Message}");
            }
            finally
            {
                // Clean up or resource release operations
                Console.WriteLine("Cleanup operations...");
            }
        }

        // Custom method that throws an exception
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }

    // In this example, we have a try-catch-finally block that demonstrates error handling
    // By following these strategies, you can handle errors and exceptions in a clean and organized manner, providing informative error messages and performing necessary cleanup operations.
}
