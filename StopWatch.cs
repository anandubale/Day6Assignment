using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Asssignments
{
    class StopWatch
    {
        //fields

        string Start;
        int ms = 0;
        int s = 0;
        int m = 0;
        int h = 0;


        //contructor
        public StopWatch(string START)
        {
            this.Start = START;
        }

        //method
        public void SolutionForStopWatch()
        {

            if (s == 59)
            {
                s = 0;
                m = m + 1;
                if (m == 59)
                {
                    m = 0;
                    h = h + 1;








                }
            }
        }
    }
}