namespace ATMSimulation;

public class Card : Transaction
{
    private int pin;

    public int Pin
    {
        get => pin;
        set => pin = value;
    }

    private int choice;
    public int amount;
    
    public void ValidateUser()
    {
        EnterPinAgain:
        try
        {

            int userEnteredPin;
            Console.WriteLine("Enter the PIN number: ");
            userEnteredPin = Convert.ToInt32(Console.ReadLine());
            if (userEnteredPin == Pin)
            {
                Console.WriteLine("Your PIN is valid");
                Thread.Sleep(1000);
                CardAction();
            }
            else
            {
                Console.WriteLine("You had Entered Invalid Pin");
                goto EnterPinAgain;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("An exemption occured: " + e);
            goto EnterPinAgain;
        }
    }

    public void CardAction()
    {
        ContinueTransaction:
        Console.WriteLine(
            "** Enter your choice \n 1. Deposit \n 2. WithDraw \n 3. Check Current Balance \n 4. Get you Bank Account Info \n 5. Exit**");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Enter the amount you want to deposit: ");
                amount = Convert.ToInt32(Console.ReadLine());
                Deposit(amount);
                Thread.Sleep(500);
                goto ContinueTransaction;
            case 2:
                Console.Write("Enter the amount you want to withdraw: ");
                amount = Convert.ToInt32(Console.ReadLine());
                Withdraw(amount);
                Thread.Sleep(500);
                goto ContinueTransaction;
            case 3:
                Console.WriteLine("Your current balance is: " + Balance);
                Thread.Sleep(500);
                goto ContinueTransaction;
            case 4:
                Console.WriteLine(
                    $"Your bank account info: \n Account Holder Name - {Name} \n Your Current Balance - {Balance} \n Your Current PIN - {Pin}");
                Thread.Sleep(500);
                goto ContinueTransaction;
            case 5:
                Console.WriteLine("Your are exiting ATM");
                Thread.Sleep(1000);
                break;
            default:
                Console.WriteLine("Invalid choice");
                goto ContinueTransaction;
        }
    }
    
}