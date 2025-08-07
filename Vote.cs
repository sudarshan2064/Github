using System;

public class Vote{
    
    public void Check(){
        Console.WriteLine("Enter your age");

        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a >= 18 ? "Eligible to vote" : "Not eligible to vote");
    }
}
