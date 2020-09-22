using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculatorPro
{
    public class InputConverter
    {
        // Create a method to make sure input is numeric
        public double ConvertInputToNumeric(string argTextInput)
        {
            // Declare a variable:
            double convertedNumber;
            // Check if the input was numeric and throw an exception if not:
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value.\r\n");
            return convertedNumber;
        }
    }
}
