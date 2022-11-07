/*
Austin Stephens
DVD Collection Example


Create a program that handles your movie collection. The program should allow to use the user to enter the following information:

Name
Genre
Year
Rating


The program should provide a menu that allows the user to do what he wants to do:

Open
New
Modify
Close.


-----------------------------------
Your program must have the following:

An introductory statement that allows the user to understand what type of program they are running.
Variable declarations
User input acceptance
Decision statement - that determines what method the file is going to be used for.
Proper output - so the user can see what DVD's they store.
You must provide the entire project file and you must save to an input file. REQUIRED.
You must provide the following:
Full visual studio project file
Your code
Screenshot of your fully functioning program with inputs/outputs



//needs more vali on inputs however conception is there. 
*/
using System;

class DVDS
{
    public string NameDVD { get; set; }
    public string GenreDVD { get; set; }
    public string YearDVD { get; set; }
    public int RatingDVD { get; set; }

    public void DVD()
    {
        NameDVD = "";
        GenreDVD = "";
        YearDVD = "";
        RatingDVD = 0;
    }
}


class workspace
{
    static void Main()
    {
        string MenIMP, SINP = "";
        bool exit = false;
        int CDNUM = 0;
        
        DVDS[] Movie = new DVDS[1000];

        while (exit == false)
        {
            //main menu
            Console.Clear();
            Console.WriteLine("DVD Collection Menu");
            Console.WriteLine("+------------------+");
            Console.WriteLine(" 1.  -   Open DVD");
            Console.WriteLine(" 2.  -    New DVD");
            Console.WriteLine(" 3.  -     Modify");
            Console.WriteLine(" 4.  - Close/Exit");
            Console.WriteLine("+------------------+");

            switch (MenIMP = Console.ReadLine())
            {
                case "1":
                    //our display menu
                    Console.Clear();
                    Console.WriteLine("*Movie Collection Menu*");


                    for (int i = 1; i < CDNUM+1; i++)
                    {
                        Console.WriteLine("\nMovie Number: " + i);
                        Console.WriteLine("Name: " + Movie[i].NameDVD);
                        Console.WriteLine("Genre: " + Movie[i].GenreDVD);
                        Console.WriteLine("Year: " + Movie[i].YearDVD);
                        Console.WriteLine("Rating: " + Movie[i].RatingDVD);
                    }

                    Console.WriteLine("\n\n\nEnter To Exit.");
                    Console.ReadLine();
                    break;
                case "2":
                    CDNUM++;
                    Console.Clear();
                    string N, G, Y;
                    int R;
                    

                    Console.WriteLine(" * New DVD Menu *");
                    Console.WriteLine("+------------------+");
                    Console.WriteLine("Enter Name Of DVD");
                    N = Console.ReadLine();
                    Console.WriteLine("Enter Genre of Movie");
                    G = Console.ReadLine();
                    Console.WriteLine("Enter Year of Movie");
                    Y = Console.ReadLine();

                    //need vali input
                            Console.WriteLine("Enter Rating of Movie");
                            R = Convert.ToInt32(Console.ReadLine());



                    //setting our new class objects
                    Movie[CDNUM] = new DVDS()
                    {
                        NameDVD = N,
                        GenreDVD = G,
                        YearDVD = Y,
                        RatingDVD = R,
                    };

                    break;
                case "3":
                    int pass = 0;
                    Console.Clear();
                    Console.WriteLine("*Movie Editor Menu*");
                    Console.WriteLine("+-----------------+");
                    Console.WriteLine("Please Open Movies to find Movie number: ");
                    Console.WriteLine("Type movie Number to edit | Exit to Exit.");
                    SINP = Console.ReadLine();

                    //need vali input

                    if (SINP == "Exit" || SINP == "exit")
                    {
                        break;
                    }

                    pass = Convert.ToInt32(SINP);




                    Console.WriteLine("\nMovie Number: " + pass);
                    Console.WriteLine("1. Name: " + Movie[pass].NameDVD);
                    Console.WriteLine("2. Genre: " + Movie[pass].GenreDVD);
                    Console.WriteLine("3. Year: " + Movie[pass].YearDVD);
                    Console.WriteLine("4. Rating: " + Movie[pass].RatingDVD);
                    

                    Console.WriteLine("\n\nPlease Enter Line to edit: ");
                    int temp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What would you like to edit that to?: ");
                    SINP = Console.ReadLine();

                    //setting new line on existing class object
                    switch (temp)
                    {
                        case 1:
                            Movie[pass].NameDVD = SINP;
                            break;
                        case 2:
                            Movie[pass].GenreDVD = SINP;
                            break;
                        case 3:
                            Movie[pass].YearDVD = SINP;
                            break;
                        case 4:
                            Movie[pass].RatingDVD = Convert.ToInt32(SINP);
                            break;
                        default:
                            Console.WriteLine("Error");
                            Console.ReadLine();
                            break;
                    }

                    Console.WriteLine("New Information: ");
                    Console.WriteLine("\n1. Movie Number: " + pass);
                    Console.WriteLine("2. Name: " + Movie[pass].NameDVD);
                    Console.WriteLine("3. Genre: " + Movie[pass].GenreDVD);
                    Console.WriteLine("4. Year: " + Movie[pass].YearDVD);
                    Console.WriteLine("5. Rating: " + Movie[pass].RatingDVD);
                    Console.WriteLine("\n\nEnter to Continue");
                    Console.ReadLine();





                    //vali input on main meun 1-4
                    break;
                case "4":
                    exit = true;
                    break;
                    default:
                    Console.WriteLine("*Please Enter # 1-4*");
                    MenIMP= Console.ReadLine();
                    break;
            }




        }

    }


}

