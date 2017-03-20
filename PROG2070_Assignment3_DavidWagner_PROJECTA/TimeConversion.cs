using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Assignment 3 PROG 2070: Project A tests interaction between Program and Convert
 * David Wagner
 * 
 * Revision History:
 * 
 * 3/12/2017 CREATED
 * 
 * 
 * */

namespace PROG2070_Assignment3_DavidWagner
{
    public static class TimeConversion
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">time value</param>
        /// <param name="convertFrom"> time unit converting from (seconds, minutes, hours, days)</param>
        /// <param name="convertTo"> time unit converting to (seconds, minutes, hours, days)</param>
        /// <returns>converted time value</returns>
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            double convertedValue = 0;
            double multiplier = 0;
            string convertFromMod = "";
            string convertToMod = "";



            try
            {
                convertFromMod = ModifyInputStub(convertFrom);
                convertToMod = ModifyInputStub(convertTo);
            }
             catch (ArgumentException ae)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n!---- INCORRECT TIME UNITS -----!");
                Console.ForegroundColor = ConsoleColor.White;

                throw ae;

               

            }
            finally
            {
                multiplier = GetMultiplierStub(convertFromMod, convertToMod);


                convertedValue = multiplier * value;
                convertedValue = Math.Round(convertedValue, 6);

               
            }



            return convertedValue;


        }

        /// <summary>
        /// Modify input stub
        /// </summary>
        /// <param name="input"></param>
        /// <returns>days</returns>
        public static string ModifyInputStub(string input)
        {
            return "days";
        }

        /// <summary>
        /// Get multiplier stub
        /// </summary>
        /// <param name="convertFrom"></param>
        /// <param name="convertTo"></param>
        /// <returns>2</returns>
        public static Double GetMultiplierStub(string convertFrom, string convertTo)
        {

            return 2d;
        }





    }
}
