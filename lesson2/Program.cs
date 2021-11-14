using System;
using System.Collections.Generic;

namespace lesson2
{

    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            Account account2 = new Account();
            Account account3 = new Account();

            account1.FillTypeAccount(TypeOfBankAccount.DEBIT);

            account1.FillBalance(100000);

            account1.FullInfo();
            account2.FullInfo();
            account3.FullInfo();
        }
    }
}
