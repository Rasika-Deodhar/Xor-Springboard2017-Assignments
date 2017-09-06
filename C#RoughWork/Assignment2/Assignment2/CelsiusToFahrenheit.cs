using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CelsiusToFahrenheit
    {
        public void CelToFahr(double cel)
        {
            double fahr;

            fahr = (cel * 1.8) + 32;

            Console.WriteLine("Fahrenheit temp is = " + fahr);

        }
    }
}
