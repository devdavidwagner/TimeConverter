using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Assignment 3 PROG 2070: Project C contains completed program and Time Conversion
 * Tests entire system adn interacti nbetween Convert and GetMultiplier
 * 
 * David Wagner
 * 
 * Revision History:
 * 
 * 3/6/2017 CREATED
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
                multiplier = GetMultiplier(convertFromMod, convertToMod);


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
        /// 
        /// </summary>
        /// <param name="convertFrom"> time unit converting from (seconds, minutes, hours, days)</param>
        /// <param name="convertTo"> time unit converting to (seconds, minutes, hours, days)</param>
        /// <returns></returns>
        private static double GetMultiplier(string convertFrom, string convertTo)
        {
          
            double multiplier = 0;
            string concatConvert = convertFrom + "-" + convertTo;

            switch(concatConvert)
            {
                //seconds
                case "seconds-minutes": 
                    multiplier = 0.0166667d;
                    break;

                case "seconds-hours":
                    multiplier = 0.000277778d;
                    break;

                case "seconds-days":
                    multiplier = 0.000011574083333d;
                    break;
                case "seconds-seconds":
                    multiplier = 1;
                    break;



                //minutes
                case "minutes-seconds":
                    multiplier = 60;
                    break;

                case "minutes-hours":
                    multiplier = 0.0166667d;
                    break;

                case "minutes=days":
                    multiplier = 0.00069444583333d;
                    break;

                case "minutes-minutes":
                    multiplier = 1;
                    break;

                //hours
                case "hours-seconds":
                    multiplier = 3600;
                    break;

                case "hours-minutes":
                    multiplier = 60;
                    break;

                case "hours-days":
                    multiplier = 0.0416667d;
                    break;

                case "hours-hours":
                    multiplier = 1;
                    break;

                //days

                case "days-seconds":
                    multiplier = 86400;
                    break;

                case "days-minutes":
                    multiplier = 1440;
                    break;

                case "days-hours":
                    multiplier = 24;
                    break;

                case "days-days":
                    multiplier = 1;
                    break;
            }

           








            return multiplier;

        }

        




    }
}
