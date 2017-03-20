﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Assignment 3 PROG 2070: Project B tests interaction 
 * between Convert and ModifyInput functions
 * David Wagner
 * 
 * Revision History:
 * 
 * 3/13/2017 CREATED
 * 
 * 
 * */

namespace PROG2070_Assignment3_DavidWagner
{
    public static class TimeConversion
    {


        /// <summary>
        /// Converts time units
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
                convertFromMod = ModifyInput(convertFrom);
                convertToMod = ModifyInput(convertTo);
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
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string ModifyInput(string input)
        {
            string modifiedInput = "";


            switch (input)
            {
                //seconds
                case "seconds":
                    modifiedInput = "seconds";
                    break;

                case "Seconds":
                    modifiedInput = "seconds";
                    break;

                case "s":
                    modifiedInput = "seconds";
                    break;

                case "S":
                    modifiedInput = "seconds";
                    break;

                //minutes
                case "minutes":
                    modifiedInput = "minutes";
                    break;

                case "Minutes":
                    modifiedInput = "minutes";
                    break;

                case "m":
                    modifiedInput = "minutes";
                    break;

                case "M":
                    modifiedInput = "minutes";
                    break;

                //hours
                case "hours":
                    modifiedInput = "hours";
                    break;

                case "Hours":
                    modifiedInput = "hours";
                    break;

                case "h":
                    modifiedInput = "hours";
                    break;

                case "H":
                    modifiedInput = "hours";
                    break;


                //days
                case "days":
                    modifiedInput = "days";
                    break;

                case "Days":
                    modifiedInput = "days";
                    break;

                case "d":
                    modifiedInput = "days";
                    break;

                case "D":
                    modifiedInput = "days";
                    break;



                default:
                    throw new ArgumentException("Incorrect time unit");

            }




            return modifiedInput;


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
