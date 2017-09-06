using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class ZeroTemperatureException : Exception
    {
        public ZeroTemperatureException(string message) : base(message)
        {

        }
    }

    public class Temperature
    {
        double temperature;
        public void SHowTemperature()
        {
            Console.WriteLine("Enter the temperature = ");
            temperature = Convert.ToInt64(Console.ReadLine());

            if (temperature == 0)
            {
                throw (new ZeroTemperatureException("Zero Temperature Exception."));
            }
            else
            {
                Console.WriteLine("Temperature is = " + temperature);
            }
        }
    }
}
