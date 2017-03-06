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

                            Console.WriteLine("What time unit are you converting from? (seconds, minutes, hours, days)");

                            convertFrom = Console.ReadLine();

                            Console.WriteLine("What time unit are you converting to? (seconds, minutes, hours, days)");

                            convertTo = Console.ReadLine();

                            convertedValue = TimeConversion.Convert(value, convertFrom, convertTo);

                            Console.WriteLine("CONVERTED TIME: " + convertedValue);


                            Console.WriteLine("\n\nPress any key to return");
                            Console.ReadLine();

                          






                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("ERROR------>  " + e.ToString());
                           
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
                    Console.WriteLine("ERROR------>  " + e.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
             
                
             }


        }
    }
}
