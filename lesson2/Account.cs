using System;
using System.Collections.Generic;
using System.Text;

namespace lesson2
{
    class Account
    {
        int _number;

        decimal _balance;

        TypeOfBankAccount _typeAccount;

        public int InfoNumber()
        {
            return _number;
        }

        public decimal InfoBalance()
        {
            return _balance;
        }

        public TypeOfBankAccount InfoTypeAccount()
        {
            return _typeAccount;
        }

        public void FillNumber(int number)
        {
            _number = number;
        }

        public void FillBalance(decimal balance)
        {
            _balance = balance;

        }

        public void FillTypeAccount(TypeOfBankAccount typeAccount)
        {
            _typeAccount = typeAccount;
        }

        public void FullInfo()
        {
            Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}");
        }
    }
}
