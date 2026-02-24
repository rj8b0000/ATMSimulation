// using ATMSimulation.Enum;
// using Action = System.Action;

namespace ATMSimulation
{
    public class Transaction: BankAccount
    {
        
        public double Deposit(double depositAmount)
        {
            if (depositAmount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
            else
            {
                Balance += depositAmount;
                Console.WriteLine("Your amount is deposited successfully.");
            }
            return Balance;
        }

        public double Withdraw(double withdrawAmount)
        {
            if (withdrawAmount > Balance)
            {
                Console.WriteLine("Withdraw amount must be less than current balance.");
            }
            else
            {
                Balance -= withdrawAmount;
                Console.WriteLine("Your amount is withdrawn successfully.");
            }
            return Balance;   
        }
    }
}

