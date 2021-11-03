using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wemabank_related
    {
              class bank
            {
                private double balance = 1000;


        public double bal
                {
                    get { return balance; }
                    set { balance = value; }
                }
            }
            class transaction
            {
                bank i = new bank();
                string name;
                int account;
                double withdraw, dep, tobal;

                public void deposit()
                {
                    Console.WriteLine("Enter Name of the depositor :");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Account Number  :");
                    account = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Deposit Amount :");
                    dep = Convert.ToDouble(Console.ReadLine());
                    tobal = i.bal + dep;

                    Console.WriteLine("------------------------------\n");
                    Console.WriteLine("Depositor name : " + name);
                    Console.WriteLine("Account Number: " + account);
                    Console.WriteLine("Balance amount in the account  : " + tobal);
                    }
                public void Withdraw()
                {
                    Console.WriteLine("Enter Account Name :");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Account Number  :");
                    account = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Withdraw Amount :");
                    withdraw = Convert.ToDouble(Console.ReadLine());
                    if (withdraw <= i.bal)
                    {
                        tobal = i.bal - withdraw;
                        Console.WriteLine("------------------------------\n");
                        Console.WriteLine("Account Name : " + name);
                        Console.WriteLine("Account Number: " + account);
                        Console.WriteLine("After Withdraw Amount balnace is : " + tobal);
                    }

                }
         public void balance()
                {
                    Console.WriteLine("Enter Account Number  :");
                    account = Convert.ToInt32(Console.ReadLine());
                    dep = Convert.ToDouble(Console.ReadLine());
                    tobal = i.bal;
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Balance amount in the account  : " + tobal);
        }
               }
    }

            

