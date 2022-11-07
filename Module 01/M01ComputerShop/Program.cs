/*
 * -----------------------------------------------------------------------
#
##
## Purpose of code:

##  Write a program that prompts Jessie to enter the total cost of the merchandise, the salary of the employees (on a yearly basis), 
yearly rent, and the estimated electricity cost (on a monthly basis). 
The program then outputs how much the merchandise should be marked up so that Jessie gets the desired profit.

5200 Computers, 20 a day 365

rite a program that prompts Jessie to enter the total cost of 
the merchandise, the salary of the employees (on a yearly basis), the yearly rent, and the estimated electricity cost 
(on a monthly basis). The program then outputs how much the merchandise should be marked up so that Jessie gets the desired profit.






After each event, data is input by the user and then displayed in the following form for recording purposes:
Your program must have the following:

Your program must have the following:

An introductory statement that allows the user to understand what type of program they are running.
Variable declarations
User input acceptance
Proper mathematical calculations
Proper output
You must provide the following:
Your code
Screenshot of your fully functioning program with inputs/outputs
-------------------------------------------------------------
##
##
## ---------------------------
##
## Notes:
##  would like to make a net profit of 20% after all the expenses are paid. 
These expenses include merchandise cost, store rent, employees’ salary, and electricity cost for the store. 
He would like to know how much he needs to cost of each computer in order to make that 20% profit.
##
## ---------------------------
*/



namespace ShopApp
{

    class Shop
    {
        int cOm;
        int YrEmpSal;
        int YrRent;
        int MoElecCost;
        double ComCost;


        static void Main(string[] args)
        {

            string Inp;
            int cOmI;
            Shop Shop1 = new Shop();



            //
            Console.WriteLine("\n\n\n\n\t\t\t\t Please Enter all Merchandise at Cost for the year\n\n\t\t\t\t");
            Inp = Console.ReadLine();
            cOmI = Convert.ToInt32(Inp);
            Shop1.cOm = cOmI;
            Console.Clear();

            //

            Console.WriteLine("\n\n\n\n\t\t\t\t Please Enter All Employee Salary For The Year\n\n\t\t\t\t");
            Inp = Console.ReadLine();
            cOmI = Convert.ToInt32(Inp);
            Shop1.YrEmpSal = cOmI;
            Console.Clear();

            //

             Console.WriteLine("\n\n\n\n\t\t\t\t Please Enter Yearly Rent For the Buisness\n\n\t\t\t\t");
             Inp = Console.ReadLine();
             cOmI = Convert.ToInt32(Inp);
             Shop1.YrRent = cOmI;
            Console.Clear();

            //

            Console.WriteLine("\n\n\n\n\t\t\t\t Estimated Monthly Electiricity Cost \n\n\t\t");
            Inp = Console.ReadLine();
            cOmI = Convert.ToInt32(Inp);
            Shop1.MoElecCost = cOmI;
            Console.Clear();

            //
            
            Console.WriteLine("\n\n\n\n\t\t\t\t Cost Per Computer \n\n\t\t");
            Inp = Console.ReadLine();
            cOmI = Convert.ToInt32(Inp);
            Shop1.ComCost = cOmI;
            Console.Clear();

            //

            int monthlyCost = Shop1.YrRent + Shop1.cOm + Shop1.YrEmpSal;
            monthlyCost = monthlyCost / 12;
            monthlyCost = monthlyCost + Shop1.MoElecCost; 
            Console.WriteLine(monthlyCost);

            //

            double income = Shop1.ComCost * 433.33;
            double NetIncome =  income - monthlyCost;
           double pass = Shop1.ComCost * 0.2;
           
           


           //*/

            Console.WriteLine("\t\t\t\t\t\t\tBalance Sheet:");
            Console.WriteLine("\t\t\t\t\tMonthly Expenses: " + monthlyCost);
            Console.WriteLine("\t\t\t\t\tNet Income: " + NetIncome);
            Console.WriteLine("\t\t\t\t\tMarkup: 20%");
            Console.WriteLine("\t\t\t\t\tSingle Computer Cost: " + Shop1.ComCost);
            Console.WriteLine("\t\t\t\t\t$Markup Per Computer: " + pass);

            pass = pass + Shop1.ComCost;
            double TotalCompPrice = pass;
            Console.WriteLine("\t\t\t\t\tTotal Computer Price: " + TotalCompPrice);


        }
    }
}


