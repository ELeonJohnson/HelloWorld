using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part One Greeting Statement

            string messageOne = "Hello World!";
            string messageTwo = "I am Spartacus";

            //Part Two Initial Sparticus Attributes
            int ageOne = 35;
            int ageTwo = 45;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            //Part Three Display Variable Values
            Console.WriteLine(messageOne);
            Console.WriteLine(messageTwo);

            //Part Four Mathematical Operators: Bool And Char Examples
            Console.WriteLine(ageOne + ageTwo);
            Console.WriteLine(heightOne - heightTwo);
            Console.WriteLine(weightOne * weightTwo);
            Console.WriteLine(isGodLikeOne);
            Console.WriteLine(genderMale);

            //Part 5 Variable Reassignment
            ageTwo = 110;
            heightTwo = 35.12345f;
            weightTwo = -429.1234573f;

            //Part 6 mathematical operator examples
            Console.WriteLine(ageTwo + ageOne);
            Console.WriteLine(heightOne + heightTwo);
            Console.WriteLine(weightOne * weightTwo);


            int ageThree = 80;
            ageTwo = 70;

            Console.WriteLine(ageTwo / ageOne);
            Console.WriteLine(ageTwo % ageOne);
            Console.WriteLine(ageThree / ageOne);
            Console.WriteLine(ageThree % ageOne);

            //Part 7 Increment And Decrement Operator Examples
            ageTwo++;
            Console.WriteLine(ageTwo);


            ageTwo--;
            Console.WriteLine(ageTwo);


            Console.WriteLine("5" == "5");
            Console.WriteLine(40 != 40);
            Console.WriteLine(11 < 4);

            // Part 8 Concatenation Example
            Console.WriteLine(messageOne + " " + messageTwo + ".");

            Console.WriteLine("I am " + ageOne + " " + "years old, and yes it's " + isGodLikeOne + " " + "I am godlike.");
            Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");

            Console.WriteLine("I am {0} years old, and yes it's {1} I am godlike.", ageOne, isGodLikeOne);
            Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);

            //Part 9
            Console.WriteLine(messageTwo.Equals(messageOne));
            Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            string myGreeting = "Hello";
            Console.WriteLine(myGreeting.ToUpper());
            Console.WriteLine(myGreeting.ToLower());
            Console.WriteLine(myGreeting);


            //Part 10: String Length Examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            //Part 11 Conditionals

            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            ////Solicit user input example 

            //Console.WriteLine("What is the distance to {0}?", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) && ((city1Distance < city2Distance) && (city1Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Vesuvius");
            //}
            //if ((city2Distance <= 125) && ((city2Distance < city1Distance) && (city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Nola");
            //}
            //if ((city3Distance <= 125) && ((city3Distance < city1Distance) && (city3Distance < city2Distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}

            //Part 12 conditional examples 
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //string vesuvius;
            //string nola;
            //string nuceria;

            ////Solicit user input example

            //Console.WriteLine("What is the weather in {0}?", city1);
            //vesuvius = Console.ReadLine();
            //Console.WriteLine("What is the weather in " + city2 + "?");
            //nola = Console.ReadLine();
            //Console.WriteLine("What is the weather in Nuceria?");
            //nuceria = Console.ReadLine();

            string job = "";

            switch(job)
            {
                case "infantry":
                    Console.WriteLine("You will carry a sword");
                    break;

                case "archers":
                    Console.WriteLine("You will carry a bow and arrow");
                    break;

                case "supply":
                    Console.WriteLine("You will carry pots and pans");
                    break;

                case "specialist":
                    Console.WriteLine("You will operate the catapault");
                    break;

                default:
                    Console.WriteLine("You will ride horseback");
                    break;

                }




        }

    } 
}
    