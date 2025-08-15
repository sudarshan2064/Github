// WAP to calculate H.C.F of given two numbers
using System;
using System.Xml;
public class Hcf
{
    public void Calculate()
    {
        Console.WriteLine("Enter two numbers to find their HCF");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        for (int c = (a < b) ? a : b; c> 1; c--)
        {
            if (a % c == 0 && b % c == 0)
            {
                Console.WriteLine($" The hcf of given number is  {c}");
                break;
            }

        }

    }
}

/* Output:

PS D:\All Folders\C#\Github\NewProject> dotnet run
Enter two numbers to find their HCF
16
24
 The hcf of given num is  8 */