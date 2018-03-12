using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelptionSolution
{
    class Program
    {

        /*  Use exsiting code
         *  int intValue = 32;
            object objValue = intValue;
            string strValue;

            strValue = (string)objValue; 

         *  Create exception handeling routine 
         *  Catch the InvalidCastException 
         * 
         */

        static void Main(string[] args)
        {
            int intValue = 32;
            object objValue = intValue;
            string strValue;
            try
            {
                strValue = (string)objValue;
            }
            catch (InvalidCastException ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine(); 
            }

        }
    }
}
