/*
 * -----------------------------------------------------------------------
#
##
## Purpose of code:

##  You have been asked to create a Dungeon and Dragons style game. They have asked you to Design a class called Character that will hold the following information:

Name
Age
Player’s Name
Level
Gender
Race
Class (i.e. fighter, wizard)


-------------------------------------------------------------
##
##
## ---------------------------
##
## Notes:

Then create a program that will allow a user to add information into this class and then the program puts the information out. Just to demonstrate the functionality.



Note - please keep this program for use later in the course.



Your program must have the following:

An introductory statement that allows the user to understand what type of program they are running.
Variable declarations
User input acceptance
Proper mathematical calculations
Proper output
You must provide the following:
Your code
Screenshot of your fully functioning program with inputs/outputs

##  .
##
## ---------------------------
*/

using System.ComponentModel.DataAnnotations;

namespace DungAndDrag
{ 
    class Character
    {
        string? CharName, PlayerName, Gender, Race, Class;
        double? Age, Level;





        static void Main()
        {
            string? inp;
 
            Character Test = new Character();
            CenterText();
            //


  //Move to Funcitons

            Console.WriteLine("Characters Name: ");
            inp = Console.ReadLine();
            Test.CharName = inp;

            //

            Console.WriteLine("Characters Age: ");
            inp = Console.ReadLine();
            int pass;
            pass = Convert.ToInt32(inp);
            Test.Age = pass;

            //

            Console.WriteLine("Players Name: ");
            inp = Console.ReadLine();
            Test.PlayerName = inp;

            //

            Console.WriteLine("Players Level");
            inp = Console.ReadLine();
            pass = Convert.ToInt32(inp);
            Test.Level = pass;

            //

            Console.WriteLine("Gender: ");
            inp = Console.ReadLine();
            Test.Gender = inp;

            //

            Console.WriteLine("Race: ");
            inp = Console.ReadLine();
            Test.Race = inp;

            //

            Console.WriteLine("Class: ");
            inp = Console.ReadLine();
            Test.Class = inp;

           //////////////////////////////////////////////
           ///

            CenterText();
             Console.WriteLine("Characters Name: " + Test.CharName);

            //

            Console.WriteLine("Characters Age: " + Test.Age);
            

            //

            Console.WriteLine("Players Name: " + Test.PlayerName);
            

            //

            Console.WriteLine("Players Level: " + Test.Level);
            

            //

            Console.WriteLine("Gender: " + Test.Gender);
            

            //

            Console.WriteLine("Race: " + Test.Race);
            

            //

            Console.WriteLine("Class: " + Test.Class);
           
            }

        static void CenterText()
        { 
            Console.Clear();
        string textToEnter = "Character Build";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
        }
        
    }
}



/*
 * 
 * static void DisplayChar()
        { 
        Console.Clear();
        Console.WriteLine("\n\t\t\t\t\t\t\t|Character|");
        Console.WriteLine("Name: ");
        Console.WriteLine("Players Name: ");
        Console.WriteLine("Age: ");
        Console.WriteLine("Level: ");
        Console.WriteLine("Gender: ");
        Console.WriteLine("Race: ");
        Console.WriteLine("Character Class: ");

        }

*/