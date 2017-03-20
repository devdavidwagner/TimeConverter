using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;







/*
 * DAVID WAGNER
 * ASSIGNMENT 3
 * Unit tests for Project A
 * 
 * CREATED: 3/20/2017 1:30PM 
 * 
 * 
 * 
 * */

namespace PROG2070_Assignment3_DavidWagner.Tests
{

    //Tests for Project A
    [TestFixture]
    public class ProjectA
    {

        //Test 1
        //Ensures Convert correctly recieves input from program 
        [Test]
        public void input2ShouldReturn4()
        {
            //arrange
            double input = 2d;
            double outcome = 0d;

            double expectedOutcome = 4d;


            //act
            outcome = TimeConversion.Convert(input, "days", "days");



            //assert

            Assert.AreEqual(expectedOutcome, outcome);


            

        }

        //Test 2
        //Ensures Convert function handles negative variables correctly
        //from program 
        [Test]
        public void inputAShouldThrowException()
        {
            //arrange
         


            //act
        



            //assert

        



        }

        //Test 3
        [Test]
        public void test3()
        {
            //arrange


            //act


            //assert



        }

        //Test 4
        [Test]
        public void test4()
        {
            //arrange


            //act


            //assert



        }
    }

}
