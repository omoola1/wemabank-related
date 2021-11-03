using System;

namespace wemabank_related
{
    internal class Program
    {
        static void Main(string[] args)
        {

            transaction wema = new transaction();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("\nPlease select a number. \n1: DEPOSIT \n2: Withdraw \n3: Balance");
            int num = int.Parse(Console.ReadLine());
            if(num == 1)
            {
                wema.deposit();
                return;
            }
            if(num == 2)
            {
                wema.Withdraw();
                return;
            }
            if (num == 3)
            {
                wema.balance();
                return;
            }

            Console.WriteLine("Thanks!");
           
             
        }
    }
}
