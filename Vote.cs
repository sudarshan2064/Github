using System;

public class Vote{
    
    public void Check(int age){
        int a = age;
        Console.WriteLine(a >= 18 ? "Eligible to vote" : "Not eligible to vote");
    }
}
