using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Assignment 3 PROG 2070: Console App that converts time
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
    class Program
    {
        static void Main(string[] args)
        {

            double value = 0;
            string convertFrom = "";
            string convertTo = "";

            double convertedValue = 0;

            while (true)
            {
                Console.WriteLine("\n****----DAVID'S TIME CONVERTER----****\n1.Convert Time\n2.Exit");
                try
                {
                    string selection = "";

                    selection = Console.ReadLine();

                    if(selection == "1")
                    {
                        try
                        {
                            Console.WriteLine("Enter a numeric value to convert:");

                            value = double.Parse(Console.ReadLine());
                            if(value <= 0)
                            {
                                throw new Exception("Value cannot be equal to or less than 0!");
                            }

                            Console.WriteLine("What time unit are you converting from? (seconds, minutes, hours, days)");

                            convertFrom = Console.ReadLine();

                            Console.WriteLine("What time unit are you converting to? (seconds, minutes, hours, days)");

                            convertTo = Console.ReadLine();

                            try
                            {
                                convertedValue = TimeConversion.Convert(value, convertFrom, convertTo);
                                Console.WriteLine("CONVERTED TIME: " + convertedValue + " " + convertTo + "(s)");


                                Console.WriteLine("\n\nPress any key to return");
                              
                            }
                            catch(ArgumentException ae)
                            {
                                Console.WriteLine("\nPlease enter correct time units <seconds, minutes, hours, days>"
                                        + "\n\nPress any key to return");
                            }




                            Console.ReadLine();






                        }

                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR------>  " + e.ToString().Substring(0, 70));
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                    }
                    else if(selection =="2")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n!-INVALID CHOICE-!\n");
                        Console.ForegroundColor = ConsoleColor.White;

                    }



                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR------>  " + e.ToString().Substring(0, 70));
                    Console.ForegroundColor = ConsoleColor.White;
                }
             
                
             }


        }
    }
}
