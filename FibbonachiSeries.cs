using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonachiSeries
{

    //next number is the sum of previous two numbers
    //for  + number should get interchange 

    class FibbonachiSeries
    {
        int n1 = 0;
        int n2 = 1;
        int n3;
        int number;

        public  FibbonachiSeries(int NUMBER)
        {
            this.number = NUMBER;

        }


        public void Solution()
        {
            Console.Write(n1 + " " + n2 + " "); //have to print 0 and 1 first


            for (int i = 2; i < number; ++i) // loop thr number after 2
                                            
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
