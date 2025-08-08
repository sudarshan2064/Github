using System;
public class Banking
{
    double amount = 0;
    public void Amount()
    {
        Console.WriteLine("Your current balance is " + amount);
    }
    public void Deposite()
    {
        Console.WriteLine("Enter amount to deposite");
        double deposite = Convert.ToDouble(Console.ReadLine());
        amount += deposite;
    }
    public void Withdraw()
    {
        Console.WriteLine("Enter amount to Withdraw");
        double withdraw = Convert.ToDouble(Console.ReadLine());
        if (withdraw > amount)
        {
            amount = amount - withdraw;
        }
    }
    public void Action()
    {
        Console.WriteLine("enter 1 for check balance , 2 for deposite and 3 for withdraw");
        int a = Convert.ToInt32(Console.ReadLine());
        Banking obj = new Banking();
        switch (a)
        {
            case 1:
                obj.Amount();
                break;

            case 2:
                obj.Deposite();
                break;

            case 3:
                obj.Withdraw();
                break;

        }
    }
}