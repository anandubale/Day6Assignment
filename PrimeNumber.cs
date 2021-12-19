using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonachiSeries
{
    class PrimeNumber

    {
        //Fields

        int number;
        //Constructor
        public PrimeNumber(int NUMBER)
        {
            this.number = NUMBER;
        }



        //Method

        public string SolutionForPrimeNumber()
        {
            for (int i=2; i <= (number -1); i++)
            {
                if(number % i == 0)
                {
                    return "this is not Prime Number";
                }
            }
            return "this is  Prime Number";    
        }


    }
}
