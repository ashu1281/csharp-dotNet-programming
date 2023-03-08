//Create a program that converts a given amount of money from one currency to another. 
//    The program should ask the user to enter the amount of money, the original currency, 
//    and the target currency.

using System;

namespace csharp_programming.Day_01.Prcatice
{
    internal class q5
    {
        public static int Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter amount of money : ");
            input = Console.ReadLine();

            double money = Convert.ToDouble(input);


            Console.Write("Enter Original currency (e.g. IND, USD, EURO) : ");
            string orgcurr = Console.ReadLine();

            Console.Write("Enter target currency (e.g. IND, USD, EURO) : ");
            string tgtcurr = Console.ReadLine();

            double rate = 0.0;

            //convert rates

            double INDtoUSD = 0.01220621;
            double INDtoEURO = 0.0114803549;
            double USDtoEuro = 0.94176;
            
            if(orgcurr == tgtcurr)
            {
                rate = 1;
            }
            else if(orgcurr == "IND" && tgtcurr == "USD")
            {
                rate = INDtoUSD;
            }
            else if(orgcurr == "IND" && tgtcurr == "EURO")
            {
                rate = INDtoEURO;
            }
            else if(orgcurr == "USD" && tgtcurr == "IND")
            {
                rate = 1.0/INDtoUSD;
            }
            else if(orgcurr == "USD" && tgtcurr == "ERO")
            {
                rate = USDtoEuro;
            }
            else if(orgcurr == "EURO" && tgtcurr == "USD")
            {
                rate = 1.0 / USDtoEuro;
            }
            else if(orgcurr == "EURO" && tgtcurr == "IND")
            {
                rate = 1.0 / INDtoEURO;
            }
            else
            {
                Console.WriteLine("Please Enter given target currency only (as it is)!");
                return 0;
            }

            money *= rate;

            Console.WriteLine("The converted money in {0} is : {1}", tgtcurr, money);


            return 0;
        }
    }
}
