using System;
namespace Demo
{
    public class Account
    {
        public int Amount;

        public Account(int amount)
        {
            this.Amount = amount;
        }

        public Account WithdrawMoney(int withdrawenMoney)
        {
            return (Amount > withdrawenMoney) ? new Account(Amount - withdrawenMoney) : throw new Exception();
        }
  
    }
}
