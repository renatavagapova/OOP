using System;
using System.Collections.Generic;

namespace lesson2
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Account> listAccount = new List<Account>();

            Account account1 = new Account();

            account1.Balance = 10;
            account1.Number = 5500;
            account1.TypeAccount = TypeOfBankAccount.DEBIT;

            listAccount.Add(account1);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account1.Number);
            Console.WriteLine(account1.TypeAccount);

            Account account2 = new Account(TypeOfBankAccount.DEBIT);
            listAccount.Add(account2);
            Account account3 = new Account(100, TypeOfBankAccount.DEPOSIT);
            listAccount.Add(account3);

            foreach (var item in listAccount)
            {
                item.FullInfo();
            }

            account1.DepositMoney(account1.Number, 325);
            account1.FullInfo();

            account1.WithdrawMoney(account1.Number, 99);
            account1.FullInfo();

            account1.WithdrawMoney(account1.Number, 455);
            account1.FullInfo();
        }
    }
}
