using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeaningfulNames
{
    // Using meaningful names in this way improves code readability and makes it easier for other developers to understand and work with the code.
    // It also enhances code maintainability, as it becomes easier to modify or extend the functionality of the  `Customer`  class based on the clarity of the variable names.
    public class Customer
    {
        private string customerName;
        private int customerAge;

        public Customer(string name, int age)
        {
            customerName = name;
            customerAge = age;
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Customer Age: {customerAge}");
        }
    }
}
