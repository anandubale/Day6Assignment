using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonachiSeries
{
    class PerfectNumber
    {
        //Feilds

        int number;
        int sum = 0;
        //int n;

        //Constructor
        public PerfectNumber(int NUMBER)
        {
            this.number = NUMBER;
        }


        //Method

        public string SolutionForPerfectNumber()
        {

        
            //n = number;
            for (int i = 1; i < number; i++) //have to find out Proper Divisor
            {
                if (number % i == 0)
                {
                    sum = sum + i; //do Addition of those devisor
                }
            }
            if (sum == number) //checking the equality of sum and number if both are equal then it is perfect number
            {
               return  "Entered number is a perfect number";
            }
            else
            {
                return"Entered number is not a perfect number";
            }

        }
    }
}
