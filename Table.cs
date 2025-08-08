// Program to get multipliacation table wih single while loop
using System;
public class Table
{
    public void Calculate()
    {

        Console.WriteLine("Enter a number to get it's multiplication");
        int num = Convert.ToInt32(Console.ReadLine());
        int a = 1;
        int pr = 0;
        while (a <= 10)
        {
            pr = a * num;
            Console.WriteLine(num + "*" + a + "=" + pr);
            a++;        }
    }
}