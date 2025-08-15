// WAP to calculate H.C.F of given two numbers
using System;
public class Lcm
{
    public void Calculate()
    {
        Console.WriteLine("Enter two numbers to find their LCM");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        for (int c = (a > b) ? a : b; c<=a*b; c++)
        {
            if (c % a == 0 && c % b == 0)
            {
                Console.WriteLine($" The LCM of given numbers is  {c}");
                break;
            }

        }

        }

    }
