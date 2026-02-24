namespace ATMSimulation;

public class ATM: Card
{
    
    public ATM()
        {
            TryAgain:
            try
            {
                Console.WriteLine("** Welcome to Rudraksh's ATM Simulator **");
                Thread.Sleep(500);
                Console.WriteLine("** Lets Begin To Bank Account and Card Setup **");
                Thread.Sleep(500);
                Console.Write("Enter your Name: ");
                Name = Console.ReadLine();
                Console.Write("Enter your Initial Balance: ");
                Balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Setup your Card Number: ");
                Pin = Convert.ToInt16(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please write in correct format. " + e.Message + " You have to restart again");
                goto TryAgain;
            }
            catch (Exception e)
            {
                Console.WriteLine("An exeception occured: " + e);
                Thread.Sleep(500);
                Console.WriteLine("We are setting up ATM Again");
                Console.Clear();
                goto TryAgain;
            }
        }

    public static void Main(string[] args)
    {
        ATM a1 = new ATM();
        a1.ValidateUser();
    }    
}