using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonachiSeries
{
    class ReverseNumber
    {
        //fields
        int number;
        int n1 = 0;
        //constructr
        public ReverseNumber(int NUMBER)
        {
            this.number = NUMBER;
        }



        //metthod
        //1.We need to calculate the remainder of the number using the modulus
        public void SolutionForReverseNumber()
        {
            while (number > 0)
            {
                int remainder = number % 10; //save remainder
                n1 = (n1 * 10) + remainder; // save next Number
                number = number / 10;     
            }
            Console.WriteLine("Reverse No. is {0}", n1);

        }
    }
}