﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppChallenge
{
    class Program
    {
        static void Main()
        {
            //------------------Part One------------------------------------------------------------------------------------------------
            string[] Siblings = { "Adam", "John", "Henry" }; //This is our starting array
            Console.WriteLine("Please add the last name for these siblings?"); //this is the printed request for user input
            string lastName = Console.ReadLine(); //user input

            for (int i = 0; i < Siblings.Length; i++) //this cycles thru the array
            { 
                StringBuilder sb = new StringBuilder(); //this creates a string builder that allows for us to modify items we chose
                sb.Append(Siblings[i]); //copied the Array
                sb.Append(" " + lastName); //added the user input
                Siblings[i] = sb.ToString(); ; //set the new value onto the array
            }

            //foreach (string kid in Siblings) //This cycles thru the array
            //{
            //    Console.WriteLine(kid); // prints of the new string value in the array
            //}
            //------------------End of Part One------------------------------------------------------------------------------------------------
            //------------------Part Two-------------------------------------------------------------------------------------------------------

            bool check = false;// pre-set a bool value for use in the loop below

            while (check != true) //this checks to see if the requirements are NOT met so it can exit
            {
                for (int i = 0; i < Siblings.Length; i++) //this cycles thru the array
                {
                    Console.WriteLine(Siblings[i]); //This prints off the kids names
                    
                    
                }
                check = true; //--------------this statment was added to let to change the check bool after the for loop has completed its iternations. ------FIXED INFINITE LOOP
            }
            Console.Clear();
            //------------------End of Part Two-------------------------------------------------------------------------------------------------------
            //------------------Part Three------------------------------------------------------------------------------------------------------------
            int[] kidsAge = { 20, 18, 12 }; //sets another array associated with the above array
            for (int i = 0; i < kidsAge.Length; i++) //iterates thru this array
            {
                if (kidsAge[i] < 18) //this checks to see if those in the family are above 18 who can vote
                {
                    Console.WriteLine(Siblings[i] + " cannot vote.");

                }
                else
                {
                    Console.WriteLine(Siblings[i] + " can vote.");
                }

            }

            Console.WriteLine("\n Can you guess the age of Henry?"); //this is a fun guessing game for the one person who cannot vote
            int guess = Convert.ToInt32(Console.ReadLine()); // accepts user input
            bool check2 = false; //sets our value for the loop

            while (check2 != true) //loops until the user guesses correctly.
            {
                if (guess >= 14) //this checks their age and lets them know if they are close or not.
                {
                    Console.WriteLine("your to high");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess == 13)
                {
                    Console.WriteLine("your correct! he is a youngster!");
                    check2 = true;
                }
                else if (guess <= 12)
                {
                    Console.WriteLine("your to low");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("oh! you chose something that doesn't work, please guesss again.");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }

            //------------------End of Part Three-------------------------------------------------------------------------------------------------------
            //------------------ Part four-------------------------------------------------------------------------------------------------------
            Console.Clear();
            List<string> items = new List<string>() {"burger", "fries", "tacos", "steak", "pizza", "chinese food", "soup", "icecream", "hotdogs", "turkey", "potatoes" };//new list of foods

            Console.WriteLine("\n Can you guess what one of the boys favorite food is?"); //poses a question for the user
            string clientsChoice = Console.ReadLine();//accepts user input
            clientsChoice.ToLower();//sets everything lower case from the input to make sure it matches the answer

            bool check3 = false; //exit variable used to break loop when the answer is found

            while (check3 != true) //our loop to check for matches
            {
                for (int i = 0; i < items.Count; i++) //iterates through each item on the list
                {
                    if (items[i].Contains(clientsChoice)) //this compares if the user found a match to an item on the list
                    {
                        Console.WriteLine("good job! " + clientsChoice + " matches the item " + items[i] + ".");
                        check3 = true;
                    }

                }
                if (check3 != true) //this lets the user try again if they didn't find a match
                {
                    Console.WriteLine("Sorry the answer you gave does not match any of the favorite foods. \n Please guess again.");
                    clientsChoice = Console.ReadLine();
                    clientsChoice.ToLower();
                }
            }

            //------------------ End of Part four-------------------------------------------------------------------------------------------------------
            //------------------  Part five-------------------------------------------------------------------------------------------------------
            Console.Clear();
            List<string> trap = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight","nine", "one" };//new list
            Console.WriteLine("\n Wait.....are you a robot? ANSWER THIS QUESTION: what is nine minus eight?"); //asks user for input
            string clients2Choice = Console.ReadLine(); //user input saved
            clients2Choice.ToLower(); //users answer turned to lowercase to confirm it matches one of the answers.
            bool check4 = false; //use to confirm correct choice was made below.

            
            foreach (string i in trap) //this iterates thru every item in the list
            {
                if (i == clients2Choice) //checks to confirm the users choice is a match for an item
                {
                    switch (i) //this reviews the specific call to give based on the response from the user
                    {
                        case "one":
                            Console.WriteLine("User's answer matches the correct answer.");
                            check4 = true;
                            continue;
                        case "two":
                            Console.WriteLine("You either are a robot or suck at math...try again");
                            clients2Choice = Console.ReadLine();
                            clients2Choice.ToLower();
                            break;
                        case "three":
                            Console.WriteLine("You either are a robot or suck at math...try again");
                            clients2Choice = Console.ReadLine();
                            clients2Choice.ToLower();
                            break;
                        case "four":
                            Console.WriteLine("You either are a robot or suck at math...try again");
                            clients2Choice = Console.ReadLine();
                            clients2Choice.ToLower();
                            break;
                        case "five":
                            Console.WriteLine("You either are a robot or suck at math...try again");
                            clients2Choice = Console.ReadLine();
                            clients2Choice.ToLower();
                            break;
                        case "six":
                            Console.WriteLine("You either are a robot or suck at math...try again");
                            clients2Choice = Console.ReadLine();
                            clients2Choice.ToLower();
                            break;
                        case "seven":
                            Console.WriteLine("You either are a robot or suck at math...try again");
                            clients2Choice = Console.ReadLine();
                            clients2Choice.ToLower();
                            break;
                        case "eight":
                            Console.WriteLine("You either are a robot or suck at math...try again");
                            clients2Choice = Console.ReadLine();
                            clients2Choice.ToLower();
                            break;
                        case "nine":
                            Console.WriteLine("You either are a robot or suck at math...try again");
                            clients2Choice = Console.ReadLine();
                            clients2Choice.ToLower();
                            break;
                        default:
                            Console.WriteLine("this will never be used"); //this value won't happen
                            break;
                    }
                }
            }

            if (check4 == false) //this will check after to see if the iteration was correct or if nothing matched up it will stop the system from running
            {
                Console.WriteLine("Apologies, but your selection did not match. You are a robot and will be locked out of the system");
            }
            else
            {
                Console.WriteLine("Oh good you are a human.");
            }

            //------------------ End of Part five-------------------------------------------------------------------------------------------------------
            //------------------ Part six---------------------------------------------------------------------------------------------------------------

            Console.Clear();
            List<string> soda = new List<string>() { "cola", "pepsi", "fanta", "rootbeer", "sprite", "coke", "applebeer", "fanta" };//new list


            for (int i = 0; i < soda.Count; i++)
            {
                string pop = soda[i];
                int place = soda.IndexOf(soda[i]);
                foreach (string x in soda)
                {
                    int currentPlace = soda.IndexOf(x);
                    if (pop == x && place != currentPlace)
                    {
                        Console.WriteLine("This is a duplicate");
                    }
                    else
                    


                }

            }



            //------------------ End of Part six---------------------------------------------------------------------------------------------------------



            Console.ReadLine(); // This reads the line of code to the user before closing.
        }
    }
}
