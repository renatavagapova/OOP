using System;
using System.Collections.Generic;

namespace lesson6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> listAccount = new List<Account>();

            Account account1 = new Account(100, TypeOfBankAccount.DEPOSIT);
            Account account2 = new Account(99, TypeOfBankAccount.DEBIT);
            Account account3 = new Account(1555, TypeOfBankAccount.CREDIT);
            Account account4 = new Account(888, TypeOfBankAccount.BUDGET);
            Account account5 = new Account(888, TypeOfBankAccount.BUDGET);
            Account account6 = new Account(888, TypeOfBankAccount.DEPOSIT);

            listAccount.Add(account1);
            listAccount.Add(account2);
            listAccount.Add(account3);
            listAccount.Add(account4);

            foreach (var item in listAccount)
            {
                item.FullInfo();
            }

            Console.WriteLine();

            if (account4 == account4)
            {
                Console.WriteLine("true 4 4");
            }

            if (account4 == account6)
            {
                Console.WriteLine("true 4 6 ");
            }

            Console.WriteLine(account4.Equals(account5));

            Console.WriteLine(account4.GetHashCode());
            Console.WriteLine(account5.GetHashCode());
            Console.WriteLine(account6.GetHashCode());

            Console.WriteLine(account6.ToString());

        }
    }
}
