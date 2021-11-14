using System;
using System.Collections.Generic;

namespace lesson2
{

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Account account = new Account();

            account.FillTypeAccount(TypeOfBankAccount.DEBIT);

            account.FillNumber(random.Next(1, 99999999));

            account.FillBalance(100000);

            account.FullInfo();
        }
    }
}
