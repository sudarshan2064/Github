//factorial of given number
using System;
public class Factorial
{
    public void Calculate(){
    Console.WriteLine("Enter a number to find factorial");
    double num = Convert.ToDouble(Console.ReadLine());
    double fact=1;
    while(num>0){
        fact = fact*num;
        num--;
    }
    Console.WriteLine("factorial:"+ fact);
    }
}