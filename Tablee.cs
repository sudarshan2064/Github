// Program to get multipliacation table wih 2 while loops
using System;
public class Tablee
{
    public void Calculate()
    {

        Console.WriteLine("Enter a number to get it's multiplication");
        int num = Convert.ToInt32(Console.ReadLine());
        int a = 1;
        int pr = 0;
        int b = 1;
        while (b <= 10)
        {
            while (a <= 10)
            {
                pr = a * num;
                Console.WriteLine(num + "*" + a + "=" + pr);
                a++;
            }
            b++;
        }
    }
}