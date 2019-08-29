using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuaverCodeTest.Models
{
    public class PreambleConstitution
    {
        public static string Preamble = "We the People of the United States, in Order to form a more perfect Union, establish Justice, insure domestic Tranquility, provide for the common defence, promote the general Welfare, and secure the Blessings of Liberty to ourselves and our Posterity, do ordain and establish this Constitution for the United States of America.";

        // Return count of how many words start with "T"
        public static int StartWithT()
        {
            string[] arr = Preamble.ToLower().Split(' ');

            var results = from w in arr
                          where w.StartsWith('t')
                          select w;

            var numOfTs = 0;

            foreach(var item in results)
            {
                numOfTs++;
            }

            return numOfTs;
        }

        // Return the count of how many words start with "E
        public static int EndWithE()
        {
            string[] arr = Preamble.ToLower().Split(' ');

            var results = from w in arr
                          where w.EndsWith('e')
                          select w;

            var numOfEs = 0;

            foreach (var item in results)
            {
                numOfEs++;
            }

            return numOfEs;
        }

        // Return count of how many words start with "T" and end with "E"
        public static int StartTEndE()
        {
            string[] arr = Preamble.ToLower().Split(' ');

            var results = from w in arr
                          where w.StartsWith('t') &&
                          w.EndsWith('e')
                          select w;

            var numOfTandEs = 0;

            foreach (var item in results)
            {
                numOfTandEs++;
            }

            return numOfTandEs;
        }
    }
}
