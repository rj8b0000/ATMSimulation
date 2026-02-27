namespace ATMSimulation;

public class BankAccount //Bank Account Class BankAccount -> Transaction -> Card -> ATM
{
    private string name;
    public string Name { get => name; set => name = value; }
    private double balance;
    public double Balance { get => balance; set => balance = value; }
}