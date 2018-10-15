using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //bool shouldContinue;
            //do
            //{

           
            bool shouldContinue;


            Console.WriteLine("Welcome to Gand Circus' Room Detail Generator");
            // James - I really like that you are making use of a do while loop! really cool, this is a 
            // great use case of do while, because after all, we want the program to run at least 
            // once.
            do
            {
                // prompt user
                Console.WriteLine("Enter length of room :");
                double lengthOfRoom = double.Parse(Console.ReadLine());

                // James - I really liked how you kept your code organized here, like a 
                // seperate block for each area we are asking the user for, good stuff
                Console.WriteLine("Enter width of room :");
                double widthOfRoom = double.Parse(Console.ReadLine());

                //formulas
                double areaOfRoom = lengthOfRoom * widthOfRoom;
                double perimeterOfRoom = 2 * (lengthOfRoom * widthOfRoom);

                //calculations
                Console.WriteLine("The area of your room is: {0}", areaOfRoom);
                Console.WriteLine("The perimeter of your rooms is: {0}", perimeterOfRoom);

                Console.WriteLine("Would you like to continue? ");
                if (Console.ReadLine() == "yes ")

                {
                    shouldContinue = true;
                }
                else
                {
                    shouldContinue = false;
                }
            }
            // James - I see you are running a while true, however, this program
            // is going to run forever until you break, make sure you are using your "should continue" variable 
            // in this while loop.
            while (true);
            


        }
    }

    }



