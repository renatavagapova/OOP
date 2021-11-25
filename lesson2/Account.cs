using System;
using System.Collections.Generic;
using System.Text;

namespace lesson2
{
    class Account
    {
        static int counter = 1;

        int _number;

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value.GetType().ToString() == "System.Int32")
                {
                    _number = value;
                }
            }

        }


        decimal _balance;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value.GetType().ToString() == "System.Decimal")
                {
                    _balance = value;
                }
            }

        }

        TypeOfBankAccount _typeAccount;

        public TypeOfBankAccount TypeAccount
        {
            get
            {
                return _typeAccount;
            }
            set
            {
                if (value.GetType().ToString() == "GB_04_02BankAccount04.TypeOfBankAccount")
                {
                    _typeAccount = value;
                }
            }

        }

        public Account()
        {
            _number = Increase();
        }

        public Account(decimal balance)
        {
            _balance = balance;
            _number = Increase();

        }
        public Account(TypeOfBankAccount typeAccount)
        {
            _typeAccount = typeAccount;
            _number = Increase();

        }

        public Account(decimal balance, TypeOfBankAccount typeAccount)
        {
            _balance = balance;
            _typeAccount = typeAccount;
            _number = Increase();

        }

        int Increase()
        {
            return counter++;
        }

        public void FullInfo()
        {
            Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}");
        }

        /// <summary>
        /// Положить на счет
        /// </summary>
        /// <param name="number">Номер счёта</param>
        /// <param name="put">Положить сумму</param>
        public void DepositMoney(int number, decimal put)
        {
            if (number == _number)
            {
                _balance = _balance + put;
                Console.WriteLine($"Счёт пополнен на: {put}");

            }

        }

        /// <summary>
        /// Снять со счета
        /// </summary>
        /// <param name="number">Номер счёта</param>
        /// <param name="take">Снять сумму</param>
        public void WithdrawMoney(int number, decimal take)
        {
            if (number == _number)
            {
                if (_balance >= take)
                {
                    _balance = _balance - take;

                    Console.WriteLine($"Со счёта снята на: {take}");
                }
                else
                    Console.WriteLine($"На счету недостаточно средств. Баланс: {_balance}; Сумма для снятия: {take};");

            }
        }

        /// <summary>
        /// Перевод денег
        /// </summary>
        /// <param name="moneyFrom">Ссылка на объект класса банковский счет откуда снимаются деньги</param>
        /// <param name="take">Сумма снятия</param>
        public void MoneyTransfer(Account moneyFrom, decimal take)
        {
            if (moneyFrom._balance > take)
            {
                _balance = _balance + take;
                moneyFrom._balance = moneyFrom._balance - take;
                Console.WriteLine($"На счёт: {_number}; Зачислена сумма {take}; Остаток: {_balance};");
                Console.WriteLine($"Со счёта: {moneyFrom._number}; Списана сумма: {take}; Остаток: {moneyFrom._balance};");

            }
            else
            {
                Console.WriteLine($"Недостаточно средств на счёте: {moneyFrom._number}, для списания суммы: {take}");

            }
        }
    }
}
