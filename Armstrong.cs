//Program to check is the number is armstrong or not
using System;
public class Armstrong
{
    public void Calculate()
    {
        Console.WriteLine("Enter a number to check if it is armstrong or not");
        int num = Convert.ToInt32(Console.ReadLine());
        int x = num;
        int c = 0;
        while (x>1)
        {
            int a = x % 10;
            c = c * 10 + a;
            x = x / 10;
        }
        string result = (num == c) ? "Given number is Armstrong" : "Given number is not armstrong";
        Console.WriteLine(result);

    }
}