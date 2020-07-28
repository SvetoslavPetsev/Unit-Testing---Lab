using System;

namespace UnitTesting
{
    public class BankAccount
    {
        private decimal amount;

        public BankAccount(decimal initialAmount)
        {
            this.Amount = initialAmount;
        }

        public decimal Amount 
        {
            get 
            {
                return this.amount;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be positive.");
                }
                this.amount = value;
            } 
        }

        public void Deposit(decimal money)
        {
            if (money < 0)
            {
                throw new ArgumentException("Value must be positive.");
            }
            this.Amount += money;
        }
    }
}
