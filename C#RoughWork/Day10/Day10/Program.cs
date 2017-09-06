using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            //ErrorsException ee = new ErrorsException();
            //ee.ExceptionHandling();

            Temperature t = new Temperature();
            try { t.SHowTemperature(); }
            catch(ZeroTemperatureException z)
            {
                Console.WriteLine(z.Message); //console message printed
            }
            //t.SHowTemperature(); //if else directly

            Console.Read();
        }
    }
}
