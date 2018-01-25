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

            /* string messageOne = "Hello World!";
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

             */


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

            //Part 13 switch example
            // string job = "";

            // switch(job)
            // {
            //    case "infantry":
            //      Console.WriteLine("You will carry a sword");
            //    break;

            //  case "archers":
            //     Console.WriteLine("You will carry a bow and arrow");
            //   break;

            //   case "supply":
            //  Console.WriteLine("You will carry pots and pans");
            //  break;

            //    case "specialist":
            // Console.WriteLine("You will operate the catapault");
            //  break;

            //  default:
            //   Console.WriteLine("You will ride horseback");
            //  break;

            //   }


           // Part 14 array examples
            string[] foodList = new string[5];
            foodList[0] = "Milk";
            foodList[1] = "Fruit";
            foodList[2] = "Meat";
            foodList[3] = "Wine";
            foodList[4] = "Bread";

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            int[] foodAmount = new int[5];
            foodAmount[0] = 1000;
            foodAmount[1] = 100;
            foodAmount[2] = 2000;
            foodAmount[3] = 10000;
            foodAmount[4] = 1500;

            ////Example of Indexing: Console.WriteLine("{0} {1} gallons, {2} {3} cases, {4} {5} pounds, {6} {7} gallons, {8} {9} loavs.", foodList[0], amountOfEachFood[0], foodList[1], amountOfEachFood[1], foodList[2], amountOfEachFood[2], foodList[3], amountOfEachFood[3], foodList[4], amountOfEachFood[4]);

            ////Example of concatenation
            //Console.WriteLine(foodList[0] + " " + amountOfEachFood[0] + " " + " gallons," + " " + foodList[1] + " " + amountOfEachFood[1] + " cases," + " " + foodList[2] + " " + amountOfEachFood[2] + " pounds," + " " + foodList[3] + " " + amountOfEachFood[3] + " gallons, " + foodList[4] + " " + amountOfEachFood[4] + " loaves.");

            //Console.WriteLine(foodList.Length);

            ////delete the extra string messageTwo
            //string messageTwo = "I am Spartacus";

            //string[] elements = messageTwo.Split(' ');
            //Console.WriteLine(elements[0]);
            //Console.WriteLine(elements[1]);
            //Console.WriteLine(elements[2]);

            //string myName = "Sue";
            //char[] letters = myName.ToCharArray();

             //Console.Write(letters[0]);
            //Console.Write(letters[1]);
            //Console.WriteLine(letters[2]);


            //Part 15 while loop example

            //string action = " ";
            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();


            //}


            //Example of a do while loop
            //string action = " ";
            //do
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //} while (action != "exit");


            //Example of for loop

            //for (int i = 0; i < foodAmount.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}





            



        }

    } 
}
    