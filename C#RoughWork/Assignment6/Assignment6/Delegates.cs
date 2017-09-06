using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment6.Program;

namespace Assignment6
{
    public class Delegates
    {
        public void getInfo(Delegates d)
        {
            Console.Write("Enter principal = ");
            float p = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter rate = ");
            float r = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter no. of years = ");
            int y = Convert.ToInt32(Console.ReadLine());

            //Instance method
            Console.WriteLine("Using Instance Method -");
            CalculateSimpleInterest d0 = new CalculateSimpleInterest(d.getTotalInterest);
            d0+=new CalculateSimpleInterest(d.getInterestRatePerYear);
            d0(p, r, y);

            //Anonymous method
            Console.WriteLine("Using Anonymous Method -");
            CalculateSimpleInterest d1 = delegate (float pricipal, float rate, int years)
            {
                Console.WriteLine("Interest is = " + (pricipal * rate * years));
            };
            d1+= delegate (float pricipal, float interest, int years)
            {
                Console.WriteLine("Rate is = " + (pricipal * years) / interest);
            };
            d1(p, r, y);

            //Lambda Expression
            Console.WriteLine("Using Lambda Expression -");
            CalculateSimpleInterest d2 = (pricipal, rate, years) =>
            {
                Console.WriteLine("Interest is = " + (pricipal * rate * years));
            };
            d2 += (pricipal, interest, years) =>
            {
                 Console.WriteLine("Rate is = " + (pricipal * years) / interest);
            };
            d2(p, r, y);
        }

        public void getTotalInterest(float pricipal, float rate, int years)
        {
            Console.WriteLine("Interest is = " + (pricipal*rate*years));
        }

        public void getInterestRatePerYear(float pricipal, float interest, int years)
        {
            Console.WriteLine("Rate is = " + (pricipal *years)/interest);
        }

        public float returnTotalInterest(float pricipal, float rate, int years)
        {
            return (pricipal * rate * years);
        }
    }
}
